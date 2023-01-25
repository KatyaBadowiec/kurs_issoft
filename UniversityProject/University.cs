namespace UniversityProject
{
    public class University
    {
        public Rector Rector { get; set; }
        public Address LegalAddress { get; set; }
        public List<Employee> Employees { get; set; }
        public List<Building> Buildings { get; set; }

        public University(
            Rector rector,
            Address legalAddress,
            List<Building> universityBuildings            
            )
        {
            Rector = rector;
            LegalAddress = legalAddress;
            Buildings = universityBuildings;
            Employees = new List<Employee>();
        }
        /*
        public void AddEmloyee(Employee newEmployee)
        {
            Employees.Add(newEmployee);
        }
        */
        public virtual string GetOficialDuties()
        {
            return "";
        }

       /* public override bool Equals(object? obj)
        {
            if (obj == null) return false;
            Employee other = obj as Employee;

            if (this.newEmployees != other.Employees)
                return false;

            return true;
        }*/

        public void AddEmloyee(Employee employee)
        {
            bool sameEmpFound = false;
            foreach (Employee emp in Employees)
            {
                if (emp.Equals(employee))
                {
                    sameEmpFound = true;
                    break;
                }
            }

            if (!sameEmpFound)
            {
                Employees.Add(employee);
            } 
        }
    }
}