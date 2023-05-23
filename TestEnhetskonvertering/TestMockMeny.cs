using Enhetskonvertering;
using Moq;



namespace TestEnhetskonvertering
{
    public class TestMockMeny
    {
        [SetUp]
        public void Setup()
        {
        }

        /// <summary>
        /// Mockar Speed med nya in parameterar
        /// </summary>
        [Test]
        public void Test_Mock_Meny()
        {
            //Arrange     
            //string mockString = "HejSvejs";
            int mockMenyChoice = 7;
            //int mockResult;
            //bool expected = true;
            // var displayHandler = new ConsoleDisplayer();
            var mockDisplayHandler = new Mock<IDisplayHandler>();
            mockDisplayHandler.Setup(_Placeholder => _Placeholder.ClearedDisplay());
            mockDisplayHandler.Setup(_Placeholder => _Placeholder.ShowMessege("test"));
            mockDisplayHandler.Setup(_Placeholder => _Placeholder.ShowLine("test1"));


            //Act
            var mockInputHandler = new Mock<IInputHandler>();
            mockInputHandler.Setup(_Placeholder => _Placeholder.ReadInput(out mockMenyChoice))
                  .Returns(true);
            
            var testConverter = new Konverter(mockDisplayHandler.Object, mockInputHandler.Object);



            Meny testMeny = new Meny(mockDisplayHandler.Object, mockInputHandler.Object, testConverter);
            testMeny.MainMeny();


            //Assert
            //bool actualAnswer = mockInputHandler.Object.ReadInput(out mockResult);
            //Assert.That(actualAnswer, Is.EqualTo(expected));
        }

    }
}