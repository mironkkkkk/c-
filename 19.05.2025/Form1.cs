using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox3.Clear();
            Console.WriteLine("Enter you choise: 1 - data 2 - html 3 - pass 4 - number 5 - mail");
            int choise = Convert.ToInt32(textBox1.Text);
            string text = textBox2.Text;
            switch (choise) { 
                case 1: MatchCollection patern = Regex.Matches(text, @"\d{2}-\d{2}-\d{4}"); 
                    foreach (var item in patern) { 
                        textBox3.Text += item;
                    } break; 
                case 2: 
                    text = Regex.Replace(text, @"<[a-z]*>", "");
                    text = Regex.Replace(text, @"</[a-z]*>", "");
                    textBox3.Text += text;
                    break; 
                case 3: 
                    MatchCollection A = Regex.Matches(text, @"(.*?=(.*[a-z])?=(.*[A-Z])?=([1-9]){8,}"); 
                    foreach (Match item in A) {
                        textBox3.Text += item.Value;
                    }
                    break; 
                case 4: 
                    MatchCollection a = Regex.Matches(text, @"\+7\(\d{3}\)\d{3}-\d{2}-\d{2}"); 
                    if (a[0].Length == 16) { 
                        textBox3.Text += "right";
                    } else { 
                        textBox3.Text += "no right";
                    }
                    break; 
                case 5: 
                    string[] arr = text.Split('@'); 
                    if (arr[1] == "mail.ru" || arr[1] == "yandex.ru") {
                        textBox3.Text += "all right";
                    }
                    else {
                        textBox3.Text += "no right";
                    } 
                    break; 
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
