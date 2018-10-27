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

        [TestMethod()]
        public void SkillSearchTest()
        {
            // Arrange
            var controller = new PredictController();

            // Act
            var result = controller.SkillSearch();

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod()]
        public void MonsterSearchTest()
        {
            // Arrange
            var controller = new PredictController();

            // Act
            var result = controller.MonsterSearch();

            // Assert
            Assert.IsNotNull(result);
        }
    }
}