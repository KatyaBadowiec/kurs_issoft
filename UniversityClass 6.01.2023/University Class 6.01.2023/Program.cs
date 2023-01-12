using University_Class_6._01._2023;

Person person1 = new Person("Vasilj", "Pupkin");
Person person2 = new Person("Petr","Solncev");
Person person3 = new Person("Marta", "Milaja");
Person person4 = new Person("Kinga", "Sladkaja");
Person person5 = new Person("Irina", "Swetlaja");
Person person6 = new Person("Vera", "Privet");

Course chemistry = new Course("Chemistry", "Doing chem");
Course math = new Course("Mathematic", "Doing math");
Course biology = new Course("Biology", "Doing bio");

Teacher chemTeacher = new Teacher(person1, 100, chemistry);
Teacher mathTeacher = new Teacher(person2, 200, math);
Teacher bioTeacher = new Teacher(person3, 300, biology);

SupportStaff driver = new SupportStaff(person4, 400, "Driver", "Driving a car");
SupportStaff cleanner = new SupportStaff(person5, 500, "Cleaner", "Doing cleanning");
SupportStaff securityGuard = new SupportStaff(person6, 600, "Security", "Securing teritory");

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

Console.WriteLine();
Console.WriteLine("Only teachers:");

for (int index = 0; index < employees.Length; index++)
{
    University_Employee employee = employees[index];
    if (employee is Teacher)
        Console.WriteLine(employee.PersonalData.GetInfo());
}





