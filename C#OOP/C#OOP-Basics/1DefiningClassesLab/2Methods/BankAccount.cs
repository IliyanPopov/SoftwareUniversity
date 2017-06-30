﻿public class BankAccount
{
    private double balance;
    private int id;

    public int ID
    {
        get { return this.id; }
        set { this.id = value; }
    }


    public double Balance { get; set; }

    public void Deposit(double amount)
    {
        this.balance += amount;
    }

    public void Withdraw(double amount)
    {
        if (amount <= this.balance)
        {
            this.balance -= amount;
        }
    }

    public override string ToString()
    {
        return $"Account { this.id} , balance { this.balance}";
    }
}