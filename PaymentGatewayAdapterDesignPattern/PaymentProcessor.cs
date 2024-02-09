// PaymentProcessor.cs
public class PaymentProcessor
{
    private IPaymentGateway _paymentGateway;

    public PaymentProcessor(IPaymentGateway paymentGateway)
    {
        _paymentGateway = paymentGateway;
    }

    public void ProcessPayment(decimal amount)
    {
        _paymentGateway.ProcessPayment(amount);
    }
}
