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
		private void Parse(Coverage result, XmlReader reader, OperationOutcome outcome, string locationPath)
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
				if (reader.IsStartElement())
				{
					switch (reader.Name)
					{
						case "id":
							result.IdElement = new Hl7.Fhir.Model.Id();
							Parse(result.IdElement as Hl7.Fhir.Model.Id, reader, outcome, locationPath + ".id"); // 10
							break;
						case "meta":
							result.Meta = new Hl7.Fhir.Model.Meta();
							Parse(result.Meta as Hl7.Fhir.Model.Meta, reader, outcome, locationPath + ".meta"); // 20
							break;
						case "implicitRules":
							result.ImplicitRulesElement = new Hl7.Fhir.Model.FhirUri();
							Parse(result.ImplicitRulesElement as Hl7.Fhir.Model.FhirUri, reader, outcome, locationPath + ".implicitRules"); // 30
							break;
						case "language":
							result.LanguageElement = new Hl7.Fhir.Model.Code();
							Parse(result.LanguageElement as Hl7.Fhir.Model.Code, reader, outcome, locationPath + ".language"); // 40
							break;
						case "text":
							result.Text = new Hl7.Fhir.Model.Narrative();
							Parse(result.Text as Hl7.Fhir.Model.Narrative, reader, outcome, locationPath + ".text"); // 50
							break;
						case "contained":
							// FirstChildOf(reader); // 60
							var ContainedResource = Parse(reader, outcome, locationPath + ".contained["+result.Contained.Count+"]");
							if (ContainedResource != null)
								result.Contained.Add(ContainedResource);
							if (!reader.Read()) return;
							break;
						case "extension":
							var newItem_extension = new Hl7.Fhir.Model.Extension();
							Parse(newItem_extension, reader, outcome, locationPath + ".extension["+result.Extension.Count+"]"); // 70
							result.Extension.Add(newItem_extension);
							break;
						case "modifierExtension":
							var newItem_modifierExtension = new Hl7.Fhir.Model.Extension();
							Parse(newItem_modifierExtension, reader, outcome, locationPath + ".modifierExtension["+result.ModifierExtension.Count+"]"); // 80
							result.ModifierExtension.Add(newItem_modifierExtension);
							break;
						case "identifier":
							var newItem_identifier = new Hl7.Fhir.Model.Identifier();
							Parse(newItem_identifier, reader, outcome, locationPath + ".identifier["+result.Identifier.Count+"]"); // 90
							result.Identifier.Add(newItem_identifier);
							break;
						case "status":
							result.StatusElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.FinancialResourceStatusCodes>();
							Parse(result.StatusElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.FinancialResourceStatusCodes>, reader, outcome, locationPath + ".status"); // 100
							break;
						case "type":
							result.Type = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.Type as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".type"); // 110
							break;
						case "policyHolder":
							result.PolicyHolder = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.PolicyHolder as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".policyHolder"); // 120
							break;
						case "subscriber":
							result.Subscriber = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Subscriber as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".subscriber"); // 130
							break;
						case "subscriberId":
							result.SubscriberIdElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.SubscriberIdElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".subscriberId"); // 140
							break;
						case "beneficiary":
							result.Beneficiary = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Beneficiary as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".beneficiary"); // 150
							break;
						case "dependent":
							result.DependentElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.DependentElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".dependent"); // 160
							break;
						case "relationship":
							result.Relationship = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.Relationship as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".relationship"); // 170
							break;
						case "period":
							result.Period = new Hl7.Fhir.Model.Period();
							Parse(result.Period as Hl7.Fhir.Model.Period, reader, outcome, locationPath + ".period"); // 180
							break;
						case "payor":
							var newItem_payor = new Hl7.Fhir.Model.ResourceReference();
							Parse(newItem_payor, reader, outcome, locationPath + ".payor["+result.Payor.Count+"]"); // 190
							result.Payor.Add(newItem_payor);
							break;
						case "class":
							var newItem_class = new Hl7.Fhir.Model.Coverage.ClassComponent();
							Parse(newItem_class, reader, outcome, locationPath + ".class["+result.Class.Count+"]"); // 200
							result.Class.Add(newItem_class);
							break;
						case "order":
							result.OrderElement = new Hl7.Fhir.Model.PositiveInt();
							Parse(result.OrderElement as Hl7.Fhir.Model.PositiveInt, reader, outcome, locationPath + ".order"); // 210
							break;
						case "network":
							result.NetworkElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.NetworkElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".network"); // 220
							break;
						case "costToBeneficiary":
							var newItem_costToBeneficiary = new Hl7.Fhir.Model.Coverage.CostToBeneficiaryComponent();
							Parse(newItem_costToBeneficiary, reader, outcome, locationPath + ".costToBeneficiary["+result.CostToBeneficiary.Count+"]"); // 230
							result.CostToBeneficiary.Add(newItem_costToBeneficiary);
							break;
						case "subrogation":
							result.SubrogationElement = new Hl7.Fhir.Model.FhirBoolean();
							Parse(result.SubrogationElement as Hl7.Fhir.Model.FhirBoolean, reader, outcome, locationPath + ".subrogation"); // 240
							break;
						case "contract":
							var newItem_contract = new Hl7.Fhir.Model.ResourceReference();
							Parse(newItem_contract, reader, outcome, locationPath + ".contract["+result.Contract.Count+"]"); // 250
							result.Contract.Add(newItem_contract);
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

		private async System.Threading.Tasks.Task ParseAsync(Coverage result, XmlReader reader, OperationOutcome outcome, string locationPath)
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
				if (reader.IsStartElement())
				{
					switch (reader.Name)
					{
						case "id":
							result.IdElement = new Hl7.Fhir.Model.Id();
							await ParseAsync(result.IdElement as Hl7.Fhir.Model.Id, reader, outcome, locationPath + ".id"); // 10
							break;
						case "meta":
							result.Meta = new Hl7.Fhir.Model.Meta();
							await ParseAsync(result.Meta as Hl7.Fhir.Model.Meta, reader, outcome, locationPath + ".meta"); // 20
							break;
						case "implicitRules":
							result.ImplicitRulesElement = new Hl7.Fhir.Model.FhirUri();
							await ParseAsync(result.ImplicitRulesElement as Hl7.Fhir.Model.FhirUri, reader, outcome, locationPath + ".implicitRules"); // 30
							break;
						case "language":
							result.LanguageElement = new Hl7.Fhir.Model.Code();
							await ParseAsync(result.LanguageElement as Hl7.Fhir.Model.Code, reader, outcome, locationPath + ".language"); // 40
							break;
						case "text":
							result.Text = new Hl7.Fhir.Model.Narrative();
							await ParseAsync(result.Text as Hl7.Fhir.Model.Narrative, reader, outcome, locationPath + ".text"); // 50
							break;
						case "contained":
							// FirstChildOf(reader); // 60
							var ContainedResource = await ParseAsync(reader, outcome, locationPath + ".contained["+result.Contained.Count+"]");
							if (ContainedResource != null)
								result.Contained.Add(ContainedResource);
							if (!reader.Read()) return;
							break;
						case "extension":
							var newItem_extension = new Hl7.Fhir.Model.Extension();
							await ParseAsync(newItem_extension, reader, outcome, locationPath + ".extension["+result.Extension.Count+"]"); // 70
							result.Extension.Add(newItem_extension);
							break;
						case "modifierExtension":
							var newItem_modifierExtension = new Hl7.Fhir.Model.Extension();
							await ParseAsync(newItem_modifierExtension, reader, outcome, locationPath + ".modifierExtension["+result.ModifierExtension.Count+"]"); // 80
							result.ModifierExtension.Add(newItem_modifierExtension);
							break;
						case "identifier":
							var newItem_identifier = new Hl7.Fhir.Model.Identifier();
							await ParseAsync(newItem_identifier, reader, outcome, locationPath + ".identifier["+result.Identifier.Count+"]"); // 90
							result.Identifier.Add(newItem_identifier);
							break;
						case "status":
							result.StatusElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.FinancialResourceStatusCodes>();
							await ParseAsync(result.StatusElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.FinancialResourceStatusCodes>, reader, outcome, locationPath + ".status"); // 100
							break;
						case "type":
							result.Type = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.Type as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".type"); // 110
							break;
						case "policyHolder":
							result.PolicyHolder = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.PolicyHolder as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".policyHolder"); // 120
							break;
						case "subscriber":
							result.Subscriber = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Subscriber as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".subscriber"); // 130
							break;
						case "subscriberId":
							result.SubscriberIdElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.SubscriberIdElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".subscriberId"); // 140
							break;
						case "beneficiary":
							result.Beneficiary = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Beneficiary as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".beneficiary"); // 150
							break;
						case "dependent":
							result.DependentElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.DependentElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".dependent"); // 160
							break;
						case "relationship":
							result.Relationship = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.Relationship as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".relationship"); // 170
							break;
						case "period":
							result.Period = new Hl7.Fhir.Model.Period();
							await ParseAsync(result.Period as Hl7.Fhir.Model.Period, reader, outcome, locationPath + ".period"); // 180
							break;
						case "payor":
							var newItem_payor = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(newItem_payor, reader, outcome, locationPath + ".payor["+result.Payor.Count+"]"); // 190
							result.Payor.Add(newItem_payor);
							break;
						case "class":
							var newItem_class = new Hl7.Fhir.Model.Coverage.ClassComponent();
							await ParseAsync(newItem_class, reader, outcome, locationPath + ".class["+result.Class.Count+"]"); // 200
							result.Class.Add(newItem_class);
							break;
						case "order":
							result.OrderElement = new Hl7.Fhir.Model.PositiveInt();
							await ParseAsync(result.OrderElement as Hl7.Fhir.Model.PositiveInt, reader, outcome, locationPath + ".order"); // 210
							break;
						case "network":
							result.NetworkElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.NetworkElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".network"); // 220
							break;
						case "costToBeneficiary":
							var newItem_costToBeneficiary = new Hl7.Fhir.Model.Coverage.CostToBeneficiaryComponent();
							await ParseAsync(newItem_costToBeneficiary, reader, outcome, locationPath + ".costToBeneficiary["+result.CostToBeneficiary.Count+"]"); // 230
							result.CostToBeneficiary.Add(newItem_costToBeneficiary);
							break;
						case "subrogation":
							result.SubrogationElement = new Hl7.Fhir.Model.FhirBoolean();
							await ParseAsync(result.SubrogationElement as Hl7.Fhir.Model.FhirBoolean, reader, outcome, locationPath + ".subrogation"); // 240
							break;
						case "contract":
							var newItem_contract = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(newItem_contract, reader, outcome, locationPath + ".contract["+result.Contract.Count+"]"); // 250
							result.Contract.Add(newItem_contract);
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
