using System;

namespace PaymentContext.Domain.Entities
{

    public abstract class Payment
    {
        protected Payment(
            string number,
            DateTime paidDate,
            DateTime expireDate,
            decimal total,
            decimal totalPaid,
            string ownerName,
            string ownerDocument,
            string ownerAddress,
            string ownerEmail)
        {
            Number = Guid.NewGuid().ToString().Replace("-", "").Substring(0, 10).ToUpper();
            PaidDate = paidDate;
            ExpireDate = expireDate;
            Total = total;
            TotalPaid = totalPaid;
            OwnerName = ownerName;
            OwnerDocument = ownerDocument;
            OwnerAddress = ownerAddress;
            OwnerEmail = ownerEmail;
        }

        public string Number { get; private set; }
        public DateTime PaidDate { get; private set; }
        public DateTime ExpireDate { get; private set; }
        public decimal Total { get; private set; }
        public decimal TotalPaid { get; private set; }
        public string OwnerName { get; private set; }
        public string OwnerDocument { get; private set; }
        public string OwnerAddress { get; private set; }
        public string OwnerEmail { get; private set; }
    }
}