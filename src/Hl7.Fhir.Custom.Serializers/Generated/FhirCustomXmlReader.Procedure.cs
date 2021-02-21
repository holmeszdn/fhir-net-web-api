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
		private void Parse(Procedure result, XmlReader reader, OperationOutcome outcome, string locationPath)
		{
			// skip ignored elements
			while (ShouldSkipNodeType(reader.NodeType))
				if (!reader.Read())
					return;

			// if (reader.IsStartElement())
			// {
			//     if (contextLocation.Count > 0)
			//         contextLocation.Push(contextLocation.Peek() + "." + reader.Name);
			//     else
			//         contextLocation.Push(reader.Name);
			// }
			// System.Diagnostics.Trace.WriteLine(contextLocation.Peek());

			if (reader.IsEmptyElement)
			{
				// contextLocation.Pop();
				return;
			}

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
						case "instantiatesCanonical":
							var newItem_instantiatesCanonical = new Hl7.Fhir.Model.Canonical();
							Parse(newItem_instantiatesCanonical, reader, outcome, locationPath + ".instantiatesCanonical["+result.InstantiatesCanonicalElement.Count+"]"); // 100
							result.InstantiatesCanonicalElement.Add(newItem_instantiatesCanonical);
							break;
						case "instantiatesUri":
							var newItem_instantiatesUri = new Hl7.Fhir.Model.FhirUri();
							Parse(newItem_instantiatesUri, reader, outcome, locationPath + ".instantiatesUri["+result.InstantiatesUriElement.Count+"]"); // 110
							result.InstantiatesUriElement.Add(newItem_instantiatesUri);
							break;
						case "basedOn":
							var newItem_basedOn = new Hl7.Fhir.Model.ResourceReference();
							Parse(newItem_basedOn, reader, outcome, locationPath + ".basedOn["+result.BasedOn.Count+"]"); // 120
							result.BasedOn.Add(newItem_basedOn);
							break;
						case "partOf":
							var newItem_partOf = new Hl7.Fhir.Model.ResourceReference();
							Parse(newItem_partOf, reader, outcome, locationPath + ".partOf["+result.PartOf.Count+"]"); // 130
							result.PartOf.Add(newItem_partOf);
							break;
						case "status":
							result.StatusElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.EventStatus>();
							Parse(result.StatusElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.EventStatus>, reader, outcome, locationPath + ".status"); // 140
							break;
						case "statusReason":
							result.StatusReason = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.StatusReason as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".statusReason"); // 150
							break;
						case "category":
							result.Category = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.Category as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".category"); // 160
							break;
						case "code":
							result.Code = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.Code as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".code"); // 170
							break;
						case "subject":
							result.Subject = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Subject as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".subject"); // 180
							break;
						case "encounter":
							result.Encounter = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Encounter as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".encounter"); // 190
							break;
						case "performedDateTime":
							result.Performed = new Hl7.Fhir.Model.FhirDateTime();
							Parse(result.Performed as Hl7.Fhir.Model.FhirDateTime, reader, outcome, locationPath + ".performed"); // 200
							break;
						case "performedPeriod":
							result.Performed = new Hl7.Fhir.Model.Period();
							Parse(result.Performed as Hl7.Fhir.Model.Period, reader, outcome, locationPath + ".performed"); // 200
							break;
						case "performedString":
							result.Performed = new Hl7.Fhir.Model.FhirString();
							Parse(result.Performed as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".performed"); // 200
							break;
						case "performedAge":
							result.Performed = new Hl7.Fhir.Model.Age();
							Parse(result.Performed as Hl7.Fhir.Model.Age, reader, outcome, locationPath + ".performed"); // 200
							break;
						case "performedRange":
							result.Performed = new Hl7.Fhir.Model.Range();
							Parse(result.Performed as Hl7.Fhir.Model.Range, reader, outcome, locationPath + ".performed"); // 200
							break;
						case "recorder":
							result.Recorder = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Recorder as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".recorder"); // 210
							break;
						case "asserter":
							result.Asserter = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Asserter as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".asserter"); // 220
							break;
						case "performer":
							var newItem_performer = new Hl7.Fhir.Model.Procedure.PerformerComponent();
							Parse(newItem_performer, reader, outcome, locationPath + ".performer["+result.Performer.Count+"]"); // 230
							result.Performer.Add(newItem_performer);
							break;
						case "location":
							result.Location = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Location as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".location"); // 240
							break;
						case "reasonCode":
							var newItem_reasonCode = new Hl7.Fhir.Model.CodeableConcept();
							Parse(newItem_reasonCode, reader, outcome, locationPath + ".reasonCode["+result.ReasonCode.Count+"]"); // 250
							result.ReasonCode.Add(newItem_reasonCode);
							break;
						case "reasonReference":
							var newItem_reasonReference = new Hl7.Fhir.Model.ResourceReference();
							Parse(newItem_reasonReference, reader, outcome, locationPath + ".reasonReference["+result.ReasonReference.Count+"]"); // 260
							result.ReasonReference.Add(newItem_reasonReference);
							break;
						case "bodySite":
							var newItem_bodySite = new Hl7.Fhir.Model.CodeableConcept();
							Parse(newItem_bodySite, reader, outcome, locationPath + ".bodySite["+result.BodySite.Count+"]"); // 270
							result.BodySite.Add(newItem_bodySite);
							break;
						case "outcome":
							result.Outcome = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.Outcome as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".outcome"); // 280
							break;
						case "report":
							var newItem_report = new Hl7.Fhir.Model.ResourceReference();
							Parse(newItem_report, reader, outcome, locationPath + ".report["+result.Report.Count+"]"); // 290
							result.Report.Add(newItem_report);
							break;
						case "complication":
							var newItem_complication = new Hl7.Fhir.Model.CodeableConcept();
							Parse(newItem_complication, reader, outcome, locationPath + ".complication["+result.Complication.Count+"]"); // 300
							result.Complication.Add(newItem_complication);
							break;
						case "complicationDetail":
							var newItem_complicationDetail = new Hl7.Fhir.Model.ResourceReference();
							Parse(newItem_complicationDetail, reader, outcome, locationPath + ".complicationDetail["+result.ComplicationDetail.Count+"]"); // 310
							result.ComplicationDetail.Add(newItem_complicationDetail);
							break;
						case "followUp":
							var newItem_followUp = new Hl7.Fhir.Model.CodeableConcept();
							Parse(newItem_followUp, reader, outcome, locationPath + ".followUp["+result.FollowUp.Count+"]"); // 320
							result.FollowUp.Add(newItem_followUp);
							break;
						case "note":
							var newItem_note = new Hl7.Fhir.Model.Annotation();
							Parse(newItem_note, reader, outcome, locationPath + ".note["+result.Note.Count+"]"); // 330
							result.Note.Add(newItem_note);
							break;
						case "focalDevice":
							var newItem_focalDevice = new Hl7.Fhir.Model.Procedure.FocalDeviceComponent();
							Parse(newItem_focalDevice, reader, outcome, locationPath + ".focalDevice["+result.FocalDevice.Count+"]"); // 340
							result.FocalDevice.Add(newItem_focalDevice);
							break;
						case "usedReference":
							var newItem_usedReference = new Hl7.Fhir.Model.ResourceReference();
							Parse(newItem_usedReference, reader, outcome, locationPath + ".usedReference["+result.UsedReference.Count+"]"); // 350
							result.UsedReference.Add(newItem_usedReference);
							break;
						case "usedCode":
							var newItem_usedCode = new Hl7.Fhir.Model.CodeableConcept();
							Parse(newItem_usedCode, reader, outcome, locationPath + ".usedCode["+result.UsedCode.Count+"]"); // 360
							result.UsedCode.Add(newItem_usedCode);
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

		private async System.Threading.Tasks.Task ParseAsync(Procedure result, XmlReader reader, OperationOutcome outcome, string locationPath)
		{
			// skip ignored elements
			while (ShouldSkipNodeType(reader.NodeType))
				if (!await reader.ReadAsync().ConfigureAwait(false))
					return;

			// if (reader.IsStartElement())
			// {
			//     if (contextLocation.Count > 0)
			//         contextLocation.Push(contextLocation.Peek() + "." + reader.Name);
			//     else
			//         contextLocation.Push(reader.Name);
			// }
			// System.Diagnostics.Trace.WriteLine(contextLocation.Peek());

			if (reader.IsEmptyElement)
			{
				// contextLocation.Pop();
				return;
			}

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
						case "instantiatesCanonical":
							var newItem_instantiatesCanonical = new Hl7.Fhir.Model.Canonical();
							await ParseAsync(newItem_instantiatesCanonical, reader, outcome, locationPath + ".instantiatesCanonical["+result.InstantiatesCanonicalElement.Count+"]"); // 100
							result.InstantiatesCanonicalElement.Add(newItem_instantiatesCanonical);
							break;
						case "instantiatesUri":
							var newItem_instantiatesUri = new Hl7.Fhir.Model.FhirUri();
							await ParseAsync(newItem_instantiatesUri, reader, outcome, locationPath + ".instantiatesUri["+result.InstantiatesUriElement.Count+"]"); // 110
							result.InstantiatesUriElement.Add(newItem_instantiatesUri);
							break;
						case "basedOn":
							var newItem_basedOn = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(newItem_basedOn, reader, outcome, locationPath + ".basedOn["+result.BasedOn.Count+"]"); // 120
							result.BasedOn.Add(newItem_basedOn);
							break;
						case "partOf":
							var newItem_partOf = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(newItem_partOf, reader, outcome, locationPath + ".partOf["+result.PartOf.Count+"]"); // 130
							result.PartOf.Add(newItem_partOf);
							break;
						case "status":
							result.StatusElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.EventStatus>();
							await ParseAsync(result.StatusElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.EventStatus>, reader, outcome, locationPath + ".status"); // 140
							break;
						case "statusReason":
							result.StatusReason = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.StatusReason as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".statusReason"); // 150
							break;
						case "category":
							result.Category = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.Category as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".category"); // 160
							break;
						case "code":
							result.Code = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.Code as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".code"); // 170
							break;
						case "subject":
							result.Subject = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Subject as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".subject"); // 180
							break;
						case "encounter":
							result.Encounter = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Encounter as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".encounter"); // 190
							break;
						case "performedDateTime":
							result.Performed = new Hl7.Fhir.Model.FhirDateTime();
							await ParseAsync(result.Performed as Hl7.Fhir.Model.FhirDateTime, reader, outcome, locationPath + ".performed"); // 200
							break;
						case "performedPeriod":
							result.Performed = new Hl7.Fhir.Model.Period();
							await ParseAsync(result.Performed as Hl7.Fhir.Model.Period, reader, outcome, locationPath + ".performed"); // 200
							break;
						case "performedString":
							result.Performed = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.Performed as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".performed"); // 200
							break;
						case "performedAge":
							result.Performed = new Hl7.Fhir.Model.Age();
							await ParseAsync(result.Performed as Hl7.Fhir.Model.Age, reader, outcome, locationPath + ".performed"); // 200
							break;
						case "performedRange":
							result.Performed = new Hl7.Fhir.Model.Range();
							await ParseAsync(result.Performed as Hl7.Fhir.Model.Range, reader, outcome, locationPath + ".performed"); // 200
							break;
						case "recorder":
							result.Recorder = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Recorder as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".recorder"); // 210
							break;
						case "asserter":
							result.Asserter = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Asserter as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".asserter"); // 220
							break;
						case "performer":
							var newItem_performer = new Hl7.Fhir.Model.Procedure.PerformerComponent();
							await ParseAsync(newItem_performer, reader, outcome, locationPath + ".performer["+result.Performer.Count+"]"); // 230
							result.Performer.Add(newItem_performer);
							break;
						case "location":
							result.Location = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Location as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".location"); // 240
							break;
						case "reasonCode":
							var newItem_reasonCode = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(newItem_reasonCode, reader, outcome, locationPath + ".reasonCode["+result.ReasonCode.Count+"]"); // 250
							result.ReasonCode.Add(newItem_reasonCode);
							break;
						case "reasonReference":
							var newItem_reasonReference = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(newItem_reasonReference, reader, outcome, locationPath + ".reasonReference["+result.ReasonReference.Count+"]"); // 260
							result.ReasonReference.Add(newItem_reasonReference);
							break;
						case "bodySite":
							var newItem_bodySite = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(newItem_bodySite, reader, outcome, locationPath + ".bodySite["+result.BodySite.Count+"]"); // 270
							result.BodySite.Add(newItem_bodySite);
							break;
						case "outcome":
							result.Outcome = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.Outcome as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".outcome"); // 280
							break;
						case "report":
							var newItem_report = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(newItem_report, reader, outcome, locationPath + ".report["+result.Report.Count+"]"); // 290
							result.Report.Add(newItem_report);
							break;
						case "complication":
							var newItem_complication = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(newItem_complication, reader, outcome, locationPath + ".complication["+result.Complication.Count+"]"); // 300
							result.Complication.Add(newItem_complication);
							break;
						case "complicationDetail":
							var newItem_complicationDetail = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(newItem_complicationDetail, reader, outcome, locationPath + ".complicationDetail["+result.ComplicationDetail.Count+"]"); // 310
							result.ComplicationDetail.Add(newItem_complicationDetail);
							break;
						case "followUp":
							var newItem_followUp = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(newItem_followUp, reader, outcome, locationPath + ".followUp["+result.FollowUp.Count+"]"); // 320
							result.FollowUp.Add(newItem_followUp);
							break;
						case "note":
							var newItem_note = new Hl7.Fhir.Model.Annotation();
							await ParseAsync(newItem_note, reader, outcome, locationPath + ".note["+result.Note.Count+"]"); // 330
							result.Note.Add(newItem_note);
							break;
						case "focalDevice":
							var newItem_focalDevice = new Hl7.Fhir.Model.Procedure.FocalDeviceComponent();
							await ParseAsync(newItem_focalDevice, reader, outcome, locationPath + ".focalDevice["+result.FocalDevice.Count+"]"); // 340
							result.FocalDevice.Add(newItem_focalDevice);
							break;
						case "usedReference":
							var newItem_usedReference = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(newItem_usedReference, reader, outcome, locationPath + ".usedReference["+result.UsedReference.Count+"]"); // 350
							result.UsedReference.Add(newItem_usedReference);
							break;
						case "usedCode":
							var newItem_usedCode = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(newItem_usedCode, reader, outcome, locationPath + ".usedCode["+result.UsedCode.Count+"]"); // 360
							result.UsedCode.Add(newItem_usedCode);
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
