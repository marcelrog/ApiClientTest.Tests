namespace ApiClientTest.Tests.Helpers
{
    public static class AgeTestDataHelper
    {
        public static DateTime DayBefore18thBirthday()
        {
            return DateTime.Today.AddYears(-18).AddDays(1);
        }

        public static DateTime DayOf18thBirthday()
        {
            return DateTime.Today.AddYears(-18);
        }

        public static DateTime DayAfter18thBirthday()
        {
            return DateTime.Today.AddYears(-18).AddDays(-1);
        }
    }
}
