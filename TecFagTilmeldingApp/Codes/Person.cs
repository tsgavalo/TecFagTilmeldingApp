using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TecFagTilmeldingApp.Models;

namespace TecFagTilmeldingApp.Codes;

internal class Person
{
    public PersonModel? PersonalInfo { get; set; }
    public DateTime BirthDate { get; set; }
    public int Age { get; set; }

    public Person(string? firstName, string? lastName, DateTime birthDate)
    {
        PersonalInfo = new() { FirstName = firstName, LastName = lastName };
        BirthDate = birthDate;
        Age = new AgeConverter(birthDate).Age;
    }
}
