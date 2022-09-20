using System;

namespace Deliverable2
{
    internal class Program
    {

        public static int numPeople;
        public static string drinkChoice;
        public static int numDrinksCoke;
        public static int numDrinksWater;
        public const double PRICE_BUFFET = 9.99;
        public const double PRICE_COKE = 2.50;
        public const double PRICE_WATER = 0.00;

        public static double totalFood;
        public static double totalBeverages;
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, how many people in your group?");
            numPeople = int.Parse(Console.ReadLine());

            if(numPeople > 6)
            {
                Console.WriteLine("I'm sorry, we can only seat parties of 6 or less.");
                Environment.Exit(0);
            }

            Console.WriteLine("Okay, follow me. I'll seat you at your table.\n");

            for (int i = 0; i < numPeople; i++)
            {

                Console.WriteLine("What would you like to drink? We have coke or water.");

                drinkChoice = Console.ReadLine();

                if (drinkChoice.ToUpper() == "COKE")
                {
                    numDrinksCoke++;
                }
                else if (drinkChoice.ToUpper() == "WATER")
                {
                    numDrinksWater++;
                }
                else
                {
                    Console.WriteLine("I'm sorry, we don't serve {0}", drinkChoice);
                }

                /*
                do
                {
                    Console.WriteLine("What would you like to drink? We have coke or water.");

                    drinkChoice = Console.ReadLine();

                    if (drinkChoice.ToUpper() == "COKE")
                    {
                        numDrinksCoke++;
                    }
                    else if (drinkChoice.ToUpper() == "WATER")
                    {
                        numDrinksWater++;
                    }
                    else
                    {
                        Console.WriteLine("I'm sorry, we don't serve {0}", drinkChoice);
                    }

                } while (drinkChoice.ToUpper() != "COKE" && drinkChoice.ToUpper() != "WATER");
                  */
            }

            Console.WriteLine("Okay, enjoy the buffet!\n");

            totalFood = numPeople * PRICE_BUFFET;
            totalBeverages = numDrinksCoke * PRICE_COKE;
            totalBeverages = totalBeverages + (numDrinksWater * PRICE_WATER);

            Console.WriteLine("Here's your bill. Thank you, come again!\n");

            Console.WriteLine(
                "Item".PadRight(10,'.')
                + "Qty".PadLeft(5,'.')
                + "Price".PadLeft(10,'.')
                + "Total".PadLeft(10, '.')
                );
            
            Console.WriteLine(
                "Buffet".PadRight(10, '.')
                + "{0}".PadLeft(5,'.')
                + "{1}".PadLeft(10,'.')
                + "{2}".PadLeft(10, '.')
                , numPeople.ToString()
                , PRICE_BUFFET.ToString()
                , totalFood
                );
            
            Console.WriteLine(
                "Coke".PadRight(10,'.')
                + "{0}".PadLeft(5,'.')
                + "{1}".PadLeft(10,'.')
                + "{2}".PadLeft(10, '.')
                , numDrinksCoke.ToString()
                , PRICE_COKE.ToString()
                , numDrinksCoke * PRICE_COKE
                );
            
            Console.WriteLine(
                "Water".PadRight(10,'.')
                + "{0}".PadLeft(5,'.')
                + "{1}".PadLeft(10,'.')
                + "{2}".PadLeft(10,'.')
                , numDrinksWater.ToString()
                , PRICE_WATER.ToString()
                , numDrinksWater * PRICE_WATER
                );

        }
    }
}