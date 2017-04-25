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
                AuthorDAO authorDAO = new AuthorDAO(sqlConnection);
                authorDAO.DeleteAll();

                sqlConnection.Close();
            }
        }
    }
}
