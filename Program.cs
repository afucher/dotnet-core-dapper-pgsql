using System;
using DAO;
using Models;
using Npgsql;

namespace dapperApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var sqlConnection =
        new NpgsqlConnection("Host=localhost;Username=postgres;Password=postgres;Database=dotnet"))
            {
                sqlConnection.Open();
                AuthorDAO authorDAO = new AuthorDAO(sqlConnection);
                
                Author myAuthor = new Author();
                myAuthor.Name = "Arthur";
                authorDAO.Add(myAuthor);

                var authors = authorDAO.FindByName("Arthur");
                foreach(var author in authors){
                    Console.WriteLine(author.Name);
                }

                authorDAO.DeleteAll();

                sqlConnection.Close();
            }
        }
    }
}
