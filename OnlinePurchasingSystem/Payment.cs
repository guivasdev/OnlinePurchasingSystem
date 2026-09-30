namespace OnlinePurchasingSystem;

//Subsystem two
public class Payment
{
    private float productPrice = 100f;

    public bool HasSufficientPayment(float paymentAmount)
    {
        Console.WriteLine("Analisando o pagamento!");

        for (int i = 0; i < 3; i++)
        {
            Console.Write(".");
            Thread.Sleep(500);
        }

        Console.WriteLine();
        
        Console.WriteLine(paymentAmount >= productPrice
            ? "Pagamento efetuado com sucesso!"
            : "Falha no pagamento, saldo insuficiente!");

        return paymentAmount >= productPrice;
    }
}