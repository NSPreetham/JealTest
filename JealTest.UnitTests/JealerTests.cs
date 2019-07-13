using JealTest;
using NUnit.Framework;

namespace JealTests.UnitTests
{
    [TestFixture]
    public class JealerTests
    {

        [Test]
        public void CapitalNames_AllSmallLetters()
        {
            // Arrange
            string str = "mavis senaida letty";
            // Act
            string Answer = JFun.CapitalNames(str);
            // Assert
            string Result = "Mavis Senaida Letty";
            Assert.AreEqual(Result, Answer);
        }

        public void CapitalNames_CapitalAndSmallLetters()
        {
            // Arrange
            string str = "SlyVia KrisTal ShariLyn CaLista";
            // Act
            string Answer = JFun.CapitalNames(str);
            // Assert
            string Result = "Slyvia Kristal Sharilyn Calista";
            Assert.AreEqual(Result, Answer);
        }

        public void CapitalNames_CapitalLetters()
        {
            // Arrange
            string str = "samuel MABELLE letitia meridith";
            // Act
            string Answer = JFun.CapitalNames(str);
            // Assert
            string Result = "Samuel Mabelle Letitia Meridith";
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
