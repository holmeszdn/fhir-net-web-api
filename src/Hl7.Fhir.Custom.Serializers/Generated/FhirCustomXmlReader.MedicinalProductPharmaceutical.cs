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
		private void Parse(MedicinalProductPharmaceutical result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
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
						case "administrableDoseForm":
							result.AdministrableDoseForm = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.AdministrableDoseForm as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".administrableDoseForm", cancellationToken); // 100
							break;
						case "unitOfPresentation":
							result.UnitOfPresentation = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.UnitOfPresentation as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".unitOfPresentation", cancellationToken); // 110
							break;
						case "ingredient":
							var newItem_ingredient = new Hl7.Fhir.Model.ResourceReference();
							Parse(newItem_ingredient, reader, outcome, locationPath + ".ingredient["+result.Ingredient.Count+"]", cancellationToken); // 120
							result.Ingredient.Add(newItem_ingredient);
							break;
						case "device":
							var newItem_device = new Hl7.Fhir.Model.ResourceReference();
							Parse(newItem_device, reader, outcome, locationPath + ".device["+result.Device.Count+"]", cancellationToken); // 130
							result.Device.Add(newItem_device);
							break;
						case "characteristics":
							var newItem_characteristics = new Hl7.Fhir.Model.MedicinalProductPharmaceutical.CharacteristicsComponent();
							Parse(newItem_characteristics, reader, outcome, locationPath + ".characteristics["+result.Characteristics.Count+"]", cancellationToken); // 140
							result.Characteristics.Add(newItem_characteristics);
							break;
						case "routeOfAdministration":
							var newItem_routeOfAdministration = new Hl7.Fhir.Model.MedicinalProductPharmaceutical.RouteOfAdministrationComponent();
							Parse(newItem_routeOfAdministration, reader, outcome, locationPath + ".routeOfAdministration["+result.RouteOfAdministration.Count+"]", cancellationToken); // 150
							result.RouteOfAdministration.Add(newItem_routeOfAdministration);
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

		private async System.Threading.Tasks.Task ParseAsync(MedicinalProductPharmaceutical result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
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
						case "administrableDoseForm":
							result.AdministrableDoseForm = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.AdministrableDoseForm as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".administrableDoseForm", cancellationToken); // 100
							break;
						case "unitOfPresentation":
							result.UnitOfPresentation = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.UnitOfPresentation as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".unitOfPresentation", cancellationToken); // 110
							break;
						case "ingredient":
							var newItem_ingredient = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(newItem_ingredient, reader, outcome, locationPath + ".ingredient["+result.Ingredient.Count+"]", cancellationToken); // 120
							result.Ingredient.Add(newItem_ingredient);
							break;
						case "device":
							var newItem_device = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(newItem_device, reader, outcome, locationPath + ".device["+result.Device.Count+"]", cancellationToken); // 130
							result.Device.Add(newItem_device);
							break;
						case "characteristics":
							var newItem_characteristics = new Hl7.Fhir.Model.MedicinalProductPharmaceutical.CharacteristicsComponent();
							await ParseAsync(newItem_characteristics, reader, outcome, locationPath + ".characteristics["+result.Characteristics.Count+"]", cancellationToken); // 140
							result.Characteristics.Add(newItem_characteristics);
							break;
						case "routeOfAdministration":
							var newItem_routeOfAdministration = new Hl7.Fhir.Model.MedicinalProductPharmaceutical.RouteOfAdministrationComponent();
							await ParseAsync(newItem_routeOfAdministration, reader, outcome, locationPath + ".routeOfAdministration["+result.RouteOfAdministration.Count+"]", cancellationToken); // 150
							result.RouteOfAdministration.Add(newItem_routeOfAdministration);
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
