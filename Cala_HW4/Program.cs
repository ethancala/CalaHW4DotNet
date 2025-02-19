namespace Cala_HW4;

class Program
{
    //main method
    static void Main(string[] args)
    {

        //create list
        List<CryptoCoin> coins = new List<CryptoCoin>();

        //introduce user
        Console.WriteLine("\nWelcome to the Crypto Tracker App!");
        Console.WriteLine("___________________________________\n");

        
        //prompt user to create coin until they quit
        while (true)
        {
            Console.WriteLine("\nEnter the data of a currency to create a coin!\n");
       
        
            //prompt user for info of coin
            Console.Write("Enter Name ('quit' to exit):  ");
            string name;
            
            if ((name = Console.ReadLine()) == "quit" ) break;
        
            Console.Write("Enter Symbol: ");
            string symbol = Console.ReadLine();
            
            double price, supply;

            // error handling for price
            while (true)
            {
                Console.Write("Enter Price: ");
                if (double.TryParse(Console.ReadLine(), out price) && price > 0)
                {
                    break; // valid price entered
                }
                Console.WriteLine("Invalid input. Please enter a valid positive number for the price.");
            }

            // error handling for supply
            while (true)
            {
                Console.Write("Enter Supply: ");
                if (double.TryParse(Console.ReadLine(), out supply) && supply >= 0)
                {
                    break; // valid supply entered
                }
                Console.WriteLine("Invalid input. Please enter a valid non-negative number for the supply.");
            }

            //create coin using custom constructor and add to list of coins
            CryptoCoin coin = new CryptoCoin(name, symbol, price, supply);
            coins.Add(coin);
        
            //display coin
            Console.Write("You created the coin: ");
            Console.WriteLine(coin.ToString());
        }

        //display all the coins in order they added to list
        Console.WriteLine("\nAll the coins\n");
        Console.WriteLine($"{"Name",-5} | {"Symbol",-3} | {"Price",5:F2} USD | {"Supply",8:F2}  | {"Market Cap",13:F2} | ");
        Console.WriteLine("_____________________________________________________________________\n");
        foreach (var coin in coins)
        {
            Console.WriteLine(coin);
        }

        //sort and display by price
        Console.WriteLine("\nCoins sorted by price\n");
        Console.WriteLine($"{"Name",-5} | {"Symbol",-3} | {"Price",5:F2} USD | {"Supply",8:F2} | {"Market Cap",13:F2} | ");
        Console.WriteLine("_____________________________________________________________________\n");
        foreach (var coin in coins.OrderBy(c => c.Price))
        {
            Console.WriteLine(coin);
        }
        
        //filter by symbol using LINQ
        Console.Write("\nEnter symbol to filter by: ");
        string targetSymbol = Console.ReadLine();
        var filteredCoins = coins.Where(c => c.Symbol.Equals(targetSymbol, StringComparison.OrdinalIgnoreCase));

        Console.WriteLine("\nCoin with the specified symbol\n ");

        //display the filtered coin
        foreach (var coin in filteredCoins)
            Console.WriteLine(coin);
    }
}

