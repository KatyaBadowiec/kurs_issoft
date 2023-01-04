// See https://aka.ms/new-console-template for more information
using System.Xml.Linq;


Candidate[] candidates = new Candidate[5];


Candidate c1 = new Candidate();

Address addresscandidate1  = new Address();
addresscandidate1.city = "Minsk";
addresscandidate1.street = "ul. Glebki";
addresscandidate1.house = "58";
addresscandidate1.flat = "109";

Person person1 = new Person();
person1.firstName = "Marta";
person1.lastName = "Nelman";
person1.address = addresscandidate1;
c1.PersonData = person1;

c1.subjectScores = new SubjectScore[3];

SubjectScore math = new SubjectScore();
math.Score = 90;
math.Subject = "mathematics";
c1.subjectScores[0] = math;

SubjectScore liter = new SubjectScore();
liter.Score = 80;
liter.Subject = "literature";
c1.subjectScores[1] = liter;

SubjectScore biol = new SubjectScore();
biol.Score = 89;
biol.Subject = "biology";
c1.subjectScores[2] = biol;

candidates[0] = c1;


Candidate c2 = new Candidate();
Person person2 = new Person();
Address addresscandidate2 = new Address();

addresscandidate2.city = "Minsk";
addresscandidate2.street = "ul. Sloneczna";
addresscandidate2.house = "24";
addresscandidate2.flat = "17";

person2.firstName = "Pawel";
person2.lastName = "Newerowski";
person2.address = addresscandidate2;
c2.PersonData = person2;

c2.subjectScores = new SubjectScore[3];
SubjectScore math2 = new SubjectScore();
math2.Score = 95;
math2.Subject = "mathematics";
c2.subjectScores[0] = math2;
SubjectScore liter2 = new SubjectScore();
liter2.Score = 87;
liter2.Subject = "literature";
c2.subjectScores[1] = liter2;
SubjectScore biol2 = new SubjectScore();
biol2.Score = 88;
biol2.Subject = "biology";
c2.subjectScores[2] = biol2;

candidates[1] = c2;

Candidate c3 = new Candidate();
Person person3 = new Person();
Address addresscandidate3 = new Address();

addresscandidate3.city = "Minsk";
addresscandidate3.street = "ul. Plomyka";
addresscandidate3.house = "16";
addresscandidate3.flat = "22";

person3.firstName = "Maja";
person3.lastName = "Kaplan";
person3.address = addresscandidate3;
c3.PersonData = person3;

c3.subjectScores = new SubjectScore[3];
SubjectScore math3 = new SubjectScore();
math3.Score = 85;
math3.Subject = "mathematics";
c3.subjectScores[0] = math3;
SubjectScore liter3 = new SubjectScore();
liter3.Score = 87;
liter3.Subject = "literature";
c3.subjectScores[1] = liter3;
SubjectScore biol3 = new SubjectScore();
biol3.Score = 88;
biol3.Subject = "biology";
c3.subjectScores[2] = biol3;

candidates[2] = c3;

Candidate c4 = new Candidate();
Person person4 = new Person();
Address addresscandidate4 = new Address();

addresscandidate4.city = "Minsk";
addresscandidate4.street = "ul. Witki";
addresscandidate4.house = "146";
addresscandidate4.flat = "33";

person4.firstName = "Tomasz";
person4.lastName = "Lapinski";
person4.address = addresscandidate4;

c4.PersonData = person4;
c4.subjectScores = new SubjectScore[3];
SubjectScore math4 = new SubjectScore();
math4.Score = 94;
math4.Subject = "mathematics";
c4.subjectScores[0] = math4;
SubjectScore liter4 = new SubjectScore();
liter4.Score = 87;
liter4.Subject = "literature";
c4.subjectScores[1] = liter4;
SubjectScore biol4 = new SubjectScore();
biol4.Score = 88;
biol4.Subject = "biology";
c4.subjectScores[2] = biol4;

candidates[3] = c4;

Candidate c5 = new Candidate();
Person person5 = new Person();
Address addresscandidate5 = new Address();

addresscandidate5.city = "Minsk";
addresscandidate5.street = "ul. Kwiatowa ";
addresscandidate5.house = "16";
addresscandidate5.flat = "51";

person5.firstName = "Kinga";
person5.lastName = "Kruk";
person5.address = addresscandidate4;
c5.PersonData = person5;

c5.subjectScores = new SubjectScore[3];

SubjectScore math5 = new SubjectScore();
math5.Score = 90;
math5.Subject = "mathematics";
c5.subjectScores[0] = math5;

SubjectScore liter5 = new SubjectScore();
liter5.Score = 80;
liter5.Subject = "literature";
c5.subjectScores[1] = liter;

SubjectScore biol5 = new SubjectScore();
biol5.Score = 89;
biol5.Subject = "biology";
c5.subjectScores[2] = biol5;
candidates[4] = c5;

int maxMathScoe = -1;
string maxMathScoeCandidateName = "";
int candidatesCount = candidates.Length;
for (int i = 0; i < candidatesCount; i++)
{
    Candidate currentCandidate = candidates[i];
    Console.WriteLine(currentCandidate.PersonData.firstName);
    Console.WriteLine(currentCandidate.PersonData.address.street);

    for (int j = 0; j < currentCandidate.subjectScores.Length; j++)
    {
        if (currentCandidate.subjectScores[j].Subject == "mathematics")
        {
            if (currentCandidate.subjectScores[j].Score > maxMathScoe)
            {
                maxMathScoe = currentCandidate.subjectScores[j].Score;
                maxMathScoeCandidateName = currentCandidate.PersonData.firstName;
            }
            Console.WriteLine("mathematics score = " + currentCandidate.subjectScores[j].Score);
        }
    }
}

Console.WriteLine();
Console.Write("mathematics max score = ");
Console.Write(maxMathScoe);
Console.WriteLine();
Console.WriteLine("for candidate " + maxMathScoeCandidateName);



class Candidate
{
    public Person PersonData;
    public SubjectScore[] subjectScores ; 
}

internal class Person
{
    public string firstName;
    public string lastName;
    public Address address;
}

internal class Address
{
    public string city;
    public string street;
    public string house;
    public string flat;
}

internal class SubjectScore
{
    public string Subject;
    public int Score;
}

internal class Subject
{
    public string math;
    public string literatura;
    public string biology;
}
