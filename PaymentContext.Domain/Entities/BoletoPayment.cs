using System;
using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Domain.Entities
{
    public class BoletoPayment : Payment
    {
        public BoletoPayment(
            string barCode,
            string boletoNumber,
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
            BarCode = barCode;
            BoletoNumber = boletoNumber;
        }

        public string BarCode { get; private set; }
        public string BoletoNumber { get; private set; }
    }
}