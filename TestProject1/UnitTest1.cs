using eShop.DataStore.HardCoded;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var productRepository = new ProductRepository();
            productRepository.GetProducts(null);
        }
    }
}
