// Program.cs
class Program
{
    static void Main(string[] args)
    {
        // Simulate integrating PayPal
        PayPalGateway payPalGateway = new PayPalGateway();
        IPaymentGateway payPalAdapter = new PayPalAdapter(payPalGateway);
        PaymentProcessor paypalProcessor = new PaymentProcessor(payPalAdapter);
        paypalProcessor.ProcessPayment(150.0m);

        // Simulate integrating Stripe
        StripeGateway stripeGateway = new StripeGateway();
        IPaymentGateway stripeAdapter = new StripeAdapter(stripeGateway);
        PaymentProcessor stripeProcessor = new PaymentProcessor(stripeAdapter);
        stripeProcessor.ProcessPayment(200.0m);

        UPIGateway upi = new UPIGateway();
        IPaymentGateway upiAdapter = new UPIGatewayAdapter(upi);
        upiAdapter.ProcessPayment(100.90m);

        List<IPaymentGateway> paymentGateways = new List<IPaymentGateway>();
        paymentGateways.Add(payPalAdapter);
        paymentGateways.Add(stripeAdapter);
        paymentGateways.Add(upiAdapter);

        foreach(var gateway in paymentGateways)
        {
            gateway.ProcessPayment(100m);
        }


    }
}
