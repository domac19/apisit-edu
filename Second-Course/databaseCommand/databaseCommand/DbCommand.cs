using System;
namespace databaseCommand
{
    public class DbCommand
    {
        private string _instructionDatabase;
        private SqlConnection _dbConnection;

        public DbCommand(SqlConnection dbConnection, string instructionDatabase)
        {
            if (dbConnection == null)
            {
                throw new Exception("Connection string can not be null or empty!");
            }
            else if (String.IsNullOrEmpty(instructionDatabase))
            {
                throw new Exception("Instruction can not be null or empty!");
            }
            _instructionDatabase = instructionDatabase;
            _dbConnection = dbConnection;
        }
        public void Execute()
        {
            _dbConnection.OpenConnection();
            Console.WriteLine(_instructionDatabase);
            _dbConnection.CloseConnection();
        }
    }
}
