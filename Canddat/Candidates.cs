namespace Canddat
{    
    public class Candidates
    {
        public Person Person { get; set; }
        public SubjectScore[] SubjectScores { get; set; }

        public Candidates(Person person, SubjectScore[] scores) 
        {
            Person = person;
            SubjectScores = scores;
        }

        public virtual string GetInfo()
        {
            return $"{Person} - {SubjectScores}";
        }
    }
}

