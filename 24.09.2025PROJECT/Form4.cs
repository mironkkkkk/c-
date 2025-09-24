using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace WindowsFormsApp4
{
    public partial class Form4 : Form
    {
        string login;
        string path = "C:\\Users\\Взрослая академия\\source\\repos\\WindowsFormsApp4\\WindowsFormsApp4\\userDataBase.csv";
        string pathNew = "C:\\Users\\Взрослая академия\\source\\repos\\WindowsFormsApp4\\WindowsFormsApp4\\userDataBaseNEW.csv";

        List<List<string>> arrNew = new List<List<string>>();
        public Form4(string loginUser)
        {
            login = loginUser;
            Console.WriteLine("form4: " + login);
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string data = textBox1.Text;
            string name = textBox2.Text;
            string type = textBox3.Text;



            using (StreamWriter writer = new StreamWriter(pathNew, true))
            {
                using (StreamReader reader = new StreamReader(path))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string loginFile = line.Split(':')[0];
                        if (login != loginFile) {
                            writer.WriteLine(line);
                        }
                        else {
                            string[] str = line.Split(':');
                            int countOrders = Convert.ToInt32(line.Split(':')[1]);
                            countOrders++;
                            str[1] = ($"{countOrders}");

                            if (str[2].Split(';')[0] == "nameOrders") {
                                str[2] = ($"{name};{data};{type}");
                            }
                            else {
                                str[2] += ($",{name};{data};{type}");
                            }
                            string finaly = ($"{str[0]}:{str[1]}:{str[2]}");
                            writer.WriteLine(finaly);
                        }
                    }
                }
            } 
            // поменять копирование файлов + добавить split по , для grid
            File.Copy(path, pathNew);
            using (StreamWriter writer = new StreamWriter(pathNew, true))
            {
                writer.WriteLine("");
            }
        }
    }
}
