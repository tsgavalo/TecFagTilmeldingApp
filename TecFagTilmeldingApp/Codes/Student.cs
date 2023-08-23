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

    public override List<string> GetInfo(List<Enrollment> enrollments)
    {
        List<string> info = new();
        foreach (Enrollment enrollment in enrollments)
        {
            if (enrollment.Student.PersonalInfo.FirstName == PersonalInfo.FirstName && enrollment.Student.PersonalInfo.LastName == PersonalInfo.LastName)
            {
                info.Add(enrollment.Course.Name);
            }
        }

        return info;
    }

    protected override string ShowAllInfo()
    {
        return $"{PersonalInfo.FirstName} {PersonalInfo.LastName}";
    }
}
