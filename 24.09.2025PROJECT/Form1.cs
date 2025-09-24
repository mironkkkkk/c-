using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        string pathFile = "C:\\Users\\Взрослая академия\\source\\repos\\WindowsFormsApp4\\WindowsFormsApp4\\userDataBase.csv";
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string login = textBox1.Text;
            bool flag = false;

            using (StreamReader reader = new StreamReader(pathFile))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string loginFile = line.Split(':')[0];
                    if (login == loginFile)
                    {
                        flag = true;
                    }

                    if (flag)
                    {
                        string numberOrders = line.Split(':')[1];
                        List<List<string>> arrOrdersList = new List<List<string>>();
                        Form3 form3 = new Form3(loginFile, numberOrders, splitArrOrders(line.Split(':')[2]));
                        form3.ShowDialog();
                        break;
                    }
                }
            }
        }

        public List<List<string>> splitArrOrders(string orders) {
            Console.WriteLine(orders);
            List<List<string>> arrList = new List<List<string>>();
            string[] arr = orders.Split(';');
            List<string> arr2 = new List<string>();

            foreach (var item in arr)
            {
                arr2.Add(item);
            }
            arrList.Add(arr2);
            return arrList;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string login = textBox1.Text;
            Form4 form4 = new Form4(login);
            form4.ShowDialog();
        }
    }
}
