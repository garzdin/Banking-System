using Banking.Storage;
using Banking.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking
{
    class Program
    {
        static bool masterInput = false;
        static Store storage = new Store();

        static void Main(string[] args)
        {
            do
            {
                string mainMenuInput = mainMenu();
                switch (mainMenuInput)
                {
                    case "1":
                        masterInput = true;
                        string accountsMenuInput = accountsMenu();
                        switch (accountsMenuInput)
                        {
                            case "1":
                                Console.Clear();
                                Console.WriteLine("Please choose a customer to open an account for:");
                                Console.WriteLine("---------------------------");
                                if(storage.Customers.Count <= 0)
                                {
                                    Console.WriteLine("There are no customers in our database. Press Return to go back.");
                                    Console.ReadLine();
                                    break;
                                }
                                for (int i = 0; i < storage.Customers.Count; i++)
                                {
                                    Console.WriteLine(i + 1 + ". Name: " + storage.Customers[i].Name);
                                    Console.WriteLine("   Age: " + storage.Customers[i].Age);
                                }
                                Console.WriteLine("---------------------------");
                                Console.Write("Customer: ");
                                int customerAccountOpenChoice = Convert.ToInt32(Console.ReadLine()) - 1;
                                Console.WriteLine("---------------------------");
                                Console.WriteLine("Please fill in the fields below:");
                                Console.WriteLine("---------------------------");
                                Console.Write("Acccount number: ");
                                string number = Console.ReadLine();
                                Console.Write("Balance (USD): ");
                                double balance = Convert.ToDouble(Console.ReadLine());
                                storage.Accounts.Add(new Account(number: number, customer: storage.Customers[customerAccountOpenChoice], balance: balance));
                                Console.WriteLine("---------------------------");
                                Console.WriteLine("Account " + number + " has been created. Press Return to go back.");
                                Console.ReadLine();
                                break;
                            case "2":
                                Console.Clear();
                                Console.WriteLine("Please choose an account to close:");
                                Console.WriteLine("---------------------------");
                                if (storage.Accounts.Count <= 0)
                                {
                                    Console.WriteLine("There are no accounts in our database. Press Return to go back.");
                                    Console.ReadLine();
                                    break;
                                }
                                for (int i = 0; i < storage.Accounts.Count; i++)
                                {
                                    Console.WriteLine(i + 1 + ". Customer name: " + storage.Accounts[i].Customer.Name);
                                    Console.WriteLine("   Account number: " + storage.Accounts[i].Number);
                                    Console.WriteLine("   Account balance: " + storage.Accounts[i].Balance);
                                }
                                Console.WriteLine("---------------------------");
                                Console.Write("Account: ");
                                int accountCloseChoice = Convert.ToInt32(Console.ReadLine()) - 1;
                                storage.Accounts.Remove(storage.Accounts[accountCloseChoice]);
                                Console.WriteLine("---------------------------");
                                Console.WriteLine("The account has been closed. Press Return to go back.");
                                Console.ReadLine();
                                break;
                            case "3":
                                Console.Clear();
                                Console.WriteLine("Please choose an account to deposit money to:");
                                Console.WriteLine("---------------------------");
                                if (storage.Accounts.Count <= 0)
                                {
                                    Console.WriteLine("There are no accounts in our database. Press Return to go back.");
                                    Console.ReadLine();
                                    break;
                                }
                                for (int i = 0; i < storage.Accounts.Count; i++)
                                {
                                    Console.WriteLine(i + 1 + ". Customer name: " + storage.Accounts[i].Customer.Name);
                                    Console.WriteLine("   Account number: " + storage.Accounts[i].Number);
                                    Console.WriteLine("   Account balance: " + storage.Accounts[i].Balance);
                                }
                                Console.WriteLine("---------------------------");
                                Console.Write("Account: ");
                                int accountDepositChoice = Convert.ToInt32(Console.ReadLine()) - 1;
                                Console.WriteLine("---------------------------");
                                Console.Write("Amount: ");
                                double accountDepositAmount = Convert.ToDouble(Console.ReadLine());
                                storage.Accounts[accountDepositChoice].depositMoney(accountDepositAmount);
                                Console.WriteLine("---------------------------");
                                Console.WriteLine(accountDepositAmount + " USD have been deposited to the account. Press Return to go back.");
                                Console.ReadLine();
                                break;
                            case "4":
                                Console.Clear();
                                Console.WriteLine("Please choose an account to withdraw money from:");
                                Console.WriteLine("---------------------------");
                                if (storage.Accounts.Count <= 0)
                                {
                                    Console.WriteLine("There are no accounts in our database. Press Return to go back.");
                                    Console.ReadLine();
                                    break;
                                }
                                for (int i = 0; i < storage.Accounts.Count; i++)
                                {
                                    Console.WriteLine(i + 1 + ". Customer name: " + storage.Accounts[i].Customer.Name);
                                    Console.WriteLine("   Account number: " + storage.Accounts[i].Number);
                                    Console.WriteLine("   Account balance: " + storage.Accounts[i].Balance);
                                }
                                Console.WriteLine("---------------------------");
                                Console.Write("Account: ");
                                int accountWithdrawChoice = Convert.ToInt32(Console.ReadLine()) - 1;
                                Console.WriteLine("---------------------------");
                                Console.Write("Amount: ");
                                double accountWithdrawAmount = Convert.ToDouble(Console.ReadLine());
                                storage.Accounts[accountWithdrawChoice].withdrawMoney(accountWithdrawAmount);
                                Console.WriteLine("---------------------------");
                                Console.WriteLine(accountWithdrawAmount + " USD have been withdrawn from the account. Press Return to go back.");
                                Console.ReadLine();
                                break;
                            case "5":
                                Console.Clear();
                                Console.WriteLine("Please choose an account to transfrer money from:");
                                Console.WriteLine("---------------------------");
                                if (storage.Accounts.Count <= 0)
                                {
                                    Console.WriteLine("There are no accounts in our database. Press Return to go back.");
                                    Console.ReadLine();
                                    break;
                                }
                                for (int i = 0; i < storage.Accounts.Count; i++)
                                {
                                    Console.WriteLine(i + 1 + ". Customer name: " + storage.Accounts[i].Customer.Name);
                                    Console.WriteLine("   Account number: " + storage.Accounts[i].Number);
                                    Console.WriteLine("   Account balance: " + storage.Accounts[i].Balance);
                                }
                                Console.WriteLine("---------------------------");
                                Console.Write("Account: ");
                                int accountTransferFromChoice = Convert.ToInt32(Console.ReadLine()) - 1;
                                Console.WriteLine("---------------------------");
                                Console.WriteLine("Please choose an account to transfrer money to:");
                                Console.WriteLine("---------------------------");
                                if (storage.Accounts.Count <= 0)
                                {
                                    Console.WriteLine("There are no accounts in our database. Press Return to go back.");
                                    Console.ReadLine();
                                    break;
                                }
                                for (int i = 0; i < storage.Accounts.Count; i++)
                                {
                                    Console.WriteLine(i + 1 + ". Customer name: " + storage.Accounts[i].Customer.Name);
                                    Console.WriteLine("   Account number: " + storage.Accounts[i].Number);
                                    Console.WriteLine("   Account balance: " + storage.Accounts[i].Balance);
                                }
                                Console.WriteLine("---------------------------");
                                Console.Write("Account: ");
                                int accountTransferToChoice = Convert.ToInt32(Console.ReadLine()) - 1;
                                Console.WriteLine("---------------------------");
                                Console.Write("Amount: ");
                                double accountTransferAmount = Convert.ToDouble(Console.ReadLine());
                                storage.Accounts[accountTransferFromChoice].withdrawMoney(accountTransferAmount);
                                storage.Accounts[accountTransferToChoice].depositMoney(accountTransferAmount);
                                Console.WriteLine("---------------------------");
                                Console.WriteLine(accountTransferAmount + " USD have been deposited to " + storage.Accounts[accountTransferToChoice].Number + " from " + storage.Accounts[accountTransferFromChoice].Number + ". Press Return to go back.");
                                Console.ReadLine();
                                break;
                            case "6":
                                mainMenuInput = mainMenu();
                                break;
                            default:
                                Console.Write("Please enter a valid option: ");
                                accountsMenuInput = Console.ReadLine();
                                break;
                        }
                        break;
                    case "2":
                        masterInput = true;
                        string customersMenuInput = customersMenu();
                        switch (customersMenuInput)
                        {
                            case "1":
                                Console.Clear();
                                Console.WriteLine("Please fill in the fields below:");
                                Console.WriteLine("---------------------------");
                                Console.Write("Name: ");
                                string name = Console.ReadLine();
                                Console.Write("Age: ");
                                int age = Convert.ToInt32(Console.ReadLine());
                                storage.Customers.Add(new Customer(name: name, age: age));
                                Console.WriteLine("---------------------------");
                                Console.WriteLine("Customer " + name + " has been added. Press Return to go back.");
                                Console.ReadLine();
                                break;
                            case "2":
                                Console.Clear();
                                Console.WriteLine("Please choose a customer from the list below:");
                                Console.WriteLine("---------------------------");
                                if (storage.Customers.Count <= 0)
                                {
                                    Console.WriteLine("There are no customers in our database. Press Return to go back.");
                                    Console.ReadLine();
                                    break;
                                }
                                for (int i = 0; i < storage.Customers.Count; i++)
                                {
                                    Console.WriteLine(i + 1 + ". Name: " + storage.Customers[i].Name);
                                    Console.WriteLine("   Age: " + storage.Customers[i].Age);
                                }
                                Console.WriteLine("---------------------------");
                                Console.Write("Customer: ");
                                int customerEditChoice = Convert.ToInt32(Console.ReadLine()) - 1;
                                Console.WriteLine("Enter the new details for " + storage.Customers[customerEditChoice].Name);
                                Console.WriteLine("---------------------------");
                                Console.Write("Name: ");
                                string customerEditName = Console.ReadLine();
                                Console.Write("Age: ");
                                int customerEditAge = Convert.ToInt32(Console.ReadLine());
                                storage.Customers[customerEditChoice].setName(customerEditName);
                                storage.Customers[customerEditChoice].setAge(customerEditAge);
                                Console.WriteLine("Customer " + customerEditName + " has been changed. Press Return to go back.");
                                Console.ReadLine();
                                break;
                            case "3":
                                Console.Clear();
                                Console.WriteLine("Please choose a customer from the list below:");
                                Console.WriteLine("---------------------------");
                                if (storage.Customers.Count <= 0)
                                {
                                    Console.WriteLine("There are no customers in our database. Press Return to go back.");
                                    Console.ReadLine();
                                    break;
                                }
                                for (int i = 0; i < storage.Customers.Count; i++)
                                {
                                    Console.WriteLine(i + 1 + ". Name: " + storage.Customers[i].Name);
                                    Console.WriteLine("   Age: " + storage.Customers[i].Age);
                                }
                                Console.WriteLine("---------------------------");
                                Console.Write("Customer: ");
                                int customerDeleteChoice = Convert.ToInt32(Console.ReadLine()) - 1;
                                for(int i = 0; i < storage.Accounts.Count; i++)
                                {
                                    if(storage.Accounts[i].Customer == storage.Customers[customerDeleteChoice])
                                    {
                                        storage.Accounts.Remove(storage.Accounts[i]);
                                    }
                                }
                                storage.Customers.Remove(storage.Customers[customerDeleteChoice]);
                                Console.WriteLine("Customer has been removed. Press Return to go back.");
                                Console.ReadLine();
                                break;
                            case "4":
                                customersMenuInput = customersMenu();
                                break;
                            default:
                                Console.Write("Please enter a valid option: ");
                                customersMenuInput = Console.ReadLine();
                                break;
                        }
                        break;
                    case "3":
                        masterInput = false;
                        break;
                    default:
                        masterInput = true;
                        Console.Write("Please enter a valid option: ");
                        mainMenuInput = Console.ReadLine();
                        break;
                }
            } while (masterInput == true);
        }

        static string mainMenu()
        {
            Console.Clear();
            Console.WriteLine("Welcome to the banking system");
            Console.WriteLine("Please choose one of the options below and press Return:");
            Console.WriteLine("---------------------------");
            Console.WriteLine("1. Manage accounts");
            Console.WriteLine("2. Manage customers");
            Console.WriteLine("3. Exit");
            Console.WriteLine("---------------------------");
            Console.Write("Option: ");

            return Console.ReadLine();
        }

        static string accountsMenu()
        {
            Console.Clear();
            Console.WriteLine("Please choose one of the options below and press Return:");
            Console.WriteLine("---------------------------");
            Console.WriteLine("1. Open an account");
            Console.WriteLine("2. Close an account");
            Console.WriteLine("3. Deposit into an account");
            Console.WriteLine("4. Withdraw from an account");
            Console.WriteLine("5. Transfer to an account");
            Console.WriteLine("6. Go back");
            Console.WriteLine("---------------------------");
            Console.Write("Option: ");

            return Console.ReadLine();
        }

        static string customersMenu()
        {
            Console.Clear();
            Console.WriteLine("Please choose one of the options below and press Return:");
            Console.WriteLine("---------------------------");
            Console.WriteLine("1. Create a customer");
            Console.WriteLine("2. Edit a customer");
            Console.WriteLine("3. Delete a customer");
            Console.WriteLine("4. Go back");
            Console.WriteLine("---------------------------");
            Console.Write("Option: ");

            return Console.ReadLine();
        }
    }
}
