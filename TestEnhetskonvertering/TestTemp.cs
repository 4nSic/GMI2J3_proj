using Enhetskonvertering;

namespace TestEnhetskonvertering
{
    public class TestTemp
    {
        private Celsius celsius;
        private Farenheit farenheit;
        private Kelvin kelvin;


        [OneTimeSetUp]
        public void Setup()
        {
            celsius = new Celsius();
            farenheit = new Farenheit();
            kelvin = new Kelvin();
        }

        /// <summary>
        /// Test konvertera Tempraturen från Celsius till Fahrenheit
        /// </summary>
        [TestCase(0, 32)]
        [TestCase(100, 212)]
        [TestCase(-100, -148)]
        public void Test_From_Celsius_To_Fahrenhiet(int testValue,int expectedAnswear)
        {
            //Act
            double actualAnswear = celsius.ToFarenheit(testValue);

            //Assert
            Assert.That(actualAnswear, Is.EqualTo(expectedAnswear),message: $"Det fungerade inte {actualAnswear} ger inte {expectedAnswear}");
        }

        /// <summary>
        /// Test konvertera Tempraturen från Celsius till Kelvin
        /// </summary>
        [TestCase(0, 273.15)]
        [TestCase(100, 373.15)]
        [TestCase(-100, 173.15)]
        public void Test_From_Celsius_To_Kelvin(int testValue, double expectedAnswear)
        {
            //Arrange
            //double testValue = 5;
            //double expectedAnswear = 278.15;

            //Act
            double actualAnswear = celsius.ToKelvin(testValue);

            //Assert
            Assert.That(actualAnswear, Is.EqualTo(expectedAnswear).Within(0.01), message: $"Det fungerade inte {actualAnswear} ger inte {expectedAnswear}");
        }

   
            //Arrange
        [TestCase(0, 255.372)]
        [TestCase(100, 310.928)]
        [TestCase(-100, 199.817)]
        public void Test_From_Farenheit_To_Kelvin(int testValue, double expectedAnswear)
        {
            //Act
            double actualAnswear = farenheit.ToKelvin(testValue);

            //Assert
            Assert.That(actualAnswear, Is.EqualTo(expectedAnswear).Within(0.01), message: $"Det fungerade inte {actualAnswear} ger inte {expectedAnswear}");
        }

            //Arrange
        [TestCase(0, -17.7778)]
        [TestCase(100, 37.7778)]
        [TestCase(-100, -73.3333)]
        public void Test_From_Farenheit_To_Celsius(int testValue, double expectedAnswear)
        {


            //Act
            double actualAnswear = farenheit.ToCelsius(testValue);

            //Assert
            Assert.That(actualAnswear, Is.EqualTo(expectedAnswear).Within(0.01), message: $"Det fungerade inte {actualAnswear} ger inte {expectedAnswear}");
        }

        //Arrange
        [TestCase(0, -273.15)]
        [TestCase(100, -173.15)]
        [TestCase(-100, -373.15)]
        public void Test_From_Kelvin_To_Celsius(int testValue, double expectedAnswear)
        {

            //Act
            double actualAnswear = kelvin.ToCelsius(testValue);

            //Assert
            Assert.That(actualAnswear, Is.EqualTo(expectedAnswear).Within(0.01), message: $"Det fungerade inte {actualAnswear} ger inte {expectedAnswear}");
        }

        //Arrange
        [TestCase(0, -459.67)]
        [TestCase(100, -279.67)]
        [TestCase(-100, -639.67)]
        public void Test_From_Kelvin_To_Farenheit(int testValue, double expectedAnswear)
        {

            //Act
            double actualAnswear = kelvin.ToFarenheit(testValue);

            //Assert
            Assert.That(actualAnswear, Is.EqualTo(expectedAnswear).Within(0.01), message: $"Det fungerade inte {actualAnswear} ger inte {expectedAnswear}");
        }
    }
}
