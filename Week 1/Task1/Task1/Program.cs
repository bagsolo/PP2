using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static bool prime(int k)
        {
            if (k == 1) return false;
            for (int i = 2; i <= Math.Sqrt(k); i++)
            {
                if (k % i == 0) return false;
            }
            return true;
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string[] s = Console.ReadLine().Split();

            int[] arr = new int[n];

            int cnt = 0;

            int[] pr = new int[n];

            for(int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(s[i]);
            }
            int j = 0;
            for(int i = 0; i < n; i++)
            {
                if (prime(arr[i])==true)
                {
                    pr[j] = arr[i];
                    cnt++;
                    j++;
                }
                    
            }
            Console.WriteLine(cnt);
            for(int i = 0; i < cnt; i++)
            {
                Console.Write(pr[i] + " ");
            }
            Console.ReadLine();   
        }
    }
}
