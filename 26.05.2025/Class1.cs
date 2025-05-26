using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ClassList
{
    public class Class1
    {

    }

    public class PC {
        private string brand;
        private int numSeria;
        private int price;
        private bool case_battle = true;
        private bool onOrOff = false;

        public string Brand {
            set { this.brand = value; }
            get { return brand; }
        }

        public int NumSeria {
            set { this.numSeria = value; }
            get { return numSeria; }
        }

        public int Price{
            set { this.price = value; }
            get { return price; }
        }

        public bool Case_battle {
            set { this.case_battle = value; }
            get { return case_battle; }
        }

        public bool OnOrOff {
            set { this.onOrOff = value; }
            get { return onOrOff; }
        }

        public PC() {
            this.brand = "";
            this.numSeria = 0;
            this.price = 0;
        }

        public PC(string str, int num1, int num2, bool flag) {
            this.brand = str;
            this.numSeria = num1;
            this.price = num2;
            this.case_battle = flag;
        }

        public PC(string str, int num1, int num2) {
            this.brand = str;
            this.numSeria = num1;
            this.price = num2;
        }



    }
}