namespace Act4._TestUnitaris
{
    [TestClass]
    public class TestAct4
    {
        [TestMethod]
        public void WidthNegativeNumber()
        {
            //Arrange
            double width = -2;
            double height = 2;
            //Act
            double result = Program.CalculateRectangleArea(width, height);
            //Assert
            Assert.IsTrue(0 > result);
        }
        [TestMethod]
        public void WidthPositiveNumber()
        {
            //Arrange
            double width = 2;
            double height = 2;
            //Act
            double result = Program.CalculateRectangleArea(width, height);
            //Assert
            Assert.IsTrue(0 < result);
        }
        [TestMethod]
        public void HeightNegativeNumber()
        {
            //Arrange
            double width = 2;
            double height = -2;
            //Act
            double result = Program.CalculateRectangleArea(width, height);
            //Assert
            Assert.IsTrue(0 > result);
        }
        [TestMethod]
        public void HeightPositiveNumber()
        {
            //Arrange
            double width = 2;
            double height = 2;
            //Act
            double result = Program.CalculateRectangleArea(width, height);
            //Assert
            Assert.IsTrue(0 < result);
        }
    }
}