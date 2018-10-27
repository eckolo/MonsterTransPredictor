using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MonsterTransPredictor.Controllers.Tests
{
    [TestClass()]
    public class PredictControllerTests
    {
        [TestMethod()]
        public void IndexTest()
        {
            // Arrange
            var controller = new PredictController();

            // Act
            var result = controller.Index();

            // Assert
            Assert.IsNotNull(result);
        }
    }
}