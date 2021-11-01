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

            ////TODO: Mudar para Fluent Validator
            // AddNotifications(new Contract()
            //     .Requires()
            //     .IsTrue(ValidateDoc(), "Document.Number", "Documento invalido")
            // );
        }

        public string Number { get; private set; }
        public EDocType Type { get; set; }
        // public bool IsValid { get; set; }

        public bool ValidateDoc(){

            if(Type == EDocType.CNPJ && Number.Length == 14)
            {
                return true;
            }

            if(Type == EDocType.CPF && Number.Length == 11)
            {
                return true;
            }

            return false;
        }
    }
}
