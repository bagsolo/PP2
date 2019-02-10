using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task1
{
    class Program
    {
       

        static void Main(string[] args)
        {

            string Reverse = "";//Создаем пустую строку

            string s;//Создаём строку

            s = Console.ReadLine();//Вводим строку
            for(int i = s.Length-1; i >=0; i--)//Делаем обратный массив
            {
                Reverse += s[i];//Присваем значение массива 
            }
            if (Reverse == s)//Сравниваем две строки
            {
                Console.WriteLine("Yes");//Выводим Yes если строка совпадает
            }
            else Console.WriteLine("No");// Выводим No если строка не совпадает
            Console.ReadKey();//Чтобы консоль сразу не закрывалась
           
        }
    }
    }

