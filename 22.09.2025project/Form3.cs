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
        public string numberOrdesr;
        public List<List<string>> arrOrdesrList;
        public Form3(string login, string numberOrders, List<List<string>> arrOrdersList)
        {
            this.login = login;
            this.numberOrdesr = numberOrders;
            this.arrOrdesrList = arrOrdersList;
            InitializeComponent();

            Console.WriteLine(login);
            Console.WriteLine(numberOrders);
            foreach (var item in arrOrdesrList) {
                foreach (var items in item) {
                    Console.WriteLine(items);
                }
                Console.WriteLine("\n");
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
