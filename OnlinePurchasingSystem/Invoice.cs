namespace OnlinePurchasingSystem;

//Sub system three
public class Invoice
{
    public bool InssueInvoice(string nameClient)
    {
        Console.WriteLine("Boleto emitido para: " + nameClient);
        return true;
    }
}