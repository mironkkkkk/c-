using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static int[] sort(int[] arr) {
            int[] arr1 = arr;
            for (int i = 0; i < arr.Length; i++) {
                for (int j = 0; j < arr.Length - 1; j++) {
                    if (arr1[j] > arr[j + 1]) {
                        int t = arr1[j];
                        arr1[j] = arr[j + 1];
                        arr1[j + 1] = t;    
                    }
                }
            }
            return arr;
        
        }
        static bool prost(int a) {
            for (int i = 2; i < a; i++) {
                if (a % i == 0) {
                    return false;
                }
            }
            return true;
        }
        static bool fib(int a) {
            int zero = 0;
            bool flag = false;
            int one = 1;
            for (int i = 0; i < a; i++) {
                int b = one + zero;
                zero = one;
                one = b;
                if (b == a) {
                    flag = true;
                }
                if (b > a)
                {
                    break;
                }
            }
            return flag;
        }
        static int multp(int min, int max)
        {
            int a = 1;
            for (int i = min; i <= max; i++) {
                a *= i;
            }
            return a;
        }

        public class City {
            private string name;
            private string country;
            private int population;
            private int num;
            private string dis;

            public void name1(string name) {
                this.name = name;
            }

            public void num1(int num) {
                this.num = num;
            }

            public void dis1(string dis) {
                this.dis += " ";
                this.dis += dis;
            }

            public void country1(string country) {
                this.country = country;
            }

            public void population1(int population) {
                this.population = population;
            }

            public void print() {
                Console.WriteLine($"City {name}");
                Console.WriteLine($"Country {country}");
                Console.WriteLine($"Population {population}");
                Console.WriteLine($"Num {num}");
                Console.Write($"Dis {dis}");
            }




        }
        static void Main(string[] args)
        {
            City a = new City();
            a.name1("Dima");
            a.country1("Afrika");
            a.population1(10);
            a.dis1("Vorosh");
            a.dis1("YDFYD");
            a.num1(1);

            a.print();

            //int[,] arr = { { 1,2,3}, { 12,23,3} };
            //int row = arr.GetLength(0);
            //int column = arr.GetLength(1);

            //int min = arr[0,0];
            //int max = arr[0,0];

            //for (int i = 0; i < arr.GetLength(0); i++) {
            //    for (int j = 0; j < arr.GetLength(1); j++) {
            //        if (arr[i, j] > max) {
            //            max = arr[i, j];
            //        }
            //        if (arr[i, j] < min) {
            //            min = arr[i, j];
            //        }
            //    }
            //}
            //Console.WriteLine("min: " + min + " max: " + max);

            //string a = Console.ReadLine();
            //string[] arr = a.Split(' ');

            //Console.WriteLine(arr.Length);

            //char[] letters = { 'а', 'е', 'ё', 'и', 'о', 'у', 'ы', 'э', 'ю', 'я' };
            //string s = Console.ReadLine().ToLower();
            //int count = 0;
            //for (int i = 0; i < s.Length; i++) {
            //    foreach (char item in letters) {
            //        if (s[i] == item) {
            //            count++;
            //        }
            //    }
            //}
            //Console.WriteLine(count);

            //string a = Console.ReadLine();
            //string s = Console.ReadLine();
            //int count = 0;
            //string[] arr = a.Split(' ');

            //foreach (string item in arr) {
            //    if (item == s) {
            //        count++;
            //    }
            //}
            //Console.WriteLine(count);
            //int a = 1;
            //int b = 5;
            //Console.WriteLine(multp(a, b));
            //Console.WriteLine(fib(8));
            //Console.WriteLine(prost(8));

            int[] arr = { 5, 6, 3, 2, 1 };
            arr = sort(arr);
            foreach (int item in arr) {
                Console.WriteLine(item + " ");
            }
        }
    }
}
