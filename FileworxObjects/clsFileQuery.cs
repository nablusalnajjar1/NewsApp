using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileworxApp.Classes
{
    public class clsFileQuery:clsBuisnessObjectQuery
    {
     
        public List<clsFile> FilesList { get; set; }= new List<clsFile>();

        public void Run()
        {
            SqlConnection conn = new SqlConnection(clsSqlConnection.ConnectionString);
            conn.Open();
            SqlCommand command = new SqlCommand(@"SELECT *
                                                    FROM [FileworxApp].[dbo].[BusinessObject]
                                                    INNER JOIN [FileworxApp].[dbo].[FXFile]
                                                    ON [FileworxApp].[dbo].[BusinessObject].ID = [FileworxApp].[dbo].[FXFile].ID", conn);
            SqlDataReader Reader = command.ExecuteReader();
            
                while(Reader.Read())
                {
                clsFile files = new clsFile()
                {
                    ID = Reader["ID"].ToString(),
                    Name = Reader["Name"].ToString(),
                    Description = Reader["Description"].ToString(),
                    CreationDate = Reader["CreationDate"].ToString(),
                    LastModifier = Reader["LastModifier"].ToString(),
                    ClassID = Convert.ToInt32(Reader["ClassID"]),
                    Body = Reader["body"].ToString()
                };

                FilesList.Add(files);
            }
            conn.Close();
        }
    }
}
