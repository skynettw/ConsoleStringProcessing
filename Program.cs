using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleStringProcessing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int a, b;
            //a = 100;
            //b = 200;

            //Console.WriteLine("a={0}, b={1}", a, b);
            //swap(a, b);
            //Console.WriteLine("a={0}, b={1}", a, b);
            //string str;
            //string[] res;
            //List<int> data = new List<int>();


            //str = Console.ReadLine();
            //res = str.Split(',');
            //foreach(string s in res)
            //{
            //    data.Add(int.Parse(s));
            //}
            //Console.WriteLine(data.Average());
            //for(int i = 0; i < str.Length; i++)
            //{
            //    Console.WriteLine(str[i]);
            //}
            DirectoryInfo dirinfo = new DirectoryInfo(@"d:\test");
            foreach(var d in dirinfo.EnumerateDirectories())
            {
                Console.WriteLine(d.FullName);
            }

            FileInfo file1 = new FileInfo(@"d:\test\ctest.txt");
            if (file1.Exists)
            {
                string line;
                StreamReader sr = file1.OpenText();
                while((line = sr.ReadLine())!=null)
                {
                    Console.WriteLine(line);
                }
                sr.Close();
            } else
            {
                StreamWriter sw = file1.CreateText();
                for (int i = 0; i < 10; i++) 
                    sw.WriteLine("Hello Lline"+i.ToString());
                sw.Close();
            }
            Console.Read();
        }

        public static void swap(int x, int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }

    }
}
