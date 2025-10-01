using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WindowsFormsApp4
{
    public partial class Form5 : Form
    {
        string strUserData;
        string[] orders;
        string login;
        string num;
        List<List<string>> arrUserFile;

        string path = "C:\\Users\\Взрослая академия\\source\\repos\\WindowsFormsApp4\\WindowsFormsApp4\\userDataBase.csv";
        public Form5(string line, List<List<string>> arrFileData)
        {
            arrUserFile = arrFileData;
            strUserData = line;
            orders = strUserData.Split(':')[2].Split(',');
            login = strUserData.Split(':')[0];
            num = strUserData.Split(':')[1];
            InitializeComponent();
            showData();
            Console.WriteLine("form5: " + strUserData);
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void showData() {
            dataGridView1.Columns.Add("Name order", "Name order");
            dataGridView1.Columns.Add("Date", "Date");
            dataGridView1.Columns.Add("Status", "Status");

            if (Convert.ToInt32(strUserData.Split(':')[1]) != 0)
            {
                foreach (string s in orders)
                {
                    string[] data = s.Split(';');
                    dataGridView1.Rows.Add($"{data[0]}", $"{data[1]}", $"{data[2]}");
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nameOrderSearch = textBox1.Text;
            string dataOrderSearch = textBox2.Text;

            string nameOderEdit = textBox3.Text;
            string dataOrdeEdit = textBox4.Text;
            string statusOrdeEdit = textBox5.Text;

            for (int i = 0; i < orders.Length; i++)
            {
                if (orders[i].Split(';')[0] == nameOrderSearch && orders[i].Split(';')[1] == dataOrderSearch) {
                    string str = ($"{nameOderEdit};{dataOrdeEdit};{statusOrdeEdit}");
                    orders[i] = str;
                    break;
                }
            }

            string strOrdersFinaly = "";
            foreach (var item in orders) { 
                strOrdersFinaly += item;
                strOrdersFinaly += ",";
            }

            string s = ($"{login}:{num}:{strOrdersFinaly}");
            Console.WriteLine("test:11111 " + s);

            File.WriteAllText(path, "");

            using (StreamWriter writer = new StreamWriter(path, true))
            {
                for (int i = 0; i < arrUserFile.Count; i++)
                {
                    if (arrUserFile[i][0] == login)
                    {
                        writer.Write(s+ "\n");
                    }
                    else
                    {
                        string str = ($"{arrUserFile[i][0]}:{arrUserFile[i][1]}:{arrUserFile[i][2]}");
                        writer.Write(str + "\n");
                    }
                }
            }
        }
    }
}
