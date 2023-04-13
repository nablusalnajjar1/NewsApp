using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileworxApp.Classes
{
    public class clsNewsQuery:clsFileQuery
    {
        public List<clsNews> NewsList { get; set; } = new List<clsNews>();

        public void Run()
        {
            SqlConnection conn = new SqlConnection(clsSqlConnection.ConnectionString);
            conn.Open();
            SqlCommand command = new SqlCommand(@"SELECT *
                                                    FROM [FileworxApp].[dbo].[BusinessObject]
                                                    INNER JOIN [FileworxApp].[dbo].[FXFile]
                                                    ON [FileworxApp].[dbo].[BusinessObject].ID = [FileworxApp].[dbo].[FXFile].ID INNER JOIN [FileworxApp].[dbo].[FXNews]  ON [FileworxApp].[dbo].[FXFile].ID = [FileworxApp].[dbo].[FXNews].ID", conn);
            SqlDataReader Reader = command.ExecuteReader();

            while (Reader.Read())
            {
                clsNews files = new clsNews()
                {
                    ID = Reader["ID"].ToString(),
                    Name = Reader["Name"].ToString(),
                    Description = Reader["Description"].ToString(),
                    CreationDate = Reader["CreationDate"].ToString(),
                    LastModifier = Reader["LastModifier"].ToString(),
                    ClassID = Convert.ToInt32(Reader["ClassID"]),
                    Body = Reader["body"].ToString(),
                    Category = Reader["category"].ToString()
                };

                FilesList.Add(files);
            }
            conn.Close();
        }
    }
}
