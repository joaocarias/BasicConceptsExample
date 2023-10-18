using Jcf.BasicConceptsExample.Entities;

var student = new Student("A", "Joao Carias", "074.981.014-06", DateTime.Now.AddYears(-15));
var teacher = new Teacher(5000, "Ana Maria", "873.982.004-50", DateTime.Now.AddYears(-40));

Console.WriteLine(student.Description());
Console.WriteLine(teacher.Description());
