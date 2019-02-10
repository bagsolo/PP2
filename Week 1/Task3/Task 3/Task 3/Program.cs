using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Program
    {
        public static int[] Twice(int[] a)
        {
            int[] twice = new int[a.Length * 2];//Увеличиваем размер массива в 2 раза

            for(int i = 0; i < a.Length; i++)//Цикл для повтора элементов
            {
                int temp = a[i];
                twice[2 * i] = twice[2 * i + 1] = a[i];
            }
            return twice;
        }

        static void Show(int[] a)
        {
            foreach(var x in a)
            {
                Console.Write(x + " ");//Выводим числа
            }
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());//Задаём размер массива

            string[] ss = Console.ReadLine().Split();//Для ввода строки и деления по пробелам

            int[] arr = new int[n];//Массив размера n

            for(int i= 0; i < n; i++)
            {
                arr[i] = int.Parse(ss[i]);//Переводим со string в int
            }

            int[] ans = Twice(arr);//Вызываем функцию

            Show(ans);//Вызываем функция
            Console.ReadKey();
        }
    }
}
