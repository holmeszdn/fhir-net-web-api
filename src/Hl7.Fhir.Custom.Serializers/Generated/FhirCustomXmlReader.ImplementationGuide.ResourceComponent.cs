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
		public void Parse(Hl7.Fhir.Model.ImplementationGuide.ResourceComponent result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
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
						case "reference":
							result.Reference = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Reference as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".reference", cancellationToken); // 40
							break;
						case "fhirVersion":
							var newItem_fhirVersion = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.FHIRVersion>();
							Parse(newItem_fhirVersion, reader, outcome, locationPath + ".fhirVersion["+result.FhirVersionElement.Count+"]", cancellationToken); // 50
							result.FhirVersionElement.Add(newItem_fhirVersion);
							break;
						case "name":
							result.NameElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.NameElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".name", cancellationToken); // 60
							break;
						case "description":
							result.DescriptionElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.DescriptionElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".description", cancellationToken); // 70
							break;
						case "exampleBoolean":
							result.Example = new Hl7.Fhir.Model.FhirBoolean();
							Parse(result.Example as Hl7.Fhir.Model.FhirBoolean, reader, outcome, locationPath + ".example", cancellationToken); // 80
							break;
						case "exampleCanonical":
							result.Example = new Hl7.Fhir.Model.Canonical();
							Parse(result.Example as Hl7.Fhir.Model.Canonical, reader, outcome, locationPath + ".example", cancellationToken); // 80
							break;
						case "groupingId":
							result.GroupingIdElement = new Hl7.Fhir.Model.Id();
							Parse(result.GroupingIdElement as Hl7.Fhir.Model.Id, reader, outcome, locationPath + ".groupingId", cancellationToken); // 90
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

		public async System.Threading.Tasks.Task ParseAsync(Hl7.Fhir.Model.ImplementationGuide.ResourceComponent result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
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
						case "reference":
							result.Reference = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Reference as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".reference", cancellationToken); // 40
							break;
						case "fhirVersion":
							var newItem_fhirVersion = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.FHIRVersion>();
							await ParseAsync(newItem_fhirVersion, reader, outcome, locationPath + ".fhirVersion["+result.FhirVersionElement.Count+"]", cancellationToken); // 50
							result.FhirVersionElement.Add(newItem_fhirVersion);
							break;
						case "name":
							result.NameElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.NameElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".name", cancellationToken); // 60
							break;
						case "description":
							result.DescriptionElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.DescriptionElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".description", cancellationToken); // 70
							break;
						case "exampleBoolean":
							result.Example = new Hl7.Fhir.Model.FhirBoolean();
							await ParseAsync(result.Example as Hl7.Fhir.Model.FhirBoolean, reader, outcome, locationPath + ".example", cancellationToken); // 80
							break;
						case "exampleCanonical":
							result.Example = new Hl7.Fhir.Model.Canonical();
							await ParseAsync(result.Example as Hl7.Fhir.Model.Canonical, reader, outcome, locationPath + ".example", cancellationToken); // 80
							break;
						case "groupingId":
							result.GroupingIdElement = new Hl7.Fhir.Model.Id();
							await ParseAsync(result.GroupingIdElement as Hl7.Fhir.Model.Id, reader, outcome, locationPath + ".groupingId", cancellationToken); // 90
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
