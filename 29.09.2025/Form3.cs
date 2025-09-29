using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form3 : Form
    {
        public string login;
        public int numberOrders;
        bool flagNum = false;
        string orders;
        public Form3(string loginUser, string number, string arr)
        {
            login = loginUser;
            numberOrders = Convert.ToInt32(number);
            if (numberOrders > 1) {
                flagNum = true;
            }
            orders = arr;
            InitializeComponent();

            Console.WriteLine(login);
            Console.WriteLine(numberOrders);

            dataGridView1.Columns.Add("Name order", "Name order");
            dataGridView1.Columns.Add("Date", "Date");
            dataGridView1.Columns.Add("Status", "Status");

            if (numberOrders != 0) {
                label4.Visible = false;
                if (flagNum) {
                    string[] ordersSplit = orders.Split(',');
                    Console.WriteLine("FORM3:" + "\n");
                    foreach (string s in ordersSplit) {
                        Console.WriteLine(s + "\n"); 
                    }

                    for (int i = 0; i < ordersSplit.Length; i++)
                    {
                        string[] str = ordersSplit[i].Split(';');
                        dataGridView1.Rows.Add($"{str[0]}", $"{str[1]}", $"{str[2]}");
                    }
                }
                else {
                    string[] str = orders.Split(';');
                    dataGridView1.Rows.Add($"{str[0]}", $"{str[1]}", $"{str[2]}");
                }
            }
            else {
                label4.Visible = true;
            }

            label5.Text = login;
            label2.Text = $"{numberOrders}";
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
