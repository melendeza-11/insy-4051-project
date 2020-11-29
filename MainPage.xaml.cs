using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace finalattempt
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

    public partial class MainPage : ContentPage
    {

        public static string readInput(string userInput)
        {
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
            inventory2.Add(new Item("bagels", 230));
            inventory2.Add(new Item("ranch", 70));
            inventory2.Add(new Item("doritos", 815));
            inventory2.Add(new Item("honey", 70));
            inventory2.Add(new Item("coffee", 20));
            inventory2.Add(new Item("pickels", 267));
            inventory2.Add(new Item("bread", 2090));
            inventory2.Add(new Item("flour", 380));
            inventory2.Add(new Item("granola", 680));

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
            inventory3.Add(new Item("chocolate", 354));
            inventory3.Add(new Item("raisins", 797));
            inventory3.Add(new Item("cheerios", 1000));
            inventory3.Add(new Item("crackers", 5780));
            inventory3.Add(new Item("soup", 70));
            inventory3.Add(new Item("cheddar cheese", 83));
            inventory3.Add(new Item("barbecue sauce", 12));
            inventory3.Add(new Item("tortillas", 780));
            inventory3.Add(new Item("coffee creamer", 490));

            Store StoreA = new Store("Store A", "Address: 1st & Greenfield, 1236 S Barcla, Milwaukee, WI, 53204", "Phone #: (414) 988- 9051", "Store Hours: 8am-9pm (Mon-Sun)", inventory1);
            Store StoreB = new Store("Store B", "Address: 1541 Miller Park Way, West Milwaukee, WI, 54214", "Phone #: (414) 988- 9051", "Store Hours: 8am-9pm (Mon-Sun)", inventory2);
            Store StoreC = new Store("Store C", "Address: 6623 N. Damen Ave., Chicago, IL, 60645", "Phone #: (872) 888- 8835", "Store Hours: 7am-10pm (Mon-Sun)", inventory3);

            if (userInput.Contains("address") & userInput.Contains("store a"))
            {
                return String.Format("The store is located at {0}", StoreA.address);
            }
            if (userInput.Contains("address") & userInput.Contains("store b"))
            {
                return String.Format("The store is located at {0}", StoreB.address);
            }
            if (userInput.Contains("address") & userInput.Contains("store c"))
            {
                return String.Format("The store is located at {0}", StoreC.address);
            }
            else if (userInput.Contains("hours") & userInput.Contains("store a"))
            {
                return String.Format("Store Hours: {0}", StoreA.hours);
            }
            else if (userInput.Contains("hours") & userInput.Contains("store b"))
            {
                return String.Format("Store Hours: {0}", StoreB.hours);
            }
            else if (userInput.Contains("hours") & userInput.Contains("store c"))
            {
                return String.Format("Store Hours: {0}", StoreC.hours);
            }
            if (userInput.Contains("phone") & userInput.Contains("store a"))
            {
                return String.Format("The store phone number is: {0}", StoreA.phone);
            }
            if (userInput.Contains("phone") & userInput.Contains("store b"))
            {
                return String.Format("The store phone number is: {0}", StoreB.phone);
            }
            if (userInput.Contains("phone") & userInput.Contains("store c"))
            {
                return String.Format("The store phone number is: {0}", StoreC.phone);
            }
            else if (userInput.Contains("inventory"))
            {
                return "Our current stock consists of {0}";
            }
            else if (userInput.Contains("thank you"))
            {
                return "I'm happy I could help!";
            }
            else
            {
                return "I'm sorry, I don't understand";
            }
        }

        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)

        {
            string userCommand = Convert.ToString(userInput.Text);
            cermyResponse.Text = readInput(userCommand);

        }
    }
}
