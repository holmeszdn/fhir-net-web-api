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
		private void Parse(ActivityDefinition result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
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
						case "url":
							result.UrlElement = new Hl7.Fhir.Model.FhirUri();
							Parse(result.UrlElement as Hl7.Fhir.Model.FhirUri, reader, outcome, locationPath + ".url", cancellationToken); // 90
							break;
						case "identifier":
							var newItem_identifier = new Hl7.Fhir.Model.Identifier();
							Parse(newItem_identifier, reader, outcome, locationPath + ".identifier["+result.Identifier.Count+"]", cancellationToken); // 100
							result.Identifier.Add(newItem_identifier);
							break;
						case "version":
							result.VersionElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.VersionElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".version", cancellationToken); // 110
							break;
						case "name":
							result.NameElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.NameElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".name", cancellationToken); // 120
							break;
						case "title":
							result.TitleElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.TitleElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".title", cancellationToken); // 130
							break;
						case "subtitle":
							result.SubtitleElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.SubtitleElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".subtitle", cancellationToken); // 140
							break;
						case "status":
							result.StatusElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.PublicationStatus>();
							Parse(result.StatusElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.PublicationStatus>, reader, outcome, locationPath + ".status", cancellationToken); // 150
							break;
						case "experimental":
							result.ExperimentalElement = new Hl7.Fhir.Model.FhirBoolean();
							Parse(result.ExperimentalElement as Hl7.Fhir.Model.FhirBoolean, reader, outcome, locationPath + ".experimental", cancellationToken); // 160
							break;
						case "subjectCodeableConcept":
							result.Subject = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.Subject as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".subject", cancellationToken); // 170
							break;
						case "subjectReference":
							result.Subject = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Subject as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".subject", cancellationToken); // 170
							break;
						case "date":
							result.DateElement = new Hl7.Fhir.Model.FhirDateTime();
							Parse(result.DateElement as Hl7.Fhir.Model.FhirDateTime, reader, outcome, locationPath + ".date", cancellationToken); // 180
							break;
						case "publisher":
							result.PublisherElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.PublisherElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".publisher", cancellationToken); // 190
							break;
						case "contact":
							var newItem_contact = new Hl7.Fhir.Model.ContactDetail();
							Parse(newItem_contact, reader, outcome, locationPath + ".contact["+result.Contact.Count+"]", cancellationToken); // 200
							result.Contact.Add(newItem_contact);
							break;
						case "description":
							result.Description = new Hl7.Fhir.Model.Markdown();
							Parse(result.Description as Hl7.Fhir.Model.Markdown, reader, outcome, locationPath + ".description", cancellationToken); // 210
							break;
						case "useContext":
							var newItem_useContext = new Hl7.Fhir.Model.UsageContext();
							Parse(newItem_useContext, reader, outcome, locationPath + ".useContext["+result.UseContext.Count+"]", cancellationToken); // 220
							result.UseContext.Add(newItem_useContext);
							break;
						case "jurisdiction":
							var newItem_jurisdiction = new Hl7.Fhir.Model.CodeableConcept();
							Parse(newItem_jurisdiction, reader, outcome, locationPath + ".jurisdiction["+result.Jurisdiction.Count+"]", cancellationToken); // 230
							result.Jurisdiction.Add(newItem_jurisdiction);
							break;
						case "purpose":
							result.Purpose = new Hl7.Fhir.Model.Markdown();
							Parse(result.Purpose as Hl7.Fhir.Model.Markdown, reader, outcome, locationPath + ".purpose", cancellationToken); // 240
							break;
						case "usage":
							result.UsageElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.UsageElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".usage", cancellationToken); // 250
							break;
						case "copyright":
							result.Copyright = new Hl7.Fhir.Model.Markdown();
							Parse(result.Copyright as Hl7.Fhir.Model.Markdown, reader, outcome, locationPath + ".copyright", cancellationToken); // 260
							break;
						case "approvalDate":
							result.ApprovalDateElement = new Hl7.Fhir.Model.Date();
							Parse(result.ApprovalDateElement as Hl7.Fhir.Model.Date, reader, outcome, locationPath + ".approvalDate", cancellationToken); // 270
							break;
						case "lastReviewDate":
							result.LastReviewDateElement = new Hl7.Fhir.Model.Date();
							Parse(result.LastReviewDateElement as Hl7.Fhir.Model.Date, reader, outcome, locationPath + ".lastReviewDate", cancellationToken); // 280
							break;
						case "effectivePeriod":
							result.EffectivePeriod = new Hl7.Fhir.Model.Period();
							Parse(result.EffectivePeriod as Hl7.Fhir.Model.Period, reader, outcome, locationPath + ".effectivePeriod", cancellationToken); // 290
							break;
						case "topic":
							var newItem_topic = new Hl7.Fhir.Model.CodeableConcept();
							Parse(newItem_topic, reader, outcome, locationPath + ".topic["+result.Topic.Count+"]", cancellationToken); // 300
							result.Topic.Add(newItem_topic);
							break;
						case "author":
							var newItem_author = new Hl7.Fhir.Model.ContactDetail();
							Parse(newItem_author, reader, outcome, locationPath + ".author["+result.Author.Count+"]", cancellationToken); // 310
							result.Author.Add(newItem_author);
							break;
						case "editor":
							var newItem_editor = new Hl7.Fhir.Model.ContactDetail();
							Parse(newItem_editor, reader, outcome, locationPath + ".editor["+result.Editor.Count+"]", cancellationToken); // 320
							result.Editor.Add(newItem_editor);
							break;
						case "reviewer":
							var newItem_reviewer = new Hl7.Fhir.Model.ContactDetail();
							Parse(newItem_reviewer, reader, outcome, locationPath + ".reviewer["+result.Reviewer.Count+"]", cancellationToken); // 330
							result.Reviewer.Add(newItem_reviewer);
							break;
						case "endorser":
							var newItem_endorser = new Hl7.Fhir.Model.ContactDetail();
							Parse(newItem_endorser, reader, outcome, locationPath + ".endorser["+result.Endorser.Count+"]", cancellationToken); // 340
							result.Endorser.Add(newItem_endorser);
							break;
						case "relatedArtifact":
							var newItem_relatedArtifact = new Hl7.Fhir.Model.RelatedArtifact();
							Parse(newItem_relatedArtifact, reader, outcome, locationPath + ".relatedArtifact["+result.RelatedArtifact.Count+"]", cancellationToken); // 350
							result.RelatedArtifact.Add(newItem_relatedArtifact);
							break;
						case "library":
							var newItem_library = new Hl7.Fhir.Model.Canonical();
							Parse(newItem_library, reader, outcome, locationPath + ".library["+result.LibraryElement.Count+"]", cancellationToken); // 360
							result.LibraryElement.Add(newItem_library);
							break;
						case "kind":
							result.KindElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.ActivityDefinition.RequestResourceType>();
							Parse(result.KindElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.ActivityDefinition.RequestResourceType>, reader, outcome, locationPath + ".kind", cancellationToken); // 370
							break;
						case "profile":
							result.ProfileElement = new Hl7.Fhir.Model.Canonical();
							Parse(result.ProfileElement as Hl7.Fhir.Model.Canonical, reader, outcome, locationPath + ".profile", cancellationToken); // 380
							break;
						case "code":
							result.Code = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.Code as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".code", cancellationToken); // 390
							break;
						case "intent":
							result.IntentElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.RequestIntent>();
							Parse(result.IntentElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.RequestIntent>, reader, outcome, locationPath + ".intent", cancellationToken); // 400
							break;
						case "priority":
							result.PriorityElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.RequestPriority>();
							Parse(result.PriorityElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.RequestPriority>, reader, outcome, locationPath + ".priority", cancellationToken); // 410
							break;
						case "doNotPerform":
							result.DoNotPerformElement = new Hl7.Fhir.Model.FhirBoolean();
							Parse(result.DoNotPerformElement as Hl7.Fhir.Model.FhirBoolean, reader, outcome, locationPath + ".doNotPerform", cancellationToken); // 420
							break;
						case "timingTiming":
							result.Timing = new Hl7.Fhir.Model.Timing();
							Parse(result.Timing as Hl7.Fhir.Model.Timing, reader, outcome, locationPath + ".timing", cancellationToken); // 430
							break;
						case "timingDateTime":
							result.Timing = new Hl7.Fhir.Model.FhirDateTime();
							Parse(result.Timing as Hl7.Fhir.Model.FhirDateTime, reader, outcome, locationPath + ".timing", cancellationToken); // 430
							break;
						case "timingAge":
							result.Timing = new Hl7.Fhir.Model.Age();
							Parse(result.Timing as Hl7.Fhir.Model.Age, reader, outcome, locationPath + ".timing", cancellationToken); // 430
							break;
						case "timingPeriod":
							result.Timing = new Hl7.Fhir.Model.Period();
							Parse(result.Timing as Hl7.Fhir.Model.Period, reader, outcome, locationPath + ".timing", cancellationToken); // 430
							break;
						case "timingRange":
							result.Timing = new Hl7.Fhir.Model.Range();
							Parse(result.Timing as Hl7.Fhir.Model.Range, reader, outcome, locationPath + ".timing", cancellationToken); // 430
							break;
						case "timingDuration":
							result.Timing = new Hl7.Fhir.Model.Duration();
							Parse(result.Timing as Hl7.Fhir.Model.Duration, reader, outcome, locationPath + ".timing", cancellationToken); // 430
							break;
						case "location":
							result.Location = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Location as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".location", cancellationToken); // 440
							break;
						case "participant":
							var newItem_participant = new Hl7.Fhir.Model.ActivityDefinition.ParticipantComponent();
							Parse(newItem_participant, reader, outcome, locationPath + ".participant["+result.Participant.Count+"]", cancellationToken); // 450
							result.Participant.Add(newItem_participant);
							break;
						case "productReference":
							result.Product = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Product as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".product", cancellationToken); // 460
							break;
						case "productCodeableConcept":
							result.Product = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.Product as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".product", cancellationToken); // 460
							break;
						case "quantity":
							result.Quantity = new Hl7.Fhir.Model.Quantity();
							Parse(result.Quantity as Hl7.Fhir.Model.Quantity, reader, outcome, locationPath + ".quantity", cancellationToken); // 470
							break;
						case "dosage":
							var newItem_dosage = new Hl7.Fhir.Model.Dosage();
							Parse(newItem_dosage, reader, outcome, locationPath + ".dosage["+result.Dosage.Count+"]", cancellationToken); // 480
							result.Dosage.Add(newItem_dosage);
							break;
						case "bodySite":
							var newItem_bodySite = new Hl7.Fhir.Model.CodeableConcept();
							Parse(newItem_bodySite, reader, outcome, locationPath + ".bodySite["+result.BodySite.Count+"]", cancellationToken); // 490
							result.BodySite.Add(newItem_bodySite);
							break;
						case "specimenRequirement":
							var newItem_specimenRequirement = new Hl7.Fhir.Model.ResourceReference();
							Parse(newItem_specimenRequirement, reader, outcome, locationPath + ".specimenRequirement["+result.SpecimenRequirement.Count+"]", cancellationToken); // 500
							result.SpecimenRequirement.Add(newItem_specimenRequirement);
							break;
						case "observationRequirement":
							var newItem_observationRequirement = new Hl7.Fhir.Model.ResourceReference();
							Parse(newItem_observationRequirement, reader, outcome, locationPath + ".observationRequirement["+result.ObservationRequirement.Count+"]", cancellationToken); // 510
							result.ObservationRequirement.Add(newItem_observationRequirement);
							break;
						case "observationResultRequirement":
							var newItem_observationResultRequirement = new Hl7.Fhir.Model.ResourceReference();
							Parse(newItem_observationResultRequirement, reader, outcome, locationPath + ".observationResultRequirement["+result.ObservationResultRequirement.Count+"]", cancellationToken); // 520
							result.ObservationResultRequirement.Add(newItem_observationResultRequirement);
							break;
						case "transform":
							result.TransformElement = new Hl7.Fhir.Model.Canonical();
							Parse(result.TransformElement as Hl7.Fhir.Model.Canonical, reader, outcome, locationPath + ".transform", cancellationToken); // 530
							break;
						case "dynamicValue":
							var newItem_dynamicValue = new Hl7.Fhir.Model.ActivityDefinition.DynamicValueComponent();
							Parse(newItem_dynamicValue, reader, outcome, locationPath + ".dynamicValue["+result.DynamicValue.Count+"]", cancellationToken); // 540
							result.DynamicValue.Add(newItem_dynamicValue);
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

		private async System.Threading.Tasks.Task ParseAsync(ActivityDefinition result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
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
						case "url":
							result.UrlElement = new Hl7.Fhir.Model.FhirUri();
							await ParseAsync(result.UrlElement as Hl7.Fhir.Model.FhirUri, reader, outcome, locationPath + ".url", cancellationToken); // 90
							break;
						case "identifier":
							var newItem_identifier = new Hl7.Fhir.Model.Identifier();
							await ParseAsync(newItem_identifier, reader, outcome, locationPath + ".identifier["+result.Identifier.Count+"]", cancellationToken); // 100
							result.Identifier.Add(newItem_identifier);
							break;
						case "version":
							result.VersionElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.VersionElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".version", cancellationToken); // 110
							break;
						case "name":
							result.NameElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.NameElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".name", cancellationToken); // 120
							break;
						case "title":
							result.TitleElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.TitleElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".title", cancellationToken); // 130
							break;
						case "subtitle":
							result.SubtitleElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.SubtitleElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".subtitle", cancellationToken); // 140
							break;
						case "status":
							result.StatusElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.PublicationStatus>();
							await ParseAsync(result.StatusElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.PublicationStatus>, reader, outcome, locationPath + ".status", cancellationToken); // 150
							break;
						case "experimental":
							result.ExperimentalElement = new Hl7.Fhir.Model.FhirBoolean();
							await ParseAsync(result.ExperimentalElement as Hl7.Fhir.Model.FhirBoolean, reader, outcome, locationPath + ".experimental", cancellationToken); // 160
							break;
						case "subjectCodeableConcept":
							result.Subject = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.Subject as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".subject", cancellationToken); // 170
							break;
						case "subjectReference":
							result.Subject = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Subject as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".subject", cancellationToken); // 170
							break;
						case "date":
							result.DateElement = new Hl7.Fhir.Model.FhirDateTime();
							await ParseAsync(result.DateElement as Hl7.Fhir.Model.FhirDateTime, reader, outcome, locationPath + ".date", cancellationToken); // 180
							break;
						case "publisher":
							result.PublisherElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.PublisherElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".publisher", cancellationToken); // 190
							break;
						case "contact":
							var newItem_contact = new Hl7.Fhir.Model.ContactDetail();
							await ParseAsync(newItem_contact, reader, outcome, locationPath + ".contact["+result.Contact.Count+"]", cancellationToken); // 200
							result.Contact.Add(newItem_contact);
							break;
						case "description":
							result.Description = new Hl7.Fhir.Model.Markdown();
							await ParseAsync(result.Description as Hl7.Fhir.Model.Markdown, reader, outcome, locationPath + ".description", cancellationToken); // 210
							break;
						case "useContext":
							var newItem_useContext = new Hl7.Fhir.Model.UsageContext();
							await ParseAsync(newItem_useContext, reader, outcome, locationPath + ".useContext["+result.UseContext.Count+"]", cancellationToken); // 220
							result.UseContext.Add(newItem_useContext);
							break;
						case "jurisdiction":
							var newItem_jurisdiction = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(newItem_jurisdiction, reader, outcome, locationPath + ".jurisdiction["+result.Jurisdiction.Count+"]", cancellationToken); // 230
							result.Jurisdiction.Add(newItem_jurisdiction);
							break;
						case "purpose":
							result.Purpose = new Hl7.Fhir.Model.Markdown();
							await ParseAsync(result.Purpose as Hl7.Fhir.Model.Markdown, reader, outcome, locationPath + ".purpose", cancellationToken); // 240
							break;
						case "usage":
							result.UsageElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.UsageElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".usage", cancellationToken); // 250
							break;
						case "copyright":
							result.Copyright = new Hl7.Fhir.Model.Markdown();
							await ParseAsync(result.Copyright as Hl7.Fhir.Model.Markdown, reader, outcome, locationPath + ".copyright", cancellationToken); // 260
							break;
						case "approvalDate":
							result.ApprovalDateElement = new Hl7.Fhir.Model.Date();
							await ParseAsync(result.ApprovalDateElement as Hl7.Fhir.Model.Date, reader, outcome, locationPath + ".approvalDate", cancellationToken); // 270
							break;
						case "lastReviewDate":
							result.LastReviewDateElement = new Hl7.Fhir.Model.Date();
							await ParseAsync(result.LastReviewDateElement as Hl7.Fhir.Model.Date, reader, outcome, locationPath + ".lastReviewDate", cancellationToken); // 280
							break;
						case "effectivePeriod":
							result.EffectivePeriod = new Hl7.Fhir.Model.Period();
							await ParseAsync(result.EffectivePeriod as Hl7.Fhir.Model.Period, reader, outcome, locationPath + ".effectivePeriod", cancellationToken); // 290
							break;
						case "topic":
							var newItem_topic = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(newItem_topic, reader, outcome, locationPath + ".topic["+result.Topic.Count+"]", cancellationToken); // 300
							result.Topic.Add(newItem_topic);
							break;
						case "author":
							var newItem_author = new Hl7.Fhir.Model.ContactDetail();
							await ParseAsync(newItem_author, reader, outcome, locationPath + ".author["+result.Author.Count+"]", cancellationToken); // 310
							result.Author.Add(newItem_author);
							break;
						case "editor":
							var newItem_editor = new Hl7.Fhir.Model.ContactDetail();
							await ParseAsync(newItem_editor, reader, outcome, locationPath + ".editor["+result.Editor.Count+"]", cancellationToken); // 320
							result.Editor.Add(newItem_editor);
							break;
						case "reviewer":
							var newItem_reviewer = new Hl7.Fhir.Model.ContactDetail();
							await ParseAsync(newItem_reviewer, reader, outcome, locationPath + ".reviewer["+result.Reviewer.Count+"]", cancellationToken); // 330
							result.Reviewer.Add(newItem_reviewer);
							break;
						case "endorser":
							var newItem_endorser = new Hl7.Fhir.Model.ContactDetail();
							await ParseAsync(newItem_endorser, reader, outcome, locationPath + ".endorser["+result.Endorser.Count+"]", cancellationToken); // 340
							result.Endorser.Add(newItem_endorser);
							break;
						case "relatedArtifact":
							var newItem_relatedArtifact = new Hl7.Fhir.Model.RelatedArtifact();
							await ParseAsync(newItem_relatedArtifact, reader, outcome, locationPath + ".relatedArtifact["+result.RelatedArtifact.Count+"]", cancellationToken); // 350
							result.RelatedArtifact.Add(newItem_relatedArtifact);
							break;
						case "library":
							var newItem_library = new Hl7.Fhir.Model.Canonical();
							await ParseAsync(newItem_library, reader, outcome, locationPath + ".library["+result.LibraryElement.Count+"]", cancellationToken); // 360
							result.LibraryElement.Add(newItem_library);
							break;
						case "kind":
							result.KindElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.ActivityDefinition.RequestResourceType>();
							await ParseAsync(result.KindElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.ActivityDefinition.RequestResourceType>, reader, outcome, locationPath + ".kind", cancellationToken); // 370
							break;
						case "profile":
							result.ProfileElement = new Hl7.Fhir.Model.Canonical();
							await ParseAsync(result.ProfileElement as Hl7.Fhir.Model.Canonical, reader, outcome, locationPath + ".profile", cancellationToken); // 380
							break;
						case "code":
							result.Code = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.Code as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".code", cancellationToken); // 390
							break;
						case "intent":
							result.IntentElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.RequestIntent>();
							await ParseAsync(result.IntentElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.RequestIntent>, reader, outcome, locationPath + ".intent", cancellationToken); // 400
							break;
						case "priority":
							result.PriorityElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.RequestPriority>();
							await ParseAsync(result.PriorityElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.RequestPriority>, reader, outcome, locationPath + ".priority", cancellationToken); // 410
							break;
						case "doNotPerform":
							result.DoNotPerformElement = new Hl7.Fhir.Model.FhirBoolean();
							await ParseAsync(result.DoNotPerformElement as Hl7.Fhir.Model.FhirBoolean, reader, outcome, locationPath + ".doNotPerform", cancellationToken); // 420
							break;
						case "timingTiming":
							result.Timing = new Hl7.Fhir.Model.Timing();
							await ParseAsync(result.Timing as Hl7.Fhir.Model.Timing, reader, outcome, locationPath + ".timing", cancellationToken); // 430
							break;
						case "timingDateTime":
							result.Timing = new Hl7.Fhir.Model.FhirDateTime();
							await ParseAsync(result.Timing as Hl7.Fhir.Model.FhirDateTime, reader, outcome, locationPath + ".timing", cancellationToken); // 430
							break;
						case "timingAge":
							result.Timing = new Hl7.Fhir.Model.Age();
							await ParseAsync(result.Timing as Hl7.Fhir.Model.Age, reader, outcome, locationPath + ".timing", cancellationToken); // 430
							break;
						case "timingPeriod":
							result.Timing = new Hl7.Fhir.Model.Period();
							await ParseAsync(result.Timing as Hl7.Fhir.Model.Period, reader, outcome, locationPath + ".timing", cancellationToken); // 430
							break;
						case "timingRange":
							result.Timing = new Hl7.Fhir.Model.Range();
							await ParseAsync(result.Timing as Hl7.Fhir.Model.Range, reader, outcome, locationPath + ".timing", cancellationToken); // 430
							break;
						case "timingDuration":
							result.Timing = new Hl7.Fhir.Model.Duration();
							await ParseAsync(result.Timing as Hl7.Fhir.Model.Duration, reader, outcome, locationPath + ".timing", cancellationToken); // 430
							break;
						case "location":
							result.Location = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Location as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".location", cancellationToken); // 440
							break;
						case "participant":
							var newItem_participant = new Hl7.Fhir.Model.ActivityDefinition.ParticipantComponent();
							await ParseAsync(newItem_participant, reader, outcome, locationPath + ".participant["+result.Participant.Count+"]", cancellationToken); // 450
							result.Participant.Add(newItem_participant);
							break;
						case "productReference":
							result.Product = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Product as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".product", cancellationToken); // 460
							break;
						case "productCodeableConcept":
							result.Product = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.Product as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".product", cancellationToken); // 460
							break;
						case "quantity":
							result.Quantity = new Hl7.Fhir.Model.Quantity();
							await ParseAsync(result.Quantity as Hl7.Fhir.Model.Quantity, reader, outcome, locationPath + ".quantity", cancellationToken); // 470
							break;
						case "dosage":
							var newItem_dosage = new Hl7.Fhir.Model.Dosage();
							await ParseAsync(newItem_dosage, reader, outcome, locationPath + ".dosage["+result.Dosage.Count+"]", cancellationToken); // 480
							result.Dosage.Add(newItem_dosage);
							break;
						case "bodySite":
							var newItem_bodySite = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(newItem_bodySite, reader, outcome, locationPath + ".bodySite["+result.BodySite.Count+"]", cancellationToken); // 490
							result.BodySite.Add(newItem_bodySite);
							break;
						case "specimenRequirement":
							var newItem_specimenRequirement = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(newItem_specimenRequirement, reader, outcome, locationPath + ".specimenRequirement["+result.SpecimenRequirement.Count+"]", cancellationToken); // 500
							result.SpecimenRequirement.Add(newItem_specimenRequirement);
							break;
						case "observationRequirement":
							var newItem_observationRequirement = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(newItem_observationRequirement, reader, outcome, locationPath + ".observationRequirement["+result.ObservationRequirement.Count+"]", cancellationToken); // 510
							result.ObservationRequirement.Add(newItem_observationRequirement);
							break;
						case "observationResultRequirement":
							var newItem_observationResultRequirement = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(newItem_observationResultRequirement, reader, outcome, locationPath + ".observationResultRequirement["+result.ObservationResultRequirement.Count+"]", cancellationToken); // 520
							result.ObservationResultRequirement.Add(newItem_observationResultRequirement);
							break;
						case "transform":
							result.TransformElement = new Hl7.Fhir.Model.Canonical();
							await ParseAsync(result.TransformElement as Hl7.Fhir.Model.Canonical, reader, outcome, locationPath + ".transform", cancellationToken); // 530
							break;
						case "dynamicValue":
							var newItem_dynamicValue = new Hl7.Fhir.Model.ActivityDefinition.DynamicValueComponent();
							await ParseAsync(newItem_dynamicValue, reader, outcome, locationPath + ".dynamicValue["+result.DynamicValue.Count+"]", cancellationToken); // 540
							result.DynamicValue.Add(newItem_dynamicValue);
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
