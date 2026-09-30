namespace OnlinePurchasingSystem;

//this is Facade
public class CompletePurchase
{
    private readonly Stock _stock = new();
    private readonly Payment _payment = new();
    private readonly Invoice _invoice = new();

    public bool IsCompletePurchase(float productQuantityInt, float productPriceInt, string nameClient)
    {
        bool isOk = true;

        _invoice.InssueInvoice(nameClient);
        if (!_stock.HasSufficientStock(productQuantityInt))
            isOk = false;

        else if (!_payment.HasSufficientPayment(productPriceInt))
            isOk = false;

        else if (!_invoice.InssueInvoice(nameClient))
            isOk = false;

        return isOk;
    }
}