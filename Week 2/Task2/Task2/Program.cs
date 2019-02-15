using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task2
{
    class Program
    { 
    
        static bool Boolean(int k)//Функция на проверку чисел 
        {
            if (k == 1)
                return false;
            for(int i = 2; i < Math.Sqrt(k); i++)
            {
                if (k % i == 0)
                    return false;
            }
            return true;
        }
    
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(@"C:\Users\PC\Desktop\PP2\Week 2\Task2\input.txt");//Путь к файлу

            string s = sr.ReadLine();

            string[] arr = s.Split();

            int[] sum = new int[arr.Length];

            for(int i = 0; i < sum.Length; i++)//Цикл перевода из строк в числа
            {
                sum[i] = int.Parse(arr[i]);
            }

            sr.Close();

            string prime = "";//Пустая строка

            for(int i = 0; i < sum.Length; i++)//Цикл добавления простых чисел
            {
                if (Boolean(sum[i]))
                {
                    prime += sum[i] + " ";
                }

            }

            StreamWriter sw = new StreamWriter(@"C:\Users\PC\Desktop\PP2\Week 2\Task2\output.txt");//Путь к файлу для выовда

            sw.WriteLine("{0} ", prime);//Вывод
            sw.Close();

        }
    }
}
