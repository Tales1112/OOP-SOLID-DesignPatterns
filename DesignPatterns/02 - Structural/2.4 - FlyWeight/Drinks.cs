using System;
using System.Collections.Generic;

namespace DesignPatterns._02___Structural._2._4___FlyWeight
{
   //FlyWeight blue 
   public interface IDrinkFlyWeight
    {
        //intrisict state - share/readonly
        string Name { get; }

        //extrinsict state
        void Server(string size);
    }

    public class Expresso : IDrinkFlyWeight
    {
        private string _name;
        public string Name { get { return _name; } }
        private IEnumerable<string> _ingredients;

        public Expresso()
        {
            _name = "Espresso";
            _ingredients = new List<string>()
            {
                "Coffe Beans",
                "Hot Water"
            };
        }
        public void Server(string size)
        {
            Console.WriteLine($"{size} {_name} with {string.Join(", ", _ingredients)} coming up!");
        }
    }

    public class BananaSmoothie : IDrinkFlyWeight
    {
        private string _name;
        public string Name { get { return _name; } }
        private IEnumerable<string> _ingredients;

        public BananaSmoothie()
        {
            _name = "Banan Smoothie";
            _ingredients = new List<string>()
            {
                "Banana",
                "Whole Milk",
                "Vanilla Extract"
            };

        }

        public void Server(string size)
        {
            Console.WriteLine($"{size} {_name} with {string.Join(", ", _ingredients)} coming up!");
        }
    }

    //Unshared concrete FlyWeight
    public class DrinkGiveAaway : IDrinkFlyWeight
    {
        //AllState
        public string Name { get { return _randomDrink.Name; } }
        private IDrinkFlyWeight [] _elegibleDrinks = new IDrinkFlyWeight []
        {
            new Expresso(),
            new BananaSmoothie()
        };

        private IDrinkFlyWeight _randomDrink;
        private string _size;

        public DrinkGiveAaway()
        {
            var randomIndex = new Random().Next(0,2);
            _randomDrink = _elegibleDrinks[randomIndex];
        }

        public IDrinkFlyWeight CreateGiveAway()
        {
            return new DrinkGiveAaway();
        }

        //Extrinsic state
        public void Server(string size)
        {
            _size = size;
            Console.WriteLine($"Free GiveAaway!");
            Console.WriteLine($"- {_size} {_randomDrink.Name} coming up!");
        }
    }
}
