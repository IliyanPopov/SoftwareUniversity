﻿using System;
public class Program
{
    public static void Main()
    {
        BankAccount acc = new BankAccount();
        acc.ID= 1;
        acc.Balance = 15;
        Console.WriteLine($"Account {acc.ID} , balance {acc.Balance}");
    }
}