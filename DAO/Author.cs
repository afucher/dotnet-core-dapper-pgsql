using System.Data;
using Dapper;

namespace DAO
{
    public class Author
    {
        private IDbConnection connection;
        public Author(IDbConnection connection){
            this.connection = connection;
        }
        public void deleteAll()
        {
            this.connection.Execute(@"delete from Authors");
        }
    }
}