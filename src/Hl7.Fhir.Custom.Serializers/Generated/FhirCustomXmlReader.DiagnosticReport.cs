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
		private void Parse(DiagnosticReport result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
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
						case "basedOn":
							var newItem_basedOn = new Hl7.Fhir.Model.ResourceReference();
							Parse(newItem_basedOn, reader, outcome, locationPath + ".basedOn["+result.BasedOn.Count+"]", cancellationToken); // 100
							result.BasedOn.Add(newItem_basedOn);
							break;
						case "status":
							result.StatusElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.DiagnosticReport.DiagnosticReportStatus>();
							Parse(result.StatusElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.DiagnosticReport.DiagnosticReportStatus>, reader, outcome, locationPath + ".status", cancellationToken); // 110
							break;
						case "category":
							var newItem_category = new Hl7.Fhir.Model.CodeableConcept();
							Parse(newItem_category, reader, outcome, locationPath + ".category["+result.Category.Count+"]", cancellationToken); // 120
							result.Category.Add(newItem_category);
							break;
						case "code":
							result.Code = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.Code as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".code", cancellationToken); // 130
							break;
						case "subject":
							result.Subject = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Subject as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".subject", cancellationToken); // 140
							break;
						case "encounter":
							result.Encounter = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Encounter as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".encounter", cancellationToken); // 150
							break;
						case "effectiveDateTime":
							result.Effective = new Hl7.Fhir.Model.FhirDateTime();
							Parse(result.Effective as Hl7.Fhir.Model.FhirDateTime, reader, outcome, locationPath + ".effective", cancellationToken); // 160
							break;
						case "effectivePeriod":
							result.Effective = new Hl7.Fhir.Model.Period();
							Parse(result.Effective as Hl7.Fhir.Model.Period, reader, outcome, locationPath + ".effective", cancellationToken); // 160
							break;
						case "issued":
							result.IssuedElement = new Hl7.Fhir.Model.Instant();
							Parse(result.IssuedElement as Hl7.Fhir.Model.Instant, reader, outcome, locationPath + ".issued", cancellationToken); // 170
							break;
						case "performer":
							var newItem_performer = new Hl7.Fhir.Model.ResourceReference();
							Parse(newItem_performer, reader, outcome, locationPath + ".performer["+result.Performer.Count+"]", cancellationToken); // 180
							result.Performer.Add(newItem_performer);
							break;
						case "resultsInterpreter":
							var newItem_resultsInterpreter = new Hl7.Fhir.Model.ResourceReference();
							Parse(newItem_resultsInterpreter, reader, outcome, locationPath + ".resultsInterpreter["+result.ResultsInterpreter.Count+"]", cancellationToken); // 190
							result.ResultsInterpreter.Add(newItem_resultsInterpreter);
							break;
						case "specimen":
							var newItem_specimen = new Hl7.Fhir.Model.ResourceReference();
							Parse(newItem_specimen, reader, outcome, locationPath + ".specimen["+result.Specimen.Count+"]", cancellationToken); // 200
							result.Specimen.Add(newItem_specimen);
							break;
						case "result":
							var newItem_result = new Hl7.Fhir.Model.ResourceReference();
							Parse(newItem_result, reader, outcome, locationPath + ".result["+result.Result.Count+"]", cancellationToken); // 210
							result.Result.Add(newItem_result);
							break;
						case "imagingStudy":
							var newItem_imagingStudy = new Hl7.Fhir.Model.ResourceReference();
							Parse(newItem_imagingStudy, reader, outcome, locationPath + ".imagingStudy["+result.ImagingStudy.Count+"]", cancellationToken); // 220
							result.ImagingStudy.Add(newItem_imagingStudy);
							break;
						case "media":
							var newItem_media = new Hl7.Fhir.Model.DiagnosticReport.MediaComponent();
							Parse(newItem_media, reader, outcome, locationPath + ".media["+result.Media.Count+"]", cancellationToken); // 230
							result.Media.Add(newItem_media);
							break;
						case "conclusion":
							result.ConclusionElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.ConclusionElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".conclusion", cancellationToken); // 240
							break;
						case "conclusionCode":
							var newItem_conclusionCode = new Hl7.Fhir.Model.CodeableConcept();
							Parse(newItem_conclusionCode, reader, outcome, locationPath + ".conclusionCode["+result.ConclusionCode.Count+"]", cancellationToken); // 250
							result.ConclusionCode.Add(newItem_conclusionCode);
							break;
						case "presentedForm":
							var newItem_presentedForm = new Hl7.Fhir.Model.Attachment();
							Parse(newItem_presentedForm, reader, outcome, locationPath + ".presentedForm["+result.PresentedForm.Count+"]", cancellationToken); // 260
							result.PresentedForm.Add(newItem_presentedForm);
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

		private async System.Threading.Tasks.Task ParseAsync(DiagnosticReport result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
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
						case "basedOn":
							var newItem_basedOn = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(newItem_basedOn, reader, outcome, locationPath + ".basedOn["+result.BasedOn.Count+"]", cancellationToken); // 100
							result.BasedOn.Add(newItem_basedOn);
							break;
						case "status":
							result.StatusElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.DiagnosticReport.DiagnosticReportStatus>();
							await ParseAsync(result.StatusElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.DiagnosticReport.DiagnosticReportStatus>, reader, outcome, locationPath + ".status", cancellationToken); // 110
							break;
						case "category":
							var newItem_category = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(newItem_category, reader, outcome, locationPath + ".category["+result.Category.Count+"]", cancellationToken); // 120
							result.Category.Add(newItem_category);
							break;
						case "code":
							result.Code = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.Code as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".code", cancellationToken); // 130
							break;
						case "subject":
							result.Subject = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Subject as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".subject", cancellationToken); // 140
							break;
						case "encounter":
							result.Encounter = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Encounter as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".encounter", cancellationToken); // 150
							break;
						case "effectiveDateTime":
							result.Effective = new Hl7.Fhir.Model.FhirDateTime();
							await ParseAsync(result.Effective as Hl7.Fhir.Model.FhirDateTime, reader, outcome, locationPath + ".effective", cancellationToken); // 160
							break;
						case "effectivePeriod":
							result.Effective = new Hl7.Fhir.Model.Period();
							await ParseAsync(result.Effective as Hl7.Fhir.Model.Period, reader, outcome, locationPath + ".effective", cancellationToken); // 160
							break;
						case "issued":
							result.IssuedElement = new Hl7.Fhir.Model.Instant();
							await ParseAsync(result.IssuedElement as Hl7.Fhir.Model.Instant, reader, outcome, locationPath + ".issued", cancellationToken); // 170
							break;
						case "performer":
							var newItem_performer = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(newItem_performer, reader, outcome, locationPath + ".performer["+result.Performer.Count+"]", cancellationToken); // 180
							result.Performer.Add(newItem_performer);
							break;
						case "resultsInterpreter":
							var newItem_resultsInterpreter = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(newItem_resultsInterpreter, reader, outcome, locationPath + ".resultsInterpreter["+result.ResultsInterpreter.Count+"]", cancellationToken); // 190
							result.ResultsInterpreter.Add(newItem_resultsInterpreter);
							break;
						case "specimen":
							var newItem_specimen = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(newItem_specimen, reader, outcome, locationPath + ".specimen["+result.Specimen.Count+"]", cancellationToken); // 200
							result.Specimen.Add(newItem_specimen);
							break;
						case "result":
							var newItem_result = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(newItem_result, reader, outcome, locationPath + ".result["+result.Result.Count+"]", cancellationToken); // 210
							result.Result.Add(newItem_result);
							break;
						case "imagingStudy":
							var newItem_imagingStudy = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(newItem_imagingStudy, reader, outcome, locationPath + ".imagingStudy["+result.ImagingStudy.Count+"]", cancellationToken); // 220
							result.ImagingStudy.Add(newItem_imagingStudy);
							break;
						case "media":
							var newItem_media = new Hl7.Fhir.Model.DiagnosticReport.MediaComponent();
							await ParseAsync(newItem_media, reader, outcome, locationPath + ".media["+result.Media.Count+"]", cancellationToken); // 230
							result.Media.Add(newItem_media);
							break;
						case "conclusion":
							result.ConclusionElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.ConclusionElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".conclusion", cancellationToken); // 240
							break;
						case "conclusionCode":
							var newItem_conclusionCode = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(newItem_conclusionCode, reader, outcome, locationPath + ".conclusionCode["+result.ConclusionCode.Count+"]", cancellationToken); // 250
							result.ConclusionCode.Add(newItem_conclusionCode);
							break;
						case "presentedForm":
							var newItem_presentedForm = new Hl7.Fhir.Model.Attachment();
							await ParseAsync(newItem_presentedForm, reader, outcome, locationPath + ".presentedForm["+result.PresentedForm.Count+"]", cancellationToken); // 260
							result.PresentedForm.Add(newItem_presentedForm);
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
