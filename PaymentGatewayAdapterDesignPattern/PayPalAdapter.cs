// PayPalAdapter.cs
public class PayPalAdapter : IPaymentGateway
{
    private PayPalGateway _payPalGateway;

    public PayPalAdapter(PayPalGateway payPalGateway)
    {
        _payPalGateway = payPalGateway;
    }

    public void ProcessPayment(decimal amount)
    {
        // Convert to double for PayPal
        double paymentAmount = (double)amount;
        _payPalGateway.MakePayment(paymentAmount);
    }
}
