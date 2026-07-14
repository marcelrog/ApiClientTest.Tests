namespace ApiClientTest.Tests.Helpers
{
    public static class AgeBoundaryHelper
    {
        public static string CalculateStatus(DateTime geboortedatum)
        {
            var vandaag = DateTime.Today;

            // Iemand is 18 als geboortedatum + 18 jaar <= vandaag
            var achttienJaar = geboortedatum.AddYears(18);

            return achttienJaar <= vandaag
                ? "Toegestaan"
                : "Afgewezen";
        }
    }
}
