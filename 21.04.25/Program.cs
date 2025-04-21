using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Employee worker1 = new Employee("Dima", 14, 200);
            //worker1.print();
            //worker1 += 100;
            //worker1.print();
            //Console.WriteLine(worker1.Name);

            Matrix arr1 = new Matrix(4,4);
            Matrix arr2 = new Matrix(4, 4);
            (arr1 + arr2).print();
            (arr1 - arr2).print();
            (arr1 * arr2).print();
            Console.WriteLine(arr1 == arr2);
        }
    }
}
