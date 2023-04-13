using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileworxApp.Classes
{
    internal class clsBuisnessObjectQuery 
    {
        


        public void Run()
        {
            SqlConnection conn = new SqlConnection("Data Source=Nablus-PC;Initial Catalog=old_FileworxApp;Integrated Security=True");
            conn.Open();
            SqlCommand command = new SqlCommand("Select * from [BusinessObject] ", conn);
            using (SqlDataReader reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    Console.WriteLine(String.Format("{0}", reader["id"]));
                }
            }

            conn.Close();
        }
    }
}
