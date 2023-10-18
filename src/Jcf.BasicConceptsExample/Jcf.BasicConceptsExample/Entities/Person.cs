namespace Jcf.BasicConceptsExample.Entities
{
    public abstract class Person
    {
        public string Name { get; protected set; }
        public string Document { get; protected set; }
        public DateTime BornAt { get; protected set; }

        public Person(string name, string document, DateTime bornAt)
        {
            Name = name;
            Document = document;
            BornAt = bornAt;
        }

        
        public virtual string Description()
        {
            return
                $"Hello, My name is {Name}, Document Number {Document} and Born At {BornAt.Date}";
        }
    }
}
