using System.Collections.Generic;

namespace DesignPatterns._02___Structural._2._4___FlyWeight
{
   public class DrinkFactory
    {
        private Dictionary<string, IDrinkFlyWeight> _drinkCache = new Dictionary<string, IDrinkFlyWeight>();
        public int ObjectsCreated = 0;

        public IDrinkFlyWeight GetDrink(string drinkKey)
        {
            IDrinkFlyWeight drink = null;

            if (_drinkCache.ContainsKey(drinkKey))
            {
                System.Console.WriteLine("\nReusing existing flyweight object.");
                return _drinkCache[drinkKey];
            }
            else
            {
                System.Console.WriteLine("\nCreating new flyWeight object.");
                switch (drinkKey)
                {
                    case "Expresso":
                        drink = new Expresso();
                        break;
                    case "BananaSmoothie":
                        drink = new BananaSmoothie();
                        break;
                    default:
                        throw new System.Exception("This is not a flyweight drink object...");
                }
            }
            _drinkCache.Add(drinkKey, drink);
            ObjectsCreated++;
            return drink;
        }

        public void ListDrinks()
        {
            System.Console.WriteLine($"\nFactory has {_drinkCache.Count} drink objects ready to user");
            System.Console.WriteLine($"Number of objects created: {ObjectsCreated}");

            foreach (var drink in _drinkCache)
            {
                System.Console.WriteLine($"\t{drink.Value.Name}");

                System.Console.WriteLine("\n");
            }
        }
    }
}
