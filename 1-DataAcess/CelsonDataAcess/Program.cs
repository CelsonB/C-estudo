// See https://aka.ms/new-console-template for more information
using Microsoft.Data.SqlClient;
using Dapper;
using CelsonDataAcess.Models;

using System.ComponentModel;
using System.Security;

class Program
    {
        static void Main(string[] args) 
        {
        const string connectionString = "Server=localhost,1433;Database=balta;User ID=sa;Password=1q2w3e4r@#$";

        using (var connection = new SqlConnection(connectionString))
        {
            //UpdateCategory(connection);
            //ListCategories(connection);
            OneToOne(connection);
        }
               


        }
   
    
        
  

        static void ListCategories(SqlConnection connection)
        {
            var categories = connection.Query<Category>("SELECT [Id], [Title]  FROM [Category]");
            foreach (var cat in categories)
            {
                Console.WriteLine($"{cat.Id} - {cat.Title}");
            }
        }

        static void CreateCategory(SqlConnection connection)
        {
            var category = new Category();
            category.Id = Guid.NewGuid();
            category.Title = "amazon aws";
            category.Url = "Amazon";
            category.Description = "categoria destinado ao serviço AWS";
            category.Order = 8;
            category.Summary = "aws cloud";
            category.Featured = false;


            var insertSql = @"INSERT INTO [Category] VALUES (@Id,@Title,@Url,@Summary,@Order, @Description, @Featured)";


            
                var rows = connection.Execute(insertSql, new
                {
                    category.Id,
                    category.Title,
                    category.Url,
                    category.Description,
                    category.Order,
                    category.Summary,
                    category.Featured
                });
                Console.WriteLine($"{rows} linhas inseridas");
            

        }

        static void UpdateCategory(SqlConnection connection)
        {
        var updateQuery = "UPDATE [Category] SET [Title]=@title WHERE [Id] = @id";

        var rows = connection.Execute(updateQuery, new
        {
            id = new Guid("af3407aa-11ae-4621-a2ef-2028b85507c4"),
            title = "frontend 2021"
        });
        Console.WriteLine($"{rows} atualizados com sucesso");
        }


        static void OneToOne(SqlConnection connection)
        {
        var sql = @"SELECT * FROM [CareerItem] INNER JOIN [Course] on [CareerItem].[CourseId] = [Course].[Id]";

        var items = connection.Query<CareerItem, Course, CareerItem>
            (sql, (careerItem,course) 
            => { careerItem.Course = course; return careerItem; 
            }, splitOn: "Id");

       
            foreach (var item in items)

            {
                Console.WriteLine(item.Course.Title);
            }
        

        }
        

}