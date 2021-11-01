using System;
using PaymentContext.Domain.ValueObjects;
using PaymentContext.Shared.Entities;

namespace PaymentContext.Domain.Entities
{

    public abstract class Payment : Entity
    {
        protected Payment(
            string number,
            DateTime paidDate,
            DateTime expireDate,
            decimal total,
            decimal totalPaid,
            string ownerName,
            Document ownerDocument,
            Address ownerAddress,
            Email ownerEmail)
        {
            Number = number;
            PaidDate = paidDate;
            ExpireDate = expireDate;
            Total = total;
            TotalPaid = totalPaid;
            OwnerName = ownerName;
            OwnerDocument = ownerDocument;
            OwnerAddress = ownerAddress;
            OwnerEmail = ownerEmail;

            //TODO: Add Fluent Validator validation
        }

        public string Number { get; private set; }
        public DateTime PaidDate { get; private set; }
        public DateTime ExpireDate { get; private set; }
        public decimal Total { get; private set; }
        public decimal TotalPaid { get; private set; }
        public string OwnerName { get; private set; }
        public Document OwnerDocument { get; private set; }
        public Address OwnerAddress { get; private set; }
        public Email OwnerEmail { get; private set; }
    }
}