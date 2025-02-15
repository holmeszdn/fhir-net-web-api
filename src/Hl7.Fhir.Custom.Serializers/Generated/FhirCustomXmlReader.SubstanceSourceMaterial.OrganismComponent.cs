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
		public void Parse(Hl7.Fhir.Model.SubstanceSourceMaterial.OrganismComponent result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
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
						case "family":
							result.Family = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.Family as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".family", cancellationToken); // 40
							break;
						case "genus":
							result.Genus = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.Genus as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".genus", cancellationToken); // 50
							break;
						case "species":
							result.Species = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.Species as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".species", cancellationToken); // 60
							break;
						case "intraspecificType":
							result.IntraspecificType = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.IntraspecificType as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".intraspecificType", cancellationToken); // 70
							break;
						case "intraspecificDescription":
							result.IntraspecificDescriptionElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.IntraspecificDescriptionElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".intraspecificDescription", cancellationToken); // 80
							break;
						case "author":
							var newItem_author = new Hl7.Fhir.Model.SubstanceSourceMaterial.AuthorComponent();
							Parse(newItem_author, reader, outcome, locationPath + ".author["+result.Author.Count+"]", cancellationToken); // 90
							result.Author.Add(newItem_author);
							break;
						case "hybrid":
							result.Hybrid = new Hl7.Fhir.Model.SubstanceSourceMaterial.HybridComponent();
							Parse(result.Hybrid as Hl7.Fhir.Model.SubstanceSourceMaterial.HybridComponent, reader, outcome, locationPath + ".hybrid", cancellationToken); // 100
							break;
						case "organismGeneral":
							result.OrganismGeneral = new Hl7.Fhir.Model.SubstanceSourceMaterial.OrganismGeneralComponent();
							Parse(result.OrganismGeneral as Hl7.Fhir.Model.SubstanceSourceMaterial.OrganismGeneralComponent, reader, outcome, locationPath + ".organismGeneral", cancellationToken); // 110
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

		public async System.Threading.Tasks.Task ParseAsync(Hl7.Fhir.Model.SubstanceSourceMaterial.OrganismComponent result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
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
						case "family":
							result.Family = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.Family as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".family", cancellationToken); // 40
							break;
						case "genus":
							result.Genus = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.Genus as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".genus", cancellationToken); // 50
							break;
						case "species":
							result.Species = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.Species as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".species", cancellationToken); // 60
							break;
						case "intraspecificType":
							result.IntraspecificType = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.IntraspecificType as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".intraspecificType", cancellationToken); // 70
							break;
						case "intraspecificDescription":
							result.IntraspecificDescriptionElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.IntraspecificDescriptionElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".intraspecificDescription", cancellationToken); // 80
							break;
						case "author":
							var newItem_author = new Hl7.Fhir.Model.SubstanceSourceMaterial.AuthorComponent();
							await ParseAsync(newItem_author, reader, outcome, locationPath + ".author["+result.Author.Count+"]", cancellationToken); // 90
							result.Author.Add(newItem_author);
							break;
						case "hybrid":
							result.Hybrid = new Hl7.Fhir.Model.SubstanceSourceMaterial.HybridComponent();
							await ParseAsync(result.Hybrid as Hl7.Fhir.Model.SubstanceSourceMaterial.HybridComponent, reader, outcome, locationPath + ".hybrid", cancellationToken); // 100
							break;
						case "organismGeneral":
							result.OrganismGeneral = new Hl7.Fhir.Model.SubstanceSourceMaterial.OrganismGeneralComponent();
							await ParseAsync(result.OrganismGeneral as Hl7.Fhir.Model.SubstanceSourceMaterial.OrganismGeneralComponent, reader, outcome, locationPath + ".organismGeneral", cancellationToken); // 110
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
