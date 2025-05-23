using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        List<User> arr = new List<User>();
        
        public Form2(List<User> arr)
        {
            this.arr = arr;
            InitializeComponent();
        }

    

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            foreach (var item in arr) {
                if (item.Login == text) {
                    Results.Text = "True";
                } else {
                    Results.Text = "False"; 
                }
            }
            Results.Visible = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
