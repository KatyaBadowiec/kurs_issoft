using Canddat;

Address address1 = new("Minsk", "Gebki", 58, 10);
Person person1 = new("Valentina", "Petrova", address1);
SubjectScore[] subjscore1 = new SubjectScore[]
{
    new ("mathematic", 350),
    new ("literatura", 400),
    new ("bialogy", 390)
};
Candidates candidate1 = new(person1, subjscore1);

Address address2 = new("Minsk", "Grushewskaja", 136, 15);
Person person2 = new("Inga", "Gering", address2);
SubjectScore[] subjscore2 = new SubjectScore[]
{
    new ("mathematic", 360),
    new ("literatura", 300),
    new ("bialogy", 370)
};
Candidates candidate2 = new(person2, subjscore2);

Address address3 = new("Milan", "Prjamaja", 23, 24);
Person person3 = new("Magda", "Fox", address3);
SubjectScore[] subjscore3 = new SubjectScore[]
{
    new ("mathematic", 330),
    new ("literatura", 340),
    new ("bialogy", 290)
};
Candidates candidate3 = new(person3, subjscore3);

Address address4 = new("Vitebsk", "Glavnaja", 56, 26);
Person person4 = new("Marta", "Milaja", address4);
SubjectScore[] subjscore4 = new SubjectScore[]
{
    new ("mathematic", 380),
    new ("literatura", 300),
    new ("bialogy", 350)
};
Candidates candidate4 = new(person4, subjscore4);

Address address5 = new("Vilejka", "Cvetnaja", 59, 109);
Person person5 = new("Irina", "Privet", address5);
SubjectScore[] subjscore5 = new SubjectScore[]
{
    new ("mathematic", 370),
    new ("literatura", 400),
    new ("bialogy", 390)
};
Candidates candidate5 = new(person5, subjscore5);

Candidates[] candidates = new Candidates[]
{
    candidate1,
    candidate2,
    candidate3,
    candidate4,
    candidate5
};

foreach (var candidate in candidates)
{
    Console.WriteLine(candidate.Person.Address.Street);
}

string subjectToCheck = "mathematic";
int maxScore = int.MinValue;
Person candidateWithMaxScore = null;
foreach (var currentCandidate in candidates)
{
    foreach (var subjectScore in currentCandidate.SubjectScores)
    {
        if (subjectScore.Subject == subjectToCheck)
        {
            if (subjectScore.Score > maxScore)
            {
                maxScore = subjectScore.Score;
                candidateWithMaxScore = currentCandidate.Person;
            }
        }
    }
}

Console.WriteLine($"Person '{candidateWithMaxScore.FirstName} {candidateWithMaxScore.LastName}' has " +
    $"max score '{maxScore}' in {subjectToCheck}.");


