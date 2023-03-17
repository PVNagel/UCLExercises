using ExtensionMethods;

namespace ExtensionMethodsTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Shift_ReturnsOriginalString_WhenAmountIsZero()
        {
            // Arrange
            string original = "This is my life";
            int amount = 0;

            // Act
            string shifted = original.Shift(amount);

            // Assert
            Assert.AreEqual("This is my life", shifted);
        }

        [TestMethod]
        public void Shift_ShiftsStringRight_WhenAmountIsPositive()
        {
            // Arrange
            string original = "This is my life";
            int amount = 1;

            // Act
            string shifted = original.Shift(amount);
            // Assert
            Assert.AreEqual("eThis is my lif", shifted);
        }

        [TestMethod]
        public void Shift_ShiftsStringLeft_WhenAmountIsNegative()
        {
            // Arrange
            string original = "This is my life";
            int amount = -1;

            // Act
            string shifted = original.Shift(amount);
            // Assert
            Assert.AreEqual("his is my lifeT", shifted);
        }

        [TestMethod]
        public void Shift_ShiftsStringLeft_WhenAmountIsPositiveAndWhitespaceIsTakenIntoAccount()
        {
            // Arrange
            string original = "This is my life";
            int amount = 5;

            // Act
            string shifted = original.Shift(amount);

            // Assert
            Assert.AreEqual(" lifeThis is my", shifted);
        }

        [TestMethod]
        public void Shift_ReturnOriginalString_WhenShiftingAmountEqualToStringLenth()
        {
            // Arrange
            string original = "This is my life";
            int amount = original.Length;

            // Act
            string shifted = original.Shift(amount);

            // Assert
            Assert.AreEqual("This is my life", shifted);
        }

        [TestMethod]
        public void Shift_ShiftStringCorrectlyLeft_WhenAmountIsGreaterThanStringLength()
        {
            // Arrange
            string original = "This is my life";
            int amount = 16;

            // Act
            string shifted = original.Shift(amount);

            // Assert
            Assert.AreEqual("eThis is my lif", shifted);
        }

        [TestMethod]
        public void Shift_ShiftStringCorrectlyRight_WhenAmountIsNegativeAndGreaterThanStringLength()
        {
            // Arrange
            string original = "This is my life";
            int amount = -16;

            // Act
            string shifted = original.Shift(amount);

            // Assert
            Assert.AreEqual("his is my lifeT", shifted);
        }

        [TestMethod]
        public void Shift_ReturnsEmptyString_WhenInputIsNull()
        {
            // Arrange
            string original = null;
            int amount = 3;

            // Act
            string shifted = original.Shift(amount);

            // Assert
            Assert.AreEqual("", shifted);
        }

        [TestMethod]
        public void Age_ReturnsAge_WhenReferenceDateIsSupplied()
        {
            // Arrange
            DateTime birthDate = new DateTime(2003, 3, 1);
            DateTime referenceDate = new DateTime(2023, 3, 5);

            // Act
            int age = birthDate.Age(referenceDate);

            // Assert
            Assert.AreEqual(20, age);
        }

        [TestMethod]
        public void Age_ReturnsZero_WhenReferenceDateIsSameAsBirthDate()
        {
            // Arrange
            DateTime birthDate = new DateTime(2000, 1, 1);
            DateTime referenceDate = new DateTime(2000, 1, 1);

            // Act
            int age = birthDate.Age(referenceDate);

            // Assert
            Assert.AreEqual(0, age);
        }

        [TestMethod]
        public void Age_ReturnsOne_WhenReferenceDateIsOneYearAfterBirthDate()
        {
            // Arrange
            DateTime birthDate = new DateTime(2000, 1, 1);
            DateTime referenceDate = new DateTime(2001, 1, 1);

            // Act
            int age = birthDate.Age(referenceDate);

            // Assert
            Assert.AreEqual(1, age);
        }

        [TestMethod]
        public void Age_ReturnsZero_WhenReferenceDateIsBeforeBirthDate()
        {
            // Arrange
            DateTime birthDate = new DateTime(2000, 1, 1);
            DateTime referenceDate = new DateTime(1999, 1, 1);

            // Act
            int age = birthDate.Age(referenceDate);

            // Assert
            Assert.AreEqual(0, age);
        }

        [TestMethod]
        public void Age_ReturnsZero_WhenReferenceDateIsOneDayBeforeBirthDate()
        {
            // Arrange
            DateTime birthDate = new DateTime(2000, 1, 1);
            DateTime referenceDate = new DateTime(1999, 12, 31);

            // Act
            int age = birthDate.Age(referenceDate);

            // Assert
            Assert.AreEqual(0, age);
        }

        [TestMethod]
        public void Age_ReturnsZero_WhenReferenceDateIsOneDayBeforeLeapYear()
        {
            // Arrange
            DateTime birthDate = new DateTime(2000, 2, 29);
            DateTime referenceDate = new DateTime(2001, 2, 28);

            // Act
            int age = birthDate.Age(referenceDate);

            // Assert
            Assert.AreEqual(0, age);
        }

        [TestMethod]
        public void Age_ReturnsTen_WhenReferenceDateIsTenYearsAfterBirthDate()
        {
            // Arrange
            DateTime birthDate = new DateTime(2000, 1, 1);
            DateTime referenceDate = new DateTime(2010, 1, 1);

            // Act
            int age = birthDate.Age(referenceDate);

            // Assert
            Assert.AreEqual(10, age);
        }

        // BONUS - need to use "DateTime?"
        //[TestMethod]
        //public void Age_ReturnsAge_WhenReferenceDateIsNotSupplied()
        //{
        //    // Arrange
        //    DateTime birthDate = new DateTime(1990, 1, 1);

        //    // Act
        //    int age = birthDate.Age();

        //    // Assert
        //    Assert.AreEqual(DateTime.Now.Year - birthDate.Year, age);
        //}
    }
}