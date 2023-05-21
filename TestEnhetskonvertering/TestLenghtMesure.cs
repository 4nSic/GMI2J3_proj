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
        //string messegeInABottle = "$\"Det fungerade inte {actualAnswear} {expectetAnswear}\"";
        
        [OneTimeSetUp]
        
        public void Setup2()
        {

        }

        /// <summary>
        ///  konvertera längdvärden från meter till centimeter, tum, yard och fot."
        /// </summary>
        [Test]
        public void Test_Konverter_From_Meter_To_Cm()
        {
            //Arrange
            double meter = 5;
            double expectetAnswear = meter * Meter.CM;
            //double expectetAnswear = 500;

            //Act
            double actualAnswear = Meter.ToCm(meter);

            //Assert
            Assert.That(actualAnswear, Is.EqualTo(expectetAnswear), message: $"Det fungerade inte {actualAnswear} ger inte {expectetAnswear}");

        }

        /// <summary>
        /// konvertera längdvärden från meter till inch."
        /// </summary>
        [Test]
        public void Test_Konverter_From_Meter_To_Inch()
        {

            //Arrange
            double meter = 5;
            double expectetAnswear = meter / Meter.INCH;
            //double expectetAnswear = 196.8505;

            //Act
            double actualAnswear = Meter.ToInch(meter);

            //Assert
            Assert.That(actualAnswear, Is.EqualTo(expectetAnswear), message: $"Det fungerade inte {actualAnswear} ger inte {expectetAnswear}");

        }


        /// <summary>
        /// konvertera längdvärden från meter till Yard."
        /// </summary>
        [Test]
        public void Test_Konverter_From_Meter_To_Yard()
        {

            //Arrange
            double meter = 5;
            double expectetAnswear = meter * Meter.YARD;

            //Act
            double actualAnswear = Meter.ToYard(meter);
            
            //------------- Just for fun ----------------------------  
            double roundeExpectetAnswer = Math.Round(expectetAnswear, 2);
            double roundedActualAnswer = Math.Round(actualAnswear, 2);
            //-------------------------------------------------------


            //Act
            Assert.That(roundedActualAnswer, Is.EqualTo(roundeExpectetAnswer),message:$"Det fungerade inte {actualAnswear} ger inte {expectetAnswear}");
        }

        public void Test_Konverter_From_Meter_To_Foot() 
        { 
        
            //Arrange
            double meter = 5;
            double expectetAnswear = meter * Meter.FOOT;

            //Assert
            double actualAnswear = Meter.ToFoot(meter);

            //Act
            Assert.That(actualAnswear, Is.EqualTo(expectetAnswear), message: $"Det fungerade inte {actualAnswear} ger inte {expectetAnswear}");

        }

    }
}