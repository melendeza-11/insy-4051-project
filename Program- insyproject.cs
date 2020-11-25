using System;
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

            Console.WriteLine("What store would you like me to check? (Pick 1 - 3): "); //Asks user to pick one of 3 stores available in the system.
            string userS = Console.ReadLine();
            int UserStore = Convert.ToInt32(userS); //Reads and converts the user's store choice to int.

            while (UserStore < 1 || UserStore > 3)
            { //Verifies that the user is inputting a valid store number and if not, it asks the user for a valid store in a loop.

                Console.WriteLine("Please enter a valid store number: ");
                userS = Console.ReadLine();
                UserStore = Convert.ToInt32(userS);
            }

            Console.WriteLine("What are you looking for?:"); //Reads user's item choice and stores it in the userStock variable.
            string userNeed = Console.ReadLine().ToLower();

            //string[] storInfo = new string[]//
              // {"store info"};

            if (UserStore == 1)//check store number to return correct store info
            {
                if (userNeed == "store info")// verifies that its the store info for this store the user is looking forand returns store info
                {
                    Console.WriteLine("Store 1 info:");//states which store info is being returned

                    Console.WriteLine("Address: 1st & Greenfield, 1236 S Barcla, Milwaukee, WI, 53204");//store address
                    Console.WriteLine("Phone#: (414) 645- 2695");//store phone number 
                    Console.WriteLine("Store Hours: 8am-9pm (Mon-Sun)");// store hours
                    return;
                }

            }

            else if (UserStore == 2)//check store number to return correct store info
            {
                if (userNeed == "store info")// verifies that its the store info for this store the user is looking forand returns store info
                {
                    Console.WriteLine("Store 2 info:");//states which store info is being returned

                    Console.WriteLine("Address: 1541 Miller Park Way, West Milwaukee, WI, 54214");//store address
                    Console.WriteLine("Phone#: (414) 988- 9051");// store phone number 
                    Console.WriteLine("Store Hours: 8am-9pm (Mon-Sun)");// store hours
                    return;
                }
            }

            else if (UserStore == 3)//check store number to return correct store info
            {
                if (userNeed == "store info")// verifies that its the store info for this store the user is looking for and returns store info
                {
                    Console.WriteLine("Store 3 info:");//states which store info is being returned

                    Console.WriteLine("Address: 6623 N. Damen Ave., Chicago, Il, 60645");//store adddress
                    Console.WriteLine("Phone#: (872) 888- 8835");//store phone number
                    Console.WriteLine("Store Hours: 7am-10pm (Mon-Sun)");//store hours
                    return;
                }
            }

            if (UserStore == 1) //Checks which store the user chose to then select the appropriate array.
            {
                while (whileCount <= 9) //Makes sure to only check the available elements in the array. For simplicity, the store stock array is only 10 elements.
                {
                    if (StoreA[whileCount] == userNeed) //Cycles through the array elements to check if it matches the user's request. If it matches, it adds 1 to the stock count.
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
                    if (StoreB[whileCount] == userNeed) //Cycles through the array elements to check if it matches the user's request. If it matches, it adds 1 to the stock count.
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
                    if (StoreC[whileCount] == userNeed) //Cycles through the array elements to check if it matches the user's request. If it matches, it adds 1 to the stock count.
                    {
                        stockCount++;
                    }

                    whileCount++;
                }
            }

            if (stockCount > 0) //Checks to see if there is any store stock of the item the user requested. If there is, the program tells the user how much there is in stock.
            {
                Console.WriteLine("In Store " + UserStore + ", there's " + stockCount + " " + userNeed + " in stock.");
            }

            else //If there isn't any stock, it tells the user the item is unavailable at their chosen store.
            {
                Console.WriteLine("Sorry, the item you seek is not in stock at Store " + UserStore + ".");
            }


        }



    }
}

