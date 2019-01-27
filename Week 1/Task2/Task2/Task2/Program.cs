using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Student
    {
        public string name;
        public string id;
        public int course;

        public Student(string name, string id, int course)
        {
            this.name = name;
            this.id = id;
            this.course = course;
        }
        public void print()
        {
            Console.WriteLine("Имя студента: {0}", name);
            Console.WriteLine("ID студента: {0}", id);
            
            if (course == 4) Console.WriteLine("В следующем году вы получите диплом бакалавриата");
            if (course > 4 && course <= 6) Console.WriteLine("Вы учитесь на магистра! Удачи!");
            if (course > 6 && course <= 9) Console.WriteLine("Доброго времени суток Доктор!");
            if(course < 4)
            {
                course++;
                Console.WriteLine("В следующем году вы будете учиться на {0} курсе", course);
                    
            }
        }

    }

    class Program
    {
       
        static void Main(string[] args)
        {
            Console.WriteLine("Введите на клавиатуре ваше имя, ID, и курс");
            Student st1 = new Student(Console.ReadLine(), Console.ReadLine(), int.Parse(Console.ReadLine()));
            st1.print();
            Console.WriteLine("Для продолжения нажмите 'ENTER'");
            Console.ReadLine();
        }
    }
}
