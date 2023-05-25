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
            int mockMenyChoice = 1;
            //int mockResult;
            //bool expected = true;
            // var displayHandler = new ConsoleDisplayer();
            var mockDisplayHandler = new Mock<IDisplayHandler>();
            mockDisplayHandler.Setup(_Placeholder => _Placeholder.ClearedDisplay());
            mockDisplayHandler.Setup(_Placeholder => _Placeholder.ShowMessege(It.IsAny<string>())).Callback((string mess) => 
            {
                if (mess != "Meny\n1)  Temperatur konvertering\n2)  Längd uträkning\n3)  Beräkna hastighet\n" +
                          "4)  Area\n5)  Volym\n6)  Ohms lag\n7)  Exit\n")
                {
                    Assert.That(mess, Is.EqualTo("Tempratur meny\n1) Celsius\n2) Fahrenheit\n3) Kelvin\n4) Till huvudmenyn"));
                    throw new Exception();
                }


            } );
            mockDisplayHandler.Setup(_Placeholder => _Placeholder.ShowLine(It.IsAny<string>()));


            //Act
            var mockInputHandler = new Mock<IInputHandler>();
            mockInputHandler.Setup(_Placeholder => _Placeholder.ReadInput(out mockMenyChoice)).Returns(true);
            
            var testConverter = new Konverter(mockDisplayHandler.Object, mockInputHandler.Object);



            Meny testMeny = new Meny(mockDisplayHandler.Object, mockInputHandler.Object, testConverter);
            try
            {
                testMeny.MainMeny();
            }
            catch (Exception)
            {

            }
            

            //Assert
            //bool actualAnswer = mockInputHandler.Object.ReadInput(out mockResult);
            //Assert.That(actualAnswer, Is.EqualTo(expected));
        }

    }
}