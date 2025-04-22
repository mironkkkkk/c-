using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        // задание 1
        static void square(string str, int a) {
            for (int i = 0; i < a; i++) {
                for (int j = 0; j < a; j++) {
                    Console.Write(str + " ");
                }
                Console.WriteLine();
            }
        }
         // задание 2
        static bool pal(int num) {
            string str = Convert.ToString(num);
            string strReverse = "";
            for (int i = str.Length - 1; i >= 0; i--) {
                strReverse += str[i];
            }
            if (str == strReverse) {
                return true;
            }
            return false;
        }

        // задание 3
        static int[] sort(int[] arr1, int[] arr2) {
            List<int> list = new List<int>();
            bool flag = false;
            for (int i = 0; i < arr1.Length; i++) {
                for (int j = 0; j < arr2.Length; j++) {
                    if (arr1[i] == arr2[j]) {
                        flag = true;
                    }
                }
                if (!flag) {
                    list.Add(arr1[i]);
                }
                flag = false;
            }
            int[] arr3 = list.ToArray();
            return arr3;
        }

        static void Main(string[] args)
        {
            //square("*", 5);
            //Console.WriteLine(pal(232));
            //int[] arr1 = { 1, 2, 3, 4, 5, 6, 5, 7 };
            //int[] arr2 = { 2, 4, 5 };
            //sort(arr1, arr2);
            //int[] arr = sort(arr1, arr2);
            //foreach (int i in arr) {
            //    Console.Write(i + " ");
            //}
            //Websait web1 = new Websait("hh", "https://hh.ru", "world", "192.158.1.38");
            //web1.print();
            //Journal a = new Journal("top",  1984, "pc", "+79182323200", "efefe");
            //a.print();
            //Shop a = new Shop("wdwd", "wdwdw", "wdwd11", "23123", "dwd");
            //a.print();
        }
    }
}
    