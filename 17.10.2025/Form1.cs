using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Task arr = DataConnection.showData();
            List<string> list = await arr;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
