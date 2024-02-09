using System;
	public class UPIGatewayAdapter: IPaymentGateway
	{
		public UPIGatewayAdapter(UPIGateway _upiGateway)
		{
			this.upiGateway = _upiGateway;
		}

		UPIGateway upiGateway;

        public void ProcessPayment(decimal amount)
        {
			this.upiGateway.transact((double)amount);
        }
    }

