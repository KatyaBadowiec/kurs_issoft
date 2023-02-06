namespace UniversityProject
{
    public class Employee
    {
        public string EmployeeName { get; set; }
        public string EmployeeDegree { get; set; }
        public string EmployeeDutes { get; set; }
        public int TaxId { get; set; }

        public Employee(string employeeName, string employeeDegree, string employeeDutes, int taxId)
        {
            EmployeeName = employeeName;
            EmployeeDegree = employeeDegree;
            EmployeeDutes = employeeDutes;
            TaxId = taxId;
        }
       
        public virtual string GetInfo()
        {
            return $"Name: {EmployeeName}. Degree: {EmployeeDegree}. Dutes: {EmployeeDutes}. TaxId: {TaxId}.";
        }

        public override bool Equals(object? obj)
        {
            if (obj == null) return false;
            Employee other = obj as Employee;

            if (this.TaxId != other.TaxId) 
                return false;
            
            return true;
        }
    }
}

