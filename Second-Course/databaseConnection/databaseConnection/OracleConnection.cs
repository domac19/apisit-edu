using System;
namespace databaseConnection
{
    public class OracleConnection : DbConnection
    {
        public OracleConnection(string connectionString) : base(connectionString)
        {
        }

        public override void OpenConnection()
        {
            Console.WriteLine("Open connection to database!");
        }
        public override void CloseConnection()
        {
            Console.WriteLine("Close connection to database!");
        }
    }
}
