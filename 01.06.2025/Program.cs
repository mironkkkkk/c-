using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {

        static void Main(string[] args)
        {

            //square('*', 5);
            //bool flag = pal(231332);
            //Console.WriteLine(flag);
            int[] q1 = { 1, 2, 6, 1, 88, 7, 6 };
            int[] q2 = { 6,88,7 };
            int[] arr = arrSort(q1,q2);
            foreach (var item in arr) {
                Console.Write(item + " ");
            }
        }

        static public void square(char b, int a) {
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < a; j++)
                {
                    Console.Write(b + " ");
                }
                Console.WriteLine("\n");
            }
        }

        static public bool pal(int a) {
            string s = Convert.ToString(a);
            for (int i = 0, j = s.Length - 1; i < s.Length; i++, j--) {
                if (s[i] != s[j]) {
                    return false;
                }
            }
            return true;
        }

        static public int[] arrSort(int[] arrBase, int[] arrAdd)
        {
            List<int> list1 = new List<int>(arrBase);
            List<int> list2 = new List<int>(arrAdd);

            List<int> result = new List<int>();

            foreach (var item in list1)
            {
                if (!list2.Contains(item))
                {
                    result.Add(item);
                }
            }

            return result.ToArray();
        }

    }
}
