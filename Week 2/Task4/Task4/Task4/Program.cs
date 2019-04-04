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
            string FileName = "text.txt";
            string sourcePath = @"C:\Users\PC\Desktop\PP2\Week 2\Task4\path";
            string targetPath = @"C:\Users\PC\Desktop\PP2\Week 2\Task4\path1";

            string sourceFile = System.IO.Path.Combine(sourcePath, FileName);//Связывание папок и файлов
            string destFile = System.IO.Path.Combine(targetPath, FileName);

            if (System.IO.Directory.Exists(sourcePath))//Функция для копирования
            {
                string[] files = System.IO.Directory.GetFiles(sourcePath);
                
                foreach(string s in files)
                {
                    FileName = System.IO.Path.GetFileName(s);
                    destFile = System.IO.Path.Combine(targetPath, FileName);
                    System.IO.File.Copy(s, destFile, true);
                }
            }
            if(System.IO.File.Exists(@"C:\Users\PC\Desktop\PP2\Week 2\Task4\path\text.txt"))//Функция для удаления
            {
                try
                {
                    System.IO.File.Delete(@"C:\Users\PC\Desktop\PP2\Week 2\Task4\path\text.txt");
                }
                catch
                {
                    Console.WriteLine("Error file does not exist");
                    return;
                }
            }
            else
            {
                Console.WriteLine("Source path does not exist");
            }
            Console.ReadKey();
        }
    }
}
