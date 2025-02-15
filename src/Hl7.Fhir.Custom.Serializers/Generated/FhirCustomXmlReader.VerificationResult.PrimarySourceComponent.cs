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
		public void Parse(Hl7.Fhir.Model.VerificationResult.PrimarySourceComponent result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
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
						case "who":
							result.Who = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Who as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".who", cancellationToken); // 40
							break;
						case "type":
							var newItem_type = new Hl7.Fhir.Model.CodeableConcept();
							Parse(newItem_type, reader, outcome, locationPath + ".type["+result.Type.Count+"]", cancellationToken); // 50
							result.Type.Add(newItem_type);
							break;
						case "communicationMethod":
							var newItem_communicationMethod = new Hl7.Fhir.Model.CodeableConcept();
							Parse(newItem_communicationMethod, reader, outcome, locationPath + ".communicationMethod["+result.CommunicationMethod.Count+"]", cancellationToken); // 60
							result.CommunicationMethod.Add(newItem_communicationMethod);
							break;
						case "validationStatus":
							result.ValidationStatus = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.ValidationStatus as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".validationStatus", cancellationToken); // 70
							break;
						case "validationDate":
							result.ValidationDateElement = new Hl7.Fhir.Model.FhirDateTime();
							Parse(result.ValidationDateElement as Hl7.Fhir.Model.FhirDateTime, reader, outcome, locationPath + ".validationDate", cancellationToken); // 80
							break;
						case "canPushUpdates":
							result.CanPushUpdates = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.CanPushUpdates as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".canPushUpdates", cancellationToken); // 90
							break;
						case "pushTypeAvailable":
							var newItem_pushTypeAvailable = new Hl7.Fhir.Model.CodeableConcept();
							Parse(newItem_pushTypeAvailable, reader, outcome, locationPath + ".pushTypeAvailable["+result.PushTypeAvailable.Count+"]", cancellationToken); // 100
							result.PushTypeAvailable.Add(newItem_pushTypeAvailable);
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

		public async System.Threading.Tasks.Task ParseAsync(Hl7.Fhir.Model.VerificationResult.PrimarySourceComponent result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
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
						case "who":
							result.Who = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Who as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".who", cancellationToken); // 40
							break;
						case "type":
							var newItem_type = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(newItem_type, reader, outcome, locationPath + ".type["+result.Type.Count+"]", cancellationToken); // 50
							result.Type.Add(newItem_type);
							break;
						case "communicationMethod":
							var newItem_communicationMethod = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(newItem_communicationMethod, reader, outcome, locationPath + ".communicationMethod["+result.CommunicationMethod.Count+"]", cancellationToken); // 60
							result.CommunicationMethod.Add(newItem_communicationMethod);
							break;
						case "validationStatus":
							result.ValidationStatus = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.ValidationStatus as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".validationStatus", cancellationToken); // 70
							break;
						case "validationDate":
							result.ValidationDateElement = new Hl7.Fhir.Model.FhirDateTime();
							await ParseAsync(result.ValidationDateElement as Hl7.Fhir.Model.FhirDateTime, reader, outcome, locationPath + ".validationDate", cancellationToken); // 80
							break;
						case "canPushUpdates":
							result.CanPushUpdates = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.CanPushUpdates as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".canPushUpdates", cancellationToken); // 90
							break;
						case "pushTypeAvailable":
							var newItem_pushTypeAvailable = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(newItem_pushTypeAvailable, reader, outcome, locationPath + ".pushTypeAvailable["+result.PushTypeAvailable.Count+"]", cancellationToken); // 100
							result.PushTypeAvailable.Add(newItem_pushTypeAvailable);
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
