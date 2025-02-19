using System;
using System.Collections.Generic;
using System.Linq;


namespace Cala_HW4;

class Program
{
    //main method
    static void Main(string[] args)
    {

        //create list
        List<CryptoCoin> coins = new List<CryptoCoin>();

        //introduce user
        Console.WriteLine("Welcome to the Crypto Tracker App!\n");

        while (true)
        {
        Console.WriteLine("Enter the data of a currency to create a coin!\n");
        
        //prompt user to keep going or not
       
        
        //prompt user for info of coin
        Console.Write("Enter Name ('quit' to exit):  ");
        string name;
        if ((name = Console.ReadLine()) == "quit" ) break;
        
        Console.Write("Enter Symbol: ");
        string symbol = Console.ReadLine();
        Console.Write("Enter Price: ");
        double price = double.Parse(Console.ReadLine());


        //create coin using custom constructor and add to list of coins
        CryptoCoin coin = new CryptoCoin(name, symbol, price);
        coins.Add(coin);
        
        Console.Write("You created the coin: ");
        Console.WriteLine(coin.ToString());
        }


}
}

class CryptoCoin
{
    
    // 3 properties of a cryptoCurrency
    public string Name { get; set; }
    public string Symbol{ get; set; }
    private double price;
    
    
    //getter and setter for price since its privately declared
    public double Price
    {
        get { return price; }
        set { price = value > 0 ? value : 0; }
    }

    //default constructor
    public CryptoCoin()
    {
        
    }
    
    //custom constructor with 3 properties
    public CryptoCoin(string name, string symbol, double price)
    {
        Name = name;
        Symbol = symbol;
        Price = price;
    }
    
    //method to calculate wallet worth
    public double CalculateSupply(double supply)
    {
        return supply * Price;
    }
    
    //toStringMethod
    public override string ToString()
    {
        return $"\n{Name} ({Symbol})  {Price} USD";
    }
}