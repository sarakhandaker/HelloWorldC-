using System;
namespace HelloWorld
{
    public class SqlConnection : DbConnection
    {
        public SqlConnection(string connect) : base(connect)
            {
            }

        public override void ClosingDb()
        {
            Console.WriteLine("Closing SQL");
        }

        public override void OpeningDb()
        {
            Console.WriteLine("Opening SQL");
        }
    }

    public class OracleConnection: DbConnection
    {
        public OracleConnection(string connect) : base(connect)
        {
        }

        public override void ClosingDb()
        {
            Console.WriteLine("Closing Oracle");
        }

        public override void OpeningDb()
        {
            Console.WriteLine("Opening Oracle");
        }
    }

    public abstract class DbConnection
    {
        public string ConnectionString { get; set; }
        public TimeSpan Timeout { get; set; }

        public DbConnection(string connection)
        {
            if (String.IsNullOrWhiteSpace(connection))
                throw new InvalidOperationException("ConnectionString is Null");
            this.ConnectionString = connection;
        }

        public abstract void OpeningDb();

        public abstract void ClosingDb();
    }
}