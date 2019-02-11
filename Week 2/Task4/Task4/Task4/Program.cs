using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TestCopyCreateDelete
{
    class Program
    {
        static void Main(string[] args)
        {
            string FileName = "text.txt";//Даём имя файлу 
            string sourcePath = @"C:\Users\PC\Desktop\PP2\Week 2\Task4\path";//Путь к папке источнику
            string targetPath = @"C:\Users\PC\Desktop\PP2\Week 2\Task4\path1";//Путь к папке в которую надо переместить

            string sourceFile = System.IO.Path.Combine(sourcePath, FileName);//Связываю файл с источником
            string destFile = System.IO.Path.Combine(targetPath, FileName);//и с папкой в которую надо переместить

            if (!System.IO.Directory.Exists(targetPath))//Услвоия если папки не существует
            {
                System.IO.Directory.CreateDirectory(targetPath);
            }
            System.IO.File.Copy(sourceFile, destFile, true);//Копируем папку

            if (System.IO.Directory.Exists(sourcePath))//Услвоия для перемещения файла с папки в другую папку
            {
                string[] files = System.IO.Directory.GetFiles(sourcePath);//Массив для файла
                
                foreach (string s in files)//Для копирования файла и перезаписи если он уже существует
                {
                    FileName = System.IO.Path.GetFileName(s);//Извлекаем имя файла из пути
                    destFile = System.IO.Path.Combine(targetPath, FileName);
                    System.IO.File.Copy(s, destFile, true);
                }
            }
            if (System.IO.File.Exists(@"C:\Users\PC\Desktop\PP2\Week 2\Task4\path\text.txt"))
            {
                try
                {
                    System.IO.File.Delete(@"C:\Users\PC\Desktop\PP2\Week 2\Task4\path\text.txt");//Удаление файла
                }
                catch (System.IO.IOException e)//Для показа ошибки если файла не будет
                {
                    Console.WriteLine(e.Message);
                    return;
                }
            }
            else
            {
                Console.WriteLine("Source path does not exist");//Если папки источника не будет существовать
            }
            Console.ReadKey();//Для того чтобы консоль сразу не закрывалась
        }
    }
}
