namespace Jcf.BasicConceptsExample.Entities
{
    public class Teacher : Person
    {
        public decimal Salary { get; private set; }
        public IEnumerable<string> Classes { get; private set; }

        public Teacher(decimal salary, string name, string document, DateTime bornAt)
            : base(name, document, bornAt)
        {
            Salary = salary;
            Classes = new List<string>() { "A", "B", "C", "D" };
        }

        public override string Description()
        {
            var description = base.Description();   
            var classes = string.Join(", ", Classes);            

            return description + $"\n My salary is {Salary}, and teaching in classes {classes}";
        }
    }
}
