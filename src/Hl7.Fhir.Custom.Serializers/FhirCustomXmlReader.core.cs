﻿using System;
using System.Linq;
using System.Collections.Generic;
using System.IO;
using Hl7.Fhir.Model;
using Hl7.Fhir.Utility;
using System.Xml.Serialization;
using System.Xml;
using System.Xml.Linq;
using System.Threading;
using Task = System.Threading.Tasks.Task;

namespace Hl7.Fhir.CustomSerializer
{
    public class FhirCustomXmlSerializationReader : XmlSerializationReader
    {
        public Resource Parse()
        {
            var reader = new FhirCustomXmlReader();
            return reader.Parse(this.Reader, new OperationOutcome(), null);
        }

        protected override void InitCallbacks()
        {
        }

        protected override void InitIDs()
        {
        }
    }

    public partial class FhirCustomXmlReader
    {
        public static XmlReaderSettings Settings = new XmlReaderSettings
        {
            Async = true,
            IgnoreComments = true,
            IgnoreProcessingInstructions = true,
            IgnoreWhitespace = true,
            DtdProcessing = DtdProcessing.Ignore, //Prohibit,
            NameTable = new NameTable()
        };

        public bool ShouldSkipNodeType(XmlNodeType nodeType)
        {
            return nodeType == XmlNodeType.Comment
                || nodeType == XmlNodeType.XmlDeclaration
                || nodeType == XmlNodeType.Whitespace
                || nodeType == XmlNodeType.SignificantWhitespace
                || nodeType == XmlNodeType.CDATA
                || nodeType == XmlNodeType.Notation
                || nodeType == XmlNodeType.ProcessingInstruction;
        }

        private static void HandlePropertyNotFound(XmlReader reader, OperationOutcome outcome, string locationPath)
        {
            // report the issue
            IXmlLineInfo info = reader as IXmlLineInfo;
            var locations = new List<string>();
            locations.Add($"xml position: {info.LineNumber},{info.LinePosition}");

            var issue = new OperationOutcome.IssueComponent()
            {
                Severity = OperationOutcome.IssueSeverity.Error,
                Code = OperationOutcome.IssueType.Structure,
                Details = new CodeableConcept() { Text = $"Unexpected element found {reader.Name}" },
                Location = locations,
                Expression = new string[] { locationPath }
            };
            outcome.Issue.Add(issue);

            // Scan over the erroneous property
            if (!reader.IsEmptyElement)
            {
                var readerChild = reader.ReadSubtree();
                if (readerChild.Read())
                {
                    issue.Diagnostics = readerChild.ReadOuterXml();
                }
                readerChild.Close();
                info = reader as IXmlLineInfo;
                locations[0] += $" to {info.LineNumber},{info.LinePosition}";
                issue.Location = locations;
            }
        }

        private static async Task HandlePropertyNotFoundAsync(XmlReader reader, OperationOutcome outcome, string locationPath)
        {
            // report the issue
            IXmlLineInfo info = reader as IXmlLineInfo;
            var locations = new List<string>();
            locations.Add($"xml position: {info.LineNumber},{info.LinePosition}");

            var issue = new OperationOutcome.IssueComponent()
            {
                Severity = OperationOutcome.IssueSeverity.Error,
                Code = OperationOutcome.IssueType.Structure,
                Details = new CodeableConcept() { Text = $"Unexpected element found {reader.Name}" },
                Location = locations,
                Expression = new string[] { locationPath }
            };
            outcome.Issue.Add(issue);

            // Scan over the erroneous property
            if (!reader.IsEmptyElement)
            {
                int depth = reader.Depth;
                do
                {
                    await reader.ReadAsync().ConfigureAwait(false);
                }
                while (reader.Depth > depth);
                // issue.Diagnostics = await reader.ReadOuterXmlAsync(); // this call has the dotnetcore bug in it where it calls a sync operation
                info = reader as IXmlLineInfo;
                locations[0] += $" to {info.LineNumber},{info.LinePosition}";
                issue.Location = locations;
            }
        }

        private static void HandleAttributeNotFound(XmlReader reader, OperationOutcome outcome, string locationPath)
        {
            IXmlLineInfo info = reader as IXmlLineInfo;
            outcome.Issue.Add(new OperationOutcome.IssueComponent()
            {
                Severity = OperationOutcome.IssueSeverity.Error,
                Code = OperationOutcome.IssueType.Structure,
                Details = new CodeableConcept() { Text = $"Unexpected attribute found {reader.Name}" },
                Location = new string[] { $"xml position: {info.LineNumber},{info.LinePosition}" },
                Expression = new string[] { locationPath }
            });
        }

