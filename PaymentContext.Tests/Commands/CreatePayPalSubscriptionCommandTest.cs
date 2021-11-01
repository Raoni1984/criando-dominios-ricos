using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.Commands;

namespace PaymentContext.Tests.Commands
{
    [TestClass]
    public class CreatePayPalSubscriptionCommandTest
    {
        [TestMethod]
        public void RecebeNomeInvalido_RetornaErro()
        {
            var command = new CreatePayPalPaymentSubscriptionCommand();
            command.FirstName = "";

            //TODO: implent validation on CreatePayPalPaymentSubscriptionCommand using Fluent Validator
            // command.Validate();
            // Assert.AreEqual(false, command.Valid);

        }
    }
}