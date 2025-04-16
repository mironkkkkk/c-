using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Num {
        private int min;
        private int max;

        public Num(int a, int b) {
            if (a > b) {
                this.min = b;
                this.max = a;
            }
            else {
                this.min = a;
                this.max = b;
            }
        }

        public void even() {
            for (int i = min; i < max; i++) {
                if (i % 2 == 0) {
                    Console.WriteLine(i);
                }
            }
        }

        public void odd() {
            for (int i = min; i < max; i++) {
                if (i % 2 == 1) {
                    Console.WriteLine(i);
                }
            }
        }

        public void def() {
            List<bool> arr = new List<bool>();
            bool flag = false;
            for (int i = 2; i < min; i++) {
                if (min % i == 0) {
                    arr.Add(false);
                    flag = true;
                    break;
                }
            }
            if (!flag) {
                arr.Add(true);
            }

            flag = false;

            for (int i = 2; i < max; i++) {
                if (max % i == 0) {
                    arr.Add(false);
                    flag = true;
                    break;
                }
            }
            if (!flag) {
                arr.Add(true);
            }

            Console.WriteLine($"{min}: {arr[0]}, {max}: {arr[1]}");
        }

        public bool def(int a)
        {
            for (int i = 2; i < a; i++) {
                if (a % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        public bool fib(int a) {
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
                if (b > a) {
                    break;
                }
            }
            return flag;
        }

    }
    internal class Class1
    {
    }
}
