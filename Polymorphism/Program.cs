using System;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            var connection = new SqlConnection("This is Sql connection");
            string instruction = "First Instruction";

            DBCommand dBCommand = new DBCommand(connection, instruction);
            dBCommand.Execute();

            var oracleConnection = new OracleConnection("This is Oracle connection");
            string instruction2 = "Second Instruction";

            DBCommand dBCommand2 = new DBCommand(oracleConnection, instruction2);
            dBCommand2.Execute();

        } 
    }
}
