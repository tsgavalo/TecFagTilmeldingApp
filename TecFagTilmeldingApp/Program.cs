using TecFagTilmeldingApp.Codes;
using TecFagTilmeldingApp.Generics;
using TecFagTilmeldingApp.Models;

DateTime birthDate = new DateTime(1971, 2, 23);
Teacher? niels = new("Niels", "Olesen", birthDate, "CIT");
PersonModel personalInfo = niels.PersonalInfo;

Course oop = new("OOP", personalInfo);

Console.WriteLine($"{oop.Name}, teacher: {personalInfo.FirstName} {personalInfo.LastName}");

Bil audi = new("Audi", "A6", 2.5);
Cykel cykel = new("Avenue", "City bike", "165 - 170 cm");
