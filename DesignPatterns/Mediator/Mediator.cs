using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Mediator
{
    /*
      * Mediator Design Pattern farklı sistemleri birbiri ile görüştürmek için kullanılır.
        Uzaktan online eğitim veren bir öğretmeni düşünün, öğrenciler ve öğretmen bir uygulama vasıtasıyla
        iletişim kuracaktır. Öğrenci sorusunu uygulama aracılığıyla hocasına gönderir veya Hoca cevabını
        uygulama aracılığıyla öğrenciye gönderir.
    */
    public abstract class CourseMember
    {
        /*
          * Teacher'ın ve Student'in iletişim kurabilmeleri için birer mediator'a ihtiyacı var.
            Öyleyse bu mediator CourseMember abstract class'ının içine tanımlanmalıdır.
        */

        protected Mediator Mediator;

        protected CourseMember(Mediator mediator)
        {
            Mediator = mediator;
        }
    }

    public class Teacher : CourseMember
    {
        public string Name { get; set; }
        public Teacher(Mediator mediator) : base(mediator)
        {
        }

        public void ReceiveQuestion(string question, Student student)
        {
            Console.WriteLine($"Teacher {Name} recieved a question from {student.Name}, the question is \"{question}\"");
        }

        public void SendNewImageUrl(string url)
        {
            Console.WriteLine($"Teacher {Name} changed slide : {url}");
            Mediator.UpdateImage(url);
        }

        public void AnswerQustion(string answer, Student student)
        {
            Console.WriteLine($"Teacher {Name} answered question of {student.Name}, the answer is \"{answer}\"");
        }
    }

    public class Student : CourseMember
    {
        public string Name { get; set; }
        public Student(Mediator mediator) : base(mediator)
        {
        }

        public void ReceiveImage(string url)
        {
            Console.WriteLine($"Student {Name} received image : {url}");
        }

        internal void ReceiveAnswer(string answer)
        {
            Console.WriteLine($"Student {Name} received answer : {answer}");
        }
    }

    public class Mediator
    {
        public Teacher Teacher { get; set; }
        public List<Student> students { get; set; }

        public void UpdateImage(string url)
        {
            foreach (Student student in students)
            {
                student.ReceiveImage(url);
            }
        }

        public void SendQustion(string question, Student student)
        {
            Teacher.ReceiveQuestion(question, student);
        }

        public void SendAnswer(string answer, Student student)
        {
            student.ReceiveAnswer(answer);
        }
    }
}
