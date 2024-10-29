using Microsoft.VisualStudio.TestTools.UnitTesting;
using CarDoorsL00188582;

namespace CarDoorTests
{
    [TestClass]
    public class CarDoorUnitTests
    {
        [TestMethod]
        public void TestNonZero()
        {
            //Arrange
            CarDoorCountProvider carDoorProvider = new CarDoorCountProvider();
            carDoorProvider.SetDoors(5);
            int expected = 0;

            //Act
            int actual = carDoorProvider.GetDoors();

            //Assert
            Assert.AreNotEqual(expected, actual);


        }

        [TestMethod]
        public void TestIsEqual()
        {
            //Arrange
            CarDoorCountProvider carDoorProvider = new CarDoorCountProvider();
            carDoorProvider.SetDoors(5);
            int expected = 5;

            //Act
            int actual = carDoorProvider.GetDoors();

            //Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void TestIsNotNull()
        {
            //Arrange
            CarDoorCountProvider carDoorProvider = new CarDoorCountProvider();
            carDoorProvider.SetDoors(5);

            //Act
            int actual = carDoorProvider.GetDoors();

            //Assert
            Assert.IsNotNull(actual);
        }

        [TestMethod]
        public void TestIsInteger()
        {
            //Arrange
            CarDoorCountProvider carDoorProvider = new CarDoorCountProvider();
            carDoorProvider.SetDoors(5);

            //Act
            int actual = carDoorProvider.GetDoors();

            //Assert
            Assert.IsInstanceOfType(actual, typeof(int));
        }

        [TestMethod]
        public void TestUsedToAlwaysFail()
        {
            //Arrange
            CarDoorCountProvider carDoorProvider = new CarDoorCountProvider();
            carDoorProvider.SetDoors(5);
            //  int expected = 3;
            int expected = 5;

            //Act
            int actual = carDoorProvider.GetDoors();

            //Assert
            Assert.AreEqual(expected, actual);

        }
    }
}
