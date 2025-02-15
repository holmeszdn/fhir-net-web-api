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
		public void Parse(Hl7.Fhir.Model.ImagingStudy.SeriesComponent result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
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
						case "uid":
							result.UidElement = new Hl7.Fhir.Model.Id();
							Parse(result.UidElement as Hl7.Fhir.Model.Id, reader, outcome, locationPath + ".uid", cancellationToken); // 40
							break;
						case "number":
							result.NumberElement = new Hl7.Fhir.Model.UnsignedInt();
							Parse(result.NumberElement as Hl7.Fhir.Model.UnsignedInt, reader, outcome, locationPath + ".number", cancellationToken); // 50
							break;
						case "modality":
							result.Modality = new Hl7.Fhir.Model.Coding();
							Parse(result.Modality as Hl7.Fhir.Model.Coding, reader, outcome, locationPath + ".modality", cancellationToken); // 60
							break;
						case "description":
							result.DescriptionElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.DescriptionElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".description", cancellationToken); // 70
							break;
						case "numberOfInstances":
							result.NumberOfInstancesElement = new Hl7.Fhir.Model.UnsignedInt();
							Parse(result.NumberOfInstancesElement as Hl7.Fhir.Model.UnsignedInt, reader, outcome, locationPath + ".numberOfInstances", cancellationToken); // 80
							break;
						case "endpoint":
							var newItem_endpoint = new Hl7.Fhir.Model.ResourceReference();
							Parse(newItem_endpoint, reader, outcome, locationPath + ".endpoint["+result.Endpoint.Count+"]", cancellationToken); // 90
							result.Endpoint.Add(newItem_endpoint);
							break;
						case "bodySite":
							result.BodySite = new Hl7.Fhir.Model.Coding();
							Parse(result.BodySite as Hl7.Fhir.Model.Coding, reader, outcome, locationPath + ".bodySite", cancellationToken); // 100
							break;
						case "laterality":
							result.Laterality = new Hl7.Fhir.Model.Coding();
							Parse(result.Laterality as Hl7.Fhir.Model.Coding, reader, outcome, locationPath + ".laterality", cancellationToken); // 110
							break;
						case "specimen":
							var newItem_specimen = new Hl7.Fhir.Model.ResourceReference();
							Parse(newItem_specimen, reader, outcome, locationPath + ".specimen["+result.Specimen.Count+"]", cancellationToken); // 120
							result.Specimen.Add(newItem_specimen);
							break;
						case "started":
							result.StartedElement = new Hl7.Fhir.Model.FhirDateTime();
							Parse(result.StartedElement as Hl7.Fhir.Model.FhirDateTime, reader, outcome, locationPath + ".started", cancellationToken); // 130
							break;
						case "performer":
							var newItem_performer = new Hl7.Fhir.Model.ImagingStudy.PerformerComponent();
							Parse(newItem_performer, reader, outcome, locationPath + ".performer["+result.Performer.Count+"]", cancellationToken); // 140
							result.Performer.Add(newItem_performer);
							break;
						case "instance":
							var newItem_instance = new Hl7.Fhir.Model.ImagingStudy.InstanceComponent();
							Parse(newItem_instance, reader, outcome, locationPath + ".instance["+result.Instance.Count+"]", cancellationToken); // 150
							result.Instance.Add(newItem_instance);
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

		public async System.Threading.Tasks.Task ParseAsync(Hl7.Fhir.Model.ImagingStudy.SeriesComponent result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
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
						case "uid":
							result.UidElement = new Hl7.Fhir.Model.Id();
							await ParseAsync(result.UidElement as Hl7.Fhir.Model.Id, reader, outcome, locationPath + ".uid", cancellationToken); // 40
							break;
						case "number":
							result.NumberElement = new Hl7.Fhir.Model.UnsignedInt();
							await ParseAsync(result.NumberElement as Hl7.Fhir.Model.UnsignedInt, reader, outcome, locationPath + ".number", cancellationToken); // 50
							break;
						case "modality":
							result.Modality = new Hl7.Fhir.Model.Coding();
							await ParseAsync(result.Modality as Hl7.Fhir.Model.Coding, reader, outcome, locationPath + ".modality", cancellationToken); // 60
							break;
						case "description":
							result.DescriptionElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.DescriptionElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".description", cancellationToken); // 70
							break;
						case "numberOfInstances":
							result.NumberOfInstancesElement = new Hl7.Fhir.Model.UnsignedInt();
							await ParseAsync(result.NumberOfInstancesElement as Hl7.Fhir.Model.UnsignedInt, reader, outcome, locationPath + ".numberOfInstances", cancellationToken); // 80
							break;
						case "endpoint":
							var newItem_endpoint = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(newItem_endpoint, reader, outcome, locationPath + ".endpoint["+result.Endpoint.Count+"]", cancellationToken); // 90
							result.Endpoint.Add(newItem_endpoint);
							break;
						case "bodySite":
							result.BodySite = new Hl7.Fhir.Model.Coding();
							await ParseAsync(result.BodySite as Hl7.Fhir.Model.Coding, reader, outcome, locationPath + ".bodySite", cancellationToken); // 100
							break;
						case "laterality":
							result.Laterality = new Hl7.Fhir.Model.Coding();
							await ParseAsync(result.Laterality as Hl7.Fhir.Model.Coding, reader, outcome, locationPath + ".laterality", cancellationToken); // 110
							break;
						case "specimen":
							var newItem_specimen = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(newItem_specimen, reader, outcome, locationPath + ".specimen["+result.Specimen.Count+"]", cancellationToken); // 120
							result.Specimen.Add(newItem_specimen);
							break;
						case "started":
							result.StartedElement = new Hl7.Fhir.Model.FhirDateTime();
							await ParseAsync(result.StartedElement as Hl7.Fhir.Model.FhirDateTime, reader, outcome, locationPath + ".started", cancellationToken); // 130
							break;
						case "performer":
							var newItem_performer = new Hl7.Fhir.Model.ImagingStudy.PerformerComponent();
							await ParseAsync(newItem_performer, reader, outcome, locationPath + ".performer["+result.Performer.Count+"]", cancellationToken); // 140
							result.Performer.Add(newItem_performer);
							break;
						case "instance":
							var newItem_instance = new Hl7.Fhir.Model.ImagingStudy.InstanceComponent();
							await ParseAsync(newItem_instance, reader, outcome, locationPath + ".instance["+result.Instance.Count+"]", cancellationToken); // 150
							result.Instance.Add(newItem_instance);
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
