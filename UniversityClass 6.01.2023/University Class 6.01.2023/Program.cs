using University_Class_6._01._2023;

Person person1 = new ("Vasilj", "Pupkin");
Person person2 = new ("Petr","Solncev");
Person person3 = new ("Marta", "Milaja");
Person person4 = new ("Kinga", "Sladkaja");
Person person5 = new ("Irina", "Swetlaja");
Person person6 = new ("Vera", "Privet");

Course chemistry = new ("Chemistry", "Doing chem");
Course math = new ("Mathematic", "Doing math");
Course biology = new ("Biology", "Doing bio");

Teacher chemTeacher = new (person1, 100, chemistry);
Teacher mathTeacher = new (person2, 200, math);
Teacher bioTeacher = new (person3, 300, biology);

SupportStaff driver = new (person4, 400, "Driver", "Driving a car");
SupportStaff cleanner = new (person5, 500, "Cleaner", "Doing cleanning");
SupportStaff securityGuard = new (person6, 600, "Security", "Securing");

University_Employee[] employees = new University_Employee[]    
{
    chemTeacher,
    mathTeacher,
    bioTeacher,
    driver,
    cleanner,
    securityGuard
};

for (int index = 0; index < employees.Length; index++)
{
    University_Employee employee = employees[index];
    Console.WriteLine(employee.PersonalData.GetInfo() + "   " + employee.GetOficialDuties());
}

Console.WriteLine("\nOnly teachers:");

foreach (var employee in employees) 
{
    if (employee is Teacher)
        Console.WriteLine(employee.PersonalData.GetInfo());
}






