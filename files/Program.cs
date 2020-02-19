using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace files
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Admin\Desktop\New folder\heloo";
            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    Console.WriteLine("enter your name");
                    string name = Console.ReadLine();
                    Console.WriteLine("enter your city");
                    string city = Console.ReadLine();
                    Console.WriteLine("enter your id");
                    string id = Console.ReadLine();
                    sw.WriteLine("My name is" + name);
                    sw.WriteLine("city is" + city);
                    sw.WriteLine("id is" + id);
                }
            }

               using(StreamReader sr=File.OpenText(path))
                {
                    string s;
                    while ((s = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(s);

                     }
            }
            using (StreamWriter sw = File.AppendText(path))
            {
                Console.WriteLine("enter some text");
                String s = Console.ReadLine();
                sw.WriteLine();
            }
        }
    }
}
