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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        logger log = new logger();
        DateTime date = DateTime.Now;

        public Form1()
        {
            InitializeComponent();
        }

        public void readFile(string path) {
            try
            {
                File.Open(path, FileMode.Open);
            }
            catch (Exception ex)
            {
                log.logging($"{date} Ошибка");
            }
            finally {
                
                Console.WriteLine("Проверка выполнена");   
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = null;
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK) { 
                path = saveFileDialog.FileName;
            }
            Console.WriteLine(path);
            using (StreamWriter writer = new StreamWriter(path, false))
            {
                writer.WriteLine(textBox1.Text);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string path2 = textBox2.Text;
            readFile(path2);
        }
    }
}
