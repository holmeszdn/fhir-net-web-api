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
		public void Parse(Hl7.Fhir.Model.TerminologyCapabilities.ExpansionComponent result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
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
						case "hierarchical":
							result.HierarchicalElement = new Hl7.Fhir.Model.FhirBoolean();
							Parse(result.HierarchicalElement as Hl7.Fhir.Model.FhirBoolean, reader, outcome, locationPath + ".hierarchical", cancellationToken); // 40
							break;
						case "paging":
							result.PagingElement = new Hl7.Fhir.Model.FhirBoolean();
							Parse(result.PagingElement as Hl7.Fhir.Model.FhirBoolean, reader, outcome, locationPath + ".paging", cancellationToken); // 50
							break;
						case "incomplete":
							result.IncompleteElement = new Hl7.Fhir.Model.FhirBoolean();
							Parse(result.IncompleteElement as Hl7.Fhir.Model.FhirBoolean, reader, outcome, locationPath + ".incomplete", cancellationToken); // 60
							break;
						case "parameter":
							var newItem_parameter = new Hl7.Fhir.Model.TerminologyCapabilities.ParameterComponent();
							Parse(newItem_parameter, reader, outcome, locationPath + ".parameter["+result.Parameter.Count+"]", cancellationToken); // 70
							result.Parameter.Add(newItem_parameter);
							break;
						case "textFilter":
							result.TextFilter = new Hl7.Fhir.Model.Markdown();
							Parse(result.TextFilter as Hl7.Fhir.Model.Markdown, reader, outcome, locationPath + ".textFilter", cancellationToken); // 80
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

		public async System.Threading.Tasks.Task ParseAsync(Hl7.Fhir.Model.TerminologyCapabilities.ExpansionComponent result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
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
						case "hierarchical":
							result.HierarchicalElement = new Hl7.Fhir.Model.FhirBoolean();
							await ParseAsync(result.HierarchicalElement as Hl7.Fhir.Model.FhirBoolean, reader, outcome, locationPath + ".hierarchical", cancellationToken); // 40
							break;
						case "paging":
							result.PagingElement = new Hl7.Fhir.Model.FhirBoolean();
							await ParseAsync(result.PagingElement as Hl7.Fhir.Model.FhirBoolean, reader, outcome, locationPath + ".paging", cancellationToken); // 50
							break;
						case "incomplete":
							result.IncompleteElement = new Hl7.Fhir.Model.FhirBoolean();
							await ParseAsync(result.IncompleteElement as Hl7.Fhir.Model.FhirBoolean, reader, outcome, locationPath + ".incomplete", cancellationToken); // 60
							break;
						case "parameter":
							var newItem_parameter = new Hl7.Fhir.Model.TerminologyCapabilities.ParameterComponent();
							await ParseAsync(newItem_parameter, reader, outcome, locationPath + ".parameter["+result.Parameter.Count+"]", cancellationToken); // 70
							result.Parameter.Add(newItem_parameter);
							break;
						case "textFilter":
							result.TextFilter = new Hl7.Fhir.Model.Markdown();
							await ParseAsync(result.TextFilter as Hl7.Fhir.Model.Markdown, reader, outcome, locationPath + ".textFilter", cancellationToken); // 80
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
