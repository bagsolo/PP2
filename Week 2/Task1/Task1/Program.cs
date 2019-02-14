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
       static void Do()
        {
            StreamReader sr = new StreamReader(@"C:\Users\PC\Desktop\PP2\Week 2\Task1\input.txt");

            string Reverse = "";//Создаем пустую строку

            string s = sr.ReadToEnd();

            //Вводим строку
            for (int i = s.Length - 1; i >= 0; i--)//Делаем обратный массив
            {
                Reverse += s[i];//Присваем значение массива 
            }
            if (Reverse == s)//Сравниваем две строки
            {
                Console.WriteLine("Yes");//Выводим Yes если строка совпадает
            }
            else Console.WriteLine("No");// Выводим No если строка не совпадает
            Console.ReadKey();//Чтобы консоль сразу не закрывалась
            sr.Close();
        }

        static void Main(string[] args)
        {
            Do();
            Console.ReadKey();
        }
    }
    }

