using System;
using Xunit;
using ACM.BL;

namespace ACM.BLtest
{
    public class CustomerTest
    {
        [Fact]
        public void FullNameTestValid()
        {
            // -- Arrange
            Customer customer = new Customer
            {
                FirstName = "Bilbo",
                LastName = "Baggins"
            };
            string expected = "Baggins, Bilbo";

            // -- Act
            string actual = customer.FullName;

            // -- Assert
            Assert.Equal(expected, actual);
        }
    }
}
