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
            Console.WriteLine("\nEnter the data of a currency to create a coin!\n");
        
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

        //display all the coins
        Console.WriteLine("\nAll the coins\n");
        Console.WriteLine($"{"Name",-7} | {"Symbol",-3} | {"Price",5:F2} USD");
        Console.WriteLine("_______________________________\n");
        foreach (var coin in coins)
        {
            Console.WriteLine(coin);
        }

        //sort and display by price
        Console.WriteLine("\nCoins sorted by price\n");
        Console.WriteLine($"{"Name",-7} | {"Symbol",-3} | {"Price",5:F2} USD");
        Console.WriteLine("_______________________________\n");
        foreach (var coin in coins.OrderBy(c => c.Price))
        {
            Console.WriteLine(coin);
        }
        
        //filter by symbol using LINQ
        Console.Write("\nEnter symbol to filter by: ");
        string targetSymbol = Console.ReadLine();
        var filteredCoins = coins.Where(c => c.Symbol.Equals(targetSymbol, StringComparison.OrdinalIgnoreCase));

        Console.WriteLine("\nCoin with the specified symbol\n ");

        foreach (var coin in filteredCoins)
            Console.WriteLine(coin);
    }
}

