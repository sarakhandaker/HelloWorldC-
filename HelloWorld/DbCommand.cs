using System;
namespace HelloWorld
{
    public class DbCommand
    { 
        public DbConnection Connection { get; set; }
        public string Instruction { get; }

        public DbCommand(DbConnection connect, string instruction)
        {
            if (connect == null || instruction==null || instruction=="")
                throw new InvalidOperationException("Connection is Null");
            this.Connection = connect;
            this.Instruction = instruction;
        }

        public void Execute()
        {
            this.Connection.OpeningDb();
            Console.WriteLine(this.Instruction); 
            this.Connection.ClosingDb();
        }
    }
}