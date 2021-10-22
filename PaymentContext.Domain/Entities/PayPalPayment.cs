using System;
using PaymentContext.Domain.ValueObjects;

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
            Name ownerName,
            Document ownerDocument,
            Address ownerAddress,
            Email ownerEmail) : base(number,
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