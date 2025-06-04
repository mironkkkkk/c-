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
    public partial class Form3 : Form
    {
        public Form3(string login)
        {
            InitializeComponent();
            label2.Text = login;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;

            string quest1 = textBox2.Text;
            string answerTrue1 = textBox4.Text;
            string answerFalse1 = textBox3.Text;

            string quest2 = textBox7.Text;
            string answerTrue2 = textBox6.Text;
            string answerFalse2 = textBox5.Text;

            string quest3 = textBox13.Text;
            string answerTrue3 = textBox12.Text;
            string answerFalse3 = textBox11.Text;


            string quest4 = textBox10.Text;
            string answerTrue4 = textBox9.Text;
            string answerFalse4 = textBox8.Text;

            string quest5 = textBox16.Text;
            string answerTrue5 = textBox15.Text;
            string answerFalse5 = textBox14.Text;

            using (StreamWriter writer = new StreamWriter("C:\\Users\\Взрослая академия\\Desktop\\WindowsFormsApp5\\kvisa.csv", append: true))
            {
                writer.WriteLine($"{name};{quest1}:{answerTrue1}:{answerFalse1};{quest2}:{answerTrue2}:{answerFalse2};{quest3}:{answerTrue3}:{answerFalse3};{quest4}:{answerTrue4}:{answerFalse4};{quest5}:{answerTrue5}:{answerFalse5}");
            }

        }
    }
}
