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
		public void Parse(Hl7.Fhir.Model.Contract.TermComponent result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
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
						case "identifier":
							result.Identifier = new Hl7.Fhir.Model.Identifier();
							Parse(result.Identifier as Hl7.Fhir.Model.Identifier, reader, outcome, locationPath + ".identifier", cancellationToken); // 40
							break;
						case "issued":
							result.IssuedElement = new Hl7.Fhir.Model.FhirDateTime();
							Parse(result.IssuedElement as Hl7.Fhir.Model.FhirDateTime, reader, outcome, locationPath + ".issued", cancellationToken); // 50
							break;
						case "applies":
							result.Applies = new Hl7.Fhir.Model.Period();
							Parse(result.Applies as Hl7.Fhir.Model.Period, reader, outcome, locationPath + ".applies", cancellationToken); // 60
							break;
						case "topicCodeableConcept":
							result.Topic = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.Topic as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".topic", cancellationToken); // 70
							break;
						case "topicReference":
							result.Topic = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Topic as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".topic", cancellationToken); // 70
							break;
						case "type":
							result.Type = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.Type as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".type", cancellationToken); // 80
							break;
						case "subType":
							result.SubType = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.SubType as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".subType", cancellationToken); // 90
							break;
						case "text":
							result.TextElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.TextElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".text", cancellationToken); // 100
							break;
						case "securityLabel":
							var newItem_securityLabel = new Hl7.Fhir.Model.Contract.SecurityLabelComponent();
							Parse(newItem_securityLabel, reader, outcome, locationPath + ".securityLabel["+result.SecurityLabel.Count+"]", cancellationToken); // 110
							result.SecurityLabel.Add(newItem_securityLabel);
							break;
						case "offer":
							result.Offer = new Hl7.Fhir.Model.Contract.ContractOfferComponent();
							Parse(result.Offer as Hl7.Fhir.Model.Contract.ContractOfferComponent, reader, outcome, locationPath + ".offer", cancellationToken); // 120
							break;
						case "asset":
							var newItem_asset = new Hl7.Fhir.Model.Contract.ContractAssetComponent();
							Parse(newItem_asset, reader, outcome, locationPath + ".asset["+result.Asset.Count+"]", cancellationToken); // 130
							result.Asset.Add(newItem_asset);
							break;
						case "action":
							var newItem_action = new Hl7.Fhir.Model.Contract.ActionComponent();
							Parse(newItem_action, reader, outcome, locationPath + ".action["+result.Action.Count+"]", cancellationToken); // 140
							result.Action.Add(newItem_action);
							break;
						case "group":
							var newItem_group = new Hl7.Fhir.Model.Contract.TermComponent();
							Parse(newItem_group, reader, outcome, locationPath + ".group["+result.Group.Count+"]", cancellationToken); // 150
							result.Group.Add(newItem_group);
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

		public async System.Threading.Tasks.Task ParseAsync(Hl7.Fhir.Model.Contract.TermComponent result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
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
						case "identifier":
							result.Identifier = new Hl7.Fhir.Model.Identifier();
							await ParseAsync(result.Identifier as Hl7.Fhir.Model.Identifier, reader, outcome, locationPath + ".identifier", cancellationToken); // 40
							break;
						case "issued":
							result.IssuedElement = new Hl7.Fhir.Model.FhirDateTime();
							await ParseAsync(result.IssuedElement as Hl7.Fhir.Model.FhirDateTime, reader, outcome, locationPath + ".issued", cancellationToken); // 50
							break;
						case "applies":
							result.Applies = new Hl7.Fhir.Model.Period();
							await ParseAsync(result.Applies as Hl7.Fhir.Model.Period, reader, outcome, locationPath + ".applies", cancellationToken); // 60
							break;
						case "topicCodeableConcept":
							result.Topic = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.Topic as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".topic", cancellationToken); // 70
							break;
						case "topicReference":
							result.Topic = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Topic as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".topic", cancellationToken); // 70
							break;
						case "type":
							result.Type = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.Type as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".type", cancellationToken); // 80
							break;
						case "subType":
							result.SubType = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.SubType as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".subType", cancellationToken); // 90
							break;
						case "text":
							result.TextElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.TextElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".text", cancellationToken); // 100
							break;
						case "securityLabel":
							var newItem_securityLabel = new Hl7.Fhir.Model.Contract.SecurityLabelComponent();
							await ParseAsync(newItem_securityLabel, reader, outcome, locationPath + ".securityLabel["+result.SecurityLabel.Count+"]", cancellationToken); // 110
							result.SecurityLabel.Add(newItem_securityLabel);
							break;
						case "offer":
							result.Offer = new Hl7.Fhir.Model.Contract.ContractOfferComponent();
							await ParseAsync(result.Offer as Hl7.Fhir.Model.Contract.ContractOfferComponent, reader, outcome, locationPath + ".offer", cancellationToken); // 120
							break;
						case "asset":
							var newItem_asset = new Hl7.Fhir.Model.Contract.ContractAssetComponent();
							await ParseAsync(newItem_asset, reader, outcome, locationPath + ".asset["+result.Asset.Count+"]", cancellationToken); // 130
							result.Asset.Add(newItem_asset);
							break;
						case "action":
							var newItem_action = new Hl7.Fhir.Model.Contract.ActionComponent();
							await ParseAsync(newItem_action, reader, outcome, locationPath + ".action["+result.Action.Count+"]", cancellationToken); // 140
							result.Action.Add(newItem_action);
							break;
						case "group":
							var newItem_group = new Hl7.Fhir.Model.Contract.TermComponent();
							await ParseAsync(newItem_group, reader, outcome, locationPath + ".group["+result.Group.Count+"]", cancellationToken); // 150
							result.Group.Add(newItem_group);
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
