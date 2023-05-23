using Enhetskonvertering;

namespace TestEnhetskonvertering
{
    public class TestTemp
    {
        private Celsius celsius;
        [OneTimeSetUp]
        public void Setup()
        {
            celsius = new Celsius();
        }

        /// <summary>
        /// Test konvertera Tempraturen från Celsius till Fahrenheit
        /// </summary>
        [TestCase(0, 32)]
        [TestCase(100, 212)]
        [TestCase(-100, -148)]
        public void Test_From_Celsius_To_Fahrenhiet(int celsiustest,int expectedAnswear)
        {

            //Arrange
            //double celsiustest = 5;
            //double expectedAnswear = 41;

            //Act
            double actualAnswear = celsius.ToFarenheit(celsiustest);

            //Assert
            Assert.That(actualAnswear, Is.EqualTo(expectedAnswear),message: $"Det fungerade inte {actualAnswear} ger inte {expectedAnswear}");
        }

        /// <summary>
        /// Test konvertera Tempraturen från Celsius till Kelvin
        /// </summary>
        [Test]
        public void Test_From_Celsius_To_Kelvin()
        {
            //Arrange
            double celsiustest = 5;
            double expectedAnswear = 278.15;

            //Act
            double actualAnswear = celsius.ToKelvin(celsiustest);

            //Assert
            Assert.That(actualAnswear, Is.EqualTo(expectedAnswear), message: $"Det fungerade inte {actualAnswear} ger inte {expectedAnswear}");
        }
    }
}
