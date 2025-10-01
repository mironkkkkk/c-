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

        List<List<string>> arrNew = new List<List<string>>();
        public Form4(string loginUser, List<List<string>> arrUsersData)
        {
            login = loginUser;
            arrNew = arrUsersData;
            Console.WriteLine("form4: " + login);
            foreach (var item in arrUsersData) {
                foreach (var item2 in item) {
                    Console.WriteLine($"{item2} ");
                }
                Console.WriteLine();
            }
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

  
            File.WriteAllText(path, "");


            using (StreamWriter writer = new StreamWriter(path, true))
            {
                for (int i = 0; i < arrNew.Count; i++) {
                    if (arrNew[i][0] == login) {
                        if (arrNew[i][1] == "0") {
                            int count = Convert.ToInt32(arrNew[i][1]);
                            count++;
                            string str = ($"{arrNew[i][0]}:{count}:{name};{data};{type}");
                            writer.Write(str + "\n");
                        }
                        else {
                            int count = Convert.ToInt32(arrNew[i][1]);
                            count++;
                            string end = arrNew[i][2] += $",{name};{data};{type}";
                            string str = ($"{arrNew[i][0]}:{count}:{end}");
                            writer.Write(str + "\n");
                        }
                    }
                    else {
                        string str = ($"{arrNew[i][0]}:{arrNew[i][1]}:{arrNew[i][2]}");
                        writer.Write(str + "\n");
                    }
                }
            }
        }
    }
}
