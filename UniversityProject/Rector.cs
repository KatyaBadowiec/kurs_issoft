namespace UniversityProject
{
    public class Rector : Employee
    {
        public string RectorDegree { get; set; }

        public Rector(string employeeName, string employeeDegree, int taxId, string rectorDegree)
            : base(employeeName, employeeDegree, taxId)
        {
            RectorDegree = rectorDegree;
        }

        public override string GetInfo() 
        {
            return base.GetInfo() + $" Status: {RectorDegree}.";
        }
    }
}