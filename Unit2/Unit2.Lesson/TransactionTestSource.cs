namespace Unit2.Lesson
{
    public class TransactionTestSource
    {
        public static IEnumerable<TestCaseData> TestData()
        {
            yield return new TestCaseData(0m);
            yield return new TestCaseData(4m);
            yield return new TestCaseData(7m);
            yield return new TestCaseData(1_000_001m);
        }
    }
}