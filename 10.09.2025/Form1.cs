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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public BindingList<Users> userList = new BindingList<Users>();

        public Form1()
        {
            InitializeComponent();
            dataGridView1.DataSource = userList;
        }

        private void userInfo(Users user) {
            userList.Add(user);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.addNewUser += userInfo;
            form2.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string deleteUser = textBox1.Text;
            foreach (Users item in userList)
            {
                if (item.Login == deleteUser)
                {
                    userList.Remove(item);
                    using (StreamWriter writer = new StreamWriter("C:\\Users\\Взрослая академия\\source\\repos\\WindowsFormsApp2\\WindowsFormsApp2\\data.csv", false))
                    {
                        
                    }
                    break;
                }
            }
            foreach (Users item in userList) {
                using (StreamWriter writer = new StreamWriter("C:\\Users\\Взрослая академия\\source\\repos\\WindowsFormsApp2\\WindowsFormsApp2\\data.csv", true))
                {
                    writer.WriteLine($"{item.Login},{item.Pass},{item.Name},{item.Age}");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog()) {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    openFileDialog.Filter = ;
                    string path = openFileDialog.FileName;
                }
            }

        }
    }


}
