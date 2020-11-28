﻿using System;
using System.Collections.Generic;

namespace PHASE_II
{
    public class Store //Creates the class 'Store'
    {
        public string name; //Establishes the members of the Store class for later use.
        public string address;
        public string phone;
        public string hours;
        public List<Item> inventory; //Links the 'Item' class that contains item names and inventory available to the Store.

        public Store(string nameInput, string addressInput, string phoneInput, string hoursInput, List<Item> inventoryInput) //Creates a constructor to add the necessary store information in the main method.
        {
            name = nameInput; //Links the inputs to the original members of the class.
            address = addressInput;
            phone = phoneInput;
            hours = hoursInput;
            inventory = inventoryInput;
        }

        public int stockCheck(string desiredStock) //Creates the method to check the stock of an item within the Item list.
        {
            foreach (Item item in inventory) //Checks each element of the store's Inventory list.
            {
                if (item.itemName == desiredStock) //If the item is available at the store, it displays the stock available for the item as a return.
                {
                    int stockCount = item.stockCount;
                    return stockCount;
                }
            }
            return -1; //If the item isn't in the list at all, it returns -1 which fulfills a specific if-else condition.
        }

    }

    public class Item //Creates the 'Item' class.
    {
        public string itemName; //Creates the members of the Item class.
        public int stockCount;

