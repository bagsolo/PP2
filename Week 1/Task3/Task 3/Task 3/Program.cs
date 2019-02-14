using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Program
    {
        
        
       static int[] DoubleNum(int[] arr)
        {
            int[] arrx2 = new int[arr.Length * 2];//Увеличиваем наш массив в 2 раза
            int cnt = -1;
            for(int i = 0; i < arr.Length; i++)//Цикл в котором значение первого массива передаются во второй и дублируются
            {
                cnt++;
                arrx2[cnt] = arr[i];
                cnt++;
                arrx2[cnt] = arr[i];
            }
            return arrx2;//Возвращаем наш ответ
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());//Задаём длинну массиву наших чисел
            string s = Console.ReadLine();//Вводим наши числа
            string[] sArr = s.Split();//Вписываем наши числа в массив строк и делим по пробелам
            int[] dArr = new int[n];//Массив для перевода наших чисел из string в int
            
            for(int j = 0; j < n; j++)//Цикл для перевода чисел из типа string в тип int
            {
                dArr[j] = int.Parse(sArr[j]);
            }

            int[] Show = DoubleNum(dArr);//Даём значения метода в новый массив

            for (int j = 0; j < Show.Length; j++)//Выводим наш ответ через цикл
            {
                Console.Write(Show[j] + " ");

            }
            Console.ReadKey();//Чтобы наша консоль сразу не закрывалась
        }
    }
}
