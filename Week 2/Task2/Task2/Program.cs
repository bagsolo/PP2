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
    
        static bool Boolean(int k)
        { 
        if (k == 1) return false;
        for (int i = 2; i < Math.Sqrt(k); i++)
        {
            if (k % i == 0) return false;
        }
        return true;
    }
    
        static void Main(string[] args)
        {
            FileStream fs = new FileStream(@"C:\Users\PC\Desktop\PP2\Week 2\Task2\input.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);

            string s = sr.ReadLine();

            String[] arr = s.Split();

            int[] sum = new int[arr.Length];


            for (int i=0; i < sum.Length; i++)
            {
                sum[i] = int.Parse(arr[i]);
            }
            int n = 0;
            sr.Close();
           
            string prime = "";
            for (int i = 0; i < sum.Length; i++)
            {
                if (Boolean(sum[i]))
                {
                    prime +=  sum[i] + " ";
                }
            }
            FileStream fs2 = new FileStream(@"C: \Users\PC\Desktop\PP2\Week 2\Task2\output.txt", FileMode.Open, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs2);


            //prime.Trim();

             sw.WriteLine( prime+" ");
            sw.Close();
        }
    }
}
