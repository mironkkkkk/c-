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
        string userLogin;
        string userPassword;

        public Form2(string log, string pass)
        {
            InitializeComponent();
            userLogin = log;
            userPassword = pass;
        }

        public void openForm(int numberTest) {
            Form3 form = new Form3(numberTest);
            form.Show();
            //this.Hide();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label1.Text = userLogin;
            label2.Text = userPassword;
        }

        private void clickBtn(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string buttonText = btn.Text;
            int numTest = Convert.ToInt32(buttonText);

            openForm(numTest);
        }
    }
}
