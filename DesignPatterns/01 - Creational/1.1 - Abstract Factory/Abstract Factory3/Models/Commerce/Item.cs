namespace DesignPatterns._01___Creational._1._1___Abstract_Factory.Abstract_Factory3.Models.Commerce
{
    public class Item
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        public Item(string id, string name, decimal price)
        {
            Id = id;
            Name = name;
            Price = price;
        }
    }
}
