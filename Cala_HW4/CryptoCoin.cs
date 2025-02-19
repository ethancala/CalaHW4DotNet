namespace Cala_HW4;

class CryptoCoin
{
    
    // 4 properties of a cryptoCurrency
    public string Name { get; set; }
    public string Symbol{ get; set; }
    private double price;
    public double Supply { get; set; }
    
    
    //getter and setter for price since its privately declared
    public double Price
    {
        get { return price; }
        set { price = value > 0 ? value : 0; }
    }

    //default constructor
    public CryptoCoin(){}
    
    //custom constructor with 3 properties
    public CryptoCoin(string name, string symbol, double price, double supply)
    {
        Name = name;
        Symbol = symbol;
        Price = price;
        Supply = supply;
    }
    
    //method to calculate wallet worth
    public double CalculateSupply(double supply)
    {
        return supply * Price;
    }
    
    //toStringMethod
    public override string ToString()
    {
        
        return $"{Name,-5} | {Symbol,-3} | {Price,5:F2} USD | {Supply, 8:F2} coins | {CalculateSupply(Supply),13:F2} USD value " ;
    }
}