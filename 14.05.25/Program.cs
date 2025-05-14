using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "C:\\Users\\Взрослая академия\\Desktop\\ConsoleApp1\\text.txt";
            double[,] arr = { { 1.2, 1.3}, { 1.4, 1.5} };
            int[,] arr2 = { { 1,2,3}, { 4,5,6} };
            //File.Create(path);
            //if (File.Exists(path)) {
            //    Console.WriteLine("Фаил уже создан");
            //}
            //else {
            //    Console.WriteLine("Фаил создан");
            //}

            //string text = File.ReadAllText(path);
            //Console.WriteLine(text);
            //File.AppendAllText(path, " и денча");
            //text = File.ReadAllText(path);
            //Console.WriteLine(text);
            //File.WriteAllText(path, "метью");
            //text = File.ReadAllText(path);
            //Console.WriteLine(text);

            //File.Create(path);
            if (File.Exists(path)) {
                Console.WriteLine("File was created");
            }
            else {
                Console.WriteLine("File will create");
            }

            //string fio;
            //string data;
            //Console.WriteLine("Enter fio: ");
            //fio = Console.ReadLine();
            //Console.WriteLine("Enter data: ");
            //data = Console.ReadLine();
            //File.AppendAllText(path, $"{fio} {data} \n");

            //int rows = 2;
            //int columns = 2;
            //File.AppendAllText(path, $"row: {rows}  columns: {columns} \n");

            //for (int i = 0; i < 2; i++) {
            //    for (int j = 0;  j < 2; j++) {
            //        File.AppendAllText(path, Convert.ToString(arr[i, j]) + " ");
            //    }
            //    File.AppendAllText(path, "\n");
            //}

            //int rows2 = 2;
            //int columns2 = 2;
            //File.AppendAllText(path, $"row: {rows2}  columns: {columns2} \n");


            //for (int i = 0; i < 2; i++) {
            //    for (int j = 0; j < 2; j++) {
            //        File.AppendAllText(path, Convert.ToString(arr2[i, j]) + " ");
            //    }
            //    File.AppendAllText(path, "\n");
            //}

            //File.AppendAllText(path, DateTime.Now.ToString("dd.MM.yyyy") + "\n");

            //File.WriteAllText(path, "");
            


        }
    }
}
