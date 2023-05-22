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
        [SetUp]
        public void Setup3()
        {
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
            double expectedAnswer = basen * djup * height;

            //Act
            double actualAnswear = Volume.Kub(basen, djup, height);

            //Assert
            Assert.That(actualAnswear, Is.EqualTo(expectedAnswer));
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
            double expectedAnswer = basen * djup * height / area;

            //Act
            double actualAnswear = Volume.Pyramid(basen, djup, height);

            //Assert
            Assert.That(actualAnswear, Is.EqualTo(expectedAnswer));
        }

        /// <summary>
        /// Test Sphere
        /// </summary>
        [Test]
        public void Test_Volume_Sphere()
        {
            //Arrange
            double radius = 10;
            double area = 3;
            double expectedAnswer = Math.Pow(radius, area) * 4 * Math.PI / area;

            //Act
            double actualAnswear = Volume.Sphere(radius);

            //Assert
            Assert.That(actualAnswear, Is.EqualTo(expectedAnswer));
        }

    }
}