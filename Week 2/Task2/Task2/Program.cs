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
    
        static bool Boolean(int k)//Конструктор для проверки простоты чисел
        { 
        if (k == 1) return false;//Условаия для того чтобы указать что 1 этоо не простое число
        for (int i = 2; i < Math.Sqrt(k); i++)//Cоздаём цикл
        {
            if (k % i == 0) return false;//Делимость для не простых чисел
        }
        return true;//Если она проходит все условия и не возвращает false то возвращаем значение true
    }
    
        static void Main(string[] args)
        {
            FileStream fs = new FileStream(@"C:\Users\PC\Desktop\PP2\Week 2\Task2\input.txt", FileMode.Open, FileAccess.Read);//Пишем путь к нашему input.txt
            StreamReader sr = new StreamReader(fs);//Считываем файл

            string s = sr.ReadLine();//Передаём считывание в программу

            String[] arr = s.Split();//Создаём массив из этих строк и разделяем их

            int[] sum = new int[arr.Length];//Cоздаём массив чисел равный длинне наших строк


            for (int i=0; i < sum.Length; i++)//Создаём цикл
            {
                sum[i] = int.Parse(arr[i]);//Переводим из типа string в тип int
            }
           // int n = 0;
            sr.Close();//Закрываем считыватель
           
            string prime = "";//Создаём пустую строку
            for (int i = 0; i < sum.Length; i++)
            {
                if (Boolean(sum[i]))
                {
                    prime +=  sum[i] + " ";//Добавляем к нашей пустой строке простые числа
                }
            }
            FileStream fs2 = new FileStream(@"C: \Users\PC\Desktop\PP2\Week 2\Task2\output.txt", FileMode.Open, FileAccess.Write);//Вписываем данные в output.txt
            StreamWriter sw = new StreamWriter(fs2);//Открываем для вписывания значения в наш output.txt


            //prime.Trim();

             sw.WriteLine( prime+" ");//Вписываем простые числа
            sw.Close();//Закрываем вписыватель
        }
    }
}
