using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture2__Buying_Products_
{
    class Shop
    {
        private Laptop _laptop;
        private Telephone _telephone;
        private Headphones _headphones;

        public Shop()
        {
            _laptop = new Laptop(100, 35700);
            _telephone = new Telephone(100, 28000);
            _headphones = new Headphones(100, 4000);
        }


        public void Buy(int choiceOfGood)
        {
            switch (choiceOfGood)
            {
                case 1:
                    Console.Write("Enter how many laptops do you want to buy: ");

                    var amountOfBooks = Convert.ToInt32(Console.ReadLine());

                    _laptop.DecreaseAmount(amountOfBooks);

                    break;
                case 2:
                    Console.Write("Enter how many telephones do you want to buy: ");

                    var amountOfCandies = Convert.ToInt32(Console.ReadLine());

                    _telephone.DecreaseAmount(amountOfCandies);

                    break;
                case 3:
                    Console.Write("Enter how many headphones do you want to buy: ");

                    var amountOfCups = Convert.ToInt32(Console.ReadLine());

                    _headphones.DecreaseAmount(amountOfCups);

                    break;
                default:
                    Console.WriteLine("There is no such choice");
                    break;
            }
        }
        public void Add(int choiceOfGood)
        {
            switch (choiceOfGood)
            {
                case 1:
                    Console.Write("Enter how many books do you want to add: ");

                    var amountOfBooks = Convert.ToInt32(Console.ReadLine());

                    _laptop.IncreaseAmount(amountOfBooks);

                    break;
                case 2:
                    Console.Write("Enter how many kg candies do you want to add: ");

                    var amountOfCandies = Convert.ToInt32(Console.ReadLine());

                    _telephone.IncreaseAmount(amountOfCandies);

                    break;
                case 3:
                    Console.Write("Enter how many cups do you want to add: ");

                    var amountOfCups = Convert.ToInt32(Console.ReadLine());

                    _headphones.IncreaseAmount(amountOfCups);

                    break;
                default:
                    Console.WriteLine("There is no such choice");
                    break;
            }
        }

        internal void ShowList()
        {
            Console.WriteLine("\n List of available goods:");
            Console.WriteLine(_laptop.ToString());
            Console.WriteLine(_telephone.ToString());
            Console.WriteLine(_headphones.ToString());
        }
    }
}
