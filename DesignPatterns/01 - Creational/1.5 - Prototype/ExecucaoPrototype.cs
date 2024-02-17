namespace DesignPatterns._01___Creational._1._5___Prototype
{
    public  class ExecucaoPrototype
    {
        public static void Executar()
        {
            System.Console.WriteLine("Original order:");
            FoodOrder savedOrder = new FoodOrder("Harrison", true, new string[] { "Pizza", "Coke" }, new OrderInfo(2345));

            savedOrder.Debug();

            System.Console.WriteLine("Cloned order: ");
            FoodOrder clonedOrder = (FoodOrder)savedOrder.DeepCopy();
            clonedOrder.Debug();

            System.Console.WriteLine("Order changes:");
            savedOrder.customerName = "Jeff";
            savedOrder.info.Id = 5555;
            savedOrder.Debug();
            clonedOrder.Debug();
        }
    }
}
