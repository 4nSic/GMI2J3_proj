using Enhetskonvertering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestEnhetskonvertering
{
    public class TestOhm
    {

        private Ohmslaw ohmslaw;

        [OneTimeSetUp]
        public void Setup()
        {
            ohmslaw = new Ohmslaw();
        }

        [TestCase(1000, 1000, 1000000)]
        [TestCase(100, 8, 800)]
        [TestCase(500, -50, -25000)]
        public void Test_To_Voltage_with_Ohmslaw(double current, double resistance, double expectedAnswear)
        {
            //Act
            double actualAnswear = ohmslaw.Voltage(current, resistance);

            //Assert
            Assert.That(actualAnswear, Is.EqualTo(expectedAnswear).Within(0.001), message: $"Det fungerade inte {actualAnswear} ger inte {expectedAnswear}");
        }

        [TestCase(1000, 1000, 1)]
        [TestCase(100, 8, 12.5)]
        [TestCase(500, -50, -10)]
        public void Test_To_Current_with_Ohmslaw(double current, double resistance, double expectedAnswear)
        {
            //Act
            double actualAnswear = ohmslaw.Current(current, resistance);

            //Assert
            Assert.That(actualAnswear, Is.EqualTo(expectedAnswear).Within(0.001), message: $"Det fungerade inte {actualAnswear} ger inte {expectedAnswear}");
        }

        [TestCase(200, 0)]
        public void Test_To_Current_With_Zero_Input(double voltage, double resistance)
        {
            // Act & Assert
            Assert.Throws<DivideByZeroException>(() => ohmslaw.Current(voltage, resistance), message: $"Det fungerade inte {voltage} ger inte {resistance}");
            
        }


    }
}
