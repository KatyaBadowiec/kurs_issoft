

using System.Numerics;
using Unversty_09._01._2023;

Rector rector = new Rector("Igor Knjaz", "Doctor sciences PhD", "Professor");
Console.WriteLine("University rector: " + rector.GetInfo());
Console.WriteLine();

LegalAddress legalAddress = new LegalAddress("Minsk, Prityckogo,17");
Console.WriteLine("University legal address: " + legalAddress.GetInfo());
Console.WriteLine();

Employee employee1 = new Employee("Vasilij Pupkin", "Teacher");
Employee employee2 = new Employee("Sasha Pushkin", "Teacher");
Employee employee3 = new Employee("Ivan Durak", "Cleaner");
Employee employee4 = new Employee("Ivan Carevich", "Securety");
Employee employee5 = new Employee("Alex Popovich", "Driver");
Employee rector1 = new Employee("Igor Knjaz", "Rector");

Employee[] employees = new Employee[]
{
    employee1,
    employee2,
    employee3,
    employee4,
    employee5,
    rector1
};

for (int index = 0; index < employees.Length; index++)
{
    Employee employee = employees[index];
    Console.WriteLine(employee.GetInfo() + " " );
}
Console.WriteLine();

Room room1 = new Room("Laboratory", 23);
Room room2 = new Room("Leture", 45);
Room room3 = new Room("Semenarian", 56);
Room room4 = new Room("Auxiliary", 78);

Room[] rooms = new Room[]
{
    room1,
    room2,
    room3,
    room4,
};

for (int index = 0; index < rooms.Length; index++) 
{
    Room room = rooms[index];
    Console.WriteLine(room.GetInfo() + " " );
}
Console.WriteLine();

Address address1 = new Address("Minsk, Glebki, 58");
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