using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TecFagTilmeldingApp.Models;

namespace TecFagTilmeldingApp.Codes;

internal class Course
{
    public string? Name { get; set; }
    public PersonModel? Teacher { get; set; }

    public Course(string? name, PersonModel? teacher)
    {
        Name = name;
        Teacher = teacher;
    }

    /// <summary>
    /// Denne metode har en metode signatur som følgende: string
    /// </summary>
    /// <returns></returns>
    public string WriteText()
    {
        return "Hello world!";
    }

    /// <summary>
    /// Denne metode har en metode signatur som følgende: string, string
    /// </summary>
    /// <returns></returns>
    public string WriteText(string valueToDisplay)
    {
        return $"Hello {valueToDisplay}!";
    }

    /// <summary>
    /// Denne metode har en metode signatur som følgende: string, string, int
    /// </summary>
    /// <returns></returns>
    public string WriteText(string valueToDisplay, int alder)
    {
        return $"Hello {valueToDisplay}!, du er {alder.ToString()} år gammel.";
    }
}