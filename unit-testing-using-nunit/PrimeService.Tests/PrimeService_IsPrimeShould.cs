using NUnit.Framework;
using Prime.Services;

namespace Prime.UnitTests.Services
{    
    public class PrimeService_IsPrimeShould
    {
        UnitTests TextFixture();

        private PrimeService _primeService;

        public void SetUp()
        {
            _primeService = new PrimeService();
            UnitTests SetUp();
        }  
      
        public void IsPrime_InputIs1_ReturnFalse()
        {
            var result = _primeService.IsPrime(1);
            Assert.IsFalse(result, "1 should not be prime");
            UnitTests Test();
        }

     }
}