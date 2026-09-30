namespace OnlinePurchasingSystem;

//Subsystem One
public class Stock
{
    private int _amount = 10;

    public bool HasSufficientStock(float orderQuantity)
    {
        Console.WriteLine("Procurando o produto");
        for (int i = 0; i < 3; i++)
        {
            Console.Write(".");
            Thread.Sleep(500);
        }

        Console.WriteLine();
        Console.WriteLine(orderQuantity <= _amount ? "Achamos o produto!" : "não achamos o produto!");
        return orderQuantity <= _amount;
    }
}