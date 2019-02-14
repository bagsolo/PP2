using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Student
    {
        public string s;
        public string s1;
        public int n;

        public Student(string s, string s1)
        {
            this.s = s;
            this.s1 = s1;
        }

        public string ShowName()
        {
            return s;
        }

        public string ShowID()
        {
            return s1;
        }


        public Student(int n)
        {
            this.n = n;
        }

        public int ShowYear()
        {
            return ++n;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Student st = new Student(Console.ReadLine(), Console.ReadLine());

            int k = int.Parse(Console.ReadLine());

            Student st1 = new Student(k);

            Console.WriteLine(st.ShowName());

            Console.WriteLine(st.ShowID());

            Console.WriteLine(st1.ShowYear());

            Console.ReadKey();



        }
    }
}