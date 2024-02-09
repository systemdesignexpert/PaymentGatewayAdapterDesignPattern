// PayPalGateway.cs
using System;

public class PayPalGateway
{
    public void MakePayment(double paymentAmount)
    {
        Console.WriteLine($"Payment of ${paymentAmount} processed via PayPal.");
    }
}
