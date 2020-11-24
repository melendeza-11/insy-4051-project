using System;

namespace INSY4051_PROJECT_PHASE_II
{
    class Program
    {
        static void Main(string[] args)
        {
            int whileCount = 0; //Initializes the while-loop count condition ahead of time.
            int stockCount = 0; //Initializes the stock count ahead of time.

            string[] StoreA = new string[10] //Fills the Store's "stock" in the array.
           {"milk", "steak", "pasta", "eggs", "eggs", "marinara", "lettuce", "tomato", "onion", "onion"};

            string[] StoreB = new string[10] //Fills the Store's "stock" in the array.
            {"sauce", "steak", "steak", "steak", "steak", "eggs", "lettuce", "tomato", "onion", "milk"};

            string[] StoreC = new string[10] //Fills the Store's "stock" in the array.
            {"pasta", "pasta", "pasta", "marinara", "marinara", "potato", "potato", "tomato", "tomato", "tomato"};

            Console.WriteLine("What store would you like me to check? (Pick 1-3): "); //Asks user to pick one of 3 stores available in the system.
            string userS = Console.ReadLine();
            int UserStore = Convert.ToInt32(userS); //Reads and converts the user's store choice to int.

            Console.WriteLine("What are you looking for?:"); //Reads user's item choice and stores it in the userStock variable.
            string userStock = Console.ReadLine();

            if (UserStore == 1) //Checks which store the user chose to then select the appropriate array.
            {
                while (whileCount <= 9) //Makes sure to only check the available elements in the array. For simplicity, the store stock array is only 10 elements.
                {
                    if (StoreA[whileCount] == userStock) //Cycles through the array elements to check if it matches the user's request. If it matches, it adds 1 to the stock count.
                    {
                        stockCount++;
                    }

                    whileCount++;
                }
            }

            else if (UserStore == 2) //Checks which store the user chose to then select the appropriate array.
            {
                while (whileCount <= 9) //Makes sure to only check the available elements in the array. For simplicity, the store stock array is only 10 elements.
                {
                    if (StoreB[whileCount] == userStock) //Cycles through the array elements to check if it matches the user's request. If it matches, it adds 1 to the stock count.
                    {
                        stockCount++;
                    }

                    whileCount++;
                }
            }

            else if (UserStore == 3) //Checks which store the user chose to then select the appropriate array.
            {
                while (whileCount <= 9) //Makes sure to only check the available elements in the array. For simplicity, the store stock array is only 10 elements.
                {
                    if (StoreC[whileCount] == userStock) //Cycles through the array elements to check if it matches the user's request. If it matches, it adds 1 to the stock count.
                    {
                        stockCount++;
                    }

                    whileCount++;
                }
            }

            if (stockCount > 0) //Checks to see if there is any store stock of the item the user requested. If there is, the program tells the user how much there is in stock.
            {
                Console.WriteLine("In Store " + UserStore + ", there's " + stockCount + " " +userStock + " in stock.");
            }

            else //If there isn't any stock, it tells the user the item is unavailable at their chosen store.
            {
                Console.WriteLine("Sorry, the item you seek is not in stock at Store " + UserStore + ".");
            }
        }
    }
}
