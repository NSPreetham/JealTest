using JealTest;
using NUnit.Framework;

namespace JealTests.UnitTests
{
    [TestFixture]
    public class JealerTests
    {  

        [Test]
        public void CapitalNames_SmallLettersInput()
        {
            // Arrange
            string str = "preetam gautam uday"; 
            // Act
            string Answer = JFun.CapitalNames(str);
            // Assert
            string Result = "Preetam Gautam Uday";
            Assert.AreEqual(Result, Answer);
        }

        [Test]
        public void ReducedFraction_DivideByGCD()
        {
            // Arrange
            string Fract = "16/48";
            // Act
            string ReducedFract = JFun.ReducedFraction(Fract);
            // Assert            
            Assert.AreEqual("1/3", ReducedFract);
        }
        
    }
}
