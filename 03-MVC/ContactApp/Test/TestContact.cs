using Microsoft.VisualStudio.TestTools.UnitTesting;
using Domain;

namespace Test
{
    [TestClass]
    public class TestContact
    {
        [TestMethod]
        public void TestGetName()
        {
            Contact c = new Contact();
            string fullnameExpected = "Nick Alfredo Escalona";
            string fullnameActual=c.GetName("Nick", "Alfredo", "Escalona");
            Assert.AreEqual(fullnameExpected, fullnameActual);
        }
    }
}
