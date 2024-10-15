using Microsoft.VisualStudio.TestTools.UnitTesting;
using System; // Переконайся, що вказуєш на правильний простір імен

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        private Person person;

        [TestInitialize]
        public void Setup()
        {
            person = new Person();
        }

        [TestMethod]
        public void TestSetName()
        {
            // Arrange
            string expectedName = "John Doe";

            // Act
            person.SetName(expectedName);
            string actualName = person.GetName();

            // Assert
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(expectedName, actualName);
        }

        [TestMethod]
        public void TestSetAge()
        {
            // Arrange
            int expectedAge = 30;

            // Act
            person.SetAge(expectedAge);
            int actualAge = person.GetAge();

            // Assert
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(expectedAge, actualAge);
        }

        [TestMethod]
        public void TestSetGender()
        {
            // Arrange
            string expectedGender = "Male";

            // Act
            person.SetGender(expectedGender);
            string actualGender = person.GetGender();

            // Assert
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(expectedGender, actualGender);
        }

        [TestMethod]
        public void TestSetPhoneNumber()
        {
            // Arrange
            string expectedPhoneNumber = "123-456-7890";

            // Act
            person.SetPhoneNumber(expectedPhoneNumber);
            string actualPhoneNumber = person.GetPhoneNumber();

            // Assert
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(expectedPhoneNumber, actualPhoneNumber);
        }
    }
}
