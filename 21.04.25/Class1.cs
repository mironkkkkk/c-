using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Employee
    {
        private string name;
        private int age;
        private decimal salary;

        public string Name {
            get { return name; }
            set { name = value; }
        }

        public int Age {
            get { return age; }
            set { age = value; }
        }

        public decimal Salary {
            get { return salary; }
            set { salary = value; }
        }

        public Employee(string name, int age, decimal salary) {
            this.name = name;
            this.age = age;
            this.salary = salary;
        }

        public void print() {
            Console.WriteLine($"name: {name} \nage: {age} \nsalary: {salary}");
        }

        public static Employee operator +(Employee worker, decimal salary2)
        {
            worker.salary += salary2;
            return worker;
        }

        public static Employee operator -(Employee worker, decimal salary2)
        {
            worker.salary -= salary2;
            return worker;
        }

        public static bool operator ==(Employee worker1, Employee worker2)
        {
            if (worker1.salary == worker2.salary) { return true; }
            else { return false; }
        }

        public static bool operator !=(Employee worker1, Employee worker2)
        {
            if (worker1.salary != worker2.salary) { return true; }
            else { return false; }
        }

        public static bool operator >(Employee worker1, Employee worker2)
        {
            if (worker1.salary > worker2.salary) { return true; }
            else { return false; }
        }

        public static bool operator <(Employee worker1, Employee worker2)
        {
            if (worker1.salary < worker2.salary) { return true; }
            else { return false; }
        }
    }
}
