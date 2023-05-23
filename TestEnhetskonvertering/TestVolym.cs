using Enhetskonvertering;
using System;
using System.Buffers.Text;
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
            //Arrange
        [TestCase (30, 30, 30, 27000)]
        public void Test_Volume_Kub_Positive_Inputs(double basen, double djup, double height, double expectedAnswer)
        {
            //Act
            double actualAnswear = volume.Kub(basen, djup, height);

            //Assert
            Assert.That(actualAnswear, Is.EqualTo(expectedAnswer).Within(0.001));
        }

        [TestCase(-30, -30, -30)]
        public void Test_Volume_Kub_Negative_Inputs(double basen, double djup, double height)
        {
            //Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => volume.Kub(basen, djup, height));
        }

        /// <summary>
        /// Test Pyramid
        /// </summary>
            //Arrange
        [TestCase (10, 20, 30, 2000)]
        public void Test_Volume_Pyramid_Positiv_Inputs(double basen, double djup, double height, double expectedAnswer)
        {

            //Act
            double actualAnswear = volume.Pyramid(basen, djup, height);

            //Assert
            Assert.That(actualAnswear, Is.EqualTo(expectedAnswer).Within(0.001));
        }

        // Arrange
        [TestCase(-10, -20, -30)]
        public void Test_Volume_Pyramid_Negative_Inputs(double basen, double djup, double height)
        {
            //Act  &  Assert 
            Assert.Throws<ArgumentOutOfRangeException>(() => volume.Pyramid(basen, djup, height));
        }

        /// <summary>
        /// Test Sphere
        /// </summary>
            //Arrange
        [TestCase(25, 65449.85)]
        public void Test_Volume_Sphere_Positive_Inputs(double radius, double expectedAnswer)
        {
            //Act
            double actualAnswear = volume.Sphere(radius);

            //Assert
            Assert.That(actualAnswear, Is.EqualTo(expectedAnswer).Within(0.01));
        }

            // Arrange  &    Act
        [TestCase(-25)]
        public void Test_Volume_Sphere_Negative_Inputs(double radius)
        {

            //Act  &  Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => volume.Sphere(radius));
        }

    }
}