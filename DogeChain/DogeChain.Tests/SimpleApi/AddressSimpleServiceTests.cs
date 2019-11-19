using DogeChain.SimpleApi.Address;
using NUnit.Framework;

namespace DogeChain.Tests.SimpleApi
{
    [TestFixture]
    public class AddressSimpleServiceTests
    {
        private IAddressService _addressService = new AddressService();

        [Test]
        public void GetBalanceTest()
        {
            var address = _addressService
                .GetBalanceAsync("DTnt7VZqR5ofHhAxZuDy4m3PhSjKFXpw3e")
                .GetAwaiter()
                .GetResult();
            
            Assert.IsNotNull(address);
            Assert.IsNotEmpty(address);
        }
        
        
        [Test]
        public void GetHashTest()
        {
            var hash = _addressService
                .AddressToHashAsync("DTnt7VZqR5ofHhAxZuDy4m3PhSjKFXpw3e")
                .GetAwaiter()
                .GetResult();
            
            Assert.IsNotNull(hash);
            Assert.IsNotEmpty(hash);
        }
        
        [Test]
        public void GetAddressValidationTest()
        {
            var address = _addressService
                .AddressValidationAsync("DTnt7VZqR5ofHhAxZuDy4m3PhSjKFXpw3e")
                .GetAwaiter()
                .GetResult();
            
            Assert.IsNotNull(address);
            Assert.IsNotEmpty(address);
        }
        
        [Test]
        public void DecodeAddressTest()
        {
            var address = _addressService
                .DecodeAddressAsync("DTnt7VZqR5ofHhAxZuDy4m3PhSjKFXpw3e")
                .GetAwaiter()
                .GetResult();
            
            Assert.IsNotNull(address);
            Assert.IsNotEmpty(address);
        }
        
        [Test]
        public void GetRecievedByAddressTest()
        {
            var recievedByAddress = _addressService
                .GetRecievedByAddressAsync("DTnt7VZqR5ofHhAxZuDy4m3PhSjKFXpw3e")
                .GetAwaiter()
                .GetResult();
            
            Assert.IsNotNull(recievedByAddress);
            Assert.IsNotEmpty(recievedByAddress);
        }
        
        [Test]
        public void GetSentByAddressTest()
        {
            var sentByAddress = _addressService
                .GetSentByAddressAsync("DTnt7VZqR5ofHhAxZuDy4m3PhSjKFXpw3e")
                .GetAwaiter()
                .GetResult();
            
            Assert.IsNotNull(sentByAddress);
            Assert.IsNotEmpty(sentByAddress);
        }
    }
}