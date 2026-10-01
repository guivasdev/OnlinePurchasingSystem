namespace OnlinePurchasingSystem;

//Subsystem One
public class Stock
{
    public static int  Amount => 10;

    public bool HasSufficientStock(float orderQuantity)
    {
        Console.WriteLine("Procurando o produto");
        for (var i = 0; i < 3; i++)
        {
            Console.Write(".");
            Thread.Sleep(500);
        }

        Console.WriteLine();
        Console.WriteLine(orderQuantity <= Amount ? "Achamos o produto!" : "não achamos o produto!");
        return orderQuantity <= Amount;
    }
}