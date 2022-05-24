using DesignPatterns.FactoryMethod;
using System;

namespace DesignPatterns._01___Creational._1._2___Factory_Method
{
    public class MongoDbConnector : DbConnector
    {
        public MongoDbConnector(string connectionString) : base(connectionString)
        {
        }

        public override Connection Connect()
        {
            Console.WriteLine("Conectando ao banco MongoDb...");
            var connection = new Connection(ConnectionString);
            connection.Open();

            return connection;
        }
    }
}
