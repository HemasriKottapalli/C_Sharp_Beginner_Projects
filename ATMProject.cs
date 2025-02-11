using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ATMProject
{
    class User
    {
        private string name = " ";
        private string password = " ";
        private string email = " ";
        private string phoneNumber = " ";
        private string address = " ";

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public void Login(string name, string password)
        {
            if (name.Equals(Name) && password.Equals(Password))
            {
                Console.WriteLine("You're Logged in!");
            }
            else
            {
                Console.WriteLine("Loggin failed! Make sure you've registered..or recheck your username/password");
                Environment.Exit(0);
            }
        }

        public void Register(string name, string password, string email, string phoneNumber, string address)
        {
            if(name != " " && password != " " 
                && email != " " && phoneNumber != " " 
                && address != " ")
            {
                Name = name;
                Password = password;
                Email = email;
                PhoneNumber = phoneNumber;
                Address = address;
                //finally
                Console.WriteLine("Registration Successful!");
            }
            else
            {
                Console.WriteLine("Make sure to fill all the fields correctly!");
                Environment.Exit(0);
            }
        }

    }

    class ATM
    {
        int totalAmount = 0;

        public void Deposit(int amount)
        {
            totalAmount = totalAmount + amount;
            Console.WriteLine($"{amount} has been credited! Thanks for banking with us!");
        }

        public void WithDraw(int amount)
        {
            if (amount <= totalAmount)
            {
                totalAmount = totalAmount - amount;
                Console.WriteLine($"{amount} has been debited!");
            }
            else
            {
                Console.WriteLine("Insufficient Balance");
                Environment.Exit(0);
            }
        }

        public void BalanceInquiery()
        {
            Console.WriteLine($"Your Balance : {totalAmount}");

        }

    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose an option to get started!\n1.Register\n2.Login \n3.Go to Options");
            int choice = Convert.ToInt32(Console.ReadLine());

            User user = new User();
            ATM atm = new ATM();

            switch (choice)
            {
                case 1:
                    Console.WriteLine("------Registration Form_______");

                    Console.WriteLine("Enter your Name: ");
                    string name = Console.ReadLine();
                    Console.WriteLine("Enter your Password: ");
                    string password = Console.ReadLine();
                    Console.WriteLine("Enter your Email: ");
                    string email = Console.ReadLine();
                    Console.WriteLine("Enter your Phone Number: ");
                    string phoneNumber = Console.ReadLine();
                    Console.WriteLine("Enter your Address: ");
                    string address = Console.ReadLine();

                    user.Register(name, password, email, phoneNumber, address);
                    break;
                    
                case 2:
                    Console.WriteLine("------login Form_______");

                    Console.WriteLine("Enter your Name: ");
                    name = Console.ReadLine();
                    Console.WriteLine("Enter your Password: ");
                    password = Console.ReadLine();

                    user.Login(name, password);
                    break;
                case 3:
                    break;
                default:
                    Console.WriteLine("Choose a valid option");
                    break;
            }

            //user reaches this part only after succesfully logging in

            while (true)
            {
                Console.WriteLine("Choose an option: \n1.Deposit \n2.Withdraw \n3.Balance Enquiry \n4.Login");

                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("How much do you want to deposit? (INR)");
                        int amount = Convert.ToInt32(Console.ReadLine());
                        atm.Deposit(amount);
                        break;
                    case 2:
                        Console.WriteLine("How much do you want to withdraw? (INR)");
                        amount = Convert.ToInt32(Console.ReadLine());
                        atm.WithDraw(amount);
                        break;
                    case 3:
                        atm.BalanceInquiery();
                        break;
                    case 4:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("please enter a valid option");
                        break;
                }

            }

            Console.ReadKey();
        }
    }
}
