using Slektstre;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Slektstre_Test
{
    [TestClass]
    public class Persontest
    {
        [TestMethod]
        public void TestNoFields()
        {
            var p = new Person
            {
                Id = 1,
            };

            var actualDescription = p.GetDescription();
            var expectedDescription = "(Id=1)";

            Assert.AreEqual(expectedDescription, actualDescription);
        }
        public void TestAllFields()

    }
}
