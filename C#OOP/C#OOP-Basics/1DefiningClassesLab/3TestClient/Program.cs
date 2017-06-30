using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        List<BankAccount> accounts = new List<BankAccount>();

        string input = Console.ReadLine();

        while (input != "End")
        {
            var data = input.Split(new string[] {" "}, StringSplitOptions.RemoveEmptyEntries);

            if (data[0] == "Create")
            {
                if (accounts.Any(x => x.ID == int.Parse(data[1])))
                {
                    Console.WriteLine("Account already exists");
                }
                else
                {
                    BankAccount bankAccount = new BankAccount
                    {
                        ID = int.Parse(data[1]),
                        Balance = 0
                    };

                    accounts.Add(bankAccount);
                }
            }
            else if (data[0] == "Deposit")
            {
                var bankAccount = accounts.FirstOrDefault(x => x.ID == int.Parse(data[1]));
                if (bankAccount != null)
                {
                    bankAccount.Deposit(double.Parse(data[2]));
                }
                else
                {
                    Console.WriteLine("Account does not exist");
                }
            }

            else if (data[0] == "Withdraw")
            {
                var bankAccount = accounts.FirstOrDefault(x => x.ID == int.Parse(data[1]));
                if (bankAccount != null)
                {
                    bankAccount.Withdraw(double.Parse(data[2]));
                }
                else
                {
                    Console.WriteLine("Account does not exist");
                }
            }

            else if (data[0] == "Print")
            {
                var bankAccount = accounts.FirstOrDefault(x => x.ID == int.Parse(data[1]));
                if (bankAccount != null)
                {
                    Console.WriteLine(bankAccount.ToString());
                }
                else
                {
                    Console.WriteLine("Account does not exist");
                }
            }
            input = Console.ReadLine();
        }
    }
}