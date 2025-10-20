using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp8
{
    public static class Connection
    {
        public static void connect() {
            string connectionString = @"Server=(localdb)\mssqllocaldb;Database=babahov;Trusted_Connection=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Команда для извлечения данных из таблицы Employees
                string query = "SELECT * FROM Employees";

                // Создаем SqlDataAdapter с командой SELECT
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

                // Создаем DataSet
                DataSet dataSet = new DataSet();

                // Заполняем DataSet данными из базы
                adapter.Fill(dataSet, "Employees");

                // Получаем таблицу из DataSet
                DataTable employeesTable = dataSet.Tables["Employees"];

                // Выводим все имена сотрудников
                foreach (DataRow row in employeesTable.Rows)
                {
                    Console.WriteLine(row["name"]); // предположим, есть колонка "Name"
                }
            }
        }

        public static void addUser() {
            string connectionString = @"Server=(localdb)\mssqllocaldb;Database=babahov;Trusted_Connection=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Employees";

                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

                // Объект командBuilder для автоматической генерации команд Insert, Update, Delete
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(adapter);

                DataSet dataSet = new DataSet();

                // Загружаем таблицу
                adapter.Fill(dataSet, "Employees");

                DataTable employeesTable = dataSet.Tables["Employees"];

                // Создаем нового сотрудника
                DataRow newRow = employeesTable.NewRow();
                newRow["name"] = "Mina";  
                newRow["position"] = "Coocking"; 
                newRow["salary"] = "1500"; 

                // Добавляем новую строку в таблицу
                employeesTable.Rows.Add(newRow);

                // Сохраняем изменения в базе
                adapter.Update(dataSet, "Employees");
            }
        }

        public static void update() {
            string connectionString = @"Server=(localdb)\mssqllocaldb;Database=babahov;Trusted_Connection=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Employees WHERE Name = 'Arsenii'";

                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(adapter);

                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet, "Employees");

                DataTable employeesTable = dataSet.Tables["Employees"];

                // Предположим, нашли нужного сотрудника
                if (employeesTable.Rows.Count > 0)
                {
                    DataRow row = employeesTable.Rows[0];

                    row["position"] = "not work";

                    adapter.Update(dataSet, "Employees");
                }
                else
                {
                    Console.WriteLine("Сотрудник не найден");
                }
            }
        }
    }
}
