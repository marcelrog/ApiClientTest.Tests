using Xunit;
using ApiClientTest.Tests.Helpers;

namespace ApiClientTest.Tests.Helpers
{
    public class AgeBoundaryCombinedTests
    {
        [Fact]
        public void Test_Leeftijdsgrens_18_Jaar()
        {
            // 1️⃣ Testdatums uit jouw bestaande helper
            var before = AgeTestDataHelper.DayBefore18thBirthday();  // Afgewezen
            var on     = AgeTestDataHelper.DayOf18thBirthday();      // Toegestaan
            var after  = AgeTestDataHelper.DayAfter18thBirthday();   // Toegestaan
            Console.WriteLine($"Before={before:yyyy-MM-dd}, On={on:yyyy-MM-dd}, After={after:yyyy-MM-dd}");

            // 2️⃣ Status uit jouw nieuwe AgeBoundaryHelper
            var statusBefore = AgeBoundaryHelper.CalculateStatus(before);
            var statusOn     = AgeBoundaryHelper.CalculateStatus(on);
            var statusAfter  = AgeBoundaryHelper.CalculateStatus(after);

            // 3️⃣ Assertions
            Assert.Equal("Afgewezen",  statusBefore);
            Assert.Equal("Toegestaan", statusOn);
            Assert.Equal("Toegestaan", statusAfter);
        }
    }
}
