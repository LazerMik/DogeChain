using DogeChain.JsonApi.Models;
using DogeChain.JsonApi.Transactions;
using NUnit.Framework;

namespace DogeChain.Tests.JsonApi
{
    [TestFixture]
    public class TransactionServiceTests
    {
        private ITransactionService _transactionService = new TransactionService();

        [Test]
        public void GetTransactionModelTest()
        {
            var transaction = _transactionService
                .GetTransactionAsync("bcc4ce3f004b02b50456976dfc4de69d651ba718ce95422f51cd1d4bf7235abb")
                .GetAwaiter()
                .GetResult();
            
            Assert.IsInstanceOf<ResponseModel>(transaction);
            Assert.IsInstanceOf<TransactionModel>(transaction);
            Assert.IsNotNull(transaction);
        }
    }
}