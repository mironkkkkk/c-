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
    public partial class Form2 : Form
    {
        public Form2(string login)
        {
            InitializeComponent();
            label2.Text = login;
            using (StreamReader reader = new StreamReader("C:\\Users\\Взрослая академия\\Desktop\\WindowsFormsApp5\\kvisa.csv"))
            {
                while (!reader.EndOfStream)
                {
                    string[] kvisaData = reader.ReadLine().Split(';');
                    comboBox1.Items.Add(kvisaData[0]);
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "") {
                label4.Visible = true;
            } else {
                label4.Visible = false;
                using (StreamReader reader = new StreamReader("C:\\Users\\Взрослая академия\\Desktop\\WindowsFormsApp5\\kvisa.csv"))
                {
                    while (!reader.EndOfStream)
                    {
                        string[] kvisaData = reader.ReadLine().Split(';');
                        if (kvisaData[0] == comboBox1.Text)
                        {
                            // переделать
                            string[] l1 = kvisaData[1].Split(':');
                            string[] l2 = kvisaData[2].Split(':');
                            string[] l3 = kvisaData[3].Split(':');
                            string[] l4 = kvisaData[4].Split(':');
                            string[] l5 = kvisaData[5].Split(':');
                            label5.Text = l1[0];
                            label10.Text = l1[1];
                            label11.Text = l1[2];

                            label6.Text = l2[0];
                            label13.Text = l2[1];
                            label12.Text = l2[2];

                            label7.Text = l3[0];
                            label17.Text = l3[1];
                            label16.Text = l2[2];

                            label8.Text = l4[0];
                            label15.Text = l4[1];
                            label14.Text = l4[2];

                            label9.Text = l5[0];
                            label19.Text = l5[1];
                            label18.Text = l5[2];
                        }
                    }
                }
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
