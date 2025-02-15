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
		public void Parse(Hl7.Fhir.Model.SampledData result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
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
						case "origin":
							result.Origin = new Hl7.Fhir.Model.Quantity();
							Parse(result.Origin as Hl7.Fhir.Model.Quantity, reader, outcome, locationPath + ".origin", cancellationToken); // 30
							break;
						case "period":
							result.PeriodElement = new Hl7.Fhir.Model.FhirDecimal();
							Parse(result.PeriodElement as Hl7.Fhir.Model.FhirDecimal, reader, outcome, locationPath + ".period", cancellationToken); // 40
							break;
						case "factor":
							result.FactorElement = new Hl7.Fhir.Model.FhirDecimal();
							Parse(result.FactorElement as Hl7.Fhir.Model.FhirDecimal, reader, outcome, locationPath + ".factor", cancellationToken); // 50
							break;
						case "lowerLimit":
							result.LowerLimitElement = new Hl7.Fhir.Model.FhirDecimal();
							Parse(result.LowerLimitElement as Hl7.Fhir.Model.FhirDecimal, reader, outcome, locationPath + ".lowerLimit", cancellationToken); // 60
							break;
						case "upperLimit":
							result.UpperLimitElement = new Hl7.Fhir.Model.FhirDecimal();
							Parse(result.UpperLimitElement as Hl7.Fhir.Model.FhirDecimal, reader, outcome, locationPath + ".upperLimit", cancellationToken); // 70
							break;
						case "dimensions":
							result.DimensionsElement = new Hl7.Fhir.Model.PositiveInt();
							Parse(result.DimensionsElement as Hl7.Fhir.Model.PositiveInt, reader, outcome, locationPath + ".dimensions", cancellationToken); // 80
							break;
						case "data":
							result.DataElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.DataElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".data", cancellationToken); // 90
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

		public async System.Threading.Tasks.Task ParseAsync(Hl7.Fhir.Model.SampledData result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
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
						case "origin":
							result.Origin = new Hl7.Fhir.Model.Quantity();
							await ParseAsync(result.Origin as Hl7.Fhir.Model.Quantity, reader, outcome, locationPath + ".origin", cancellationToken); // 30
							break;
						case "period":
							result.PeriodElement = new Hl7.Fhir.Model.FhirDecimal();
							await ParseAsync(result.PeriodElement as Hl7.Fhir.Model.FhirDecimal, reader, outcome, locationPath + ".period", cancellationToken); // 40
							break;
						case "factor":
							result.FactorElement = new Hl7.Fhir.Model.FhirDecimal();
							await ParseAsync(result.FactorElement as Hl7.Fhir.Model.FhirDecimal, reader, outcome, locationPath + ".factor", cancellationToken); // 50
							break;
						case "lowerLimit":
							result.LowerLimitElement = new Hl7.Fhir.Model.FhirDecimal();
							await ParseAsync(result.LowerLimitElement as Hl7.Fhir.Model.FhirDecimal, reader, outcome, locationPath + ".lowerLimit", cancellationToken); // 60
							break;
						case "upperLimit":
							result.UpperLimitElement = new Hl7.Fhir.Model.FhirDecimal();
							await ParseAsync(result.UpperLimitElement as Hl7.Fhir.Model.FhirDecimal, reader, outcome, locationPath + ".upperLimit", cancellationToken); // 70
							break;
						case "dimensions":
							result.DimensionsElement = new Hl7.Fhir.Model.PositiveInt();
							await ParseAsync(result.DimensionsElement as Hl7.Fhir.Model.PositiveInt, reader, outcome, locationPath + ".dimensions", cancellationToken); // 80
							break;
						case "data":
							result.DataElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.DataElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".data", cancellationToken); // 90
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
