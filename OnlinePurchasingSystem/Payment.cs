namespace OnlinePurchasingSystem;

//Subsystem two
public class Payment
{
    public static float ProductPrice => 10f;

    public bool HasSufficientPayment(float paymentAmount, float productQuantity)
    {
        Console.WriteLine("Analisando o pagamento!");

        for (var i = 0; i < 3; i++)
        {
            Console.Write(".");
            Thread.Sleep(500);
        }

        Console.WriteLine();

        Console.WriteLine(paymentAmount >= ProductPrice
            ? "Pagamento efetuado com sucesso!"
            : "Falha no pagamento, saldo insuficiente!");

        return paymentAmount >= ProductPrice;
    }
}