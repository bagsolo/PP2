using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());//Задаём высоту нашей треугольника

            for(int i = 1; i <= n; i++)//Цикл для вывода треугольника
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("[*]");
                   

                }
                Console.WriteLine();//Делит по блокам
            }

            Console.ReadKey();  

        }
    }
}