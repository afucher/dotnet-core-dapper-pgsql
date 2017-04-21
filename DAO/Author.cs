using System.Collections.Generic;
using System.Data;
using Dapper;

namespace DAO
{
    public class Author
    {
        private IDbConnection connection;
        public Author(IDbConnection connection)
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
    }
}