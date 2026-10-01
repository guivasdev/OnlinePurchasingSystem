namespace OnlinePurchasingSystem;

//this is Facade
public class CompletePurchase
{
    private readonly Stock _stock = new();
    private readonly Payment _payment = new();
    private readonly Invoice _invoice = new();

    public bool IsCompletePurchase(float productQuantity, float productPriceInt, string nameClient)
    { 
        bool isOk = true;
        
        if (!_stock.HasSufficientStock(productQuantity))
            isOk = false;

        else if (!_payment.HasSufficientPayment(productPriceInt, productQuantity))
            isOk = false;

        else if (!_invoice.InssueInvoice(nameClient))
            isOk = false;

        return isOk;
    }
}