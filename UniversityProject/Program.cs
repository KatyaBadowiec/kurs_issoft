using OpenQA.Selenium.Chrome;
using System.Collections.Immutable;
using System.Security.Cryptography.X509Certificates;
using UniversityProject;

using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

Rector rector = new Rector("Kinga Kniga", "Doctor sciences PhD", "rector", 2230, "Professor");
Address universityLegalAddress = new Address("Minsk", "Prityckogo", 17);

Employee employee1 = new ("Vasilij Pupkin", "Teacher", "biology", 1233);
Employee employee2 = new ("Sasha Pushkin", "Teacher", "biology", 234);
Employee employee3 = new ("Ivan Durak", "Cleaner", "clean", 1238);
Employee employee4 = new ("Ivan Durak", "Securety", "guard", 1237);
Employee employee5 = new ("Alex Popovich", "Driver", "drive", 239);
Employee employee6 = new ("Maxim Fox", "Teacher", "mathematics", 355);
Employee employee7 = new ("Iwona Fix", "Teacher", "literatura", 1222);
Employee employee8 = new ("Aliona Fis", "Teacher", "mathematics", 1252);

List<Employee> employees = new List<Employee>
{
    employee1,
    employee2,
    employee3,
    employee4,
    employee5,
    employee6,
    employee7,
    employee8
};

/* Create building: univCorpus1 */
Room univCorpus1room1 = new Room("Laboratory", 23);
Room univCorpus1room2 = new Room("Leture", 45);
Room univCorpus1room3 = new Room("Semenarian", 56);
Room univCorpus1room4 = new Room("Auxiliary", 78);

List<Room> univCorpus1Rooms = new List<Room>
{
    univCorpus1room1,
    univCorpus1room2,
    univCorpus1room3,
    univCorpus1room4,
};

Address univCorpus1Address = new Address("Minsk", "Glebki", 58);
Building univCorpus1 = new(univCorpus1Address, univCorpus1Rooms);

/* Create building: univCorpus2 */
Room univCorpus2room1 = new Room("Laboratory", 2);
Room univCorpus2room2 = new Room("Leture", 5);
Room univCorpus2room3 = new Room("Lecture", 15);

List<Room> univCorpus2Rooms = new List<Room>
{
    univCorpus2room1,
    univCorpus2room2,
    univCorpus2room3
};

Address univCorpus2Address = new Address("Minsk", "Prytyckogo", 132);
Building univCorpus2 = new(univCorpus2Address, univCorpus2Rooms);

/* Create building: univCorpus sportzal */
Room univCorpusSportzalRoom1 = new Room("Auxiliary", 1);
Room univCorpusSportzalRoom2 = new Room("Auxiliary", 2);

List<Room> univCorpusSportzalRooms = new List<Room>
{
    univCorpusSportzalRoom1,
    univCorpusSportzalRoom2
};

Address univCorpusSportzalAddress = new Address("Minsk", "Skoryny", 1);
Building univCorpusSportzal = new(univCorpusSportzalAddress, univCorpusSportzalRooms);

var pedUniversityBuidings = new List<Building>
{
    univCorpus1,
    univCorpus2,
    univCorpusSportzal
};

// create University
var pedUniversity = new University(rector, universityLegalAddress, pedUniversityBuidings);

pedUniversity.AddEmloyee(employee1);
pedUniversity.AddEmloyee(employee2);
pedUniversity.AddEmloyee(employee3);
pedUniversity.AddEmloyee(employee4);
pedUniversity.AddEmloyee(employee5);
pedUniversity.AddEmloyee(employee6);
pedUniversity.AddEmloyee(employee7);
pedUniversity.AddEmloyee(employee8);

Console.WriteLine($"\nUniversity rector: {pedUniversity.Rector.GetInfo()}");
Console.WriteLine($"\nUniversity legal address: {pedUniversity.LegalAddress.GetInfo()}");
Console.WriteLine("\nUniversity Employees:");

foreach (Employee employee in pedUniversity.Employees)
{
    Console.WriteLine(employee.GetInfo());
}
Console.WriteLine("\nUniversity Buildings:");

foreach (var building in pedUniversity.Buildings)
{
    Console.WriteLine();
    Console.WriteLine(building.GetInfo());
    foreach (var room in building.Rooms )
    {
        Console.WriteLine(room.GetInfo());
    }
}

var corus1_is_corpus2 = univCorpus1.Equals(univCorpus2);
Console.WriteLine($"Corpus 1 equals corpus 2: {corus1_is_corpus2}.");

List<Employee> flteredList = pedUniversity.Employees
    .Where(employee => employee.TaxId < 1000)
    .OrderByDescending(emplo => emplo.EmployeeName)
    .ToList();

Console.WriteLine("\ntask 5:");

foreach (Employee employee in flteredList)
{
    Console.WriteLine(employee.GetInfo());
}


// 1. Выборка по первой букве имени и сортировка по TaxId
var filteredList = pedUniversity.Employees
    .Where(employee => employee.EmployeeName.StartsWith("I"))
    .OrderBy(emplo => emplo.TaxId)
    .ToList();

Console.WriteLine("\nEmployee containing 'I': ");

foreach (Employee employee in filteredList)
{
    Console.WriteLine(employee.GetInfo());
}

// 2. Выборка по преподаваемому предмету
var filteredList2 = pedUniversity.Employees
    .Where(employee => employee.EmployeeDutes == "biology")
    .OrderBy(emplo => emplo.TaxId)
    .ToList();

Console.WriteLine("\nEmployee dutes 'biology':");

foreach (Employee employee in filteredList2)
{
    Console.WriteLine(employee.GetInfo());
}

// 3. TaxId и должностные обяанности
var filteredList3 = pedUniversity.Employees.Select(emp => $"{emp.EmployeeDegree} - {emp.TaxId}");
Console.WriteLine("\nEmployee degree and TaxID:");

foreach (var duty in filteredList3)
{
    Console.WriteLine(duty);
}

// 4. Сортировка по номеру комнаты
var roomNr = 5;
var filteredList5 = pedUniversityBuidings
    .Where(building => building.Rooms.Any(r => r.RoomNumber == roomNr))
    .Select(buil => buil.BuldingAddress.GetInfo())
    .ToList();

Console.WriteLine($"\nRooms number {roomNr}");

foreach (var buildingAddress in filteredList5)
{
    Console.WriteLine(buildingAddress);
}
Console.WriteLine();

// 5. Выборка по максимальному коллчеству комнат.
var buildingWithMaxRooms = pedUniversityBuidings
    .MaxBy(build => build.Rooms.Count);

Console.WriteLine("\nAddress of building with max number of rooms:");
Console.WriteLine(buildingWithMaxRooms?.BuldingAddress.GetInfo());
Console.WriteLine($"rooms count: {buildingWithMaxRooms?.Rooms.Count}.");

// 6. Выборка по имени
var employeeWithMostOftenName = pedUniversity.Employees
    .GroupBy(x => x.EmployeeName)
    .OrderByDescending(gr => gr.Count())
    .First();

Console.WriteLine("\nEmployee with max name occurances:");
Console.WriteLine(employeeWithMostOftenName.Key);
Console.WriteLine($"names count: {employeeWithMostOftenName.Count()}.");

