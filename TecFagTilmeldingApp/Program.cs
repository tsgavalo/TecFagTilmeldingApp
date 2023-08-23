using TecFagTilmeldingApp.Codes;
using TecFagTilmeldingApp.Generics;
using TecFagTilmeldingApp.Models;

Person student2 = new Student("Patrik", "Nielsen", new DateTime(1971, 2, 23));
Person teacher2 = new Teacher("Patrik", "Nielsen", new DateTime(1971, 2, 23), "CIT");

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
        Console.WriteLine($"Fag id: {i++}, fag navn: {item.Name}");
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

    Console.WriteLine("Vil du forsætte: [y/n]");
    string isContinue = Console.ReadLine();
    if (isContinue.ToLower() == "n")
    {
        Console.Clear();
        break;
    }
    else
    {
        Console.Clear();
    }
}





//Bil audi = new("Audi", "A6", 2.5);
//Cykel cykel = new("Avenue", "City bike", "165 - 170 cm");





//Person p = new Student("Patrik", "Nielsen", new DateTime(2002, 6, 14));
//Student p2 = new Student("Patrik", "Nielsen", new DateTime(2002, 6, 14));

//Person p3 = new Teacher("Niels", "Olesen", new DateTime(2002, 6, 14), "CIT");
//Teacher p4 = new Teacher("Niels", "Olesen", new DateTime(2002, 6, 14), "CIT");

