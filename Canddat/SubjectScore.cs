namespace Canddat
{
    public class SubjectScore
    {
        public string Subject { get; set; }
        public int Score { get; set; }

        public SubjectScore(string subject, int score)
        {
            Subject = subject;
            Score = score;
        }
    }
}
