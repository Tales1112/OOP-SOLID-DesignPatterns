namespace DesignPatterns._01___Creational._1._2___Factory_Method.Factory_Method_3.Commerce
{
    public class Item
    {
        public string Id { get; }
        public string Name { get; }
        public decimal Price { get; }

        public Item(string id, string name, decimal price)
        {
            Id = id;
            Name = name;   
            Price = price;
        }
    }
}
