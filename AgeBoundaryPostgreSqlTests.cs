using System;
using Xunit;
using ApiClientTest.Tests.Helpers;

namespace ApiClientTest.Tests
{
    public class AgeBoundaryPostgreSqlTests
    {
        [Fact]
        public void Leeftijdscheck_Afgewezen_Bij_17_Jaar()
        {
            var geboortedatum = DateTime.Today.AddYears(-17);

            var status = AgeBoundaryHelper.CalculateStatus(geboortedatum);

            Assert.Equal("Afgewezen", status);
        }
    }
}
