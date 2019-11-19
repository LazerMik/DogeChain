using System.Threading.Tasks;
using DogeChain.JsonApi.Address;
using DogeChain.JsonApi.Models;
using NUnit.Framework;

namespace DogeChain.Tests.JsonApi
{
    [TestFixture]
    public class AddressServiceTests
    {
        private IAddressService _addressService = new AddressService();

        [Test]
        public void GetBalanceSuccessTest()
        {
            var balance = _addressService
                .GetBalanceAsync("DTnt7VZqR5ofHhAxZuDy4m3PhSjKFXpw3e")
                .GetAwaiter()
                .GetResult();
            
            Assert.IsInstanceOf<ResponseModel>(balance);
            Assert.IsInstanceOf<BalanceModel>(balance);
            Assert.IsNotNull(balance);
        }
        
        
        [Test]
        public void GetErrorTest()
        {
            var error = _addressService
                .GetBalanceAsync("DTnt7VZqR5ofHhAxZuDy4m3PhSjKFXpe")
                .GetAwaiter()
                .GetResult();
            
            Assert.IsInstanceOf<ResponseModel>(error);
            Assert.IsInstanceOf<ErrorModel>(error);
            Assert.IsNotNull(error);
        }
        
        [Test]
        public void GetAmountReceivedTest()
        {
            var totalAmount = _addressService
                .GetRecievedByAddressAsync("DTnt7VZqR5ofHhAxZuDy4m3PhSjKFXpw3e")
                .GetAwaiter()
                .GetResult();
            
            Assert.IsInstanceOf<ResponseModel>(totalAmount);
            Assert.IsInstanceOf<TotalAmountModel>(totalAmount);
            Assert.IsNotNull(totalAmount);
        }
        
        [Test]
        public void GetAmountSentTest()
        {
            var totalAmountSent = _addressService
                .GetSentByAddressAsync("DTnt7VZqR5ofHhAxZuDy4m3PhSjKFXpw3e")
                .GetAwaiter()
                .GetResult();
            
            Assert.IsInstanceOf<ResponseModel>(totalAmountSent);
            Assert.IsInstanceOf<SentAmountModel>(totalAmountSent);
            Assert.IsNotNull(totalAmountSent);
        }
    }
}