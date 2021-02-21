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
		public void Parse(Hl7.Fhir.Model.Provenance.EntityComponent result, XmlReader reader, OperationOutcome outcome, string locationPath)
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
				if (reader.IsStartElement())
				{
					switch (reader.Name)
					{
						case "extension":
							var newItem_extension = new Hl7.Fhir.Model.Extension();
							Parse(newItem_extension, reader, outcome, locationPath + ".extension["+result.Extension.Count+"]"); // 20
							result.Extension.Add(newItem_extension);
							break;
						case "modifierExtension":
							var newItem_modifierExtension = new Hl7.Fhir.Model.Extension();
							Parse(newItem_modifierExtension, reader, outcome, locationPath + ".modifierExtension["+result.ModifierExtension.Count+"]"); // 30
							result.ModifierExtension.Add(newItem_modifierExtension);
							break;
						case "role":
							result.RoleElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.Provenance.ProvenanceEntityRole>();
							Parse(result.RoleElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.Provenance.ProvenanceEntityRole>, reader, outcome, locationPath + ".role"); // 40
							break;
						case "what":
							result.What = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.What as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".what"); // 50
							break;
						case "agent":
							var newItem_agent = new Hl7.Fhir.Model.Provenance.AgentComponent();
							Parse(newItem_agent, reader, outcome, locationPath + ".agent["+result.Agent.Count+"]"); // 60
							result.Agent.Add(newItem_agent);
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

		public async System.Threading.Tasks.Task ParseAsync(Hl7.Fhir.Model.Provenance.EntityComponent result, XmlReader reader, OperationOutcome outcome, string locationPath)
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
				if (reader.IsStartElement())
				{
					switch (reader.Name)
					{
						case "extension":
							var newItem_extension = new Hl7.Fhir.Model.Extension();
							await ParseAsync(newItem_extension, reader, outcome, locationPath + ".extension["+result.Extension.Count+"]"); // 20
							result.Extension.Add(newItem_extension);
							break;
						case "modifierExtension":
							var newItem_modifierExtension = new Hl7.Fhir.Model.Extension();
							await ParseAsync(newItem_modifierExtension, reader, outcome, locationPath + ".modifierExtension["+result.ModifierExtension.Count+"]"); // 30
							result.ModifierExtension.Add(newItem_modifierExtension);
							break;
						case "role":
							result.RoleElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.Provenance.ProvenanceEntityRole>();
							await ParseAsync(result.RoleElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.Provenance.ProvenanceEntityRole>, reader, outcome, locationPath + ".role"); // 40
							break;
						case "what":
							result.What = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.What as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".what"); // 50
							break;
						case "agent":
							var newItem_agent = new Hl7.Fhir.Model.Provenance.AgentComponent();
							await ParseAsync(newItem_agent, reader, outcome, locationPath + ".agent["+result.Agent.Count+"]"); // 60
							result.Agent.Add(newItem_agent);
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
