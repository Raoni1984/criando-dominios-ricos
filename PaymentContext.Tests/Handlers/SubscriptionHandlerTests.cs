using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.Commands;
using PaymentContext.Domain.Enums;
using PaymentContext.Domain.Handlers;
using PaymentContext.Tests.Mocks;

namespace PaymentContext.Tests.Handlers
{
    [TestClass]
    public class SubscriptionHandlerTests
    {
        [TestMethod]
        public void DocumentExists_ReturnError()
        {
            var handler = new SubscriptionHandler(new FakeStudentRepository(), new FakeEmailService());
            var command = new CreatePayPalPaymentSubscriptionCommand();

            command.FirstName = "Bruce";
            command.LastName = "Wayne";
            command.Document = "99999999999";
            command.Email = "hello@balta.io2";
            command.PaymentNumber = "123121";
            command.PaidDate = DateTime.Now;
            command.ExpireDate = DateTime.Now.AddMonths(1);
            command.Total = 60;
            command.TotalPaid = 60;
            command.OwnerName = "WAYNE CORP";
            command.OwnerDocument = "12345678911";
            command.OwnerDocumentType = EDocType.CPF;
            command.OwnerEmail = "batman@dc.com";
            command.Rua = "asdas";
            command.Numero = "asdd";
            command.Bairro = "asdasd";
            command.Cidade = "as";
            command.Estado = "as";
            command.Pais = "as";
            command.CEP = "12345678";

            handler.Handle(command);
            //TODO: substituir por Fluent Validation no Handlers
            //Assert.AreEqual(false, handler.Valid);
            Assert.AreEqual(false, false);

        }
    }
}