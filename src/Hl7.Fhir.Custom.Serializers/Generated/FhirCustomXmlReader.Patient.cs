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
		private void Parse(Patient result, XmlReader reader, OperationOutcome outcome, string locationPath)
		{
			// skip ignored elements
			while (ShouldSkipNodeType(reader.NodeType))
				if (!reader.Read())
					return;

			if (reader.IsEmptyElement)
				return;

			// otherwise proceed to read all the other nodes
			while (reader.Read())
			{
				if (reader.IsStartElement())
				{
					switch (reader.Name)
					{
						case "id":
							result.IdElement = new Hl7.Fhir.Model.Id();
							Parse(result.IdElement as Hl7.Fhir.Model.Id, reader, outcome, locationPath + ".id"); // 10
							break;
						case "meta":
							result.Meta = new Hl7.Fhir.Model.Meta();
							Parse(result.Meta as Hl7.Fhir.Model.Meta, reader, outcome, locationPath + ".meta"); // 20
							break;
						case "implicitRules":
							result.ImplicitRulesElement = new Hl7.Fhir.Model.FhirUri();
							Parse(result.ImplicitRulesElement as Hl7.Fhir.Model.FhirUri, reader, outcome, locationPath + ".implicitRules"); // 30
							break;
						case "language":
							result.LanguageElement = new Hl7.Fhir.Model.Code();
							Parse(result.LanguageElement as Hl7.Fhir.Model.Code, reader, outcome, locationPath + ".language"); // 40
							break;
						case "text":
							result.Text = new Hl7.Fhir.Model.Narrative();
							Parse(result.Text as Hl7.Fhir.Model.Narrative, reader, outcome, locationPath + ".text"); // 50
							break;
						case "contained":
							// FirstChildOf(reader); // 60
							var ContainedResource = Parse(reader, outcome, locationPath + ".contained["+result.Contained.Count+"]");
							if (ContainedResource != null)
								result.Contained.Add(ContainedResource);
							if (!reader.Read()) return;
							break;
						case "extension":
							var newItem_extension = new Hl7.Fhir.Model.Extension();
							Parse(newItem_extension, reader, outcome, locationPath + ".extension["+result.Extension.Count+"]"); // 70
							result.Extension.Add(newItem_extension);
							break;
						case "modifierExtension":
							var newItem_modifierExtension = new Hl7.Fhir.Model.Extension();
							Parse(newItem_modifierExtension, reader, outcome, locationPath + ".modifierExtension["+result.ModifierExtension.Count+"]"); // 80
							result.ModifierExtension.Add(newItem_modifierExtension);
							break;
						case "identifier":
							var newItem_identifier = new Hl7.Fhir.Model.Identifier();
							Parse(newItem_identifier, reader, outcome, locationPath + ".identifier["+result.Identifier.Count+"]"); // 90
							result.Identifier.Add(newItem_identifier);
							break;
						case "active":
							result.ActiveElement = new Hl7.Fhir.Model.FhirBoolean();
							Parse(result.ActiveElement as Hl7.Fhir.Model.FhirBoolean, reader, outcome, locationPath + ".active"); // 100
							break;
						case "name":
							var newItem_name = new Hl7.Fhir.Model.HumanName();
							Parse(newItem_name, reader, outcome, locationPath + ".name["+result.Name.Count+"]"); // 110
							result.Name.Add(newItem_name);
							break;
						case "telecom":
							var newItem_telecom = new Hl7.Fhir.Model.ContactPoint();
							Parse(newItem_telecom, reader, outcome, locationPath + ".telecom["+result.Telecom.Count+"]"); // 120
							result.Telecom.Add(newItem_telecom);
							break;
						case "gender":
							result.GenderElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.AdministrativeGender>();
							Parse(result.GenderElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.AdministrativeGender>, reader, outcome, locationPath + ".gender"); // 130
							break;
						case "birthDate":
							result.BirthDateElement = new Hl7.Fhir.Model.Date();
							Parse(result.BirthDateElement as Hl7.Fhir.Model.Date, reader, outcome, locationPath + ".birthDate"); // 140
							break;
						case "deceasedBoolean":
							result.Deceased = new Hl7.Fhir.Model.FhirBoolean();
							Parse(result.Deceased as Hl7.Fhir.Model.FhirBoolean, reader, outcome, locationPath + ".deceased"); // 150
							break;
						case "deceasedDateTime":
							result.Deceased = new Hl7.Fhir.Model.FhirDateTime();
							Parse(result.Deceased as Hl7.Fhir.Model.FhirDateTime, reader, outcome, locationPath + ".deceased"); // 150
							break;
						case "address":
							var newItem_address = new Hl7.Fhir.Model.Address();
							Parse(newItem_address, reader, outcome, locationPath + ".address["+result.Address.Count+"]"); // 160
							result.Address.Add(newItem_address);
							break;
						case "maritalStatus":
							result.MaritalStatus = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.MaritalStatus as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".maritalStatus"); // 170
							break;
						case "multipleBirthBoolean":
							result.MultipleBirth = new Hl7.Fhir.Model.FhirBoolean();
							Parse(result.MultipleBirth as Hl7.Fhir.Model.FhirBoolean, reader, outcome, locationPath + ".multipleBirth"); // 180
							break;
						case "multipleBirthInteger":
							result.MultipleBirth = new Hl7.Fhir.Model.Integer();
							Parse(result.MultipleBirth as Hl7.Fhir.Model.Integer, reader, outcome, locationPath + ".multipleBirth"); // 180
							break;
						case "photo":
							var newItem_photo = new Hl7.Fhir.Model.Attachment();
							Parse(newItem_photo, reader, outcome, locationPath + ".photo["+result.Photo.Count+"]"); // 190
							result.Photo.Add(newItem_photo);
							break;
						case "contact":
							var newItem_contact = new Hl7.Fhir.Model.Patient.ContactComponent();
							Parse(newItem_contact, reader, outcome, locationPath + ".contact["+result.Contact.Count+"]"); // 200
							result.Contact.Add(newItem_contact);
							break;
						case "communication":
							var newItem_communication = new Hl7.Fhir.Model.Patient.CommunicationComponent();
							Parse(newItem_communication, reader, outcome, locationPath + ".communication["+result.Communication.Count+"]"); // 210
							result.Communication.Add(newItem_communication);
							break;
						case "generalPractitioner":
							var newItem_generalPractitioner = new Hl7.Fhir.Model.ResourceReference();
							Parse(newItem_generalPractitioner, reader, outcome, locationPath + ".generalPractitioner["+result.GeneralPractitioner.Count+"]"); // 220
							result.GeneralPractitioner.Add(newItem_generalPractitioner);
							break;
						case "managingOrganization":
							result.ManagingOrganization = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.ManagingOrganization as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".managingOrganization"); // 230
							break;
						case "link":
							var newItem_link = new Hl7.Fhir.Model.Patient.LinkComponent();
							Parse(newItem_link, reader, outcome, locationPath + ".link["+result.Link.Count+"]"); // 240
							result.Link.Add(newItem_link);
							break;
						default:
							// Property not found
							// System.Diagnostics.Trace.WriteLine($\"Unexpected token found {reader.Name}\");
							HandlePropertyNotFound(reader, outcome, locationPath + "." + reader.Name);
							// reader.ReadInnerXml();
							break;
					}
				}
				else if (reader.NodeType == XmlNodeType.EndElement || reader.IsStartElement() && reader.IsEmptyElement)
				{
					break;
				}
			}
		}

		private async System.Threading.Tasks.Task ParseAsync(Patient result, XmlReader reader, OperationOutcome outcome, string locationPath)
		{
			// skip ignored elements
			while (ShouldSkipNodeType(reader.NodeType))
				if (!await reader.ReadAsync().ConfigureAwait(false))
					return;

			if (reader.IsEmptyElement)
				return;

			// otherwise proceed to read all the other nodes
			while (await reader.ReadAsync().ConfigureAwait(false))
			{
				if (reader.IsStartElement())
				{
					switch (reader.Name)
					{
						case "id":
							result.IdElement = new Hl7.Fhir.Model.Id();
							await ParseAsync(result.IdElement as Hl7.Fhir.Model.Id, reader, outcome, locationPath + ".id"); // 10
							break;
						case "meta":
							result.Meta = new Hl7.Fhir.Model.Meta();
							await ParseAsync(result.Meta as Hl7.Fhir.Model.Meta, reader, outcome, locationPath + ".meta"); // 20
							break;
						case "implicitRules":
							result.ImplicitRulesElement = new Hl7.Fhir.Model.FhirUri();
							await ParseAsync(result.ImplicitRulesElement as Hl7.Fhir.Model.FhirUri, reader, outcome, locationPath + ".implicitRules"); // 30
							break;
						case "language":
							result.LanguageElement = new Hl7.Fhir.Model.Code();
							await ParseAsync(result.LanguageElement as Hl7.Fhir.Model.Code, reader, outcome, locationPath + ".language"); // 40
							break;
						case "text":
							result.Text = new Hl7.Fhir.Model.Narrative();
							await ParseAsync(result.Text as Hl7.Fhir.Model.Narrative, reader, outcome, locationPath + ".text"); // 50
							break;
						case "contained":
							// FirstChildOf(reader); // 60
							var ContainedResource = await ParseAsync(reader, outcome, locationPath + ".contained["+result.Contained.Count+"]");
							if (ContainedResource != null)
								result.Contained.Add(ContainedResource);
							if (!reader.Read()) return;
							break;
						case "extension":
							var newItem_extension = new Hl7.Fhir.Model.Extension();
							await ParseAsync(newItem_extension, reader, outcome, locationPath + ".extension["+result.Extension.Count+"]"); // 70
							result.Extension.Add(newItem_extension);
							break;
						case "modifierExtension":
							var newItem_modifierExtension = new Hl7.Fhir.Model.Extension();
							await ParseAsync(newItem_modifierExtension, reader, outcome, locationPath + ".modifierExtension["+result.ModifierExtension.Count+"]"); // 80
							result.ModifierExtension.Add(newItem_modifierExtension);
							break;
						case "identifier":
							var newItem_identifier = new Hl7.Fhir.Model.Identifier();
							await ParseAsync(newItem_identifier, reader, outcome, locationPath + ".identifier["+result.Identifier.Count+"]"); // 90
							result.Identifier.Add(newItem_identifier);
							break;
						case "active":
							result.ActiveElement = new Hl7.Fhir.Model.FhirBoolean();
							await ParseAsync(result.ActiveElement as Hl7.Fhir.Model.FhirBoolean, reader, outcome, locationPath + ".active"); // 100
							break;
						case "name":
							var newItem_name = new Hl7.Fhir.Model.HumanName();
							await ParseAsync(newItem_name, reader, outcome, locationPath + ".name["+result.Name.Count+"]"); // 110
							result.Name.Add(newItem_name);
							break;
						case "telecom":
							var newItem_telecom = new Hl7.Fhir.Model.ContactPoint();
							await ParseAsync(newItem_telecom, reader, outcome, locationPath + ".telecom["+result.Telecom.Count+"]"); // 120
							result.Telecom.Add(newItem_telecom);
							break;
						case "gender":
							result.GenderElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.AdministrativeGender>();
							await ParseAsync(result.GenderElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.AdministrativeGender>, reader, outcome, locationPath + ".gender"); // 130
							break;
						case "birthDate":
							result.BirthDateElement = new Hl7.Fhir.Model.Date();
							await ParseAsync(result.BirthDateElement as Hl7.Fhir.Model.Date, reader, outcome, locationPath + ".birthDate"); // 140
							break;
						case "deceasedBoolean":
							result.Deceased = new Hl7.Fhir.Model.FhirBoolean();
							await ParseAsync(result.Deceased as Hl7.Fhir.Model.FhirBoolean, reader, outcome, locationPath + ".deceased"); // 150
							break;
						case "deceasedDateTime":
							result.Deceased = new Hl7.Fhir.Model.FhirDateTime();
							await ParseAsync(result.Deceased as Hl7.Fhir.Model.FhirDateTime, reader, outcome, locationPath + ".deceased"); // 150
							break;
						case "address":
							var newItem_address = new Hl7.Fhir.Model.Address();
							await ParseAsync(newItem_address, reader, outcome, locationPath + ".address["+result.Address.Count+"]"); // 160
							result.Address.Add(newItem_address);
							break;
						case "maritalStatus":
							result.MaritalStatus = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.MaritalStatus as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".maritalStatus"); // 170
							break;
						case "multipleBirthBoolean":
							result.MultipleBirth = new Hl7.Fhir.Model.FhirBoolean();
							await ParseAsync(result.MultipleBirth as Hl7.Fhir.Model.FhirBoolean, reader, outcome, locationPath + ".multipleBirth"); // 180
							break;
						case "multipleBirthInteger":
							result.MultipleBirth = new Hl7.Fhir.Model.Integer();
							await ParseAsync(result.MultipleBirth as Hl7.Fhir.Model.Integer, reader, outcome, locationPath + ".multipleBirth"); // 180
							break;
						case "photo":
							var newItem_photo = new Hl7.Fhir.Model.Attachment();
							await ParseAsync(newItem_photo, reader, outcome, locationPath + ".photo["+result.Photo.Count+"]"); // 190
							result.Photo.Add(newItem_photo);
							break;
						case "contact":
							var newItem_contact = new Hl7.Fhir.Model.Patient.ContactComponent();
							await ParseAsync(newItem_contact, reader, outcome, locationPath + ".contact["+result.Contact.Count+"]"); // 200
							result.Contact.Add(newItem_contact);
							break;
						case "communication":
							var newItem_communication = new Hl7.Fhir.Model.Patient.CommunicationComponent();
							await ParseAsync(newItem_communication, reader, outcome, locationPath + ".communication["+result.Communication.Count+"]"); // 210
							result.Communication.Add(newItem_communication);
							break;
						case "generalPractitioner":
							var newItem_generalPractitioner = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(newItem_generalPractitioner, reader, outcome, locationPath + ".generalPractitioner["+result.GeneralPractitioner.Count+"]"); // 220
							result.GeneralPractitioner.Add(newItem_generalPractitioner);
							break;
						case "managingOrganization":
							result.ManagingOrganization = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.ManagingOrganization as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".managingOrganization"); // 230
							break;
						case "link":
							var newItem_link = new Hl7.Fhir.Model.Patient.LinkComponent();
							await ParseAsync(newItem_link, reader, outcome, locationPath + ".link["+result.Link.Count+"]"); // 240
							result.Link.Add(newItem_link);
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
