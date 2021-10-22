using System;
using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Domain.Entities
{
    public class CreditCardPayment : Payment
    {
        public CreditCardPayment( 
            string cardNumber,
            string cardHolderName,
            string lastTransactionNumber,
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
            CardNumber = cardNumber;
            CardHolderName = cardHolderName;
            LastTransactionNumber = lastTransactionNumber;
        }

        public string CardNumber { get; private set; }
       public string CardHolderName { get; private set; }
       public string LastTransactionNumber { get; private set; }
    }
}