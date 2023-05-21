using Enhetskonvertering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestEnhetskonvertering
{
    public class TestTemp
    {
        [SetUp]
        public void Setup3()
        {
        }

        /// <summary>
        /// Test konvertera Tempraturen från Celsius till Fahrenheit
        /// </summary>
        [Test]
        public void Test_From_Celsius_To_Fahrenhiet()
        {

            //Arrange
            double celsius = 5;
            double expectedAnswear = (celsius * 9 / 5) + 32;

            //Act
            double actualAnswear = Celsius.ToFarenheit(celsius);

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
            double celsius = 5;
            double expectedAnswear = celsius + 273.15;

            //Act
            double actualAnswear = Celsius.ToKelvin(celsius);

            //Assert
            Assert.That(actualAnswear, Is.EqualTo(expectedAnswear), message: $"Det fungerade inte {actualAnswear} ger inte {expectedAnswear}");
        }
    }
}
