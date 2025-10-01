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
using System.Xml.Linq;

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
                        Form3 form3 = new Form3(loginFile, numberOrders, line.Split(':')[2]);
                        form3.ShowDialog();
                        break;
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string login = textBox1.Text;
            List<List<string>> arrCopy = new List<List<string>>();
            using (StreamReader reader = new StreamReader(pathFile))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] loginFile = line.Split(':');
                    List<string> arrStr = new List<string>();
                    foreach (string str in loginFile) { 
                        arrStr.Add(str);
                    }
                    arrCopy.Add(arrStr);
                }
            }
            Form4 form4 = new Form4(login, arrCopy);
            form4.ShowDialog();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            string login = textBox1.Text;

            List<List<string>> arrCopy = new List<List<string>>();
            using (StreamReader reader = new StreamReader(pathFile))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] loginFile = line.Split(':');
                    List<string> arrStr = new List<string>();
                    foreach (string str in loginFile)
                    {
                        arrStr.Add(str);
                    }
                    arrCopy.Add(arrStr);

                    if (login == loginFile[0]) {
                        Form5 form5 = new Form5(line, arrCopy);
                        form5.ShowDialog();
                        break;
                    }
                }
            }

        }
    }
}
