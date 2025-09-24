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

        public List<List<string>> arrOrdesrList;
        public Form3(string loginUser, string number, List<List<string>> arr)
        {
            login = loginUser;
            numberOrders = Convert.ToInt32(number);
            arrOrdesrList = arr;
            InitializeComponent();

            Console.WriteLine(login);
            Console.WriteLine(numberOrders);
            foreach (var item in arrOrdesrList) {
                foreach (var items in item) {
                    Console.WriteLine(items);
                }
                Console.WriteLine("\n");
            }

            dataGridView1.Columns.Add("Name order", "Name order");
            dataGridView1.Columns.Add("Date", "Date");
            dataGridView1.Columns.Add("Status", "Status");

            if (numberOrders != 0) {
                label4.Visible = false;
                foreach (var item in arrOrdesrList)
                {
                    dataGridView1.Rows.Add($"{item[0]}", $"{item[1]}", $"{item[2]}");
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
