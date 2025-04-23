using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program

    {

        static void Main(string[] args)
        {
            // задагие 1
            //string str = Console.ReadLine();

            //try
            //{
            //    int a = Convert.ToInt32(str);
            //    Console.WriteLine(a);
            //}

            //catch (OverflowException)
            //{
            //    Console.WriteLine("Выход за границу");
            //}
            //catch (System.FormatException)
            //{
            //    Console.WriteLine("Не должно содержать символы");
            //}

            // задание 2

            //string str = Console.ReadLine();
            //try
            //{
            //    int num = 0;
            //    int step = str.Length - 1;
            //    for (int i = 0; i < str.Length; i++)
            //    {
            //        num += (Convert.ToInt32(str[i]) - 48) * (Convert.ToInt32(Math.Pow(2, step)));
            //        step--;
            //    }
            //    Console.WriteLine(num);
            //}

            //catch (OverflowException)
            //{
            //    Consol
            //
            //    e.WriteLine("Выход за границу");
            //}

            string str = Console.ReadLine();
            string str2 = "";
            List<string> arr = new List<string>();
            List<char> arrChar = new List<char>();
            List<string> list3 = new List<string>();



            for (int i = 0; i < str.Length; i++) {
                if (str[i] == '*' || str[i] == '/' || str[i] == '+' || str[i] == '-')
                {
                    str2 += " ";
                    arrChar.Add(str[i]);
                }
                else {
                    str2 += str[i];
                }
            }

            string[] str3 = str2.Split(' ');

            foreach (string item in str3) {
                Console.Write(item + " ");
                list3.Add(item);
            }

            Console.WriteLine();

            foreach (char item in arrChar)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();

            foreach (string item in arr)
            {
                Console.Write(item + " ");
            }


            for (int i = 0; i <= arrChar.Count - 1; i++)
            {
                if (arrChar[i] == '*')
                {
                    int a = (Convert.ToInt32(list3[i]) - 48) * (Convert.ToInt32(list3[i + 1]) - 48);
                    list3.RemoveAt(i);
                    list3.RemoveAt(i + 1);
                    list3.Add(Convert.ToString(a));
                    arrChar.RemoveAt(i);
                }
            }
            Console.WriteLine();
            Console.WriteLine();

            foreach (string item in list3)
            {
                Console.Write(item + " ");
            }
        }
    }
}
