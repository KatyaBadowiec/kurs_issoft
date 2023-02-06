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

        public virtual string GetOficialDuties()
        {
            return "";
        }

        public void AddEmloyee(Employee employee)
        {
            if (!Employees.Contains(employee)) 
            { 
                Employees.Add(employee); 
            }
        }
    }
}