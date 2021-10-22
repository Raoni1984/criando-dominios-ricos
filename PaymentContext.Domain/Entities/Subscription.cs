using System;
using System.Collections.Generic;
using System.Linq;
using PaymentContext.Shared.Entities;

namespace PaymentContext.Domain.Entities 
{

    public class Subscription : Entity
    {
        private IList<Payment> _payments;

        public Subscription(DateTime? expireDate)
        {
            Active = true;
            CreateDate = DateTime.Now;
            LastUpdateDate = CreateDate;
            ExpireDate = expireDate;
            _payments = new List<Payment>();
        }

        public bool Active { get; private set; }
        public DateTime CreateDate { get; private set; }
        public DateTime LastUpdateDate { get; private set; }
        public DateTime? ExpireDate { get; private set; }
        public IReadOnlyCollection<Payment> Payments { get { return  _payments.ToArray(); } }

        public void DeactiveSubscription()
        {
            this.Active = false;
            LastUpdateDate = DateTime.Now;
        }

        public void ActivateSubscription()
        {
            this.Active = true;
            LastUpdateDate = DateTime.Now;
        }

        public void AddPayment(Payment payment)
        {
            _payments.Add(payment);
        } 
    }
}