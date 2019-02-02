using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); // Вводим n  для определения размера массива

            int[] arr = new int[n];// Присваиваем n и определяем размер массива

            string[] s = Console.ReadLine().Split();//Ввод чисел через строчный массив и разделение чисел через пробел

            for(int i = 0; i < n; i++)//Парсуем строчный массив в int
            {
                arr[i] = int.Parse(s[i]);
            }
            for (int i = 0; i < arr.Length; i++)//Выводим все числа(каждую по отдельности) в массиве 2 раза
            {
                Console.Write("{0} {0} ", arr[i]);
            }
            Console.ReadLine();//Чтобы консоль не закрывалась сразу
        }
    }
}
