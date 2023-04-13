using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileworxApp.Classes
{
    public class clsUsersQuery:clsBuisnessObjectQuery
    {
        public List<clsUser> UsersList { get; set; } = new List<clsUser>();

        public void Run()
        {
            SqlConnection conn = new SqlConnection(clsSqlConnection.ConnectionString);
            conn.Open();
            SqlCommand command = new SqlCommand(@"SELECT *
                                                    FROM [FileworxApp].[dbo].[BusinessObject]
                                                    INNER JOIN [FileworxApp].[dbo].[FXUsers]
                                                    ON [FileworxApp].[dbo].[BusinessObject].ID = [FileworxApp].[dbo].[FXUsers].ID", conn);
            SqlDataReader Reader = command.ExecuteReader();

            while (Reader.Read())
            {
                clsUser files = new clsUser()
                {
                    ID = Reader["ID"].ToString(),
                    Name = Reader["Name"].ToString(),
                    Description = Reader["Description"].ToString(),
                    CreationDate = Reader["CreationDate"].ToString(),
                    LastModifier = Reader["LastModifier"].ToString(),
                    ClassID = Convert.ToInt32(Reader["ClassID"]),
                    FullName = Reader["FullName"].ToString(),
                    Password= Reader["Password"].ToString(),
                };
                UsersList.Add(files);
            }
            conn.Close();
        }
    }
}
