using System.Collections.Generic;
using System.Numerics;
using TecFagTilmeldingApp.Codes;
using TecFagTilmeldingApp.Generics;
using TecFagTilmeldingApp.Models;
using TecFagTilmeldingApp.Øvelse.Animals;

#region sound player

//while (true)
//{
//    Console.Write("\nIndtast tal 1 for at afspille lyden: ");
//    string talInput = Console.ReadLine();
//    if (talInput == "1")
//    {
//        string myCurrentDer = System.IO.Directory.GetCurrentDirectory();
//        string appDir = System.IO.Path.Combine(myCurrentDer, "SoundTest");
//        appDir = System.IO.Path.Combine(appDir, "phone.wav");

//        System.Media.SoundPlayer soundPlayer = new System.Media.SoundPlayer();
//        soundPlayer.SoundLocation = appDir;
//        soundPlayer.Play();
//    }
//    else
//    {
//        Console.Clear();
//    }
//}

#endregion

Teacher? niels = new("Niels", "Olesen", new DateTime(1971, 2, 23), "CIT");
Teacher? henrik = new("Henrik", "Paulsen", new DateTime(1975, 9, 13), "CIT");
Teacher? jack = new("Jack", "Baltzer", new DateTime(1986, 1, 20), "CIT");
Teacher? bo = new("Bo", "Elbæk", new DateTime(1965, 8, 3), "CIT");

Course grundlæggendeProgrammering = new("Grundlæggende programmering", niels.PersonalInfo);
Course oop = new("OOP", niels.PersonalInfo);
Course studieTeknik = new("Studieteknik", niels.PersonalInfo);
Course netværk = new("Netværk", henrik.PersonalInfo);
Course clientsideProgrammering = new("Clientside programmering", jack.PersonalInfo);
Course databaseProgrammering = new("Database programmering", jack.PersonalInfo);
Course computerTeknologi = new("Computerteknologi", bo.PersonalInfo);

List<Course> courses = new() { grundlæggendeProgrammering, oop, studieTeknik, netværk, clientsideProgrammering, databaseProgrammering, computerTeknologi };
List<Enrollment> enrollments = new();
while (true)
{
    if(enrollments.Count > 0 )
    {
        foreach (var item in enrollments)
        {
            Console.WriteLine($"{item.Student.PersonalInfo.FirstName} {item.Student.PersonalInfo.LastName} ({item.Student.Age}) er tilmeldt {item.Course.Name}");
        }
    }
    else
    {
        Console.WriteLine("Ingen elev er tilmeldt endnu.");
    }

    Console.Write("\nAngive elev fornavn: ");
    string elevFornavn = Console.ReadLine();

    Console.Write("Angive elev efternavn: ");
    string efterFornavn = Console.ReadLine();

    Console.Write("Angive elev fødsesdato: ");
    string elevFødsesdato = Console.ReadLine();

    for (int i = 0; i < courses.Count; i++)
    {
        Course item = courses[i];
        Console.WriteLine($"Fag id: {i+1}, fag navn: {item.Name}");
    }
    
    Console.Write("Angive fag id: ");
    string fagId = Console.ReadLine();
    Course? valgteFag = null;
    switch(fagId)
    {
        case "1":
            valgteFag = courses[0];
            break;
        case "2":
            valgteFag = courses[1];
            break;
        case "3":
            valgteFag = courses[2];
            break;
        case "4":
            valgteFag = courses[3];
            break;
        case "5":
            valgteFag = courses[4];
            break;
        case "6":
            valgteFag = courses[5];
            break;
        case "7":
            valgteFag = courses[6];
            break;
    }

    Student tilmeldteElev = new Student(elevFornavn, efterFornavn, Convert.ToDateTime(elevFødsesdato));

    Enrollment enrolledStudent = new (tilmeldteElev, valgteFag);
    enrollments.Add(enrolledStudent);

    Console.WriteLine("\nLæser fra abstrakt metode: GetInfo");
    List<string> infos = tilmeldteElev.GetInfo(enrollments);
    foreach(string info in infos)
    {
        Console.WriteLine("Elev er tilmeldt: " + info);
    }

    List<string> infosTeacher = bo.GetInfo(enrollments);
    if(infosTeacher.Count > 0)
    {
        foreach (string info in infosTeacher)
        {
            Console.WriteLine("Læreren skal undervises i fag: " + info);
        }
    }
    else
    {
        Console.WriteLine("Ingen elev er tilmed et fag som læren er læreren for.");
    }


    Console.WriteLine("Vil du forsætte: [y/n]");
    string isContinue = Console.ReadLine();
    Console.Clear();
    if (isContinue.ToLower() == "n")
    {
        break;
    }
}

