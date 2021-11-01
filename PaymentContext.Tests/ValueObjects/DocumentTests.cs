using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.Enums;
using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Tests
{
    [TestClass]
    public class DocumentTests
    {
        [TestMethod]
        public void ShouldReturnError_InvalidCPF()
        {
            var doc = new Document("123", EDocType.CPF);
            Assert.IsFalse(doc.ValidateDoc());
        }


        [TestMethod]
        [DataTestMethod]
        [DataRow("49491954091")]
        [DataRow("16140618070")]
        [DataRow("39819421080")]
        public void ShouldReturnSuccess_ValidCPF(string cpf)
        {
            var doc = new Document(cpf, EDocType.CPF);
            Assert.IsTrue(doc.IsValid);
        }



    }
}