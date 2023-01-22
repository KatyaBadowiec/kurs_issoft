namespace UniversityProject
{
    public class Rector : Employee
    {
        public string RectorDegree { get; set; }

        public Rector(string employeeName, string employeeDegree, string rectorDegree)
            : base(employeeName, employeeDegree)
        {
            RectorDegree = rectorDegree;
        }

        public override string GetInfo() 
        {
            return base.GetInfo() + $" Status: {RectorDegree}.";
        }
    }
}