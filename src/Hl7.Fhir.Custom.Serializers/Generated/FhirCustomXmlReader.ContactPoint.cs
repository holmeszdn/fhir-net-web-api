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
		public void Parse(Hl7.Fhir.Model.ContactPoint result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
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
						case "system":
							result.SystemElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.ContactPoint.ContactPointSystem>();
							Parse(result.SystemElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.ContactPoint.ContactPointSystem>, reader, outcome, locationPath + ".system", cancellationToken); // 30
							break;
						case "value":
							result.ValueElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.ValueElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".value", cancellationToken); // 40
							break;
						case "use":
							result.UseElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.ContactPoint.ContactPointUse>();
							Parse(result.UseElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.ContactPoint.ContactPointUse>, reader, outcome, locationPath + ".use", cancellationToken); // 50
							break;
						case "rank":
							result.RankElement = new Hl7.Fhir.Model.PositiveInt();
							Parse(result.RankElement as Hl7.Fhir.Model.PositiveInt, reader, outcome, locationPath + ".rank", cancellationToken); // 60
							break;
						case "period":
							result.Period = new Hl7.Fhir.Model.Period();
							Parse(result.Period as Hl7.Fhir.Model.Period, reader, outcome, locationPath + ".period", cancellationToken); // 70
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

		public async System.Threading.Tasks.Task ParseAsync(Hl7.Fhir.Model.ContactPoint result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
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
						case "system":
							result.SystemElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.ContactPoint.ContactPointSystem>();
							await ParseAsync(result.SystemElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.ContactPoint.ContactPointSystem>, reader, outcome, locationPath + ".system", cancellationToken); // 30
							break;
						case "value":
							result.ValueElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.ValueElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".value", cancellationToken); // 40
							break;
						case "use":
							result.UseElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.ContactPoint.ContactPointUse>();
							await ParseAsync(result.UseElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.ContactPoint.ContactPointUse>, reader, outcome, locationPath + ".use", cancellationToken); // 50
							break;
						case "rank":
							result.RankElement = new Hl7.Fhir.Model.PositiveInt();
							await ParseAsync(result.RankElement as Hl7.Fhir.Model.PositiveInt, reader, outcome, locationPath + ".rank", cancellationToken); // 60
							break;
						case "period":
							result.Period = new Hl7.Fhir.Model.Period();
							await ParseAsync(result.Period as Hl7.Fhir.Model.Period, reader, outcome, locationPath + ".period", cancellationToken); // 70
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
