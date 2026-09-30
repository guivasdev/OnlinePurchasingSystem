namespace OnlinePurchasingSystem;

public class Program
{
    static void Main()
    {
        CompletePurchase completePurchase = new CompletePurchase();
        var nameClient = ShowName();

        var productQuantity = ShowDesiredQuantity();
        var productPrice = ShowPayment();

        completePurchase.IsCompletePurchase(productQuantity, productPrice, nameClient);
    }

    protected static string ShowName()
    {
        Console.WriteLine("Insira seu nome abaixo!");
        return Console.ReadLine();
    }

    protected static float ShowDesiredQuantity()
    {
        Console.WriteLine("Favor informe a quantidade desejada: ");
        var quantity = float.Parse(Console.ReadLine());
        Console.WriteLine("Aperte qualquer tecla para continuar...");
        Console.ReadLine();
        Console.Clear();
        return quantity;
    }

    protected static float ShowPayment()
    {
        Console.WriteLine("O valor a ser pago é de 100R$. Favor realizar o pagamento! ");
        Console.WriteLine("Informe o valor aqui:");
        var payment = float.Parse(Console.ReadLine());
        Console.WriteLine("Aperte qualquer tecla para continuar...");
        Console.ReadLine();
        Console.Clear();
        return payment;
    }
}