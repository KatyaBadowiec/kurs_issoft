namespace UniversityProject
{
    public class Rector : Employee
    {
        public string RectorDegree { get; set; }

        public Rector(string employeeName, string employeeDegree, string employeeDutes, int taxId, string rectorDegree)
            : base(employeeName, employeeDegree, employeeDutes, taxId)
        {
            RectorDegree = rectorDegree;
        }

        public override string GetInfo() 
        {
            return base.GetInfo() + $" Status: {RectorDegree}.";
        }
    }
}