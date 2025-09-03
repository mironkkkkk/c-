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

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        int numTest;
        List<string> test = new List<string>();
        public Form3(int num)
        {
            numTest = num;
            InitializeComponent();
            label2.Text = numTest.ToString();

            using (StreamReader reader = new StreamReader("C:\\Users\\Взрослая академия\\source\\repos\\WindowsFormsApp1\\WindowsFormsApp1\\data.csv"))
            {
                while (!reader.EndOfStream)
                {
                    string[] str = reader.ReadLine().Split('.');
                    if (Convert.ToInt32(str[0]) == numTest) {
                        for (int i = 1; i < str.Length; i++) {
                            test.Add(str[i]);
                        }
                    }
                }
            }

            foreach (string item in test)
            {
                Console.WriteLine(item + "\n");
            }

            List<System.Windows.Forms.Button> ListBtn = new List<System.Windows.Forms.Button> { button1, button2, button3, button4, button5, button6 };
            List<Label> ListLabel = new List<Label> { label3, label4, label5 };

            for (int i = 0; i < ListBtn.Count; i++) {
                if (i % 2 == 0) {
                    ListBtn[i].Text = test[0].Split(',')[1];
                }
                else {
                    ListBtn[i].Text = test[0].Split(',')[2].Split(':')[0];
                }
            }

            for (int i = 0; i < ListLabel.Count; i++) {
                ListLabel[i].Text = test[i].Split(',')[0];
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
