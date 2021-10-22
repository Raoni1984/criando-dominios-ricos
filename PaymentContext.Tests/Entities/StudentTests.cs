using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.Entities;

namespace PaymentContext.Tests
{
    [TestClass]
    public class StudentTests
    {
        [TestMethod]
        public void TestMethod1()
        { 
            var student = new Student( "Andre", "Solari", "1234", "andre@email.com");
            var subscription = new Subscription(null);
            
            
        }
    }
}

