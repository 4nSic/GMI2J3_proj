using Enhetskonvertering;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Meter = Enhetskonvertering.Meter;

namespace TestEnhetskonvertering
{ 
    /// <summary>
    /// Testar alla users stories bunda till Längd
    /// </summary>
    public class TestLenghtMesure
    {
        private Meter meter;
        [OneTimeSetUp]
        public void Setup()
        {
            meter = new Meter();
        }

        /// <summary>
        ///  konvertera längdvärden från meter till centimeter, tum, yard och fot."
        /// </summary>
        [Test]
        public void Test_Konverter_From_Meter_To_Cm()
        {
            //Arrange
            double testMeter = 5;
            double expectedAnswer = 500;

            //Act
            double actualAnswear = meter.ToCm(testMeter);

            //Assert
            Assert.That(actualAnswear, Is.EqualTo(expectedAnswer).Within(0.01), message: $"Det fungerade inte {actualAnswear} ger inte {expectedAnswer}");
        }

        /// <summary>
        /// konvertera längdvärden från meter till inch."
        /// </summary>
        [Test]
        public void Test_Konverter_From_Meter_To_Inch()
        {

            //Arrange
            double testmeter = 5;
            double expectedAnswear = 196.8505;

            //Act
            double actualAnswear = meter.ToInch(testmeter);

            //Assert
            Assert.That(actualAnswear, Is.EqualTo(expectedAnswear).Within(0.01), message: $"Det fungerade inte {actualAnswear} ger inte {expectedAnswear}");
        }


        /// <summary>
        /// konvertera längdvärden från meter till Yard.
        /// </summary>
        [Test]
        public void Test_Konverter_From_Meter_To_Yard()
        {
            //Arrange
            double testmeter = 5;
            double expectedAnswear = 5.46807;

            //Act
            double actualAnswear = meter.ToYard(testmeter);
       
            //Act
            Assert.That(actualAnswear, Is.EqualTo(expectedAnswear).Within(0.01), message: $"Det fungerade inte {actualAnswear} ger inte {expectedAnswear}");

        }

        /// <summary>
        /// konvertera längdvärden från meter till foot.
        /// </summary>
        [Test]
        public void Test_Konverter_From_Meter_To_Foot() 
        { 
        
            //Arrange
            double testmeter = 5;
            double expectedAnswear = 16.4042;

            //Assert
            double actualAnswear = meter.ToFoot(testmeter);

            //Act
            Assert.That(actualAnswear, Is.EqualTo(expectedAnswear).Within(0.01), message: $"Det fungerade inte {actualAnswear} ger inte {expectedAnswear}");
        }
    }
}