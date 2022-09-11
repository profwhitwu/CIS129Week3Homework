namespace Week3_Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SumOfTwoNumbers_ReturnsSum()
        {
            // arrange
            Operators operators = new Operators();

            // act
            var result = operators.SumOfTwoNumbers(1, 2);

            // assert
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void DifferenceOfTwoNumbers_ReturnsXMinusY()
        {
            // arrange
            Operators operators = new Operators();

            // act
            var result = operators.DifferenceOfTwoNumbers(5, -5);

            // assert
            Assert.AreEqual(10, result);
        }

        [TestMethod]
        public void ProductOfTwoNumbers_ReturnsXTimesY()
        {
            // arrange
            Operators operators = new Operators();

            // act 
            var result = operators.ProductOfTwoNumbers(6, 2);

            // assert
            Assert.AreEqual(12, result);
        }

        [TestMethod]
        public void QuotientOfTwoNumbers_ReturnsQuotient()
        {
            // arrange
            Operators operators = new Operators();

            // act 
            var result = operators.QuotientOfTwoNumbers(6, 3);

            // assert 
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void QuotientOfTwoNumbers_YIsZero_ReturnsNull()
        {
            // arrange
            Operators operators = new Operators();

            // act 
            var result = operators.QuotientOfTwoNumbers(6, 0);

            // assert 
            Assert.AreEqual(null, result);
        }

        [TestMethod]
        public void DividentOfTwoNumbers_ReturnsDividend()
        {
            // arrange
            Operators operators = new Operators();

            // act
            var result = operators.DividendOfTwoNumbers(6, 4);

            // Assert 
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void DividentOfTwoNumbers_YIsZero_ReturnsNull()
        {
            // arrange
            Operators operators = new Operators();

            // act
            var result = operators.DividendOfTwoNumbers(6, 0);

            // Assert 
            Assert.AreEqual(null, result);
        }

        [TestMethod]
        public void IsXGreaterThanY_XIsGreater_ReturnsTrue()
        {
            // arrange
            Operators operators = new Operators();

            // act
            var result = operators.IsXGreaterThanY(10, 3);

            // assert 
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsXGreaterThanY_YIsGreater_ReturnsFalse()
        {
            // arrange
            Operators operators = new Operators();

            // act 
            var result = operators.IsXGreaterThanY(3, 10);

            // assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsXLessThanY_XIsLessThanY_ReturnsTrue()
        {
            // arrange
            Operators operators = new Operators();

            // act
            var result = operators.IsXLessThanY(1, 6);

            // assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsXLessThanY_XIsGreterThanY_ReturnsFalse()
        {
            // arrange
            Operators operators = new Operators();

            // act
            var result = operators.IsXLessThanY(5, 2);

            // assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsXGreaterThanOrEqualToY_XIsGreaterThanY_ReturnsTrue()
        {
            // arragne 
            Operators operators = new Operators();

            // act
            var result = operators.IsXGreaterThanOrEqualToY(10, 3);

            // assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsXGreaterThanOrEqualToY_XIsEqualToY_ReturnsTrue()
        {
            // arragne 
            Operators operators = new Operators();

            // act
            var result = operators.IsXGreaterThanOrEqualToY(3, 3);

            // assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsXGreaterThanOrEqualToY_XIsLessThanY_ReturnsFalse()
        {
            // arragne 
            Operators operators = new Operators();

            // act
            var result = operators.IsXGreaterThanOrEqualToY(1, 3);

            // assert
            Assert.IsFalse(result);
        }


        [TestMethod]
        public void IsXLessThanOrEqualToY_XIsLessThanY_ReturnsTrue()
        {
            // arrange
            Operators operators = new Operators();

            // act
            var result = operators.IsXLessThanOrEqualToY(1, 3);

            // assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsXLessThanOrEqualToY_XEqualsY_ReturnsTrue()
        {
            // arrange
            Operators operators = new Operators();

            // act
            var result = operators.IsXLessThanOrEqualToY(1, 1);

            // assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsXLessThanOrEqualToY_XIsGreaterThanY_ReturnsFalse()
        {
            // arrange
            Operators operators = new Operators();

            // act
            var result = operators.IsXLessThanOrEqualToY(3, 1);

            // assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void AreXAndYEqual_XAndYAreEqual_ReturnsTrue()
        {
            // arrange
            Operators operators = new Operators();

            // act
            var result = operators.AreXAndYEqual(1, 1);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void AreXAndYEqual_XAndYAreNotEqual_ReturnsFalse()
        {
            // arrange
            Operators operators = new Operators();

            // act
            var result = operators.AreXAndYEqual(1, 2);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsXOrYGreaterThanZero_XAndYGreaterThanZero_ReturnsTrue()
        {
            // arrange
            Operators operators = new Operators();

            // act
            var result = operators.IsXOrYGreaterThanZero(1, 1);

            // assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsXOrYGreaterThanZero_XIsGreater_ReturnsTrue()
        {
            // arrange
            Operators operators = new Operators();

            // act
            var result = operators.IsXOrYGreaterThanZero(1, -1);

            // assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsXOrYGreaterThanZero_YIsGreater_ReturnsTrue()
        {
            // arrange
            Operators operators = new Operators();

            // act
            var result = operators.IsXOrYGreaterThanZero(-1, 1);

            // assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsXOrYGreaterThanZero_NeitherAreGreater_ReturnsFalse()
        {
            // arrange
            Operators operators = new Operators();

            // act
            var result = operators.IsXOrYGreaterThanZero(-1, -1);

            // assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void AreXAndYGreaterThanZero_XAndYAreGreater_ReturnsTrue()
        {
            // arrange
            Operators operators = new Operators();

            // act
            var result = operators.AreXAndYGreaterThanZero(1, 1);

            // assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void AreXAndYGreaterThanZero_XGreaterThanZeroYLessThanZero_ReturnsFalse()
        {
            // arrange
            Operators operators = new Operators();

            // act
            var result = operators.AreXAndYGreaterThanZero(1, -1);

            // assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void AreXAndYGreaterThanZero_XLessThanZeroYGreaterThanZero_ReturnsFalse()
        {
            // arrange
            Operators operators = new Operators();

            // act
            var result = operators.AreXAndYGreaterThanZero(-1, 1);

            // assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void AreXAndYGreaterThanZero_XAndYLessThan0_ReturnsFalse()
        {
            // arrange
            Operators operators = new Operators();

            // act
            var result = operators.AreXAndYGreaterThanZero(-1, -1);

            // assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void AreXAndYGreaterThanZero_XAndYAre0_ReturnsFalse()
        {
            // arrange
            Operators operators = new Operators();

            // act
            var result = operators.AreXAndYGreaterThanZero(0, 0);

            // assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsXNotEqualToY_XNotEqualToY_ReturnsTrue()
        {
            // arrange
            Operators operators = new Operators();

            // act
            var result = operators.IsXNotEqualToY(0, 1);

            // assert 
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsXNotEqualToY_XEqualToY_ReturnsFalse()
        {
            // arrange
            Operators operators = new Operators();

            // act
            var result = operators.IsXNotEqualToY(1, 1);

            // assert 
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void ReturnCustomerTypeDiscountRate_IsStudent_Returns10Percent()
        {
            // arrange
            Operators operators = new Operators();

            // act
            var result = operators.ReturnCustomerTypeDiscountRate(Operators.CustomerType.Student);

            // assert
            Assert.AreEqual((decimal?)0.1, result);
        }

        [TestMethod]
        public void ReturnCustomerTypeDiscountRate_IsSenior_Returns15Percent()
        {
            // arrange
            Operators operators = new Operators();

            // act
            var result = operators.ReturnCustomerTypeDiscountRate(Operators.CustomerType.Senior);

            // assert
            Assert.AreEqual((decimal?)0.15, result);
        }

        [TestMethod]
        public void ReturnCustomerTypeDiscountRate_IsChild_Returns100Percent()
        {
            // arrange
            Operators operators = new Operators();

            // act
            var result = operators.ReturnCustomerTypeDiscountRate(Operators.CustomerType.Child);

            // assert
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void ReturnCustomerTypeDiscountRate_IsAdult_ReturnsNull()
        {
            // arrange
            Operators operators = new Operators();

            // act
            var result = operators.ReturnCustomerTypeDiscountRate(Operators.CustomerType.Adult);

            // assert
            Assert.AreEqual(null, result);
        }

        [TestMethod]
        public void ReturnCustomerTypeDiscountRate_IsMilitary_Returns20Percent()
        {
            // arrange
            Operators operators = new Operators();

            // act
            var result = operators.ReturnCustomerTypeDiscountRate(Operators.CustomerType.Military);

            // assert
            Assert.AreEqual((decimal?)0.2, result);
        }

        [TestMethod]
        public void ReturnCustomerTypeDiscountRateSwtich_IsStudent_Returns10Percent()
        {
            // arrange
            Operators operators = new Operators();

            // act
            var result = operators.ReturnCustomerTypeDiscountRateSwitch(Operators.CustomerType.Student);

            // assert
            Assert.AreEqual((decimal?)0.1, result);
        }

        [TestMethod]
        public void ReturnCustomerTypeDiscountRateSwitch_IsSenior_Returns15Percent()
        {
            // arrange
            Operators operators = new Operators();

            // act
            var result = operators.ReturnCustomerTypeDiscountRateSwitch(Operators.CustomerType.Senior);

            // assert
            Assert.AreEqual((decimal?)0.15, result);
        }

        [TestMethod]
        public void ReturnCustomerTypeDiscountRateSwitch_IsChild_Returns100Percent()
        {
            // arrange
            Operators operators = new Operators();

            // act
            var result = operators.ReturnCustomerTypeDiscountRateSwitch(Operators.CustomerType.Child);

            // assert
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void ReturnCustomerTypeDiscountRateSwitch_IsAdult_ReturnsNull()
        {
            // arrange
            Operators operators = new Operators();

            // act
            var result = operators.ReturnCustomerTypeDiscountRateSwitch(Operators.CustomerType.Adult);

            // assert
            Assert.AreEqual(null, result);
        }

        [TestMethod]
        public void ReturnCustomerTypeDiscountRateSwitch_IsMilitary_Returns20Percent()
        {
            // arrange
            Operators operators = new Operators();

            // act
            var result = operators.ReturnCustomerTypeDiscountRateSwitch(Operators.CustomerType.Military);

            // assert
            Assert.AreEqual((decimal?)0.2, result);
        }
    }
}