using PaymentContext.Shared.ValueObjects;

namespace PaymentContext.Domain.ValueObjects
{
    public class Name : ValueObject
    {
        public Name(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;

            if(string.IsNullOrEmpty(FirstName))
            {
                AddNotification("FirstName","Nome Invalido");
            }
              if(string.IsNullOrEmpty(LastName))
            {
                AddNotification("LastName","Nome Invalido");
            }

            ////TODO: Mudar para Fluent Validator
            // AddNotifications(new Contract()
            //     .Requires()
            // );
        }

        public string FirstName { get; private set; }
        public string LastName { get; private set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
