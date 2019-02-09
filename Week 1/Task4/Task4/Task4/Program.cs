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
            string[,] arr = new string[100, 100];//Создали 2-мерный массив

            int n = Convert.ToInt32(Console.ReadLine());//Переводим с string в int

            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j<= i; j++)
                {
                    arr[i, j] = "[*]";

                }
            }
            for(int i = 0; i <n; i++)
            {
                for(int j = 0; j<= i; j++)
                {
                    Console.Write(arr[i, j]);//Вывод
                }
                Console.WriteLine();
            }
            Console.ReadKey();  

        }
    }
}