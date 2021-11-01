using System;
using PaymentContext.Domain.Enums;
using PaymentContext.Shared.Commands;

namespace PaymentContext.Domain.Commands
{
    public class CreatePayPalPaymentSubscriptionCommand : ICommand
    {
        public string FirstName { get;  set; }
        public string LastName { get;  set; }
        public string Document { get;  set; }
        public string Email { get;  set; }
        public string TransactionCode { get;  set; }
        public string PaymentNumber { get; set; }
        public DateTime PaidDate { get;  set; }
        public DateTime ExpireDate { get;  set; }
        public decimal Total { get;  set; }
        public decimal TotalPaid { get;  set; }
        public string OwnerName { get;  set; }
        public string OwnerDocument { get;  set; }
         public EDocType OwnerDocumentType { get; set; }
        public string OwnerEmail { get;  set; }
        public string Rua { get;  set; }
        public string Numero { get;  set; }
        public string Complemento { get;  set; }
        public string Bairro { get;  set; }
        public string CEP { get;  set; }
        public string Cidade { get;  set; }
        public string Estado { get;  set; }
        public string Pais { get;  set; }

        //TODO: implementar validations

    }
}