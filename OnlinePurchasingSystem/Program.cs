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

        //facade em ação!
        completePurchase.IsCompletePurchase(productQuantity, productPrice, nameClient);
    }

    /*"Front-End"*/
    private static string ShowName()
    {
        Console.WriteLine("Insira seu nome abaixo!");
        return Console.ReadLine() ?? string.Empty;
    }

    private static float ShowDesiredQuantity()
    {
        Console.WriteLine("Favor informe a quantidade desejada: ");
        var quantity = float.Parse(Console.ReadLine() ?? string.Empty);
        Console.WriteLine("Aperte qualquer tecla para continuar...");
        Console.ReadLine();
        Console.Clear();
        return quantity;
    }

    private static float ShowPayment(float productQuantity)
    {
        Console.WriteLine("O valor a ser pago é de" + productQuantity * Payment.ProductPrice +
                          " Favor realizar o pagamento! ");
        Console.WriteLine("Informe o valor aqui:");
        var payment = float.Parse(Console.ReadLine() ?? string.Empty);
        Console.WriteLine("Aperte qualquer tecla para continuar...");
        Console.ReadLine();
        Console.Clear();
        return payment;
    }
}