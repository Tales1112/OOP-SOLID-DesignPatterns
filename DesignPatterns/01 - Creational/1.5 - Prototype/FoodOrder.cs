namespace DesignPatterns._01___Creational._1._5___Prototype
{
    public class OrderInfo
    {
        public int Id;

        public OrderInfo(int id)
        {
            this.Id = id;
        }
    }
    public class FoodOrder : IPrototype
    {
        public string customerName;
        public bool isDelivery;
        public string[] orderContents;
        public OrderInfo info;

        public FoodOrder(string name, bool delivery, string[] contents, OrderInfo info)
        {
            customerName = name;
            isDelivery = delivery;
            orderContents = contents;
            this.info = info;
        }
        public IPrototype DeepCopy()
        {
            FoodOrder clonedOrder = (FoodOrder)this.MemberwiseClone();
            clonedOrder.info = new OrderInfo(this.info.Id);

            return clonedOrder;
        }

        public void Debug()
        {
            System.Console.WriteLine("-----------Prototype Food Order----------");
            System.Console.WriteLine("\nName: {0} \nDelivery: {1}", this.customerName, this.isDelivery);
            System.Console.WriteLine("ID: {0}", this.info.Id);
            System.Console.WriteLine("Order contents" + string.Join(",", orderContents) + "\n");
        }

        public IPrototype ShallowCopy()
        {
            return (FoodOrder)this.MemberwiseClone();
        }
    }
}
