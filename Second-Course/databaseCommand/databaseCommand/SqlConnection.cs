using System;
using System.Diagnostics;

namespace databaseCommand
{
        public class SqlConnection : DbConnection
        {
            public SqlConnection(string connectionString) : base(connectionString)
            {
            }

            public override void OpenConnection()
            {
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();
                if (stopwatch.Elapsed.TotalSeconds < TimeBase.Seconds)
                {
                    Console.WriteLine("Open connection to SQL database!");
                }
                else
                {
                    throw new TimeoutException("Connection to database was not opened in time");
                }

                stopwatch.Stop();
            }

            public override void CloseConnection()
            {
                Console.WriteLine("Close connection to SQL database!");
            }
        }
    }
