using System;

namespace databaseConnection
{
    class Program
    {
        static void Main(string[] args)
        {
            var dbConnection = new OracleConnection("Connect");
            dbConnection.OpenConnection();
            dbConnection.CloseConnection();
        }
    }
}
