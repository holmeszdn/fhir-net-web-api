﻿// -----------------------------------------------------------------------------
// GENERATED CODE - DO NOT EDIT
// -----------------------------------------------------------------------------
using System;
using System.Linq;
using System.Collections.Generic;
using Hl7.Fhir.Model;
using Hl7.Fhir.Utility;
using System.Xml.Serialization;
using System.Xml;
using System.Xml.Linq;
using System.Threading;

namespace Hl7.Fhir.CustomSerializer
{
    public partial class FhirCustomXmlReader
    {
		public void Parse(Hl7.Fhir.Model.SubstanceProtein.SubunitComponent result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
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
					}
				} while (reader.MoveToNextAttribute());
				reader.MoveToElement();
			}

			if (reader.IsEmptyElement)
				return;

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
							Parse(newItem_extension, reader, outcome, locationPath + ".extension["+result.Extension.Count+"]", cancellationToken); // 20
							result.Extension.Add(newItem_extension);
							break;
						case "modifierExtension":
							var newItem_modifierExtension = new Hl7.Fhir.Model.Extension();
							Parse(newItem_modifierExtension, reader, outcome, locationPath + ".modifierExtension["+result.ModifierExtension.Count+"]", cancellationToken); // 30
							result.ModifierExtension.Add(newItem_modifierExtension);
							break;
						case "subunit":
							result.SubunitElement = new Hl7.Fhir.Model.Integer();
							Parse(result.SubunitElement as Hl7.Fhir.Model.Integer, reader, outcome, locationPath + ".subunit", cancellationToken); // 40
							break;
						case "sequence":
							result.SequenceElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.SequenceElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".sequence", cancellationToken); // 50
							break;
						case "length":
							result.LengthElement = new Hl7.Fhir.Model.Integer();
							Parse(result.LengthElement as Hl7.Fhir.Model.Integer, reader, outcome, locationPath + ".length", cancellationToken); // 60
							break;
						case "sequenceAttachment":
							result.SequenceAttachment = new Hl7.Fhir.Model.Attachment();
							Parse(result.SequenceAttachment as Hl7.Fhir.Model.Attachment, reader, outcome, locationPath + ".sequenceAttachment", cancellationToken); // 70
							break;
						case "nTerminalModificationId":
							result.NTerminalModificationId = new Hl7.Fhir.Model.Identifier();
							Parse(result.NTerminalModificationId as Hl7.Fhir.Model.Identifier, reader, outcome, locationPath + ".nTerminalModificationId", cancellationToken); // 80
							break;
						case "nTerminalModification":
							result.NTerminalModificationElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.NTerminalModificationElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".nTerminalModification", cancellationToken); // 90
							break;
						case "cTerminalModificationId":
							result.CTerminalModificationId = new Hl7.Fhir.Model.Identifier();
							Parse(result.CTerminalModificationId as Hl7.Fhir.Model.Identifier, reader, outcome, locationPath + ".cTerminalModificationId", cancellationToken); // 100
							break;
						case "cTerminalModification":
							result.CTerminalModificationElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.CTerminalModificationElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".cTerminalModification", cancellationToken); // 110
							break;
						default:
							// Property not found
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

		public async System.Threading.Tasks.Task ParseAsync(Hl7.Fhir.Model.SubstanceProtein.SubunitComponent result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
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
					}
				} while (reader.MoveToNextAttribute());
				reader.MoveToElement();
			}

			if (reader.IsEmptyElement)
				return;

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
							await ParseAsync(newItem_extension, reader, outcome, locationPath + ".extension["+result.Extension.Count+"]", cancellationToken); // 20
							result.Extension.Add(newItem_extension);
							break;
						case "modifierExtension":
							var newItem_modifierExtension = new Hl7.Fhir.Model.Extension();
							await ParseAsync(newItem_modifierExtension, reader, outcome, locationPath + ".modifierExtension["+result.ModifierExtension.Count+"]", cancellationToken); // 30
							result.ModifierExtension.Add(newItem_modifierExtension);
							break;
						case "subunit":
							result.SubunitElement = new Hl7.Fhir.Model.Integer();
							await ParseAsync(result.SubunitElement as Hl7.Fhir.Model.Integer, reader, outcome, locationPath + ".subunit", cancellationToken); // 40
							break;
						case "sequence":
							result.SequenceElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.SequenceElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".sequence", cancellationToken); // 50
							break;
						case "length":
							result.LengthElement = new Hl7.Fhir.Model.Integer();
							await ParseAsync(result.LengthElement as Hl7.Fhir.Model.Integer, reader, outcome, locationPath + ".length", cancellationToken); // 60
							break;
						case "sequenceAttachment":
							result.SequenceAttachment = new Hl7.Fhir.Model.Attachment();
							await ParseAsync(result.SequenceAttachment as Hl7.Fhir.Model.Attachment, reader, outcome, locationPath + ".sequenceAttachment", cancellationToken); // 70
							break;
						case "nTerminalModificationId":
							result.NTerminalModificationId = new Hl7.Fhir.Model.Identifier();
							await ParseAsync(result.NTerminalModificationId as Hl7.Fhir.Model.Identifier, reader, outcome, locationPath + ".nTerminalModificationId", cancellationToken); // 80
							break;
						case "nTerminalModification":
							result.NTerminalModificationElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.NTerminalModificationElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".nTerminalModification", cancellationToken); // 90
							break;
						case "cTerminalModificationId":
							result.CTerminalModificationId = new Hl7.Fhir.Model.Identifier();
							await ParseAsync(result.CTerminalModificationId as Hl7.Fhir.Model.Identifier, reader, outcome, locationPath + ".cTerminalModificationId", cancellationToken); // 100
							break;
						case "cTerminalModification":
							result.CTerminalModificationElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.CTerminalModificationElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".cTerminalModification", cancellationToken); // 110
							break;
						default:
							// Property not found
							await HandlePropertyNotFoundAsync(reader, outcome, locationPath + "." + reader.Name);
							break;
					}
				}
				else if (reader.NodeType == XmlNodeType.EndElement || reader.IsStartElement() && reader.IsEmptyElement)
				{
					break;
				}
			}
		}
	}
}
