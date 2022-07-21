namespace DesignPatterns._01___Creational._1._5___Prototype
{
    public abstract class Prototype
    {
        public abstract Prototype ShallowCopy();
        public abstract Prototype DeppCopy();
        public abstract void Debug();
    }
    public class OrderInfo
    {
        public int Id;

        public OrderInfo(int id)
        {
         this.Id = id;  
        }
    }
    public class FoodOrder : Prototype
    {
        public string customerName;
        public bool isDelivery;
        public string[] orderContents;
        public OrderInfo info;

        public FoodOrder(string name, bool delivery, string[] contents,OrderInfo info)
        {
            customerName = name;
            isDelivery = delivery;
            orderContents = contents;
            this.info = info;
        }
        public override Prototype ShallowCopy()
        {
            return (Prototype)this.MemberwiseClone();
        }

        public override Prototype DeppCopy()
        {
            FoodOrder clonedOrder = (FoodOrder)this.MemberwiseClone();
            clonedOrder.info = new OrderInfo(this.info.Id);

            return clonedOrder;
        }

        public override void Debug()
        {
            System.Console.WriteLine("-----------Prototype Food Order----------");
            System.Console.WriteLine(this.customerName,this.isDelivery);
            System.Console.WriteLine("Order contents" + string.Join(",",orderContents));
            System.Console.WriteLine(this.info.Id);
        }
    }
}
