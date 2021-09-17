namespace Extensibility
{
    class Program
    {
        static void Main(string[] args)
        {
            DbMigrator dbMigrator = new DbMigrator(new ConsoleLogger());
            dbMigrator.Migrate();

            DbMigrator dbMigrator2 = new DbMigrator(new FileLogger(@"C:\Saloni\log.txt"));
            dbMigrator2.Migrate();
        }
    }
}
