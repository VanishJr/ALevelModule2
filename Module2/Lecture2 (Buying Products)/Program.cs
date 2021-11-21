using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture2__Buying_Products_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Shop!\n" + 
                "by Ivan Logutov\n" + 
                "_________________");

            var mainShop = new Shop();

            var work = true;

            while (work)
            {
                Console.WriteLine("\nPlease choose what do you want to do:\n" +
                    "1. To see list of available goods;\n" +
                    "2. To buy something;\n" +
                    "3. To add more goods;\n" +
                    "4. To exit the shop.");
                Console.Write("Enter number of your choice:");

                var choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        mainShop.ShowList();
                        break;
                    case 2:
                        var buying = true;
                        while (buying)
                        {

                            Console.WriteLine("\nChoose what do you want to buy:\n" +
                                "1. Laptops;\n" +
                                "2. Telephones;\n" +
                                "3. Headphones.");
                            Console.Write("Enter number of your choice:"); 

                            var choiceOfGood = Convert.ToInt32(Console.ReadLine());

                            mainShop.Buy(choiceOfGood);

                            Console.Write("\nDo you want to go back to main menu?(y/n): ");
                            var answerBuy = Console.ReadLine();
                            buying = answerBuy == "n"; 
                        }
                        break;
                    case 3:
                        var adding = true;
                        while (adding)
                        {
                            Console.WriteLine("\nChoose what do you want to add:\n" +
                                              "1. Laptops;\n" +
                                              "2. Telephones;\n" +
                                              "3. Headphones.");
                            Console.Write("Enter number of your choice: ");

                            var choiceOfGood = Convert.ToInt32(Console.ReadLine());

                            mainShop.Add(choiceOfGood);

                            Console.Write("Do you want to go back to main menu?(y/n): ");
                            var answerAdd = Console.ReadLine();
                            adding = answerAdd == "n";
                        }
                        break;
                    case 4:
                        Console.WriteLine("Good Buy!");
                        work = false;
                        break;
                }
            }

            void ShowMainMenu() 
            {
                Console.WriteLine("Please choose what do you want to do:\n " +
                    "1. To see list of available goods;\n" + 
                    "2. To buy something;\n" +
                    "3. To add more goods;\n" +
                    "4. To exit the shop.");
                Console.Write("Enter number of your choice:");
            }
        }


    }
}
