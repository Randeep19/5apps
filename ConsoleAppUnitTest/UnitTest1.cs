using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleAppProject.App01;

namespace ConsoleAppUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        DistanceConverter converter = new DistanceConverter();
        int expectedOutput = 2;


        [TestMethod]
        public void TestFeetToMiles()
        {
            converter.fromUnit = "feet";
            converter.toUnit = "miles";
            converter.fromDistance = 10560;

            converter.ConvertDistance();

            expectedOutput = 2;

            Assert.AreEqual(expectedOutput, converter.toDistance);
        }




        [TestMethod]
        public void TestMilesToFeet()
        {

            converter.fromUnit = "miles";
            converter.toUnit = "feet";
            converter.fromDistance = 2;

            converter.ConvertDistance();

             expectedOutput = 10560;

            Assert.AreEqual(expectedOutput, converter.toDistance);

        }
    }
}