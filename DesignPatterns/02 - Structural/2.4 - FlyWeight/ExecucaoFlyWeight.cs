using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns._02___Structural._2._4___FlyWeight
{
    public class ExecucaoFlyWeight
    {
        public static void Executar()
        {
            var drinkFactory = new DrinkFactory();
            drinkFactory.ListDrinks();

            var largeExpresso = drinkFactory.GetDrink("Expresso");
            largeExpresso.Server("Large");

            var mediumSmoothie = drinkFactory.GetDrink("BananaSmoothie");
            mediumSmoothie.Server("Medium");

        }
    }
}
