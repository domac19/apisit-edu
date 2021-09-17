using System;

namespace databaseConnection
{
    public abstract class DbConnection
    {
        private string _connectionString { get; set; }
        public TimeSpan Timeout { get; set; }

        public DbConnection(string connectionString)
        {
            if (connectionString == "")
            {
                throw new Exception("ConnectionString can not be empty!");
            }
            else if (connectionString == null)
            {
                throw new Exception("ConnectionString can not have null values!");
            }
            _connectionString = connectionString;
        }
        public abstract void OpenConnection();
        public abstract void CloseConnection();
    }
}
