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
		private void Parse(Consent result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
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
							result.StatusElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.Consent.ConsentState>();
							Parse(result.StatusElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.Consent.ConsentState>, reader, outcome, locationPath + ".status", cancellationToken); // 100
							break;
						case "scope":
							result.Scope = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.Scope as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".scope", cancellationToken); // 110
							break;
						case "category":
							var newItem_category = new Hl7.Fhir.Model.CodeableConcept();
							Parse(newItem_category, reader, outcome, locationPath + ".category["+result.Category.Count+"]", cancellationToken); // 120
							result.Category.Add(newItem_category);
							break;
						case "patient":
							result.Patient = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Patient as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".patient", cancellationToken); // 130
							break;
						case "dateTime":
							result.DateTimeElement = new Hl7.Fhir.Model.FhirDateTime();
							Parse(result.DateTimeElement as Hl7.Fhir.Model.FhirDateTime, reader, outcome, locationPath + ".dateTime", cancellationToken); // 140
							break;
						case "performer":
							var newItem_performer = new Hl7.Fhir.Model.ResourceReference();
							Parse(newItem_performer, reader, outcome, locationPath + ".performer["+result.Performer.Count+"]", cancellationToken); // 150
							result.Performer.Add(newItem_performer);
							break;
						case "organization":
							var newItem_organization = new Hl7.Fhir.Model.ResourceReference();
							Parse(newItem_organization, reader, outcome, locationPath + ".organization["+result.Organization.Count+"]", cancellationToken); // 160
							result.Organization.Add(newItem_organization);
							break;
						case "sourceAttachment":
							result.Source = new Hl7.Fhir.Model.Attachment();
							Parse(result.Source as Hl7.Fhir.Model.Attachment, reader, outcome, locationPath + ".source", cancellationToken); // 170
							break;
						case "sourceReference":
							result.Source = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Source as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".source", cancellationToken); // 170
							break;
						case "policy":
							var newItem_policy = new Hl7.Fhir.Model.Consent.PolicyComponent();
							Parse(newItem_policy, reader, outcome, locationPath + ".policy["+result.Policy.Count+"]", cancellationToken); // 180
							result.Policy.Add(newItem_policy);
							break;
						case "policyRule":
							result.PolicyRule = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.PolicyRule as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".policyRule", cancellationToken); // 190
							break;
						case "verification":
							var newItem_verification = new Hl7.Fhir.Model.Consent.VerificationComponent();
							Parse(newItem_verification, reader, outcome, locationPath + ".verification["+result.Verification.Count+"]", cancellationToken); // 200
							result.Verification.Add(newItem_verification);
							break;
						case "provision":
							result.Provision = new Hl7.Fhir.Model.Consent.provisionComponent();
							Parse(result.Provision as Hl7.Fhir.Model.Consent.provisionComponent, reader, outcome, locationPath + ".provision", cancellationToken); // 210
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

		private async System.Threading.Tasks.Task ParseAsync(Consent result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
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
							result.StatusElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.Consent.ConsentState>();
							await ParseAsync(result.StatusElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.Consent.ConsentState>, reader, outcome, locationPath + ".status", cancellationToken); // 100
							break;
						case "scope":
							result.Scope = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.Scope as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".scope", cancellationToken); // 110
							break;
						case "category":
							var newItem_category = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(newItem_category, reader, outcome, locationPath + ".category["+result.Category.Count+"]", cancellationToken); // 120
							result.Category.Add(newItem_category);
							break;
						case "patient":
							result.Patient = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Patient as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".patient", cancellationToken); // 130
							break;
						case "dateTime":
							result.DateTimeElement = new Hl7.Fhir.Model.FhirDateTime();
							await ParseAsync(result.DateTimeElement as Hl7.Fhir.Model.FhirDateTime, reader, outcome, locationPath + ".dateTime", cancellationToken); // 140
							break;
						case "performer":
							var newItem_performer = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(newItem_performer, reader, outcome, locationPath + ".performer["+result.Performer.Count+"]", cancellationToken); // 150
							result.Performer.Add(newItem_performer);
							break;
						case "organization":
							var newItem_organization = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(newItem_organization, reader, outcome, locationPath + ".organization["+result.Organization.Count+"]", cancellationToken); // 160
							result.Organization.Add(newItem_organization);
							break;
						case "sourceAttachment":
							result.Source = new Hl7.Fhir.Model.Attachment();
							await ParseAsync(result.Source as Hl7.Fhir.Model.Attachment, reader, outcome, locationPath + ".source", cancellationToken); // 170
							break;
						case "sourceReference":
							result.Source = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Source as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".source", cancellationToken); // 170
							break;
						case "policy":
							var newItem_policy = new Hl7.Fhir.Model.Consent.PolicyComponent();
							await ParseAsync(newItem_policy, reader, outcome, locationPath + ".policy["+result.Policy.Count+"]", cancellationToken); // 180
							result.Policy.Add(newItem_policy);
							break;
						case "policyRule":
							result.PolicyRule = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.PolicyRule as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".policyRule", cancellationToken); // 190
							break;
						case "verification":
							var newItem_verification = new Hl7.Fhir.Model.Consent.VerificationComponent();
							await ParseAsync(newItem_verification, reader, outcome, locationPath + ".verification["+result.Verification.Count+"]", cancellationToken); // 200
							result.Verification.Add(newItem_verification);
							break;
						case "provision":
							result.Provision = new Hl7.Fhir.Model.Consent.provisionComponent();
							await ParseAsync(result.Provision as Hl7.Fhir.Model.Consent.provisionComponent, reader, outcome, locationPath + ".provision", cancellationToken); // 210
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
