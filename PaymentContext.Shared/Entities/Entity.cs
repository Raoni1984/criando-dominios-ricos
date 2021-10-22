using System;
using Flunt.Notifications;

namespace PaymentContext.Shared.Entities
{
    public abstract class Entity : Notifiable<Notification>
    {
        protected Entity()
        {
            Id = Guid.NewGuid().ToString().Replace("-", "").Substring(0, 10).ToUpper();
        }

        public string Id { get; private set; }
    }
}