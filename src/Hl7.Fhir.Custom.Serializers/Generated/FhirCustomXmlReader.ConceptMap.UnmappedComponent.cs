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
		public void Parse(Hl7.Fhir.Model.ConceptMap.UnmappedComponent result, XmlReader reader, OperationOutcome outcome, string locationPath)
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
						case "mode":
							result.ModeElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.ConceptMap.ConceptMapGroupUnmappedMode>();
							Parse(result.ModeElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.ConceptMap.ConceptMapGroupUnmappedMode>, reader, outcome, locationPath + ".mode"); // 40
							break;
						case "code":
							result.CodeElement = new Hl7.Fhir.Model.Code();
							Parse(result.CodeElement as Hl7.Fhir.Model.Code, reader, outcome, locationPath + ".code"); // 50
							break;
						case "display":
							result.DisplayElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.DisplayElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".display"); // 60
							break;
						case "url":
							result.UrlElement = new Hl7.Fhir.Model.Canonical();
							Parse(result.UrlElement as Hl7.Fhir.Model.Canonical, reader, outcome, locationPath + ".url"); // 70
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

		public async System.Threading.Tasks.Task ParseAsync(Hl7.Fhir.Model.ConceptMap.UnmappedComponent result, XmlReader reader, OperationOutcome outcome, string locationPath)
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
						case "mode":
							result.ModeElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.ConceptMap.ConceptMapGroupUnmappedMode>();
							await ParseAsync(result.ModeElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.ConceptMap.ConceptMapGroupUnmappedMode>, reader, outcome, locationPath + ".mode"); // 40
							break;
						case "code":
							result.CodeElement = new Hl7.Fhir.Model.Code();
							await ParseAsync(result.CodeElement as Hl7.Fhir.Model.Code, reader, outcome, locationPath + ".code"); // 50
							break;
						case "display":
							result.DisplayElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.DisplayElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".display"); // 60
							break;
						case "url":
							result.UrlElement = new Hl7.Fhir.Model.Canonical();
							await ParseAsync(result.UrlElement as Hl7.Fhir.Model.Canonical, reader, outcome, locationPath + ".url"); // 70
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
