using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp9
{
    public partial class Form1 : Form
    {
        List<Studentka> Studentki = new List<Studentka>();
        Studentka Milena = new Studentka("Milena", 17);
        Studentka Meri = new Studentka("Meri", 40);
        Studentka Galina= new Studentka("Galina", 18);

        public Form1()
        {
            InitializeComponent();
            //Milena.showStudentka();
            //Meri.showStudentka();
            //Galina.showStudentka();
            Studentki.Add(Milena);
            Studentki.Add(Meri);
            Studentki.Add(Galina);

            int min = 99;
            int minId = 0;

            var results = from Studentka in Studentki where Studentka.Age >= 18 select Studentka;

            foreach (var item in results) {
                item.showStudentka();
            }

            var results2 = from Studentka in Studentki select Studentka;

            foreach (var item in results2)
            {
                if (item.Age <= min) { 
                    min = item.Age;
                    minId = item.Id;
                }
            }
            Console.WriteLine("\nmin age:");
            Studentki[minId].showStudentka();

            var results3 = from Studentka in Studentki where Studentka.Age >= 18 select Studentka.Name;
            Console.Write("\nlist:");

            foreach (var item in results3)
            {
                Console.Write($"{item} ");
            }

            var results4 = from Studentka in Studentki select Studentka.Age;
            Console.Write("\nlist:");
            List<int> ages = results4.ToList();

            for (int i = 0; i < ages.Count() - 1; i++)
            {
                for (int j = 0; j < ages.Count() - 1 - i; j++)
                {
                    if (ages[j] > ages[j + 1])
                    {
                        int temp = ages[j];
                        ages[j] = ages[j + 1];
                        ages[j + 1] = temp;
                    }
                }
            }

            foreach (var item in ages)
            {
                Console.Write($"{item} ");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
