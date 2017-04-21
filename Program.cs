using System;
using System.Collections;
using Dapper;
using Npgsql;

namespace hwapp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var sqlConnection =
        new NpgsqlConnection("Host=localhost;Username=postgres;Password=postgres;Database=dotnet"))
            {
                sqlConnection.Open();

                IEnumerable authors =
                    sqlConnection.Query("Select * from Authors");

                foreach (Author author in authors)
                {
                    Console.Write(author);
                }

                sqlConnection.Close();
            }
        }
    }
}
