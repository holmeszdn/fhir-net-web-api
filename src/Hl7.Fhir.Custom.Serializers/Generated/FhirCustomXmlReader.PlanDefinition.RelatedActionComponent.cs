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
		public void Parse(Hl7.Fhir.Model.PlanDefinition.RelatedActionComponent result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
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
						case "actionId":
							result.ActionIdElement = new Hl7.Fhir.Model.Id();
							Parse(result.ActionIdElement as Hl7.Fhir.Model.Id, reader, outcome, locationPath + ".actionId", cancellationToken); // 40
							break;
						case "relationship":
							result.RelationshipElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.ActionRelationshipType>();
							Parse(result.RelationshipElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.ActionRelationshipType>, reader, outcome, locationPath + ".relationship", cancellationToken); // 50
							break;
						case "offsetDuration":
							result.Offset = new Hl7.Fhir.Model.Duration();
							Parse(result.Offset as Hl7.Fhir.Model.Duration, reader, outcome, locationPath + ".offset", cancellationToken); // 60
							break;
						case "offsetRange":
							result.Offset = new Hl7.Fhir.Model.Range();
							Parse(result.Offset as Hl7.Fhir.Model.Range, reader, outcome, locationPath + ".offset", cancellationToken); // 60
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

		public async System.Threading.Tasks.Task ParseAsync(Hl7.Fhir.Model.PlanDefinition.RelatedActionComponent result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
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
						case "actionId":
							result.ActionIdElement = new Hl7.Fhir.Model.Id();
							await ParseAsync(result.ActionIdElement as Hl7.Fhir.Model.Id, reader, outcome, locationPath + ".actionId", cancellationToken); // 40
							break;
						case "relationship":
							result.RelationshipElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.ActionRelationshipType>();
							await ParseAsync(result.RelationshipElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.ActionRelationshipType>, reader, outcome, locationPath + ".relationship", cancellationToken); // 50
							break;
						case "offsetDuration":
							result.Offset = new Hl7.Fhir.Model.Duration();
							await ParseAsync(result.Offset as Hl7.Fhir.Model.Duration, reader, outcome, locationPath + ".offset", cancellationToken); // 60
							break;
						case "offsetRange":
							result.Offset = new Hl7.Fhir.Model.Range();
							await ParseAsync(result.Offset as Hl7.Fhir.Model.Range, reader, outcome, locationPath + ".offset", cancellationToken); // 60
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
