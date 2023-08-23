using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TecFagTilmeldingApp.Models;

namespace TecFagTilmeldingApp.Codes;

// Abstract er tilføjet for at man ikke kan istantierer en base klasse. Og
// denne klasse er base klasse for Teacher og Student.
internal abstract class Person
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

    public abstract List<string> GetInfo(List<Enrollment> enrollments);

    /// <summary>
    /// Brug af protected modifier for at metoden er "public" internt i arven
    /// men private for alle andre types(klasse).
    /// </summary>
    /// <returns></returns>
    protected string ShowFullName()
    {
        return $"{PersonalInfo.FirstName} {PersonalInfo.LastName}";
    }

    protected abstract string ShowAllInfo();
    
    
    protected virtual string ShowAllInfo2()
    {
        return $"{PersonalInfo.FirstName} {PersonalInfo.LastName}";
    }
}
