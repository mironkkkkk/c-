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

namespace WindowsFormsApp1
{

    public partial class Form1 : Form
    {
       public List<User> arr = new List<User> ();
        bool flag = false;
        public Form1()
        {
            InitializeComponent();
            adadad();
        }

        private void login_TextChanged(object sender, EventArgs e)
        {

        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            if (login.Text == "" || pass.Text == "" || textBoxRegisterMail.Text == "")
            {
                labelError.Visible = true;
            }
            else {
                foreach (var item in arr) {
                    if (item.Login == login.Text) {
                        flag = true;
                    }
                }
                if (flag)
                {
                    labelError.Visible = true;
                    flag = false;
                }
                else {
                    labelError.Visible = false;
                    User a = new User(login.Text, pass.Text, textBoxRegisterMail.Text);
                    arr.Add(a);
                    using (StreamWriter writer = new StreamWriter("C:\\Users\\Взрослая академия\\source\\repos\\ConsoleApp1\\WindowsFormsApp1\\data.csv", append: true))
                    {
                        foreach (User item in arr)
                        {
                            writer.WriteLine(item.Login + "," + item.Pass + "," + item.Mail);
                        }
                    }
                    flag = false;
                }
             
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxLoginLogin.Text == "" || textBoxLoginPass.Text == "")
            {
                labelError.Visible = true;
            }
            else
            {
                labelError.Visible = false;
                foreach (var item in arr) {
                    if (item.Login == textBoxLoginLogin.Text && item.Pass == textBoxLoginPass.Text && textBoxLoginMail.Text == item.Mail)
                    {
                        label5.Visible = true;
                        label5.Text = "True";
                        Form Form2 = new Form2(arr);
                        Form2.Show();
                        break;
                    }
                    else {
                        label5.Visible = true;
                        label5.Text = "False";
                    }
                }
                using (StreamWriter writer = new StreamWriter("C:\\Users\\Взрослая академия\\source\\repos\\ConsoleApp1\\WindowsFormsApp1\\data.csv", append: true))
                {
                    foreach (User item in arr)
                    {
                        writer.WriteLine(item.Login + "," + item.Pass + "," + item.Mail);
                    }
                }
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void adadad()
        {
            using (StreamReader reader = new StreamReader("C:\\Users\\Взрослая академия\\source\\repos\\ConsoleApp1\\WindowsFormsApp1\\data.csv"))
            {
                while (!reader.EndOfStream)
                {
                    string[] str = reader.ReadLine().Split(',');
                    foreach (var item in str)
                    {
                        User a = new User(str[0], str[1], str[2]);
                        arr.Add(a);
                    }
                }
            }
        }

        private void pass_TextChanged(object sender, EventArgs e)
        {

        }
    }

    public class User
    {
        private string login;
        private string mail;
        private string pass;


        public string Login
        {
            get { return login; }
            set { login = value; }
        }

        public string Pass
        {
            get { return pass; }
            set { pass = value; }
        }

        public string Mail { 
            get { return mail; }    

        }

        public User(string login, string password,string mail)
        {
            this.login = login;
            this.pass = password;
            this.mail = mail;
        }
    }

  
}
