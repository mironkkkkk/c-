using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] a = { "121212", "efefefe", "efefygeft"};
            using (StreamWriter writer = new StreamWriter("C:\\Users\\Взрослая академия\\source\\repos\\ConsoleApp1\\ConsoleApp1\\file.csv", append:true)) {
                writer.WriteLine();
                writer.WriteLine(string.Join(", ", a));
            }
            using (StreamReader reader = new StreamReader("C:\\Users\\Взрослая академия\\source\\repos\\ConsoleApp1\\ConsoleApp1\\file.csv")) {

                while (!reader.EndOfStream)
                {
                    string[] str = reader.ReadLine().Split(',');
                    foreach (var item in str)
                    {
                        Console.Write($"{item} ");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
