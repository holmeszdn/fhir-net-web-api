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
		public void Parse(Hl7.Fhir.Model.ElementDefinition.ElementDefinitionBindingComponent result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
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
						case "strength":
							result.StrengthElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.BindingStrength>();
							Parse(result.StrengthElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.BindingStrength>, reader, outcome, locationPath + ".strength", cancellationToken); // 40
							break;
						case "description":
							result.DescriptionElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.DescriptionElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".description", cancellationToken); // 50
							break;
						case "valueSet":
							result.ValueSetElement = new Hl7.Fhir.Model.Canonical();
							Parse(result.ValueSetElement as Hl7.Fhir.Model.Canonical, reader, outcome, locationPath + ".valueSet", cancellationToken); // 60
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

		public async System.Threading.Tasks.Task ParseAsync(Hl7.Fhir.Model.ElementDefinition.ElementDefinitionBindingComponent result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
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
						case "strength":
							result.StrengthElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.BindingStrength>();
							await ParseAsync(result.StrengthElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.BindingStrength>, reader, outcome, locationPath + ".strength", cancellationToken); // 40
							break;
						case "description":
							result.DescriptionElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.DescriptionElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".description", cancellationToken); // 50
							break;
						case "valueSet":
							result.ValueSetElement = new Hl7.Fhir.Model.Canonical();
							await ParseAsync(result.ValueSetElement as Hl7.Fhir.Model.Canonical, reader, outcome, locationPath + ".valueSet", cancellationToken); // 60
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
