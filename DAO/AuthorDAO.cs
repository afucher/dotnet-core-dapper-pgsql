using System.Collections.Generic;
using System.Data;
using Dapper;
using Models;

namespace DAO
{
    public class AuthorDAO
    {
        private IDbConnection connection;
        public AuthorDAO(IDbConnection connection)
        {
            this.connection = connection;
        }
        public void DeleteAll()
        {
            this.connection.Execute(@"delete from Authors");
        }
        public List<Author> ReadAll()
        {
            return connection.Query<Author>(@"select name from Authors").AsList(); 
        }

        public Author Add(Author author){
            string insertQuery = @"INSERT INTO Authors(Name) VALUES (@Name)";
            var result = connection.Execute(insertQuery,author);
            return author;
        }
    }
}