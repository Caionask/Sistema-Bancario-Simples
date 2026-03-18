using System;
using System.Text.RegularExpressions; 
using System.Collections.Generic; // Para uso de listas.

class Account
{
    private int accountNum = 0;
    private int accountKey = 0;
    private double balance = 0;
    private string name = "";
    Random random = new Random();
    List<int> accounts = new List<int>();

    public void SetWithDraw(double value)
    { 
        if (value >= this.balance)
            this.balance -= value;
        else
            Console.WriteLine("Insufficient Balance!");
    }

    public void SetDeposit(double value)
    {
        if (value > 0)
            this.balance += value;
        else
            Console.WriteLine("Invalid value!");
    }

    public double GetBalance()
    {
        return this.balance;
    }

    public void SetRegister()
    {
        Console.WriteLine("Your name account:");
        this.name = Console.ReadLine() ?? "";

        Console.WriteLine("Your key account:");
        this.accountKey = Convert.ToInt32(Console.ReadLine());

        this.accountNum = random.Next(1, 11);
        if(!accounts.Contains(accountNum))
            accounts.Add(this.accountNum);
        else
            Console.WriteLine();
            
    }
    
} 