        public Item(string itemInput, int stockInput) //Creates a constructer that takes in inputs from the main method.
        {
            itemName = itemInput; //Assigns the inputs to the original members of the class.
            stockCount = stockInput;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            List<Store> stores = new List<Store>(); //Creates a new list of object type 'Store'

            List<Item> inventory1 = new List<Item>(); //Creates a new list of object type 'Item'
            inventory1.Add(new Item("milk", 5)); //Adds both item name and stock amount to an element of 'inventory1'
            inventory1.Add(new Item("pasta", 2));
            inventory1.Add(new Item("cheese", 10));
            inventory1.Add(new Item("apple", 0));
            inventory1.Add(new Item("ham", 3));
            inventory1.Add(new Item("tomato", 22));
            inventory1.Add(new Item("cereal", 30));
            inventory1.Add(new Item("oatmeal", 0));
            inventory1.Add(new Item("sugar", 100));
            inventory1.Add(new Item("salt", 2));
            inventory1.Add(new Item("cinnamon", 12));
            inventory1.Add(new Item("paprika", 10));
            inventory1.Add(new Item("oregano", 9));
            inventory1.Add(new Item("taco shells", 5));
             inventory1.Add(new Item("oranges", 67));
            inventory1.Add(new Item("cheez-it", 109));
            inventory1.Add(new Item("green tea", 560));
            inventory1.Add(new Item("jalapeños", 37));
            inventory1.Add(new Item("gummy bears", 272));
            inventory1.Add(new Item("chicken", 37));
            inventory1.Add(new Item("broccoli", 40));
            inventory1.Add(new Item("coca-cola", 1008));
            inventory1.Add(new Item("peanut butter", 562));
            inventory1.Add(new Item("cucumber", 24));





            List<Item> inventory2 = new List<Item>(); //Creates a new list of object type 'Item'
            inventory2.Add(new Item("lettuce", 1)); //Adds both item name and stock amount to an element of 'inventory2'
            inventory2.Add(new Item("eggs", 0));
            inventory2.Add(new Item("orange juice", 20));
            inventory2.Add(new Item("strawberries", 15));
            inventory2.Add(new Item("lemons", 0));
            inventory2.Add(new Item("pears", 200));
            inventory2.Add(new Item("blueberries", 2));
            inventory2.Add(new Item("raspberries", 2000));
            inventory2.Add(new Item("peaches", 30));
            inventory2.Add(new Item("persimmons", 80));
            inventory2.Add(new Item("smelt", 8));
            inventory2.Add(new Item("canned tuna", 10));
            inventory2.Add(new Item("smoked salmon", 16));
            inventory2.Add(new Item("avacados", 11));







            List<Item> inventory3 = new List<Item>(); //Creates a new list of object type 'Item'
            inventory3.Add(new Item("eggs", 2)); //Adds both item name and stock amount to an element of 'inventory3'
            inventory3.Add(new Item("lettuce", 304));
            inventory3.Add(new Item("bok choy", 397));
            inventory3.Add(new Item("onions", 100));
            inventory3.Add(new Item("green onions", 5000));
            inventory3.Add(new Item("cereal", 0));
            inventory3.Add(new Item("cucumbers", 403));
            inventory3.Add(new Item("tomato", 102));
            inventory3.Add(new Item("carrot", 0));
            inventory3.Add(new Item("potatoes", 40));
            inventory3.Add(new Item("figs", 1));
            inventory3.Add(new Item("turnip", 3));
            inventory3.Add(new Item("red snapper", 17));
            inventory3.Add(new Item("halibut", 4));





            //Creates 3 new elements to the 'Store' list, adding the store name, address, phone number, store hours, and respective inventory.
            stores.Add(new Store("Store A", "Address: 1st & Greenfield, 1236 S Barcla, Milwaukee, WI, 53204", "Phone #: (414) 988- 9051", "Store Hours: 8am-9pm (Mon-Sun)", inventory1));
            stores.Add(new Store("Store B", "Address: 1541 Miller Park Way, West Milwaukee, WI, 54214", "Phone #: (414) 988- 9051", "Store Hours: 8am-9pm (Mon-Sun)", inventory2));
            stores.Add(new Store("Store C", "Address: 6623 N. Damen Ave., Chicago, IL, 60645", "Phone #: (872) 888- 8835", "Store Hours: 7am-10pm (Mon-Sun)", inventory3));

            bool loop = true; //Sets conditions for the loop.
            bool secondLoop = true; //Sets conditions for the loop.

            Console.WriteLine("Hello! What store would you like information on?");

            while (loop == true) //This first loop allows the AI to ask the user if they need any further assistance.
            {
                Console.WriteLine("0: Store A"); //Lists stores and their respective numbers to choose.
                Console.WriteLine("1: Store B");
                Console.WriteLine("2: Store C");

                string userStoreStr = Console.ReadLine(); //Reads what store the user chose.
                int userStore = Convert.ToInt32(userStoreStr); //Converts the user input into an integer.

                if (userStore < 0 || userStore > 2) //Checks whether the user input is a valid choice, if not, it will start the loop from the beginning.
                {
                    Console.WriteLine("Please select a valid store.");
                    continue; //Causes the loop to start over again.
                }


                while (secondLoop == true) //Starts a secondary loop to make sure the user inputs a valid number.
                {

                    Console.WriteLine("What would you like help with?"); //Asks user if they would like to see their store information based on their first decision.
                    Console.WriteLine("1: Store Information");
                    Console.WriteLine("2: Stock Checker");

                    string userRequestStr = Console.ReadLine(); //Reads user's input
                    int userRequest = Convert.ToInt32(userRequestStr); //Converts user input into an integer.

                    Store selectedStore = stores[userStore]; //Assigns the user's chosen store to an objecte 'Store' for future methods and information output.

                    if (userRequest == 1) //If the user chose Store Information, it brings up the information of their 'selectedStore' variable.
                    {
                        Console.WriteLine(selectedStore.address);
                        Console.WriteLine(selectedStore.phone);
                        Console.WriteLine(selectedStore.hours);

                        secondLoop = false; //Stops the loop for future decisions.
                    }

                    else if (userRequest == 2) //If user chose Stock Checker, it executes the stockCheck method.
                    {
                        Console.WriteLine("What item are you looking for? "); //Asks user for the item they are looking for.
                        string userItem = Console.ReadLine().ToLower(); //Assigns the user's item to a string class.

                        int stockVer = selectedStore.stockCheck(userItem); //Executes the stockCheck method previously written.

                        if (stockVer > 0) //If there is available stock, it tells the user that it is in stock and how much is in stock.
                        {
                            Console.WriteLine("In {0}, there are " + stockVer + " {1} in stock.", selectedStore.name, userItem);

                            secondLoop = false; //Stops the loops for future decisions.
                        }

                        else if (stockVer < 0) //If the method did not find anything and returned a negative, it tells the user the item isn't stocked what-so-ever.
                        {
                            Console.WriteLine("Sorry, we do not stock {0} at {1}.", userItem, selectedStore.name);

                            secondLoop = false; //Stops the loops for future decisions.
                        }

                        else //If the item exists in the list, but has a stock of 0, it tells the user that it isn't in stock at the moment.
                        {
                            Console.WriteLine("Sorry, it looks like there are no {0} in stock at {1} at the moment..", userItem, selectedStore.name);

                            secondLoop = false; //Stops the loops for future decisions.
                        }
                    }

                    else //If the user inputs an incorrect option, it starts the loop over again until the user inputs a valid option.
                    {
                        Console.WriteLine("Please select a valid option. ");
                        continue;
                    }

                }

                Console.WriteLine("Is there anything else I can help you with today? (Y/N)"); //Asks user if there is anything else they would like help with.
                string loopResponse = Console.ReadLine().ToUpper(); //Assigns user response to the string variable and converts it to Uppercase

                if (loopResponse == "Y") //If the user responds with "Y", it restarts the main loop.
                {
                    loop = true; //Restarts both loops.
                    secondLoop = true; //Restarts both loops.
                    Console.WriteLine("What store would you like more information on? ");
                }

                else if (loopResponse == "N") //If the user respodns with "N", it breaks the main loop and prints a farewell message.
                {
                    Console.WriteLine("Thanks for using the Cermak Virtual Agent, have a nice day!");
                    loop = false;
                }
            }
        }
    }
}
