using System;
using System.Diagnostics;
namespace databaseCommand
{
    namespace databaseConnection
    {
        public class OracleConnection : DbConnection
        {
            public OracleConnection(string connectionString) : base(connectionString)
            {
            }

            public override void OpenConnection()
            {
                var stopWatch = new Stopwatch();
                stopWatch.Start();
                if (stopWatch.Elapsed.TotalSeconds < TimeBase.Seconds)
                {
                    Console.WriteLine("Open connection to database!");
                }
                stopWatch.Stop();
            }
            public override void CloseConnection()
            {
                Console.WriteLine("Close connection to database!");
            }
        }
    }
}
