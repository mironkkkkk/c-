using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    public class Users
    {
        private string login;
        private string pass;
        private string name;
        private int age;

        public string Login {
            get { return login; }
            set { login = value; }
        }

        public string Pass {
            get { return pass; }
            set { pass = value; }
        }

        public string Name {
            get { return name; }
            set { name = value; }
        }

        public int Age {
            get { return age; }
            set {age = value; }
        }

        public Users(string login, string pass, string name, int age) { 
            this.login = login;
            this.pass = pass;
            this.name = name;
            this.age = age;
        }
    }
}
