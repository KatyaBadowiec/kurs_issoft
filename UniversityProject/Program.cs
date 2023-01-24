using UniversityProject;

Rector rector = new Rector("Kinga Kniga", "Doctor sciences PhD", "Professor");
Address universityLegalAddress = new Address("Minsk", "Prityckogo", 17);

Employee employee1 = new ("Vasilij Pupkin", "Teacher");
Employee employee2 = new ("Sasha Pushkin", "Teacher");
Employee employee3 = new ("Ivan Durak", "Cleaner");
Employee employee4 = new ("Ivan Carevich", "Securety");
Employee employee5 = new ("Alex Popovich", "Driver");

List<Employee> employees = new List<Employee> 
{
    employee1,
    employee2,
    employee3,
    employee4,
    employee5
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
var pedUniversity = new University(rector, universityLegalAddress, employees, pedUniversityBuidings);

Console.WriteLine($"University rector: {pedUniversity.Rector.GetInfo()}");
Console.WriteLine($"University legal address: {pedUniversity.LegalAddress.GetInfo()}");
Console.WriteLine("University Employees:");
foreach (Employee employee in pedUniversity.Employees)
{
    Console.WriteLine(employee.GetInfo());
}
Console.WriteLine("University Buildings:");
foreach (var building in pedUniversity.Buildings)
{
    Console.WriteLine(building.GetInfo());
    foreach (var room in building.Rooms )
    {
        Console.WriteLine(room.GetInfo());
    }
}


/*

Address address2 = new Address("Minsk, Pushkna,26");

Address[] addresses = new Address[] 
{
    address1, 
    address2 
};
Console.WriteLine("University addresses: ");
for (int index = 0;index < addresses.Length; index++)
{
    Address address= addresses[index];
    Console.WriteLine(address.GetInfo());
}
*/
