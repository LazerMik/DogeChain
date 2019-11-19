using DogeChain.SimpleApi.Platform;
using NUnit.Framework;

namespace DogeChain.Tests.SimpleApi
{
    [TestFixture]
    public class PlatformServiceTests
    {
        private IDogechainInfoService _dogechainInfoService = new DogechainInfoService();

        [Test]
        public void GetBlockCountTest()
        {
            var blockCount = _dogechainInfoService
                .GetBlockCountAsync()
                .GetAwaiter()
                .GetResult();
            
            Assert.IsNotNull(blockCount);
            Assert.IsNotEmpty(blockCount);
        }
        
        [Test]
        public void GetCurrentDifficultyTest()
        {
            var currentDifficulty = _dogechainInfoService
                .GetCurrentDifficultyAsync()
                .GetAwaiter()
                .GetResult();
            
            Assert.IsNotNull(currentDifficulty);
            Assert.IsNotEmpty(currentDifficulty);
        }
        
        [Test]
        public void GetTotalMinedTest()
        {
            var totalMined = _dogechainInfoService
                .GetTotalMinedAsync()
                .GetAwaiter()
                .GetResult();
            
            Assert.IsNotNull(totalMined);
            Assert.IsNotEmpty(totalMined);
        }
    }
}