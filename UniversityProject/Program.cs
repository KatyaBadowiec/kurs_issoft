using UniversityProject;

Rector rector = new Rector("Kinga Kniga", "Doctor sciences PhD", 2230, "Professor");
Address universityLegalAddress = new Address("Minsk", "Prityckogo", 17);

Employee employee1 = new ("Vasilij Pupkin", "Teacher", 1233);
Employee employee2 = new ("Sasha Pushkin", "Teacher", 1234);
Employee employee3 = new ("Ivan Durak", "Cleaner", 1236);
Employee employee4 = new ("Ivan Carevich", "Securety", 1237);
Employee employee5 = new ("Alex Popovich", "Driver", 1239);
Employee employee6 = new("Maxim Fox", "Teacher", 1355);


List<Employee> employees = new List<Employee>
{
    employee1,
    employee2,
    employee3,
    employee4,
    employee5,
    employee6
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
Room univCorpus2room1 = new Room("Laboratory", 234);
Room univCorpus2room2 = new Room("Leture", 5);

List<Room> univCorpus2Rooms = new List<Room>
{
    univCorpus2room1,
    univCorpus2room2
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

if (rector != null)


/**/
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
Console.WriteLine(corus1_is_corpus2);



