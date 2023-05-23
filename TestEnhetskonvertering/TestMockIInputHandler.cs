using Enhetskonvertering;
using Moq;



namespace TestEnhetskonvertering
{
    public class TestMockIInputHandler
    {
        [SetUp]
        public void Setup()
        {
        }

        /// <summary>
        /// Mockar Speed med nya in parameterar
        /// </summary>
        [Test]
        public void Test_Mock_IInputHandler()
        {
            //Arrange
     
            string mockString = "HejSvejs";
            int hej;
            int mockResult;
            bool expected = true;



            //Act
            var mockHandler = new Mock<IInputHandler>();
            mockHandler.Setup(_Placeholder => _Placeholder.ReadInput(out hej))
                  .Returns(true);

            //Assert
            bool actualAnswer = mockHandler.Object.ReadInput(out mockResult);
            Assert.That(actualAnswer, Is.EqualTo(expected));
        }
    }
}