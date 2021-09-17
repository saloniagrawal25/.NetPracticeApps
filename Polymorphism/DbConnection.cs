using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    public abstract class DbConnection
    {
        public string ConnectionString { get; set; }
        public TimeSpan Timeout { get; set; }

        public DbConnection(string connectionString)
        {
            if (!string.IsNullOrEmpty(connectionString))
            {
                this.ConnectionString = connectionString;
            }
            else
                throw new ArgumentNullException();
        }

        public abstract void OpenConnection();

        public abstract void CloseConnection();
    }

    public class SqlConnection : DbConnection
    {
        public SqlConnection(string connectionString) : base(connectionString)
        {

        }
        public override void OpenConnection()
        {
            Console.WriteLine("Sql Connection is open : {0}", ConnectionString);
        }

        public override void CloseConnection()
        {
            Console.WriteLine("Sql Connection is closed: {0}", ConnectionString);
        }
    }

    public class OracleConnection : DbConnection
    {
        public OracleConnection(string connectionString) : base(connectionString)
        {

        }
        public override void OpenConnection()
        {
            Console.WriteLine("Oracle Connection is open: {0}", ConnectionString);
        }

        public override void CloseConnection()
        {
            Console.WriteLine("Oracle Connection is closed: {0}", ConnectionString);
        }
    }

    public class DBCommand
    {
        DbConnection _dbConnection;
        string _instruction;
        public DBCommand(DbConnection dbConnection, string instruction)
        {
            if (dbConnection != null && !string.IsNullOrEmpty(instruction))
            {
                this._dbConnection = dbConnection;
                this._instruction = instruction;
            }
            else
                throw new ArgumentNullException();
        }

        public void Execute()
        {
            _dbConnection.OpenConnection();
            Console.WriteLine("Run the instruction : {0}", _instruction);
            _dbConnection.CloseConnection();
        }
    }
}
