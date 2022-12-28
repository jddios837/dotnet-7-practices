namespace BlazorServerFundamentals.Data;

public class Pizza : PizzaSpecial
{
    public const int DefaultSize = 3;
    public const int MinimumSize = 1;
    public const int MaximumSize = 5;
    public PizzaSpecial Special { get; set; }
    public int SpecialId { get; set; }
    public int Size { get; set; }

    public List<PizzaToppingModel> Toppings { get; set; }
    
    public string GetFormattedTotalPrice()
    {
        return (BasePrice * Size).ToString("0.00");
    }
}