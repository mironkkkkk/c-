using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassList;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ClassList.PC a1 = new ClassList.PC();
            ClassList.PC a2 = new ClassList.PC();
            ClassList.PC a3 = new ClassList.PC();
            ClassList.PC a4 = new ClassList.PC();
            ClassList.PC a5 = new ClassList.PC();

            List<PC> arr = new List<PC>();
            arr.Add(a1);
            arr.Add(a2);
            arr.Add(a3);
            arr.Add(a4);
            arr.Add(a5);

            using (StreamWriter writer = new StreamWriter("C:\\Users\\Взрослая академия\\Desktop\\ClassList\\postol.csv", append: true)) {
                foreach (var item in arr) {
                    writer.WriteLineAsync($"brand: {item.Brand} num: {item.NumSeria} price: {item.Price} case_battle {item.Case_battle} onOrOff {item.OnOrOff}");
                }
                writer.WriteLineAsync("\n");
            }
        }
    }
}
