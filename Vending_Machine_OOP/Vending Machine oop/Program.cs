using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Vending_Machine_oop
{
    class Machine
    {
        private double cashturnover = 0; // to store the earnings.
        private double cardturnover = 0; // to store the earnings from card payment
        private Dictionary<string, double> prices = new Dictionary<string, double>
        {
            {"Burger", 5.00 },
            {"Hot Dog", 3.50 },
            {"Club Sandwich", 3.50 },
            {"Cola", 2.00 },
            {"Sprite", 1.50 },
            {"Still Water", 1.50 },

        };
        public double getPrice(string item)
        {
            return prices.ContainsKey(item) ? prices[item] : 0;
        }
        public void processPayment(string product)
        {
            double price = getPrice(product);
            if (price == 0)
            {
                Console.WriteLine("Invalid Product");
                return;
            }

            Console.WriteLine($"\nYou have selected {product}. Price: £{price:F2}");
            Console.WriteLine("Choose payment method: \n1. Card \n2. Cash");
            string paymentMethod = Console.ReadLine();

            if (paymentMethod == "1")
            {
                Console.WriteLine("Please insert your card...");
                string card = Console.ReadLine();
                if (card.ToLower() == "card")
                {
                    Console.Write($"Payment Successful! Enjoy your {product}\n");
                    cardturnover += price;

                }
            }
            else if (paymentMethod == "2")
            {
                Console.WriteLine("Insert Cash..");
                double cash = Convert.ToDouble(Console.ReadLine());
                if (cash >= price)
                {
                    Console.WriteLine($"Payment successful! Enjoy your {product} \nChange returned ${cash - price:F2}");
                    cashturnover += price;

                }
                else
                {
                    Console.WriteLine("Insuficient Cash! Payment declined");
                }
            }
            else
            {
                Console.WriteLine("Invalid Payment Method");
            }



        }
        public double GetTurnoverCard()
        {
            return cardturnover;

        }

        public double GetTurnoverCash()
        {
            return cashturnover;
        }
        public void UpdateTurnoverCash(double amount)
        {
            cashturnover -= amount;
        }

    }
    class Food
    {
        private Machine machine;
        public Food(Machine machine)
        {
            this.machine = machine;
        }

        public void foodMenu()
        {
            Console.WriteLine("1. Burger (£5.00) \n2. Hot Dog (£3.50) \n3. Club Sandwich (£3.50) \n0. Back");
            string select = Console.ReadLine();
            switch (select)
            {
                case "1":
                    machine.processPayment("Burger");
                    break;
                case "2":
                    machine.processPayment("Hot Dog");
                    break;

                case "3":
                    machine.processPayment("Club Sandwich");
                    break;
                case "0":
                    Console.Write("Back to Main Menu!");
                    break;

                default:
                    Console.WriteLine("Invalid selection. Try again.");
                    break;

            }

        }
    }

    class Drinks
    {
        private Machine machine;
        public Drinks(Machine machine)
        {
            this.machine = machine;
        }

        public void drinksMenu()
        {
            Console.WriteLine("1. Cola (£2.00) \n2. Sprite (£1.50) \n3. Still Water (£1.50) \n0. Back");
            string select = Console.ReadLine();
            switch (select)
            {
                case "1":
                    machine.processPayment("Cola");
                    break;
                case "2":
                    machine.processPayment("Sprite");
                    break;

                case "3":
                    machine.processPayment("Still Water");
                    break;
                case "0":
                    Console.Write("Back to main menu");
                    break;

                default:
                    Console.WriteLine("Invalid selection. Try again.");
                    break;

            }

        }
    }

    class Exit
    {
        public void exitMenu()
        {
            Console.WriteLine("Only admins. Please insert the password to shut down the system");
            string exitPassword = Console.ReadLine();
            if (exitPassword.ToLower() == "exit123")
            {

                Environment.Exit(0);
            }
            else
            {
                Program program = new Program();
            }
        }
    }

    class Admin
    {
        public Machine machine;
        public Admin(Machine machine)
        {
            this.machine = machine;
        }

        public void adminArea()
        {
            Console.Write("Please insert password: ");
            string adminArea = Console.ReadLine();
            if (adminArea.ToLower() != "admin123")
            {
                Console.WriteLine("Access Denied");
                return;
            }
            else
            {
                Console.WriteLine($"Total Card Turnover: £{machine.GetTurnoverCard():F2}\n");
                Console.WriteLine($"Total Cash Turnover: £{machine.GetTurnoverCash():F2}  - Press 123 to cash out...");
                string cashOut = Console.ReadLine();
                if (cashOut.Equals("123"))
                {

                    Console.WriteLine($"Insert the amount would like to cash out");
                    if (double.TryParse(Console.ReadLine(), out double amount))
                    {

                        if (amount > machine.GetTurnoverCash())
                        {
                            Console.WriteLine("Amount exceeded. \nTry again");
                        }
                        else if (amount <= machine.GetTurnoverCash())
                        {
                            machine.UpdateTurnoverCash(amount);
                            Console.WriteLine($"Cashing out £{amount:F2}");
                            Console.WriteLine($"Remaining Balance £{machine.GetTurnoverCash()}");
                        
                            Console.ReadKey();
                        }

                    }
                    else
                    {
                        Console.WriteLine("Invalid input! Please enter a numeric amount.");
                    }
                }


               
            }
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            
            
                Machine machine = new Machine();
                Food food = new Food(machine);
                Drinks drinks = new Drinks(machine);
                Exit exit = new Exit();
                Admin admin = new Admin(machine);

            while (true)
            { 
                Console.WriteLine("\n#### WELCOME #### \nPlease select a product: \n1.Food \n2.Drinks \n\n\n\n 0.Exit  ---- 00. Admin Area");
                string menu = Console.ReadLine();
                if (menu == "1")
                {
                    food.foodMenu();
                }
                else if (menu == "2")
                {
                    drinks.drinksMenu();
                }
                else if (menu == "0")
                {
                    exit.exitMenu();
                }
                else if (menu == "00")
                {
                    admin.adminArea();
                }
                else
                {
                    Console.WriteLine("Invalid Option. \nPlease try again...");
                }
            }

        }
    }
}
    

