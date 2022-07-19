namespace DesignPatterns._01___Creational._1._4___Builder
{
    public class FurnitureItem
    {
        public string Name;
        public double Price;
        public double Height;
        public double Width;
        public double Weight;

        public FurnitureItem(string name, double price, double height, double width, double weight)
        {
            Name = name;
            Price = price;
            Height = height;
            Width = width;
            Weight = weight;    
        }
    }
}
