using DAO;
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
                Author author = new Author(sqlConnection);
                author.deleteAll();

                sqlConnection.Close();
            }
        }
    }
}
