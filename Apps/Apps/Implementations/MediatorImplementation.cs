using DesignPatterns.Mediator;

namespace Apps.Implementations
{
    public static class MediatorImplementation
    {
        public static void Mediator_Implementation()
        {
            Console.WriteLine("**************************************************");
            Console.WriteLine("\nMediator Design Pattern\n");

            Mediator mediator = new Mediator();
            

            Teacher teacher = new Teacher(mediator);
            teacher.Name = "John";
            mediator.Teacher = teacher;

            mediator.students = new List<Student>();

            Student student = new Student(mediator);
            student.Name = "Jude";
            mediator.students.Add(student);

            Student student2 = new Student(mediator);
            student2.Name = "Jack";
            mediator.students.Add(student2);

            teacher.SendNewImageUrl("slide1.img");
            teacher.ReceiveQuestion("How you doing?", student2);

            Console.WriteLine("\n**************************************************");
        }
    }
}
