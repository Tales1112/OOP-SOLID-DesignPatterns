using DesignPatterns.FactoryMethod;

namespace DesignPatterns._01___Creational._1._2___Factory_Method
{
    public class MongoDbFactory : DbFactory
    {
        public override DbConnector CreateConnector(string connectionString)
        {
           return new MongoDbConnector(connectionString);
        }
    }
}
