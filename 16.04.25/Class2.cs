using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Figure {
        public void square(int a) {
            for (int i = 0; i < a; i++) {
                for (int j = 0; j < a; j++) {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        public void rectangle(int a, int b) {
            for (int i = 0; i < b; i++) {
                for (int j = 0; j < a; j++) {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        public void troian(int a) {
            int c = a + 1;
            int count = 1;
            for (int i = 0; i < a; i++) {
                for (int j = 0; j < c / 2; j++) {
                    Console.Write(" ");
                }
                for (int k = 0; k < count; k++) {
                    Console.Write("* ");
                }
                count++;
                c -= 2;
                if (c == 0) {
                    c = 2;
                }
                Console.WriteLine();
            }
        }
    }
    internal class Class2
    {
    }
}
