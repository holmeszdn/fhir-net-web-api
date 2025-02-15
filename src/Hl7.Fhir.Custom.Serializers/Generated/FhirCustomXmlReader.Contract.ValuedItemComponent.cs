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
		public void Parse(Hl7.Fhir.Model.Contract.ValuedItemComponent result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
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
						case "entityCodeableConcept":
							result.Entity = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.Entity as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".entity", cancellationToken); // 40
							break;
						case "entityReference":
							result.Entity = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Entity as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".entity", cancellationToken); // 40
							break;
						case "identifier":
							result.Identifier = new Hl7.Fhir.Model.Identifier();
							Parse(result.Identifier as Hl7.Fhir.Model.Identifier, reader, outcome, locationPath + ".identifier", cancellationToken); // 50
							break;
						case "effectiveTime":
							result.EffectiveTimeElement = new Hl7.Fhir.Model.FhirDateTime();
							Parse(result.EffectiveTimeElement as Hl7.Fhir.Model.FhirDateTime, reader, outcome, locationPath + ".effectiveTime", cancellationToken); // 60
							break;
						case "quantity":
							result.Quantity = new Hl7.Fhir.Model.Quantity();
							Parse(result.Quantity as Hl7.Fhir.Model.Quantity, reader, outcome, locationPath + ".quantity", cancellationToken); // 70
							break;
						case "unitPrice":
							result.UnitPrice = new Hl7.Fhir.Model.Money();
							Parse(result.UnitPrice as Hl7.Fhir.Model.Money, reader, outcome, locationPath + ".unitPrice", cancellationToken); // 80
							break;
						case "factor":
							result.FactorElement = new Hl7.Fhir.Model.FhirDecimal();
							Parse(result.FactorElement as Hl7.Fhir.Model.FhirDecimal, reader, outcome, locationPath + ".factor", cancellationToken); // 90
							break;
						case "points":
							result.PointsElement = new Hl7.Fhir.Model.FhirDecimal();
							Parse(result.PointsElement as Hl7.Fhir.Model.FhirDecimal, reader, outcome, locationPath + ".points", cancellationToken); // 100
							break;
						case "net":
							result.Net = new Hl7.Fhir.Model.Money();
							Parse(result.Net as Hl7.Fhir.Model.Money, reader, outcome, locationPath + ".net", cancellationToken); // 110
							break;
						case "payment":
							result.PaymentElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.PaymentElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".payment", cancellationToken); // 120
							break;
						case "paymentDate":
							result.PaymentDateElement = new Hl7.Fhir.Model.FhirDateTime();
							Parse(result.PaymentDateElement as Hl7.Fhir.Model.FhirDateTime, reader, outcome, locationPath + ".paymentDate", cancellationToken); // 130
							break;
						case "responsible":
							result.Responsible = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Responsible as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".responsible", cancellationToken); // 140
							break;
						case "recipient":
							result.Recipient = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Recipient as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".recipient", cancellationToken); // 150
							break;
						case "linkId":
							var newItem_linkId = new Hl7.Fhir.Model.FhirString();
							Parse(newItem_linkId, reader, outcome, locationPath + ".linkId["+result.LinkIdElement.Count+"]", cancellationToken); // 160
							result.LinkIdElement.Add(newItem_linkId);
							break;
						case "securityLabelNumber":
							var newItem_securityLabelNumber = new Hl7.Fhir.Model.UnsignedInt();
							Parse(newItem_securityLabelNumber, reader, outcome, locationPath + ".securityLabelNumber["+result.SecurityLabelNumberElement.Count+"]", cancellationToken); // 170
							result.SecurityLabelNumberElement.Add(newItem_securityLabelNumber);
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

		public async System.Threading.Tasks.Task ParseAsync(Hl7.Fhir.Model.Contract.ValuedItemComponent result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
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
						case "entityCodeableConcept":
							result.Entity = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.Entity as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".entity", cancellationToken); // 40
							break;
						case "entityReference":
							result.Entity = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Entity as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".entity", cancellationToken); // 40
							break;
						case "identifier":
							result.Identifier = new Hl7.Fhir.Model.Identifier();
							await ParseAsync(result.Identifier as Hl7.Fhir.Model.Identifier, reader, outcome, locationPath + ".identifier", cancellationToken); // 50
							break;
						case "effectiveTime":
							result.EffectiveTimeElement = new Hl7.Fhir.Model.FhirDateTime();
							await ParseAsync(result.EffectiveTimeElement as Hl7.Fhir.Model.FhirDateTime, reader, outcome, locationPath + ".effectiveTime", cancellationToken); // 60
							break;
						case "quantity":
							result.Quantity = new Hl7.Fhir.Model.Quantity();
							await ParseAsync(result.Quantity as Hl7.Fhir.Model.Quantity, reader, outcome, locationPath + ".quantity", cancellationToken); // 70
							break;
						case "unitPrice":
							result.UnitPrice = new Hl7.Fhir.Model.Money();
							await ParseAsync(result.UnitPrice as Hl7.Fhir.Model.Money, reader, outcome, locationPath + ".unitPrice", cancellationToken); // 80
							break;
						case "factor":
							result.FactorElement = new Hl7.Fhir.Model.FhirDecimal();
							await ParseAsync(result.FactorElement as Hl7.Fhir.Model.FhirDecimal, reader, outcome, locationPath + ".factor", cancellationToken); // 90
							break;
						case "points":
							result.PointsElement = new Hl7.Fhir.Model.FhirDecimal();
							await ParseAsync(result.PointsElement as Hl7.Fhir.Model.FhirDecimal, reader, outcome, locationPath + ".points", cancellationToken); // 100
							break;
						case "net":
							result.Net = new Hl7.Fhir.Model.Money();
							await ParseAsync(result.Net as Hl7.Fhir.Model.Money, reader, outcome, locationPath + ".net", cancellationToken); // 110
							break;
						case "payment":
							result.PaymentElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.PaymentElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".payment", cancellationToken); // 120
							break;
						case "paymentDate":
							result.PaymentDateElement = new Hl7.Fhir.Model.FhirDateTime();
							await ParseAsync(result.PaymentDateElement as Hl7.Fhir.Model.FhirDateTime, reader, outcome, locationPath + ".paymentDate", cancellationToken); // 130
							break;
						case "responsible":
							result.Responsible = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Responsible as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".responsible", cancellationToken); // 140
							break;
						case "recipient":
							result.Recipient = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Recipient as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".recipient", cancellationToken); // 150
							break;
						case "linkId":
							var newItem_linkId = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(newItem_linkId, reader, outcome, locationPath + ".linkId["+result.LinkIdElement.Count+"]", cancellationToken); // 160
							result.LinkIdElement.Add(newItem_linkId);
							break;
						case "securityLabelNumber":
							var newItem_securityLabelNumber = new Hl7.Fhir.Model.UnsignedInt();
							await ParseAsync(newItem_securityLabelNumber, reader, outcome, locationPath + ".securityLabelNumber["+result.SecurityLabelNumberElement.Count+"]", cancellationToken); // 170
							result.SecurityLabelNumberElement.Add(newItem_securityLabelNumber);
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
