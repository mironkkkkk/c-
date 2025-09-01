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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        string loginUser = null;
        string passUser = null;
        public Form1()
        {

            InitializeComponent();
        }

        public bool checkUser(string log) {
            bool resultCheck = false;
            using (StreamReader reader = new StreamReader("C:\\Users\\Взрослая академия\\source\\repos\\WindowsFormsApp1\\WindowsFormsApp1\\user.csv"))
            {
                string line = null;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] str = line.Split(',');
                    if (resultCheck) { break; }
                    if (str[0] == log) {
                        resultCheck = true;
                    }
                }
            }
            return resultCheck;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string login = textBox1.Text;
            string pass = textBox3.Text;

            if (checkUser(login) == false)
            {
                using (StreamWriter writer = new StreamWriter("C:\\Users\\Взрослая академия\\source\\repos\\WindowsFormsApp1\\WindowsFormsApp1\\user.csv", append: true))
                {
                    writer.WriteLine($"{login},{pass}");
                }
            }
            else {
                label5.Visible = true;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool flagCheck = false;
            using (StreamReader reader = new StreamReader("C:\\Users\\Взрослая академия\\source\\repos\\WindowsFormsApp1\\WindowsFormsApp1\\user.csv"))
            {

                while (!reader.EndOfStream)
                {
                    string[] str = reader.ReadLine().Split(',');
                    if (flagCheck) { break; }
                    if (str[0] == textBox2.Text && str[1] == textBox4.Text) {
                        flagCheck = true;
                        Form2 form = new Form2(str[0], str[1]);
                        form.Show();
                        this.Hide();
                    }
                }
            }
            if (flagCheck) {
                label6.Visible = flagCheck;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
