using System;

namespace Unit2.Lesson
{
    public class Transaction
    {
        public decimal CalculateTransaction(decimal amount)
        {
            if (amount < 10 || amount > 1_000_000)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "The amount should be between 10 and 1000000.");
            }

            decimal commission = 0;
            commission = amount switch
            {
                var a when a >= 10 && a <= 999 => a * 0.1m,
                var a when a >= 1000 && a <= 9999 => a * 0.05m,
                var a when a >= 10_000 => a * 0.01m,
                _ => throw new ArgumentOutOfRangeException(nameof(amount))
            };
            
            return amount + commission;
        }
    }
}