using Microsoft.VisualStudio.TestTools.UnitTesting;
using PersonalProjectLab;

namespace PersonalProjectLabTests
{
    [TestClass]
    public class GPA_CalculatorTest
    {
        [TestMethod]
        public void GPA_CalculatorTest1()
        {
            //arrange

            GPA_Calculator GPA = new GPA_Calculator();

            //act

            decimal Calculated_GPA = GPA.CalculateGPA(8, 0, 0, 8, 0, 0, 0, 0, 0, 0, 0, 16);

            //assertion

            Assert.AreEqual(3.50m, Calculated_GPA);
        }
    }
}
