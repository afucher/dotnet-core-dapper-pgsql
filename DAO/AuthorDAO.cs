using System.Collections.Generic;
using System.Data;
using Dapper;

namespace DAO
{
    public class AuthorDAO
    {
        private IDbConnection connection;
        public AuthorDAO(IDbConnection connection)
        {
            this.connection = connection;
        }
        public void deleteAll()
        {
            this.connection.Execute(@"delete from Authors");
        }
        public List<Models.Author> ReadAll()
        {
            return connection.Query<Models.Author>(@"select name from Authors").AsList(); 
        }

        public Models.Author Add(Models.Author author){
            string insertQuery = @"INSERT INTO Authors(Name) VALUES (@Name)";
            var result = connection.Execute(insertQuery,author);
            return author;
        }
    }
}