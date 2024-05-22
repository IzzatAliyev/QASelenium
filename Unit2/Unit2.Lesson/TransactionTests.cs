using System;

namespace Unit2.Lesson
{
    [TestFixture]
    public class TransactionTests
    {
        private Transaction transaction;

        [SetUp]
        public void Setup()
        {
            transaction = new Transaction();
        }

        [Test]
        [Category("Exception")]
        [TestCaseSource(typeof(TransactionTestSource), nameof(TransactionTestSource.TestData))]
        public void CalculateTransaction_InvalidAmount_ThrowsArgumentOutOfRangeException(decimal amount)
        {
            Assert.Catch<ArgumentOutOfRangeException>(() => transaction.CalculateTransaction(amount));
        }

        [Test]
        [Category("Equal")]
        public void CalculateTransaction_AmountBetween10And999_ReturnsAmountPlus10PercentCommission()
        {
            decimal amount = 500;
            decimal result = transaction.CalculateTransaction(amount);

            Assert.AreEqual(amount * 1.1m, result);
        }

        [Test]
        [Category("Equal")]
        public void CalculateTransaction_AmountBetween1000And9999_ReturnsAmountPlus5PercentCommission()
        {
            decimal amount = 5000;
            decimal result = transaction.CalculateTransaction(amount);

            Assert.AreEqual(amount * 1.05m, result);
        }

        [Test]
        [Category("Equal")]
        public void CalculateTransaction_AmountGreaterThan10000_ReturnsAmountPlus1PercentCommission()
        {
            decimal amount = 50000;
            decimal result = transaction.CalculateTransaction(amount);

            Assert.AreEqual(amount * 1.01m, result);
        }
    }
}