using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture2__Buying_Products_
{
    internal class Product
    {
        protected ProductName _productName;
        protected int _amount;
        protected double _price;

        protected Product(int amount, double price)
        {
            _amount = amount;
            _price = price;
        }

        public void DecreaseAmount(int amount) 
        {
            var order = new Order();

            if ((_amount - amount) >= 0)
            {
                _amount = _amount - amount;
                Console.WriteLine($"You have purchased {amount} of {_productName} successfully.\n" + order.OrderWithId);
            }
            else
            {
                Console.WriteLine($"We are sorry, there is only {_amount} left.\n");
            }

        }

        public void IncreaseAmount(int amount)
        {
            _amount = _amount + amount;
            Console.WriteLine($"You have added {amount} successfully.\n");
        }

        public override string ToString()
        {
            return string.Format("Type: {0}, Price: {1}, Amount: {2}", _productName, _price, _amount);
        }
    }

    class Laptop : Product
    {
        private string _title;

        public Laptop(string title, int amount, double price) : base(amount, price)
        {
            _title = title;
            _price = 11.4;
        }

        public Laptop(int amount, double price) : base(amount, price)
        {
            _productName = ProductName.Laptop;
        }
    }

    class Telephone : Product
    {
        public Telephone(int amount, double price) : base(amount, price)
        {
            _productName = ProductName.Telephone;
        }
    }

    class Headphones : Product
    {
        public Headphones(int amount, double price) : base(amount, price)
        {
            _productName = ProductName.Headphones;
        }
    }
}

