using System;

namespace databaseCommand
{
    class Program
    {
        static void Main(string[] args)
        {
            var dbCommand = new DbCommand(new SqlConnection("Sql string"), "SELECT * FROM Persons"); 
            dbCommand.Execute();
        }
    }
}
