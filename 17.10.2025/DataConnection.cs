using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp7
{
    static class DataConnection
    {

        public static async Task<List<string>> showData() {
            using (SqlConnection SqlConnect = new SqlConnection(@"Server=(localdb)\test;Database=master;Trusted_Connection=True")) {
                List<string> values = new List<string>();
                string sqlText = $"select * from orders";
                await SqlConnect.OpenAsync();
                SqlCommand command = new SqlCommand(sqlText, SqlConnect);
                SqlDataReader reader = command.ExecuteReader();
                using (reader) {
                    while (reader.Read()) {
                        int id = reader.IsDBNull(0) ? -1:reader.GetInt32(0);
                        int price = reader.IsDBNull(0) ? -1 : reader.GetInt32(1);
                        DateTime date = reader.IsDBNull(0) ? Convert.ToDateTime("0000.00.00") : reader.GetDateTime(2);
                        string name = reader.IsDBNull(0) ? null : reader.GetString(3);
                        values.Add(Convert.ToString(id));
                        values.Add(Convert.ToString(price));
                        values.Add(Convert.ToString(date));
                        values.Add(name);
                        return values;
                    }
                }
                return values;

            }
        }



    }
}
