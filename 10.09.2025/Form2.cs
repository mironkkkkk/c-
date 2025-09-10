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

namespace WindowsFormsApp2
{
    public partial class Form2 : Form
    {
        public event Action<Users> addNewUser;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Users user = new Users(textBox1.Text, textBox2.Text, textBox3.Text, Convert.ToInt32(textBox4.Text));
            addNewUser?.Invoke(user);
            // добавление в файл
            using (StreamWriter writer = new StreamWriter("C:\\Users\\Взрослая академия\\source\\repos\\WindowsFormsApp2\\WindowsFormsApp2\\data.csv", true))
            {
                writer.WriteLine($"{textBox1.Text },{ textBox2.Text },{textBox3.Text},{textBox4.Text}");
            }
        }
    }
}
