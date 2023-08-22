using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TecFagTilmeldingApp.Codes;
using TecFagTilmeldingApp.Models;

namespace TecFagTilmeldingApp;

internal static class Utility
{
    public static List<Course> Courses { get; set; }

    public static void SetCourseList()
    {
        DateTime birthDate = new DateTime(1971, 2, 23);
        Teacher? niels = new("Niels", "Olesen", birthDate, "CIT");
        PersonModel personalInfo = niels.PersonalInfo;
        Course oop = new("OOP", personalInfo);
    }
}
