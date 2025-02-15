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
		private void Parse(Location result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
		{
			// skip ignored elements
			while (ShouldSkipNodeType(reader.NodeType))
				if (!reader.Read())
					return;

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
						case "id":
							result.IdElement = new Hl7.Fhir.Model.Id();
							Parse(result.IdElement as Hl7.Fhir.Model.Id, reader, outcome, locationPath + ".id", cancellationToken); // 10
							break;
						case "meta":
							result.Meta = new Hl7.Fhir.Model.Meta();
							Parse(result.Meta as Hl7.Fhir.Model.Meta, reader, outcome, locationPath + ".meta", cancellationToken); // 20
							break;
						case "implicitRules":
							result.ImplicitRulesElement = new Hl7.Fhir.Model.FhirUri();
							Parse(result.ImplicitRulesElement as Hl7.Fhir.Model.FhirUri, reader, outcome, locationPath + ".implicitRules", cancellationToken); // 30
							break;
						case "language":
							result.LanguageElement = new Hl7.Fhir.Model.Code();
							Parse(result.LanguageElement as Hl7.Fhir.Model.Code, reader, outcome, locationPath + ".language", cancellationToken); // 40
							break;
						case "text":
							result.Text = new Hl7.Fhir.Model.Narrative();
							Parse(result.Text as Hl7.Fhir.Model.Narrative, reader, outcome, locationPath + ".text", cancellationToken); // 50
							break;
						case "contained":
							// FirstChildOf(reader); // 60
							var ContainedResource = Parse(reader, outcome, locationPath + ".contained["+result.Contained.Count+"]", cancellationToken);
							if (ContainedResource != null)
								result.Contained.Add(ContainedResource);
							if (!reader.Read()) return;
							break;
						case "extension":
							var newItem_extension = new Hl7.Fhir.Model.Extension();
							Parse(newItem_extension, reader, outcome, locationPath + ".extension["+result.Extension.Count+"]", cancellationToken); // 70
							result.Extension.Add(newItem_extension);
							break;
						case "modifierExtension":
							var newItem_modifierExtension = new Hl7.Fhir.Model.Extension();
							Parse(newItem_modifierExtension, reader, outcome, locationPath + ".modifierExtension["+result.ModifierExtension.Count+"]", cancellationToken); // 80
							result.ModifierExtension.Add(newItem_modifierExtension);
							break;
						case "identifier":
							var newItem_identifier = new Hl7.Fhir.Model.Identifier();
							Parse(newItem_identifier, reader, outcome, locationPath + ".identifier["+result.Identifier.Count+"]", cancellationToken); // 90
							result.Identifier.Add(newItem_identifier);
							break;
						case "status":
							result.StatusElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.Location.LocationStatus>();
							Parse(result.StatusElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.Location.LocationStatus>, reader, outcome, locationPath + ".status", cancellationToken); // 100
							break;
						case "operationalStatus":
							result.OperationalStatus = new Hl7.Fhir.Model.Coding();
							Parse(result.OperationalStatus as Hl7.Fhir.Model.Coding, reader, outcome, locationPath + ".operationalStatus", cancellationToken); // 110
							break;
						case "name":
							result.NameElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.NameElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".name", cancellationToken); // 120
							break;
						case "alias":
							var newItem_alias = new Hl7.Fhir.Model.FhirString();
							Parse(newItem_alias, reader, outcome, locationPath + ".alias["+result.AliasElement.Count+"]", cancellationToken); // 130
							result.AliasElement.Add(newItem_alias);
							break;
						case "description":
							result.DescriptionElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.DescriptionElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".description", cancellationToken); // 140
							break;
						case "mode":
							result.ModeElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.Location.LocationMode>();
							Parse(result.ModeElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.Location.LocationMode>, reader, outcome, locationPath + ".mode", cancellationToken); // 150
							break;
						case "type":
							var newItem_type = new Hl7.Fhir.Model.CodeableConcept();
							Parse(newItem_type, reader, outcome, locationPath + ".type["+result.Type.Count+"]", cancellationToken); // 160
							result.Type.Add(newItem_type);
							break;
						case "telecom":
							var newItem_telecom = new Hl7.Fhir.Model.ContactPoint();
							Parse(newItem_telecom, reader, outcome, locationPath + ".telecom["+result.Telecom.Count+"]", cancellationToken); // 170
							result.Telecom.Add(newItem_telecom);
							break;
						case "address":
							result.Address = new Hl7.Fhir.Model.Address();
							Parse(result.Address as Hl7.Fhir.Model.Address, reader, outcome, locationPath + ".address", cancellationToken); // 180
							break;
						case "physicalType":
							result.PhysicalType = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.PhysicalType as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".physicalType", cancellationToken); // 190
							break;
						case "position":
							result.Position = new Hl7.Fhir.Model.Location.PositionComponent();
							Parse(result.Position as Hl7.Fhir.Model.Location.PositionComponent, reader, outcome, locationPath + ".position", cancellationToken); // 200
							break;
						case "managingOrganization":
							result.ManagingOrganization = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.ManagingOrganization as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".managingOrganization", cancellationToken); // 210
							break;
						case "partOf":
							result.PartOf = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.PartOf as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".partOf", cancellationToken); // 220
							break;
						case "hoursOfOperation":
							var newItem_hoursOfOperation = new Hl7.Fhir.Model.Location.HoursOfOperationComponent();
							Parse(newItem_hoursOfOperation, reader, outcome, locationPath + ".hoursOfOperation["+result.HoursOfOperation.Count+"]", cancellationToken); // 230
							result.HoursOfOperation.Add(newItem_hoursOfOperation);
							break;
						case "availabilityExceptions":
							result.AvailabilityExceptionsElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.AvailabilityExceptionsElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".availabilityExceptions", cancellationToken); // 240
							break;
						case "endpoint":
							var newItem_endpoint = new Hl7.Fhir.Model.ResourceReference();
							Parse(newItem_endpoint, reader, outcome, locationPath + ".endpoint["+result.Endpoint.Count+"]", cancellationToken); // 250
							result.Endpoint.Add(newItem_endpoint);
							break;
						default:
							// Property not found
							// System.Diagnostics.Trace.WriteLine($\"Unexpected token found {reader.Name}\");
							HandlePropertyNotFound(reader, outcome, locationPath + "." + reader.Name);
							// reader.ReadInnerXml();
							break;
					}
				}
				else if (reader.NodeType == XmlNodeType.EndElement || reader.IsStartElement() && reader.IsEmptyElement)
				{
					break;
				}
			}
		}

		private async System.Threading.Tasks.Task ParseAsync(Location result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
		{
			// skip ignored elements
			while (ShouldSkipNodeType(reader.NodeType))
				if (!await reader.ReadAsync().ConfigureAwait(false))
					return;

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
						case "id":
							result.IdElement = new Hl7.Fhir.Model.Id();
							await ParseAsync(result.IdElement as Hl7.Fhir.Model.Id, reader, outcome, locationPath + ".id", cancellationToken); // 10
							break;
						case "meta":
							result.Meta = new Hl7.Fhir.Model.Meta();
							await ParseAsync(result.Meta as Hl7.Fhir.Model.Meta, reader, outcome, locationPath + ".meta", cancellationToken); // 20
							break;
						case "implicitRules":
							result.ImplicitRulesElement = new Hl7.Fhir.Model.FhirUri();
							await ParseAsync(result.ImplicitRulesElement as Hl7.Fhir.Model.FhirUri, reader, outcome, locationPath + ".implicitRules", cancellationToken); // 30
							break;
						case "language":
							result.LanguageElement = new Hl7.Fhir.Model.Code();
							await ParseAsync(result.LanguageElement as Hl7.Fhir.Model.Code, reader, outcome, locationPath + ".language", cancellationToken); // 40
							break;
						case "text":
							result.Text = new Hl7.Fhir.Model.Narrative();
							await ParseAsync(result.Text as Hl7.Fhir.Model.Narrative, reader, outcome, locationPath + ".text", cancellationToken); // 50
							break;
						case "contained":
							// FirstChildOf(reader); // 60
							var ContainedResource = await ParseAsync(reader, outcome, locationPath + ".contained["+result.Contained.Count+"]", cancellationToken);
							if (ContainedResource != null)
								result.Contained.Add(ContainedResource);
							if (!reader.Read()) return;
							break;
						case "extension":
							var newItem_extension = new Hl7.Fhir.Model.Extension();
							await ParseAsync(newItem_extension, reader, outcome, locationPath + ".extension["+result.Extension.Count+"]", cancellationToken); // 70
							result.Extension.Add(newItem_extension);
							break;
						case "modifierExtension":
							var newItem_modifierExtension = new Hl7.Fhir.Model.Extension();
							await ParseAsync(newItem_modifierExtension, reader, outcome, locationPath + ".modifierExtension["+result.ModifierExtension.Count+"]", cancellationToken); // 80
							result.ModifierExtension.Add(newItem_modifierExtension);
							break;
						case "identifier":
							var newItem_identifier = new Hl7.Fhir.Model.Identifier();
							await ParseAsync(newItem_identifier, reader, outcome, locationPath + ".identifier["+result.Identifier.Count+"]", cancellationToken); // 90
							result.Identifier.Add(newItem_identifier);
							break;
						case "status":
							result.StatusElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.Location.LocationStatus>();
							await ParseAsync(result.StatusElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.Location.LocationStatus>, reader, outcome, locationPath + ".status", cancellationToken); // 100
							break;
						case "operationalStatus":
							result.OperationalStatus = new Hl7.Fhir.Model.Coding();
							await ParseAsync(result.OperationalStatus as Hl7.Fhir.Model.Coding, reader, outcome, locationPath + ".operationalStatus", cancellationToken); // 110
							break;
						case "name":
							result.NameElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.NameElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".name", cancellationToken); // 120
							break;
						case "alias":
							var newItem_alias = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(newItem_alias, reader, outcome, locationPath + ".alias["+result.AliasElement.Count+"]", cancellationToken); // 130
							result.AliasElement.Add(newItem_alias);
							break;
						case "description":
							result.DescriptionElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.DescriptionElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".description", cancellationToken); // 140
							break;
						case "mode":
							result.ModeElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.Location.LocationMode>();
							await ParseAsync(result.ModeElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.Location.LocationMode>, reader, outcome, locationPath + ".mode", cancellationToken); // 150
							break;
						case "type":
							var newItem_type = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(newItem_type, reader, outcome, locationPath + ".type["+result.Type.Count+"]", cancellationToken); // 160
							result.Type.Add(newItem_type);
							break;
						case "telecom":
							var newItem_telecom = new Hl7.Fhir.Model.ContactPoint();
							await ParseAsync(newItem_telecom, reader, outcome, locationPath + ".telecom["+result.Telecom.Count+"]", cancellationToken); // 170
							result.Telecom.Add(newItem_telecom);
							break;
						case "address":
							result.Address = new Hl7.Fhir.Model.Address();
							await ParseAsync(result.Address as Hl7.Fhir.Model.Address, reader, outcome, locationPath + ".address", cancellationToken); // 180
							break;
						case "physicalType":
							result.PhysicalType = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.PhysicalType as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".physicalType", cancellationToken); // 190
							break;
						case "position":
							result.Position = new Hl7.Fhir.Model.Location.PositionComponent();
							await ParseAsync(result.Position as Hl7.Fhir.Model.Location.PositionComponent, reader, outcome, locationPath + ".position", cancellationToken); // 200
							break;
						case "managingOrganization":
							result.ManagingOrganization = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.ManagingOrganization as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".managingOrganization", cancellationToken); // 210
							break;
						case "partOf":
							result.PartOf = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.PartOf as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".partOf", cancellationToken); // 220
							break;
						case "hoursOfOperation":
							var newItem_hoursOfOperation = new Hl7.Fhir.Model.Location.HoursOfOperationComponent();
							await ParseAsync(newItem_hoursOfOperation, reader, outcome, locationPath + ".hoursOfOperation["+result.HoursOfOperation.Count+"]", cancellationToken); // 230
							result.HoursOfOperation.Add(newItem_hoursOfOperation);
							break;
						case "availabilityExceptions":
							result.AvailabilityExceptionsElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.AvailabilityExceptionsElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".availabilityExceptions", cancellationToken); // 240
							break;
						case "endpoint":
							var newItem_endpoint = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(newItem_endpoint, reader, outcome, locationPath + ".endpoint["+result.Endpoint.Count+"]", cancellationToken); // 250
							result.Endpoint.Add(newItem_endpoint);
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
