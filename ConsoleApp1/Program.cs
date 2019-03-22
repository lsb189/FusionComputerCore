using System;
using System.Text;
using System.IO;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
           
            
            List<string> a = new List<string>();
            a.Add("A");
            a.Add("B");
            for (int i= 0;i< a.Count;i++)
            {
                string str = a[i];
                Console.WriteLine(str);
            }

            Console.ReadKey();
        }
    }
}
