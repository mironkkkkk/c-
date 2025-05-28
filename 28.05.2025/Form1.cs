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

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        List<string> arrCategory = new List<string> { "Продукты", "Транспорт", "Развлечения" };
        List<int> arrCount = new List<int> { 0,0,0,};
        bool flagShow = true;
        string textBtnShow = "Скрыть";
        public Form1()
        {
            InitializeComponent();
            foreach (var item in arrCategory) {
                comboBox1.Items.Add(item);
            }
            foreach (var item in arrCategory) {
                comboBox2.Items.Add(item);
            }

            using (StreamReader reader = new StreamReader("C:\\Users\\Взрослая академия\\Desktop\\WindowsFormsApp3\\file.csv"))
            {
                string[] str = reader.ReadLine().Split(',');
                arrCount[0] = Convert.ToInt32(str[0]);
                arrCount[1] = Convert.ToInt32(str[1]);
                arrCount[2] = Convert.ToInt32(str[2]);
                labelProduct.Text = Convert.ToString(arrCount[0]);
                labelTransport.Text = Convert.ToString(arrCount[1]);
                labelGaiety.Text = Convert.ToString(arrCount[2]);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string choiceCategory = comboBox1.SelectedItem.ToString();
            int userText = Convert.ToInt32(textBox1.Text);
            if (Convert.ToString(userText) == "" || choiceCategory == "") {
                MessageBox.Show($"Произошла ошибка, некоторые поля пустые");
            }
            else {
                for (int i = 0; i < arrCategory.Count; i++) {
                    if (arrCategory[i] == choiceCategory) {
                        arrCount[i] += userText;
                    }
                }
            }
            labelProduct.Text =  Convert.ToString(arrCount[0]);
            labelTransport.Text = Convert.ToString(arrCount[1]);
            labelGaiety.Text = Convert.ToString(arrCount[2]);
            writer();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            labelProduct.Visible = flagShow;
            labelTransport.Visible = flagShow;
            labelGaiety.Visible = flagShow;
            flagShow = !flagShow;

            button2.Text = textBtnShow;
            if (textBtnShow == "Показать") { textBtnShow = "Скрыть"; }
            else { textBtnShow = "Показать"; }
            writer();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string choiceCategory = comboBox2.SelectedItem.ToString();
            string userNewText = textBox2.Text;
            if (userNewText == "" || choiceCategory == "") {
                MessageBox.Show($"Произошла ошибка, некоторые поля пустые");
            }
            else {
                for (int i = 0; i < arrCategory.Count; i++) {
                    if (arrCategory[i] == choiceCategory) {
                        arrCount[i] = Convert.ToInt32(userNewText);
                    }
                }
            }
            labelProduct.Text = Convert.ToString(arrCount[0]);
            labelTransport.Text = Convert.ToString(arrCount[1]);
            labelGaiety.Text = Convert.ToString(arrCount[2]);
            writer();
        }

        public void writer() {
            using (StreamWriter writer = new StreamWriter("C:\\Users\\Взрослая академия\\Desktop\\WindowsFormsApp3\\file.csv", append: false))
            {
                writer.WriteLine($"{labelProduct.Text},{labelTransport.Text},{labelGaiety.Text}");
            }
        }
    }
}
