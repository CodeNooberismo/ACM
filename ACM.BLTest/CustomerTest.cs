using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ACM.BL;

namespace ACM.BLTest
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void FullNameValid()
        {
            //--Arrange
            Customer customer = new Customer();
            customer.FirstName = "Bilbo";
            customer.LastName = "Baggins";

            var expected = "Baggins, Bilbo";

            //--Act
            var actual = customer.FullName;

            //--Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
