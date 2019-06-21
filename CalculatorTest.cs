using NUnit.Framework;
using NSubstitute;

namespace Sample
{
    public class CalculatorTest
    {
        [SetUp]
        public void Start()
        {
            ICalculator mock = Substitute.For<ICalculator>();
            mock.Add(Arg.Any<int>(),Arg.Any<int>()).Returns(2);
        } 
        
        [Test]
        public void Add()
        {
            var calc = new Calculator();
            
            Assert.AreEqual(10,calc.Add(4,6));
        }
    }
}