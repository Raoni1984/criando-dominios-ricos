using PaymentContext.Domain.Enums;
using PaymentContext.Shared.ValueObjects;

namespace PaymentContext.Domain.ValueObjects
{
    public class Document : ValueObject
    {
        public Document(string number, EDocType docType)
        {
            Number = number;
            Type = docType;
        }

        public string Number { get; private set; }
        public EDocType Type { get; set; }
    }
}
