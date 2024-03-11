using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;
using Xunit;

namespace Area_figures.Tests
{
    [TestClass]
    public class Area_figuresTests
    {
        [Fact]
        public void CreateTriangleWithWrongParameters()
        {
            double a = 6;
            double b = 2.2;
            double c = 0.5;
          
            try
            {
                new Triangle(a, b, c);
                Assert.Fail("Exception not thrown");
            }
            catch (ArgumentOutOfRangeException)
            {

            }
        }
        [Fact]
        public void CalculateTriangleAreaTest()
        {
            double a = 3.0;
            double b = 4.0;
            double c = 5.0;
            Triangle triangle = new Triangle(a, b, c);
        
            double area = triangle.Area();
       
            Assert.IsTrue(area <= 6.0 && area > 5.99);
        }
        [Fact]
        public void CheckIfTriangleIsRight()
        {
            double a = 3.0;
            double b = 4.0;
            double c = 5.0;
            Triangle triangle = new Triangle(a, b, c);
         
            bool testResult = triangle.CheckRightTriangle();
         
            Assert.IsTrue(testResult);
        }
        [Fact]
        public void CalculateCircleAreaTest()
        {
            double radius = 3.0;
            Circle circle = new Circle(radius);
            double expectedArea = Math.PI * Math.Pow(3, 2);
           
            double area = circle.Area();
          
            Assert.AreEqual(expectedArea, area);
        }
    }
}