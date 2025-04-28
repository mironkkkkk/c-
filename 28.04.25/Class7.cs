using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    abstract class Figure
    {
        public abstract void square();
    }

    internal class Triangle {
        private int a, b;

        public Triangle(int a, int b) {
            this.a = a;
            this.b = b;
        }

        public int area() {
            return (a * b) / 2;
        }
    }
}
