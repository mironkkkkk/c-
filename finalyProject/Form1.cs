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

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string login = textBox1.Text;
            string data = textBox2.Text;
            string pass = textBox3.Text;
            bool errorFlag = false;

            if (login == "" || pass == "" || data == "") {
                errorFlag = true;
                label4.Visible = errorFlag;
            } else {
                errorFlag = false;
                label4.Visible = errorFlag;
                bool flagLogIn = false;

                using (StreamReader reader = new StreamReader("C:\\Users\\Взрослая академия\\Desktop\\WindowsFormsApp5\\userData.csv"))
                {
                    while (!reader.EndOfStream)
                    {
                        string[] userData = reader.ReadLine().Split(',');
                        if (userData[0] == login)
                        {
                            flagLogIn = true;
                            break;
                        }
                    }
                }
                if (flagLogIn) {
                    errorFlag = true;
                    label4.Visible = errorFlag;
                } else {
                    errorFlag = false;
                    label4.Visible = errorFlag;
                    using (StreamWriter writer = new StreamWriter("C:\\Users\\Взрослая академия\\Desktop\\WindowsFormsApp5\\userData.csv", append: true))
                    {
                        writer.WriteLine($"{login},{pass},{data}");
                    }
                }
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string login = textBox4.Text;
            string pass = textBox5.Text;
            bool errorFlag = false;

            if (login == "" || pass == "") {
                errorFlag = true;
                label4.Visible = errorFlag;
            }
            else {
                errorFlag = false;
                label4.Visible = errorFlag;

                using (StreamReader reader = new StreamReader("C:\\Users\\Взрослая академия\\Desktop\\WindowsFormsApp5\\userData.csv"))
                {
                    while (!reader.EndOfStream)
                    {
                        string[] userData = reader.ReadLine().Split(',');
                        if (userData[0] == login && userData[1] == pass)
                        {
                            errorFlag = false;
                            label4.Visible = errorFlag;
                            Form Form2 = new Form2(login);
                            Form2.Show();
                            break;
                        }
                        else
                        {
                            errorFlag = true;
                            label4.Visible = errorFlag;
                        }
                    }

                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bool errorFlag = false;
            string login = textBox7.Text;
            string pass = textBox6.Text;

            if (login == "" || pass == "") {
                errorFlag = true;
                label4.Visible = errorFlag;
            } else {
                errorFlag = true;
                label4.Visible = errorFlag;

                using (StreamReader reader = new StreamReader("C:\\Users\\Взрослая академия\\Desktop\\WindowsFormsApp5\\adminData.csv"))
                {
                    while (!reader.EndOfStream)
                    {
                        string[] userData = reader.ReadLine().Split(',');
                        if (userData[0] == login && userData[1] == pass)
                        {
                            errorFlag = false;
                            label4.Visible = errorFlag;
                            Form Form3 = new Form3(login);
                            Form3.Show();
                            break;
                        }
                        else
                        {
                            errorFlag = true;
                            label4.Visible = errorFlag;
                        }
                    }

                }

            }


        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
