using System;

namespace PaymentContext.Domain.Entities
{
    public class PayPalPayment : Payment
    {

        public PayPalPayment(
            string transactionCode,
            string number,
            DateTime paidDate,
            DateTime expireDate,
            decimal total,
            decimal totalPaid,
            string ownerName,
            string ownerDocument,
            string ownerAddress,
            string ownerEmail) : base(number,
                                      paidDate,
                                      expireDate,
                                      total,
                                      totalPaid,
                                      ownerName,
                                      ownerDocument,
                                      ownerAddress,
                                      ownerEmail)
        {
            TransactionCode = transactionCode;
        }

       public string TransactionCode { get; private set; }

        
    }
}