// StripeAdapter.cs
public class StripeAdapter : IPaymentGateway
{
    private StripeGateway _stripeGateway;

    public StripeAdapter(StripeGateway stripeGateway)
    {
        _stripeGateway = stripeGateway;
    }

    public void ProcessPayment(decimal amount)
    {
        // Convert to decimal for Stripe
        decimal amountInDollars = amount / 100; // Assuming Stripe uses cents
        _stripeGateway.ChargePayment(amountInDollars);
    }
}
