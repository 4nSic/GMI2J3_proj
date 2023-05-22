using Enhetskonvertering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestEnhetskonvertering
{
    public class TestVolym
    {
        private Volume volume;
        [OneTimeSetUp]
        public void Setup()
        {
            volume = new Volume();
        }

        /// <summary>
        /// Test Kub
        /// </summary>
        [Test]
        public void Test_Volume_Kub()
        {
            //Arrange
            double basen = 10;
            double djup = 10;
            double height = 10;
            double expectedAnswer = 1000;

            //Act
            double actualAnswear = volume.Kub(basen, djup, height);

            //Assert
            Assert.That(actualAnswear, Is.EqualTo(expectedAnswer).Within(0.001));
        }

        /// <summary>
        /// Test Pyramid
        /// </summary>
        [Test]
        public void Test_Volume_Pyramid()
        {
            //Arrange
            double basen = 10;
            double djup = 10;
            double height = 10;
            double area = 3;
            double expectedAnswer = 333.333333333;

            //Act
            double actualAnswear = volume.Pyramid(basen, djup, height);

            //Assert
            Assert.That(actualAnswear, Is.EqualTo(expectedAnswer).Within(0.001));
        }

        /// <summary>
        /// Test Sphere
        /// </summary>
        [Test]
        public void Test_Volume_Sphere()
        {
            //Arrange
            double radius = 10;
            double expectedAnswer = 4188.79;

            //Act
            double actualAnswear = volume.Sphere(radius);

            //Assert
            Assert.That(actualAnswear, Is.EqualTo(expectedAnswer).Within(0.001));
        }

    }
}