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
    public partial class Form1 : Form
    {
        char[] arrOperationBase = {'-', '+', '*', '/'};
        List<int> arrNum = new List<int>(); // массив чисел
        List<char> arrOperation = new List<char>(); // массив операций
        public void calc() { 
            
        }

        public Form1()
        {
            InitializeComponent();
        }

        public void calc(char operation) {
            for (int i = 0; i < arrOperation.Count; i++) {
                if (arrOperation[i] == operation) {
                    switch (operation) {
                        case '*':
                            arrNum[i] = arrNum[i] * arrNum[i + 1];
                            break;
                        case '/':
                            arrNum[i] = arrNum[i] / arrNum[i + 1];
                            break;
                        case '+':
                            arrNum[i] = arrNum[i] + arrNum[i + 1];
                            break;
                        case '-':
                            arrNum[i] = arrNum[i] - arrNum[i + 1];
                            break;
                    }
                    arrNum.RemoveAt(i + 1);
                }
            }

            for (int i = 0; i < arrOperation.Count; i++) {
                if (arrOperation[i] == operation) {
                    arrOperation.RemoveAt(i);
                }
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBoxRes.Text += "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBoxRes.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxRes.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBoxRes.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBoxRes.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBoxRes.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBoxRes.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBoxRes.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBoxRes.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBoxRes.Text += "9";
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            textBoxRes.Text += "+";
        }

        private void buttonMines_Click(object sender, EventArgs e)
        {
            textBoxRes.Text += "-";
        }

        private void buttonMult_Click(object sender, EventArgs e)
        {
            textBoxRes.Text += "*";
        }

        private void buttonDevide_Click(object sender, EventArgs e)
        {
            textBoxRes.Text += "/";
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            textBoxRes.Text = null;
        }

        private void buttonEquals_Click(object sender, EventArgs e)
        {
            string[] arrNumString = textBoxRes.Text.Split(arrOperationBase);
            foreach (string item in arrNumString)
            {
                arrNum.Add(Convert.ToInt32(item));
            }
            for (int i = 0; i < textBoxRes.Text.Length; i++)
            {
                if (textBoxRes.Text[i] == '+' || textBoxRes.Text[i] == '-' || textBoxRes.Text[i] == '*' || textBoxRes.Text[i] == '/') {
                    arrOperation.Add(textBoxRes.Text[i]);
                }
            }

            calc('*');
            calc('/');
            calc('+');
            calc('-');
            int summ = 0;
            foreach (var item in arrNum) {
                summ += item;
            }
            textBoxRes.Text = Convert.ToString(summ);
            summ = 0;
        }
    }
}
