using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2

{

    public class Plane {
        private string namePlane;
        private string nameManufacturer;
        private int realiseYear;
        private string type;

        public Plane(string namePlane, string nameManufacturer, int realiseYear, string type) {
            this.namePlane = namePlane;
            this.nameManufacturer = nameManufacturer;
            this.realiseYear = realiseYear;
            this.type = type;
        }

        public void setNamePlane() {
            Console.WriteLine("Enter plane name: ");
            string name = Console.ReadLine();
            this.namePlane = name;
        }

        public void setNameManufacturer() {
            Console.WriteLine("Enter manufacturer name: ");
            string name = Console.ReadLine();
            this.nameManufacturer = name;
        }

        public void setRealiseYear() {
            Console.WriteLine("Enter realise year: ");
            int data = Convert.ToInt32(Console.ReadLine());
            this.realiseYear = data;
        }

        public void setType() {
            Console.WriteLine("Enter type: ");
            string type = Console.ReadLine();
            this.type = type;
        }

        public void print() {
            Console.WriteLine($"name plane: {namePlane}, name manufacturer: {nameManufacturer}, data: {realiseYear}, type: {type}");
        }


    }
    public class Employee {
        private string name;
        private string surname;
        private string lastname;
        private string age;
        private string number;
        private string mail;
        private string post;
        private List<string> tasks = new List<string>();

        public void setName(string name) {
            this.name = name;
        }

        public void setSurname(string surname) {
            this.surname = surname;
        }

        public void setLastname(string lastname) {
            this.lastname = lastname;
        }

        public void setAge(string age) {
            this.age = age;
        }

        public void setNumber(string number) {
            this.number = number;
        }

        public void setMail(string mail) {
            this.mail = mail;
        }

        public void setPost(string post) {
            this.post = post;
        }

        public void setTasks(List<string> tasks) {
            this.tasks = tasks;
        }

        public void addTasks(string task) {
            this.tasks.Add(task);
        }

        public void print() {
            Console.WriteLine($"name: {name}, surname: {surname}, lastname: {lastname}, age: {age}, number: {number}, mail: {mail}, post: {post}");
            Console.Write($"tasks: ");
            foreach (string item in tasks) {
                Console.Write(item + " ");
            } 
        }


    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee Kirill = new Employee();

            Kirill.setName("Kirill");
            Kirill.setAge("12.12.2009");
            Kirill.setLastname("Nikolavich");
            Kirill.setSurname("Statov");
            Kirill.setNumber("+7-938-109-9523");
            Kirill.setMail("kirillstatov2009@mail.ru");
            Kirill.setPost("Vodolas");
            Kirill.addTasks("walk with his friends");
            Kirill.addTasks("play pubg");
            Kirill.print();
            Console.WriteLine();

            Num num = new Num(2,7);
            num.def();

            Figure a = new Figure();
            //a.square(4);
            //a.rectangle(6, 7);
            a.troian(7);
        }
    }
}
