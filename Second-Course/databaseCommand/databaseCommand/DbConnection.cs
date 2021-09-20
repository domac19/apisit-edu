using System;
namespace databaseCommand
{
    public abstract class DbConnection
    {
        private string _connectionString { get; set; }
        public TimeSpan TimeBase
        {
            get
            {
                var timeout = DateTime.Now.Subtract(DateTime.Now.AddSeconds(-15));
                return timeout;
            }
        }

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
