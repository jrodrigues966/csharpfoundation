using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Tracker
{
    struct itemData
    {
        public int itemIDNo;
        public string Description;
        public double PricePerItem;
        public int QuantityOnHand;
        public double CostPerItem;
        public double ItemValue;
    }
    class Inventory
    {
        static void Main(string[] args)
        {
            // use an interger to keep track of the count of items in your inventory
            int ItemCount = 0;
            // create an array of your ItemData struct
            var item = new itemData[3];

            // use a never ending loop that shows the user what options they can select
            while (true)
            {
                Console.WriteLine("************************************");
                Console.WriteLine();
                Console.WriteLine("Select one of the following options");
                Console.WriteLine();
                Console.WriteLine("1) Add an item 2) Change an item 3) Delete an item 4) List all items 5) Quit");

                // read user's input
                string Selection = Console.ReadLine();

                // convert the given string to integer to match our case types shown below and convert option to be non-case sensitive
                int choice = int.Parse(Selection);

                // provide an extra blank line on screen
                Console.WriteLine();

                switch (choice)
                {
                    // add an item to the list if this option is selected
                    case 1:
                        {
                            Console.Write("Please enter item ID No: ");
                            string id = Console.ReadLine();
                            int itemidno = int.Parse(id);

                            Console.Write("Please enter description: ");
                            string description = Console.ReadLine();

                            Console.Write("Please enter price: ");
                            string p = Console.ReadLine();
                            double price = double.Parse(p);

                            Console.Write("Please enter quantity: ");
                            string q = Console.ReadLine();
                            int quantity = int.Parse(q);

                            Console.Write("Please enter cost: ");
                            string c = Console.ReadLine();
                            double cost = double.Parse(c);

                            //Add item to the end of the array 
                            item[ItemCount].itemIDNo = itemidno;
                            item[ItemCount].Description = description;
                            item[ItemCount].PricePerItem = price;
                            item[ItemCount].QuantityOnHand = quantity;
                            item[ItemCount].CostPerItem = cost;
                            item[ItemCount].ItemValue = price * cost;

                            ItemCount = ItemCount + 1;
                            break;
                        }

                    //Change items in the list if this option is selected
                    case 2:
                        {
                            Console.Write("Please enter an item ID No: ");
                            string oldid = Console.ReadLine();
                            int olditemidno = int.Parse(oldid);
                            bool iFound = false;

                            for (int i = 0; i < item.Length; i++) 
                            {
                                if (item[i].itemIDNo == olditemidno)
                                {
                                    iFound = true;
                                    //Code to show what has to happen if the item in the list is found
                                    Console.Write("Please enter new item ID No: ");
                                    string newid = Console.ReadLine();
                                    int newitemidno = int.Parse(newid);
                                    item[i].itemIDNo = newitemidno;

                                    Console.Write("Please enter description: ");
                                    string description = Console.ReadLine();
                                    item[i].Description = description;

                                    Console.Write("Please enter price: ");
                                    string p = Console.ReadLine();
                                    double price = double.Parse(p);
                                    item[i].PricePerItem = price;

                                    Console.Write("Please enter quantity: ");
                                    string q = Console.ReadLine();
                                    int quantity = int.Parse(q);
                                    item[i].QuantityOnHand = quantity;

                                    Console.Write("Please enter cost: ");
                                    string c = Console.ReadLine();
                                    double cost = double.Parse(c);
                                    item[i].CostPerItem = cost;

                                    item[i].ItemValue = price * cost;
                                    
                                    //Reset the count to show a new count for your list
                                    //ItemCount = ItemCount + 1;
                                    //(Note: your list is now increased by one item) 
                                }
                            }
                            //And if not found
                            if (!iFound)
                            {
                                Console.WriteLine("Item {0} not found.", olditemidno);
                            }
                            break;
                        }

                    //Delete items in the list if this option is selected
                    case 3:
                        {
                            Console.Write("Please enter an item ID No: ");
                            string id = Console.ReadLine();
                            int itemidnotodelete = int.Parse(id);
                            bool iDelete = false;

                            for (int i = 0; i < ItemCount; i++)
                            {
                                if (item[i].itemIDNo == itemidnotodelete)
                                {
                                    iDelete = true;
                                    //Delete the item if you found it
                                    item[i + 1] = item[i];
                                    
                                    //Reset the count to show a new count for your list
                                    ItemCount = ItemCount - 1;
                                    //(Note: your list is now reduced by one item)
                                }
                            }
                            //Hint the user that you deleted the requested item
                            if (iDelete)
                            {
                                Console.WriteLine("Item deleted.");
                            }
                            // if did not find it, hint the user that you did not find it in your list
                            else
                            {
                                Console.WriteLine("Item {0} not found.", itemidnotodelete);
                            }
                            break;
                        }

                    //List all items in current database if this option is selected
                    case 4:
                        {
                            Console.WriteLine("Item#  ItemID  Description           Price   QOH  Cost  Value");
                            Console.WriteLine("-----  ------  --------------------  -----   ---  ----  -----");

                            //Code in this block. Use the above line format as a guide for printing or displaying the items in your list right under it
                            for (int i = 0; i < ItemCount; i++)
                            {
                                Console.WriteLine("{0, -6} {1, -7} {2, -13} {3,12} {4, -6} {5, -13} {6, -22}", i + 1, item[i].itemIDNo, 
                                    item[i].Description, item[i].PricePerItem, item[i].QuantityOnHand, item[i].CostPerItem, item[i].PricePerItem * item[i].QuantityOnHand);
                            }
                            break;
                        }

                    ////quit the program if this option is selected
                    //case 5:
                    //    {
                    //        Console.Write("Are you sure that you want to quit(y/n)? ");
                    //        string strresp = Console.ReadLine();


                    //        if (code) // code
                    //        {
                    //            optx = 0;   //as long as it is not 5, the process is not breaking
                    //        }
                    //        break;
                    //    }
                    default:
                        {
                            Console.Write("Invalid Option, try again");
                            break;
                        }
                }
            }
        }
    }
}
