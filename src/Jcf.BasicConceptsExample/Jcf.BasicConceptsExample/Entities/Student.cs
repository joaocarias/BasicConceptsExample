namespace Jcf.BasicConceptsExample.Entities
{
    public class Student : Person
    {
        public string Class { get; private set; }   
        public IEnumerable<int> Scores {  get; set; }   


        public Student(string @class, string name, string document, DateTime bornAt) : base(name, document, bornAt)
        {
            Class = @class;
            Scores = new List<int>() { 10, 10, 4, 2, 3, 5};
        }

        public override string Description()
        {            
            var averageScores = Scores.Average();
            return base.Description() + $"\n I'm Student of the class {Class}, My Average Score is {averageScores} ";
        }
    }
}
