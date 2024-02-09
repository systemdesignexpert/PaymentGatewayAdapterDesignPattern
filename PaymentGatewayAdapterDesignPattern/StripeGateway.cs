// StripeGateway.cs
using System;

public class StripeGateway
{
    public void ChargePayment(decimal amountInDollars)
    {
        Console.WriteLine($"Charge of ${amountInDollars} made using Stripe.");
    }
}
