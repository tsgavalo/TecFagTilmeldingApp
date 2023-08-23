using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TecFagTilmeldingApp.Models;

namespace TecFagTilmeldingApp.Codes;

// Sealed class må ikke arves fra.
internal sealed class Student : Person
{
    public Student(string? firstName, string? lastName, DateTime birthDate) : base(firstName, lastName, birthDate)
    {
        string defaultInfo = ShowAllInfo2();
    }

    protected override string ShowAllInfo()
    {
        return $"{PersonalInfo.FirstName} {PersonalInfo.LastName}";
    }
}
