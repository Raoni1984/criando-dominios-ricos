using PaymentContext.Shared.ValueObjects;

namespace PaymentContext.Domain.ValueObjects
{
    public class Email : ValueObject
    {
        public Email(string emailAddress)
        {
            EmailAddress = emailAddress;

            ////TODO: Mudar para Fluent Validator
            // AddNotifications(new Contract()
            //     .Requires()
            //     .IsEmail(emailAddress, "Email.Address", "E-mail invalido")
            // );
        }

        

        public string EmailAddress { get; private set; }

       
    }
}
