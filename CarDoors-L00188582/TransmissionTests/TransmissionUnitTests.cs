using CarDoors_L00188582;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TransmissionTests
{
    [TestClass]
    public class TransmissionUnitTests
    {
        [TestMethod]
        public void TestNotNullOrEmpty()
        {
            //Arrange
            TransmissionProvider transmissionProvider = new TransmissionProvider();
            transmissionProvider.SetTransmissionType("Automatic");
            bool expected = false;

            //Act
            bool actual = string.IsNullOrWhiteSpace(transmissionProvider.GetTransmissionType());

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
