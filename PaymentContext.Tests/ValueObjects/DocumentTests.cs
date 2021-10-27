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
            Assert.IsTrue(doc.IsValid);
            
        }
    }
}