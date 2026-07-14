using System;
using Xunit;
using ApiClientTest.Tests.Helpers;

namespace ApiClientTest.Tests
{
    public class BoundaryApiTests
    {
        [Fact]
        public void Leeftijdscheck_Toegestaan_Bij_18_Jaar()
        {
            var geboortedatum = DateTime.Today.AddYears(-18);

            var status = AgeBoundaryHelper.CalculateStatus(geboortedatum);

            Assert.Equal("Toegestaan", status);
        }
    }
}
