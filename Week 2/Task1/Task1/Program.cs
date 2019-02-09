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

            string Reverse = "";

            string s;

            s = Console.ReadLine();
            for(int i = s.Length-1; i >=0; i--)
            {
                Reverse += s[i];
            }
            if (Reverse == s)
            {
                Console.WriteLine("Yes");
            }
            else Console.WriteLine("No");
            Console.ReadKey();
           
        }
    }
    }