        private static void HandleAttributeInvalidValue(XmlReader reader, string dataFormatType, OperationOutcome outcome, string locationPath, Exception ex)
        {
            IXmlLineInfo info = reader as IXmlLineInfo;
            outcome.Issue.Add(new OperationOutcome.IssueComponent()
            {
                Severity = OperationOutcome.IssueSeverity.Error,
                Code = OperationOutcome.IssueType.Value,
                Details = new CodeableConcept() { Text = $"Invalid {dataFormatType} value '{reader.Value}'" },
                Location = new string[] { $"xml position: {info.LineNumber},{info.LinePosition}" },
                Expression = new string[] { locationPath },
                Diagnostics = ex?.Message
            });
        }

        public void Parse<T>(Code<T> result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
            where T : struct
        {
            // skip ignored elements
            while (ShouldSkipNodeType(reader.NodeType))
                if (!reader.Read())
                    return;

            if (reader.MoveToFirstAttribute())
            {
                do
                {
                    switch (reader.Name)
                    {
                        case "id":
                            result.ElementId = reader.Value;
                            break;
                        case "value":
                            // Should this be validated?
                            result.ObjectValue = reader.Value;
                            break;
                        default:
                            // Property not found
                            HandleAttributeNotFound(reader, outcome, locationPath);
                            break;
                    }
                } while (reader.MoveToNextAttribute());
                reader.MoveToElement();
            }
            if (reader.IsEmptyElement)
            {
                // contextLocation.Pop();
                return;
            }
            // otherwise proceed to read all the other nodes
            while (reader.Read())
            {
                if (cancellationToken.IsCancellationRequested)
                    return;
                if (reader.IsStartElement())
                {
                    switch (reader.Name)
                    {
                        case "extension":
                            var newItem_extension = new Hl7.Fhir.Model.Extension();
                            Parse(newItem_extension, reader, outcome, locationPath + ".extension[" + result.Extension.Count + "]", cancellationToken); // 20
                            result.Extension.Add(newItem_extension);
                            break;
                        default:
                            // Property not found, skip over it
                            HandlePropertyNotFound(reader, outcome, locationPath + "." + reader.Name);
                            break;
                    }
                }
                else if (reader.NodeType == XmlNodeType.EndElement || reader.IsStartElement() && reader.IsEmptyElement)
                {
                    break;
                }
            }
        }

        public async Task ParseAsync<T>(Code<T> result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
            where T : struct
        {
            // skip ignored elements
            while (ShouldSkipNodeType(reader.NodeType))
                if (!await reader.ReadAsync().ConfigureAwait(false))
                    return;

            if (reader.MoveToFirstAttribute())
            {
                do
                {
                    switch (reader.Name)
                    {
                        case "id":
                            result.ElementId = reader.Value;
                            break;
                        case "value":
                            // Should this be validated?
                            result.ObjectValue = reader.Value;
                            break;
                        default:
                            // Property not found
                            HandleAttributeNotFound(reader, outcome, locationPath);
                            break;
                    }
                } while (reader.MoveToNextAttribute());
                reader.MoveToElement();
            }
            if (reader.IsEmptyElement)
            {
                // contextLocation.Pop();
                return;
            }
            // otherwise proceed to read all the other nodes
            while (await reader.ReadAsync().ConfigureAwait(false))
            {
                if (cancellationToken.IsCancellationRequested)
                    return;
                if (reader.IsStartElement())
                {
                    switch (reader.Name)
                    {
                        case "extension":
                            var newItem_extension = new Hl7.Fhir.Model.Extension();
                            await ParseAsync(newItem_extension, reader, outcome, locationPath + ".extension[" + result.Extension.Count + "]", cancellationToken); // 20
                            result.Extension.Add(newItem_extension);
                            break;
                        default:
                            // Property not found, skip over it
                            HandlePropertyNotFound(reader, outcome, locationPath + "." + reader.Name);
                            break;
                    }
                }
                else if (reader.NodeType == XmlNodeType.EndElement || reader.IsStartElement() && reader.IsEmptyElement)
                {
                    break;
                }
            }
        }

        // For Async Processing the Div Element
        private async Task WriteNodeAsync(XmlReader reader, XmlWriter xtw, bool defattr)
        {
            int d = reader.NodeType == XmlNodeType.None ? -1 : reader.Depth;
            while (await reader.ReadAsync().ConfigureAwait(false) && (d < reader.Depth))
            {
                switch (reader.NodeType)
                {
                    case XmlNodeType.Element:
                        xtw.WriteStartElement(reader.Prefix, reader.LocalName, reader.NamespaceURI);
                        ((XmlTextWriter)xtw).QuoteChar = reader.QuoteChar;
                        xtw.WriteAttributes(reader, defattr);
                        if (reader.IsEmptyElement)
                        {
                            xtw.WriteEndElement();
                        }
                        break;
                    case XmlNodeType.Text:
                        xtw.WriteString(await reader.GetValueAsync().ConfigureAwait(false));
                        break;
                    case XmlNodeType.Whitespace:
                    case XmlNodeType.SignificantWhitespace:
                        xtw.WriteWhitespace(await reader.GetValueAsync().ConfigureAwait(false));
                        break;
                    case XmlNodeType.CDATA:
                        xtw.WriteCData(reader.Value);
                        break;
                    case XmlNodeType.EntityReference:
                        xtw.WriteEntityRef(reader.Name);
                        break;
                    case XmlNodeType.XmlDeclaration:
                    case XmlNodeType.ProcessingInstruction:
                        xtw.WriteProcessingInstruction(reader.Name, reader.Value);
                        break;
                    case XmlNodeType.DocumentType:
                        xtw.WriteDocType(reader.Name, reader.GetAttribute("PUBLIC"), reader.GetAttribute("SYSTEM"), reader.Value);
                        break;
                    case XmlNodeType.Comment:
                        xtw.WriteComment(reader.Value);
                        break;
                    case XmlNodeType.EndElement:
                        xtw.WriteFullEndElement();
                        break;
                }
            }
            if (d == reader.Depth && reader.NodeType == XmlNodeType.EndElement)
            {
                await reader.ReadAsync().ConfigureAwait(false);
            }
        }

        // Workaround from an async bug in the XML Core assembly
        // https://github.com/dotnet/runtime/blob/release/5.0/src/libraries/System.Private.Xml/src/System/Xml/Core/XmlReaderAsync.cs#L301
        // Returns the current element and its descendants or an attribute as a string.
        public async System.Threading.Tasks.Task<string> ReadOuterXmlAsync(XmlReader reader)
        {
            if (reader.ReadState != ReadState.Interactive)
            {
                return string.Empty;
            }
            if ((reader.NodeType != XmlNodeType.Attribute) && (reader.NodeType != XmlNodeType.Element))
            {
                await reader.ReadAsync().ConfigureAwait(false);
                return string.Empty;
            }

            StringWriter sw = new StringWriter(System.Globalization.CultureInfo.InvariantCulture);
            XmlTextWriter xtw = new XmlTextWriter(sw);
            if (reader is XmlTextReader tr)
            {
                xtw.Namespaces = tr.Namespaces;
            }
            try
            {
                if (reader.NodeType == XmlNodeType.Attribute)
                {
                    xtw.WriteStartAttribute(reader.Prefix, reader.LocalName, reader.NamespaceURI);
                    WriteAttributeValue(reader, xtw);
                    xtw.WriteEndAttribute();
                }
                else
                {
                    xtw.WriteStartElement(reader.Prefix, reader.LocalName, reader.NamespaceURI);
                    ((XmlTextWriter)xtw).QuoteChar = reader.QuoteChar;
                    xtw.WriteAttributes(reader, false);
                    if (reader.IsEmptyElement)
                    {
                        xtw.WriteEndElement();
                    }
                    else
                    {
                        await WriteNodeAsync(reader, xtw, false);
                    }
                }
            }
            finally
            {
                xtw.Close();
            }
            return sw.ToString();
        }

        private void WriteAttributeValue(XmlReader reader, XmlWriter xtw)
        {
            string attrName = reader.Name;
            while (reader.ReadAttributeValue())
            {
                if (reader.NodeType == XmlNodeType.EntityReference)
                {
                    xtw.WriteEntityRef(reader.Name);
                }
                else
                {
                    xtw.WriteString(reader.Value);
                }
            }
            reader.MoveToAttribute(attrName);
        }
    }
}
