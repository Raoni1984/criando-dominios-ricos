using System.Collections.Generic;
using System.Linq;
using PaymentContext.Domain.ValueObjects;
using PaymentContext.Shared.Entities;

namespace PaymentContext.Domain.Entities 
{

    public class Student : Entity
    {
        private IList<Subscription>_subscriptions;

        public Student(Name name, Document document, Email email, Address address)
        {
            Name = name;
            Document = document;
            Email = email;
            Address = address;
            _subscriptions = new List<Subscription>();

           AddNotifications(name, document, email, address);
        }

        public Name Name { get; set; }
        public Document Document { get; private set; }
        public Email Email { get; private set; }
        public Address Address { get; private set; }
        public IReadOnlyCollection<Subscription> Subscriptions { get { return _subscriptions.ToArray(); } }

        public void AddSubscription(Subscription subscription)
        {
            var hasSubscription = false;

            foreach(var sb in _subscriptions)
            {
                if(sb.Active)
                    hasSubscription = true;
            }

            //TODO: Mudar para Fluent Validator
            // AddNotifications(new Contract()
            //     .Requires()
            //     .IsFalse(hasSubscription, "Student.Subscription", "Ja tem assinatura ativa!")
            // );

            //Alternativa
            if(hasSubscription)
            {
                AddNotification("Student.Subscription", "Ja tem assinatura ativa!");
            }
            else
            {
                _subscriptions.Add(subscription);
            }
        }
    }
}