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
using WindowsFormsApp3;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        logger log = new logger();
     

        public void readFile(string path)
        {
            try
            {
                File.Open(path, FileMode.Open);
            }
            catch (Exception ex)
            {
                log.logging($"Ошибка {ex}", ErrorType.Warning);
            }
            finally
            {

                Console.WriteLine("Проверка выполнена");
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            string path2 = textBox2.Text;
            readFile(path2);
            timer1.Enabled = true;
            label1.Location = new Point(label1.Location.X + 100, label1.Location.Y + 100);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }
    }
}
