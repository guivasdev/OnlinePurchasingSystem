namespace OnlinePurchasingSystem;

public static class Program
{
    private static void Main()
    {
        //facade!
        var completePurchase = new CompletePurchase();

        var nameClient = ShowName();

        var productQuantity = ShowDesiredQuantity();

        var productPrice = ShowPayment(productQuantity);
        
        FictitiousLoading();
        //facade em ação!
        completePurchase.IsCompletePurchase(productQuantity, productPrice, nameClient);
    }

    /*"Front-End"*/
    private static void FictitiousLoading()
    {
        Console.Clear();
        for (int i = 0; i < 3; i++)
        {
            Console.Write(".");
            Thread.Sleep(500);
        }

        Console.Clear();
    }

    private static string ShowName()
    {
        FictitiousLoading();
        Console.WriteLine("Insira seu nome abaixo!");
        return Console.ReadLine() ?? string.Empty;
    }

    private static float ShowDesiredQuantity()
    {
        FictitiousLoading();
        Console.WriteLine("Quantidade maxima: " + Stock.Amount);
        Console.WriteLine("Favor informe a quantidade desejada: ");
        return float.Parse(Console.ReadLine() ?? string.Empty);
    }

    private static float ShowPayment(float productQuantity)
    {
        FictitiousLoading();
        Console.WriteLine(
            "O valor a ser pago é de " +
            productQuantity * Payment.ProductPrice +
            " Favor realizar o pagamento! "
        );
        Console.WriteLine("Informe o valor aqui:");
        return float.Parse(Console.ReadLine() ?? string.Empty);
    }
}