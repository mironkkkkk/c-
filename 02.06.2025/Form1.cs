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

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        List<string> arr = new List<string>();
        List<string> language = new List<string>() { "Русский", "Англиский", "Белоруский", "Украинский"};
        public Form1()
        {
            InitializeComponent();
            using (StreamReader reader = new StreamReader("C:\\Users\\Взрослая академия\\Desktop\\WindowsFormsApp4\\file.csv"))
            {
                while (!reader.EndOfStream)
                {
                    string str = reader.ReadLine();
                    arr.Add(str);
                }
            }

            foreach (var item in language) {
                comboBox1.Items.Add(item);
                comboBox2.Items.Add(item);
            }
        }

        private void textBoxWord1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            bool flag = false;
            string box1 = comboBox1.SelectedItem.ToString();
            string box2 = comboBox2.SelectedItem.ToString();

            if (textBoxWord1.Text == "" || box1 == "" || box2 == "") {
                label3.Visible = true;
            }
            else {
                label3.Visible = false;
                string wordUser = textBoxWord1.Text;
                int languageId1 = 0;
                int languageId2 = 0;
                for (int i = 0; i < language.Count; i++) {
                    if (box1 == language[i]) {
                        languageId1 = i;
                    }
                    if (box2 == language[i]) {
                        languageId2 = i;
                    }
                }
                foreach (string item in arr) {
                    if (flag) {
                        label3.Visible = false;
                        break; 
                    }
                    string[] wordArr = item.Split('.');
                    if (wordArr[languageId1].ToLower() == wordUser.ToLower()) {
                        labelResult.Text = wordArr[languageId2];
                        flag = true;
                    }
                }
                if (!flag) {
                    label3.Visible = true;
                }
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool flagDelete = false;
            string wordDelete = textBoxDelete.Text;
            if (wordDelete == "") {
                label3.Visible = true;
            }
            else {
                label3.Visible = false;
                foreach (var item in arr) {
                    string[] arrWord = item.Split('.');
                    for (int i = 0; i < arrWord.Length; i++) {
                        if (flagDelete) { break; } 
                        if (arrWord[i] == wordDelete) {
                            arr.Remove(item);
                            flagDelete = true;
                        }
                    }
                    if (flagDelete) { break; }
                }
                using (StreamWriter writer = new StreamWriter("C:\\Users\\Взрослая академия\\Desktop\\WindowsFormsApp4\\file.csv", append: false))
                {
                    foreach (var item in arr) {
                        writer.WriteLine(item);
                    }
                }
            }
        }

        private void textBoxDelete_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string wordRus = textBoxAddRus.Text;
            string wordEngl = textBoxAddEnglish.Text;
            string wordBel = textBoxAddBel.Text;
            string wordUkr = textBoxAddUkr.Text;

            if (wordRus == "" || wordEngl == "" || wordBel == "" || wordUkr == "") {
                label3.Visible = true;
            }
            else {
                label3.Visible = false;
                string newWord = $"{wordRus}.{wordEngl}.{wordBel}.{wordUkr}";
                arr.Add(newWord);
                using (StreamWriter writer = new StreamWriter("C:\\Users\\Взрослая академия\\Desktop\\WindowsFormsApp4\\file.csv", append: false))
                {
                    foreach (var item in arr)
                    {
                        writer.WriteLine(item);
                    }
                }
            }
        }
    }
}
