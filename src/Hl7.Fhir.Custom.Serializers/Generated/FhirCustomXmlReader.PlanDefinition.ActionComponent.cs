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
		public void Parse(Hl7.Fhir.Model.PlanDefinition.ActionComponent result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
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
						case "prefix":
							result.PrefixElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.PrefixElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".prefix", cancellationToken); // 40
							break;
						case "title":
							result.TitleElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.TitleElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".title", cancellationToken); // 50
							break;
						case "description":
							result.DescriptionElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.DescriptionElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".description", cancellationToken); // 60
							break;
						case "textEquivalent":
							result.TextEquivalentElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.TextEquivalentElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".textEquivalent", cancellationToken); // 70
							break;
						case "priority":
							result.PriorityElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.RequestPriority>();
							Parse(result.PriorityElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.RequestPriority>, reader, outcome, locationPath + ".priority", cancellationToken); // 80
							break;
						case "code":
							var newItem_code = new Hl7.Fhir.Model.CodeableConcept();
							Parse(newItem_code, reader, outcome, locationPath + ".code["+result.Code.Count+"]", cancellationToken); // 90
							result.Code.Add(newItem_code);
							break;
						case "reason":
							var newItem_reason = new Hl7.Fhir.Model.CodeableConcept();
							Parse(newItem_reason, reader, outcome, locationPath + ".reason["+result.Reason.Count+"]", cancellationToken); // 100
							result.Reason.Add(newItem_reason);
							break;
						case "documentation":
							var newItem_documentation = new Hl7.Fhir.Model.RelatedArtifact();
							Parse(newItem_documentation, reader, outcome, locationPath + ".documentation["+result.Documentation.Count+"]", cancellationToken); // 110
							result.Documentation.Add(newItem_documentation);
							break;
						case "goalId":
							var newItem_goalId = new Hl7.Fhir.Model.Id();
							Parse(newItem_goalId, reader, outcome, locationPath + ".goalId["+result.GoalIdElement.Count+"]", cancellationToken); // 120
							result.GoalIdElement.Add(newItem_goalId);
							break;
						case "subjectCodeableConcept":
							result.Subject = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.Subject as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".subject", cancellationToken); // 130
							break;
						case "subjectReference":
							result.Subject = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Subject as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".subject", cancellationToken); // 130
							break;
						case "trigger":
							var newItem_trigger = new Hl7.Fhir.Model.TriggerDefinition();
							Parse(newItem_trigger, reader, outcome, locationPath + ".trigger["+result.Trigger.Count+"]", cancellationToken); // 140
							result.Trigger.Add(newItem_trigger);
							break;
						case "condition":
							var newItem_condition = new Hl7.Fhir.Model.PlanDefinition.ConditionComponent();
							Parse(newItem_condition, reader, outcome, locationPath + ".condition["+result.Condition.Count+"]", cancellationToken); // 150
							result.Condition.Add(newItem_condition);
							break;
						case "input":
							var newItem_input = new Hl7.Fhir.Model.DataRequirement();
							Parse(newItem_input, reader, outcome, locationPath + ".input["+result.Input.Count+"]", cancellationToken); // 160
							result.Input.Add(newItem_input);
							break;
						case "output":
							var newItem_output = new Hl7.Fhir.Model.DataRequirement();
							Parse(newItem_output, reader, outcome, locationPath + ".output["+result.Output.Count+"]", cancellationToken); // 170
							result.Output.Add(newItem_output);
							break;
						case "relatedAction":
							var newItem_relatedAction = new Hl7.Fhir.Model.PlanDefinition.RelatedActionComponent();
							Parse(newItem_relatedAction, reader, outcome, locationPath + ".relatedAction["+result.RelatedAction.Count+"]", cancellationToken); // 180
							result.RelatedAction.Add(newItem_relatedAction);
							break;
						case "timingDateTime":
							result.Timing = new Hl7.Fhir.Model.FhirDateTime();
							Parse(result.Timing as Hl7.Fhir.Model.FhirDateTime, reader, outcome, locationPath + ".timing", cancellationToken); // 190
							break;
						case "timingAge":
							result.Timing = new Hl7.Fhir.Model.Age();
							Parse(result.Timing as Hl7.Fhir.Model.Age, reader, outcome, locationPath + ".timing", cancellationToken); // 190
							break;
						case "timingPeriod":
							result.Timing = new Hl7.Fhir.Model.Period();
							Parse(result.Timing as Hl7.Fhir.Model.Period, reader, outcome, locationPath + ".timing", cancellationToken); // 190
							break;
						case "timingDuration":
							result.Timing = new Hl7.Fhir.Model.Duration();
							Parse(result.Timing as Hl7.Fhir.Model.Duration, reader, outcome, locationPath + ".timing", cancellationToken); // 190
							break;
						case "timingRange":
							result.Timing = new Hl7.Fhir.Model.Range();
							Parse(result.Timing as Hl7.Fhir.Model.Range, reader, outcome, locationPath + ".timing", cancellationToken); // 190
							break;
						case "timingTiming":
							result.Timing = new Hl7.Fhir.Model.Timing();
							Parse(result.Timing as Hl7.Fhir.Model.Timing, reader, outcome, locationPath + ".timing", cancellationToken); // 190
							break;
						case "participant":
							var newItem_participant = new Hl7.Fhir.Model.PlanDefinition.ParticipantComponent();
							Parse(newItem_participant, reader, outcome, locationPath + ".participant["+result.Participant.Count+"]", cancellationToken); // 200
							result.Participant.Add(newItem_participant);
							break;
						case "type":
							result.Type = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.Type as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".type", cancellationToken); // 210
							break;
						case "groupingBehavior":
							result.GroupingBehaviorElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.ActionGroupingBehavior>();
							Parse(result.GroupingBehaviorElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.ActionGroupingBehavior>, reader, outcome, locationPath + ".groupingBehavior", cancellationToken); // 220
							break;
						case "selectionBehavior":
							result.SelectionBehaviorElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.ActionSelectionBehavior>();
							Parse(result.SelectionBehaviorElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.ActionSelectionBehavior>, reader, outcome, locationPath + ".selectionBehavior", cancellationToken); // 230
							break;
						case "requiredBehavior":
							result.RequiredBehaviorElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.ActionRequiredBehavior>();
							Parse(result.RequiredBehaviorElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.ActionRequiredBehavior>, reader, outcome, locationPath + ".requiredBehavior", cancellationToken); // 240
							break;
						case "precheckBehavior":
							result.PrecheckBehaviorElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.ActionPrecheckBehavior>();
							Parse(result.PrecheckBehaviorElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.ActionPrecheckBehavior>, reader, outcome, locationPath + ".precheckBehavior", cancellationToken); // 250
							break;
						case "cardinalityBehavior":
							result.CardinalityBehaviorElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.ActionCardinalityBehavior>();
							Parse(result.CardinalityBehaviorElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.ActionCardinalityBehavior>, reader, outcome, locationPath + ".cardinalityBehavior", cancellationToken); // 260
							break;
						case "definitionCanonical":
							result.Definition = new Hl7.Fhir.Model.Canonical();
							Parse(result.Definition as Hl7.Fhir.Model.Canonical, reader, outcome, locationPath + ".definition", cancellationToken); // 270
							break;
						case "definitionUri":
							result.Definition = new Hl7.Fhir.Model.FhirUri();
							Parse(result.Definition as Hl7.Fhir.Model.FhirUri, reader, outcome, locationPath + ".definition", cancellationToken); // 270
							break;
						case "transform":
							result.TransformElement = new Hl7.Fhir.Model.Canonical();
							Parse(result.TransformElement as Hl7.Fhir.Model.Canonical, reader, outcome, locationPath + ".transform", cancellationToken); // 280
							break;
						case "dynamicValue":
							var newItem_dynamicValue = new Hl7.Fhir.Model.PlanDefinition.DynamicValueComponent();
							Parse(newItem_dynamicValue, reader, outcome, locationPath + ".dynamicValue["+result.DynamicValue.Count+"]", cancellationToken); // 290
							result.DynamicValue.Add(newItem_dynamicValue);
							break;
						case "action":
							var newItem_action = new Hl7.Fhir.Model.PlanDefinition.ActionComponent();
							Parse(newItem_action, reader, outcome, locationPath + ".action["+result.Action.Count+"]", cancellationToken); // 300
							result.Action.Add(newItem_action);
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

		public async System.Threading.Tasks.Task ParseAsync(Hl7.Fhir.Model.PlanDefinition.ActionComponent result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
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
						case "prefix":
							result.PrefixElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.PrefixElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".prefix", cancellationToken); // 40
							break;
						case "title":
							result.TitleElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.TitleElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".title", cancellationToken); // 50
							break;
						case "description":
							result.DescriptionElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.DescriptionElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".description", cancellationToken); // 60
							break;
						case "textEquivalent":
							result.TextEquivalentElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.TextEquivalentElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".textEquivalent", cancellationToken); // 70
							break;
						case "priority":
							result.PriorityElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.RequestPriority>();
							await ParseAsync(result.PriorityElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.RequestPriority>, reader, outcome, locationPath + ".priority", cancellationToken); // 80
							break;
						case "code":
							var newItem_code = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(newItem_code, reader, outcome, locationPath + ".code["+result.Code.Count+"]", cancellationToken); // 90
							result.Code.Add(newItem_code);
							break;
						case "reason":
							var newItem_reason = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(newItem_reason, reader, outcome, locationPath + ".reason["+result.Reason.Count+"]", cancellationToken); // 100
							result.Reason.Add(newItem_reason);
							break;
						case "documentation":
							var newItem_documentation = new Hl7.Fhir.Model.RelatedArtifact();
							await ParseAsync(newItem_documentation, reader, outcome, locationPath + ".documentation["+result.Documentation.Count+"]", cancellationToken); // 110
							result.Documentation.Add(newItem_documentation);
							break;
						case "goalId":
							var newItem_goalId = new Hl7.Fhir.Model.Id();
							await ParseAsync(newItem_goalId, reader, outcome, locationPath + ".goalId["+result.GoalIdElement.Count+"]", cancellationToken); // 120
							result.GoalIdElement.Add(newItem_goalId);
							break;
						case "subjectCodeableConcept":
							result.Subject = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.Subject as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".subject", cancellationToken); // 130
							break;
						case "subjectReference":
							result.Subject = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Subject as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".subject", cancellationToken); // 130
							break;
						case "trigger":
							var newItem_trigger = new Hl7.Fhir.Model.TriggerDefinition();
							await ParseAsync(newItem_trigger, reader, outcome, locationPath + ".trigger["+result.Trigger.Count+"]", cancellationToken); // 140
							result.Trigger.Add(newItem_trigger);
							break;
						case "condition":
							var newItem_condition = new Hl7.Fhir.Model.PlanDefinition.ConditionComponent();
							await ParseAsync(newItem_condition, reader, outcome, locationPath + ".condition["+result.Condition.Count+"]", cancellationToken); // 150
							result.Condition.Add(newItem_condition);
							break;
						case "input":
							var newItem_input = new Hl7.Fhir.Model.DataRequirement();
							await ParseAsync(newItem_input, reader, outcome, locationPath + ".input["+result.Input.Count+"]", cancellationToken); // 160
							result.Input.Add(newItem_input);
							break;
						case "output":
							var newItem_output = new Hl7.Fhir.Model.DataRequirement();
							await ParseAsync(newItem_output, reader, outcome, locationPath + ".output["+result.Output.Count+"]", cancellationToken); // 170
							result.Output.Add(newItem_output);
							break;
						case "relatedAction":
							var newItem_relatedAction = new Hl7.Fhir.Model.PlanDefinition.RelatedActionComponent();
							await ParseAsync(newItem_relatedAction, reader, outcome, locationPath + ".relatedAction["+result.RelatedAction.Count+"]", cancellationToken); // 180
							result.RelatedAction.Add(newItem_relatedAction);
							break;
						case "timingDateTime":
							result.Timing = new Hl7.Fhir.Model.FhirDateTime();
							await ParseAsync(result.Timing as Hl7.Fhir.Model.FhirDateTime, reader, outcome, locationPath + ".timing", cancellationToken); // 190
							break;
						case "timingAge":
							result.Timing = new Hl7.Fhir.Model.Age();
							await ParseAsync(result.Timing as Hl7.Fhir.Model.Age, reader, outcome, locationPath + ".timing", cancellationToken); // 190
							break;
						case "timingPeriod":
							result.Timing = new Hl7.Fhir.Model.Period();
							await ParseAsync(result.Timing as Hl7.Fhir.Model.Period, reader, outcome, locationPath + ".timing", cancellationToken); // 190
							break;
						case "timingDuration":
							result.Timing = new Hl7.Fhir.Model.Duration();
							await ParseAsync(result.Timing as Hl7.Fhir.Model.Duration, reader, outcome, locationPath + ".timing", cancellationToken); // 190
							break;
						case "timingRange":
							result.Timing = new Hl7.Fhir.Model.Range();
							await ParseAsync(result.Timing as Hl7.Fhir.Model.Range, reader, outcome, locationPath + ".timing", cancellationToken); // 190
							break;
						case "timingTiming":
							result.Timing = new Hl7.Fhir.Model.Timing();
							await ParseAsync(result.Timing as Hl7.Fhir.Model.Timing, reader, outcome, locationPath + ".timing", cancellationToken); // 190
							break;
						case "participant":
							var newItem_participant = new Hl7.Fhir.Model.PlanDefinition.ParticipantComponent();
							await ParseAsync(newItem_participant, reader, outcome, locationPath + ".participant["+result.Participant.Count+"]", cancellationToken); // 200
							result.Participant.Add(newItem_participant);
							break;
						case "type":
							result.Type = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.Type as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".type", cancellationToken); // 210
							break;
						case "groupingBehavior":
							result.GroupingBehaviorElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.ActionGroupingBehavior>();
							await ParseAsync(result.GroupingBehaviorElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.ActionGroupingBehavior>, reader, outcome, locationPath + ".groupingBehavior", cancellationToken); // 220
							break;
						case "selectionBehavior":
							result.SelectionBehaviorElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.ActionSelectionBehavior>();
							await ParseAsync(result.SelectionBehaviorElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.ActionSelectionBehavior>, reader, outcome, locationPath + ".selectionBehavior", cancellationToken); // 230
							break;
						case "requiredBehavior":
							result.RequiredBehaviorElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.ActionRequiredBehavior>();
							await ParseAsync(result.RequiredBehaviorElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.ActionRequiredBehavior>, reader, outcome, locationPath + ".requiredBehavior", cancellationToken); // 240
							break;
						case "precheckBehavior":
							result.PrecheckBehaviorElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.ActionPrecheckBehavior>();
							await ParseAsync(result.PrecheckBehaviorElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.ActionPrecheckBehavior>, reader, outcome, locationPath + ".precheckBehavior", cancellationToken); // 250
							break;
						case "cardinalityBehavior":
							result.CardinalityBehaviorElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.ActionCardinalityBehavior>();
							await ParseAsync(result.CardinalityBehaviorElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.ActionCardinalityBehavior>, reader, outcome, locationPath + ".cardinalityBehavior", cancellationToken); // 260
							break;
						case "definitionCanonical":
							result.Definition = new Hl7.Fhir.Model.Canonical();
							await ParseAsync(result.Definition as Hl7.Fhir.Model.Canonical, reader, outcome, locationPath + ".definition", cancellationToken); // 270
							break;
						case "definitionUri":
							result.Definition = new Hl7.Fhir.Model.FhirUri();
							await ParseAsync(result.Definition as Hl7.Fhir.Model.FhirUri, reader, outcome, locationPath + ".definition", cancellationToken); // 270
							break;
						case "transform":
							result.TransformElement = new Hl7.Fhir.Model.Canonical();
							await ParseAsync(result.TransformElement as Hl7.Fhir.Model.Canonical, reader, outcome, locationPath + ".transform", cancellationToken); // 280
							break;
						case "dynamicValue":
							var newItem_dynamicValue = new Hl7.Fhir.Model.PlanDefinition.DynamicValueComponent();
							await ParseAsync(newItem_dynamicValue, reader, outcome, locationPath + ".dynamicValue["+result.DynamicValue.Count+"]", cancellationToken); // 290
							result.DynamicValue.Add(newItem_dynamicValue);
							break;
						case "action":
							var newItem_action = new Hl7.Fhir.Model.PlanDefinition.ActionComponent();
							await ParseAsync(newItem_action, reader, outcome, locationPath + ".action["+result.Action.Count+"]", cancellationToken); // 300
							result.Action.Add(newItem_action);
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
