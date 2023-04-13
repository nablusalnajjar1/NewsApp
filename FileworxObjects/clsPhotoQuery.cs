using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileworxApp.Classes
{
    public class clsPhotoQuery:clsFileQuery
    {
        public List<clsphoto> PhotoList { get; set; } = new List<clsphoto>();

        public void Run()
        {
            SqlConnection conn = new SqlConnection(clsSqlConnection.ConnectionString);
            conn.Open();
            SqlCommand command = new SqlCommand(@"SELECT *
                                                    FROM [FileworxApp].[dbo].[BusinessObject]
                                                    INNER JOIN [FileworxApp].[dbo].[FXFile]
                                                    ON [FileworxApp].[dbo].[BusinessObject].ID = [FileworxApp].[dbo].[FXFile].ID INNER JOIN [FileworxApp].[dbo].[FXPhoto]  ON [FileworxApp].[dbo].[FXFile].ID = [FileworxApp].[dbo].[FXPhoto].ID", conn);
            SqlDataReader Reader = command.ExecuteReader();

            while (Reader.Read())
            {
                clsphoto files = new clsphoto()
                {
                    ID = Reader["ID"].ToString(),
                    Name = Reader["Name"].ToString(),
                    Description = Reader["Description"].ToString(),
                    CreationDate = Reader["CreationDate"].ToString(),
                    LastModifier = Reader["LastModifier"].ToString(),
                    ClassID = Convert.ToInt32(Reader["ClassID"]),
                    Body = Reader["body"].ToString(),
                    PhotoPath = Reader["PhotoPath"].ToString()
                };

                FilesList.Add(files);
            }
            conn.Close();
        }
    }
}
