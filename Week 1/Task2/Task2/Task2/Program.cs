using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Student//Объвляем класс студент и пишем туда данные которые нам нужно вывести
    {
        //Имя это s, Id это s1, год обучения это n
        public string s;
        public string s1;
        public int n;

        public Student(string s, string s1)//Создаём конструктор с двумя параметрами
        {
            //Квалифицируем элементы
            this.s = s;
            this.s1 = s1;
        }

        public string ShowName()//Метод для возвращения имени
        {
            return s;
        }

        public string ShowID()//Метод для возвращения ID
        {
            return s1;
        }


        public Student(int n)//Конструктор для 
        {
            //Квалифицируем элемент
            this.n = n;
        }

        public int ShowYear()//Метод возвращения года
        {
            //Возвращаем увеличенный год
            return ++n;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            //Вводим данные имени и ID
            Student st = new Student(Console.ReadLine(), Console.ReadLine());

            //k будет нашим годом обучения
            int k = int.Parse(Console.ReadLine());
            //Вводим данные о годе обучения
            Student st1 = new Student(k);
            //Вызываем метод для имени
            Console.WriteLine(st.ShowName());

            //Вызываем метод для ID
            Console.WriteLine(st.ShowID());

            //Вызывваем метод для Года
            Console.WriteLine(st1.ShowYear());

            //Чтобы консоль сразу не закрывалась
            Console.ReadKey();



        }
    }
}