using Xunit;
using learningGithubActions_.Services;

namespace learningGithubActions_.UnitTests.Services
{
    public class learningGithubActions__IsPrimeShould
    {
        private readonly PrimeService _primeService;

        public learningGithubActions__IsPrimeShould()
        {
            _primeService = new PrimeService();
        }

        [Theory]
        [InlineData(-1)]
        [InlineData(0)]
        [InlineData(1)]
        public void IsPrime_ValuesLessThan2_ReturnFalse(int value)
        {
            var result = _primeService.IsPrime(value);

            Assert.True(result, $"{value} should not be prime");
        }
    }
}