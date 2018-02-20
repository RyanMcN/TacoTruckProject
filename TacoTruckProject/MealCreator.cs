using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TacoTruckProject
{
    class MealCreator
    {
        BaseModel baseModel = new BaseModel();
        ProteinModel proteinModel = new ProteinModel();
        ToppingsModel toppingsModel = new ToppingsModel();
        SidesModel sidesModel = new SidesModel();
        DrinkModel drinkModel = new DrinkModel();

        public string CreateMeal()
        {
            chooseBase();

            chooseProtein();

            chooseToppings();

            chooseSides();

            chooseDrink();

            return "";
        }

        private string chooseBase()
        {
            string baseFood;
            if (baseModel.Flour_Tortilla)
                baseFood = "A base of a Flour Tortilla";
            else if (baseModel.Wheat_Tortilla)
                baseFood = "A base of a Wheat Tortilla";
            else if (baseModel.Chips)
                baseFood = "A base of Tortilla Chips";
            else if (baseModel.Salad)
                baseFood = "A base of Salad";
            else
                baseFood = "Please choose a base";

            return baseFood;
        }

        private string chooseProtein()
        {
            string protein;
            if (proteinModel.Beef)
                protein = "Beef for meat";
            else if (proteinModel.Chicken)
                protein = "Chicken for meat";
            else if (proteinModel.Fish)
                protein = "Fish for meat";
            else
                protein = "No meat";

            return protein;
        }

        private string chooseToppings()
        {
            string toppings = "For toppings you chose:";

            if (toppingsModel.Cheese)
                toppings += toppings + " cheese";
            if (toppingsModel.Cilantro)
                toppings += toppings + " cilantro";
            if (toppingsModel.Guacamole)
                toppings += toppings + " guacamole";
            if (toppingsModel.Lettuce)
                toppings += toppings + " lettuce";
            if (toppingsModel.Sour_Cream)
                toppings += toppings + " sour cream";
            if (toppingsModel.Tomatoes)
                toppings += toppings + " tomatoes";
            else
                toppings = "no toppings";
            return toppings;
        }

        private string chooseSides()
        {
            string sides = "on the side you have:";

            if (sidesModel.ChipGuac)
                sides += sides + "Chips with Guacamole";
            if (sidesModel.ChipSalsa)
                sides += sides + "Chips with Salsa";
            if (sidesModel.ChipQueso)
                sides += sides + "Chips with Queso";
            if (sidesModel.RiceBeans)
                sides += sides + "Rice and Beans";
            else
                sides = "with nothing on the side";

            return sides;
        }

        private string chooseDrink()
        {
            string drink;
            if (drinkModel.Coke)
                drink = "and a Coke to drink";
            else if (drinkModel.DietCoke)
                drink = "and a Diet Coke to drink";
            else if (drinkModel.Sprite)
                drink = "and a Sprite to drink";
            else if (drinkModel.MrPibb)
                drink = "and a Mr. Pibb to drink";
            else if (drinkModel.SweetTea)
                drink = "and a Sweet Tea to drink";
            else if (drinkModel.Water)
                drink = "and a Water to drink";
            else
                drink = "and nothing to drink.";

            return drink;
        }
    }
}
