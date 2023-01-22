namespace UniversityProject
{
    public class Employee
    {
        public string EmployeeName { get; set; }
        public string EmployeeDegree { get; set; }

        public Employee(string employeeName, string employeeDegree)
        {
            EmployeeName = employeeName;
            EmployeeDegree = employeeDegree; 
        }
       
        public virtual string GetInfo()
        {
            return $"Name: {EmployeeName}. Degree: {EmployeeDegree}.";
        }
    }
}

