namespace UniversityProject
{
    internal class University
    {
        public Rector Rector { get; set; }
        public Address LegalAddress { get; set; }
        public List<Employee> Employees { get; set; }
        public List<Building> Buildings { get; set; }

        public University(
            Rector rector,
            Address legalAddress,
            List<Employee> universityEmployees,
            List<Building> universityBuildings            
            )
        {
            Rector = rector;
            LegalAddress = legalAddress;
            Employees = universityEmployees;
            Buildings = universityBuildings;
        }

        public virtual string GetOficialDuties()
        {
            return "";
        }
    }
}