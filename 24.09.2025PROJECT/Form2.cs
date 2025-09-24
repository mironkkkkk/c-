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

namespace WindowsFormsApp4
{
    public partial class Form2 : Form
    {
        string pathFile = "C:\\Users\\Взрослая академия\\source\\repos\\WindowsFormsApp4\\WindowsFormsApp4\\userDataBase.csv";
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool flag = false;
            using (StreamReader reader = new StreamReader(pathFile))
            {
                string text = reader.ReadToEnd();
                string login = text.Split(':')[0];
                if (textBox1.Text == login) { 
                    flag = true;
                }
                Console.WriteLine(text);
            }
            label2.Visible = flag;
            if (!flag) {
                label3.Visible = true;
                using (StreamWriter writer = new StreamWriter(pathFile, true))
                {
                    // login:numOrders:nameOrders1;12.09.2025;object1,nameOrders2;08.08.2025;object2,nameOrdes3;10.09.2025;object3ё
                    writer.WriteLineAsync($"{textBox1.Text}:0:nameOrder;00.00.2000;activites");
                }
            }
            else {
                label3.Visible = false;
            }
        }
    }
}
