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
		public void Parse(Hl7.Fhir.Model.SpecimenDefinition.TypeTestedComponent result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
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
						case "isDerived":
							result.IsDerivedElement = new Hl7.Fhir.Model.FhirBoolean();
							Parse(result.IsDerivedElement as Hl7.Fhir.Model.FhirBoolean, reader, outcome, locationPath + ".isDerived", cancellationToken); // 40
							break;
						case "type":
							result.Type = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.Type as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".type", cancellationToken); // 50
							break;
						case "preference":
							result.PreferenceElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.SpecimenDefinition.SpecimenContainedPreference>();
							Parse(result.PreferenceElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.SpecimenDefinition.SpecimenContainedPreference>, reader, outcome, locationPath + ".preference", cancellationToken); // 60
							break;
						case "container":
							result.Container = new Hl7.Fhir.Model.SpecimenDefinition.ContainerComponent();
							Parse(result.Container as Hl7.Fhir.Model.SpecimenDefinition.ContainerComponent, reader, outcome, locationPath + ".container", cancellationToken); // 70
							break;
						case "requirement":
							result.RequirementElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.RequirementElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".requirement", cancellationToken); // 80
							break;
						case "retentionTime":
							result.RetentionTime = new Hl7.Fhir.Model.Duration();
							Parse(result.RetentionTime as Hl7.Fhir.Model.Duration, reader, outcome, locationPath + ".retentionTime", cancellationToken); // 90
							break;
						case "rejectionCriterion":
							var newItem_rejectionCriterion = new Hl7.Fhir.Model.CodeableConcept();
							Parse(newItem_rejectionCriterion, reader, outcome, locationPath + ".rejectionCriterion["+result.RejectionCriterion.Count+"]", cancellationToken); // 100
							result.RejectionCriterion.Add(newItem_rejectionCriterion);
							break;
						case "handling":
							var newItem_handling = new Hl7.Fhir.Model.SpecimenDefinition.HandlingComponent();
							Parse(newItem_handling, reader, outcome, locationPath + ".handling["+result.Handling.Count+"]", cancellationToken); // 110
							result.Handling.Add(newItem_handling);
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

		public async System.Threading.Tasks.Task ParseAsync(Hl7.Fhir.Model.SpecimenDefinition.TypeTestedComponent result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
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
						case "isDerived":
							result.IsDerivedElement = new Hl7.Fhir.Model.FhirBoolean();
							await ParseAsync(result.IsDerivedElement as Hl7.Fhir.Model.FhirBoolean, reader, outcome, locationPath + ".isDerived", cancellationToken); // 40
							break;
						case "type":
							result.Type = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.Type as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".type", cancellationToken); // 50
							break;
						case "preference":
							result.PreferenceElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.SpecimenDefinition.SpecimenContainedPreference>();
							await ParseAsync(result.PreferenceElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.SpecimenDefinition.SpecimenContainedPreference>, reader, outcome, locationPath + ".preference", cancellationToken); // 60
							break;
						case "container":
							result.Container = new Hl7.Fhir.Model.SpecimenDefinition.ContainerComponent();
							await ParseAsync(result.Container as Hl7.Fhir.Model.SpecimenDefinition.ContainerComponent, reader, outcome, locationPath + ".container", cancellationToken); // 70
							break;
						case "requirement":
							result.RequirementElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.RequirementElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".requirement", cancellationToken); // 80
							break;
						case "retentionTime":
							result.RetentionTime = new Hl7.Fhir.Model.Duration();
							await ParseAsync(result.RetentionTime as Hl7.Fhir.Model.Duration, reader, outcome, locationPath + ".retentionTime", cancellationToken); // 90
							break;
						case "rejectionCriterion":
							var newItem_rejectionCriterion = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(newItem_rejectionCriterion, reader, outcome, locationPath + ".rejectionCriterion["+result.RejectionCriterion.Count+"]", cancellationToken); // 100
							result.RejectionCriterion.Add(newItem_rejectionCriterion);
							break;
						case "handling":
							var newItem_handling = new Hl7.Fhir.Model.SpecimenDefinition.HandlingComponent();
							await ParseAsync(newItem_handling, reader, outcome, locationPath + ".handling["+result.Handling.Count+"]", cancellationToken); // 110
							result.Handling.Add(newItem_handling);
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
