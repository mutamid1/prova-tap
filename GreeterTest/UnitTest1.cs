namespace GreeterTest;
using Moq;
using IClock;
using Greeter;
public class UnitTest1
{
    [Fact]
    public void GetMessage_ShouldSayBuonAnno_OnFirstOfJan() {
    var mockClock = new Mock<IClock>();// creo il mio STUB/ fake input
    mockClock.Setup(c => c.Now()).Returns(new DateTime(2026, 1, 1));// definisco il comportamento/ valore fisso
    var greeter = new Greeter(mockClock.Object);// creo greeter passando lo STUB
    string message = greeter.GetMessage();
    Assert.Equal("Buon Anno!", message);  // verifico l'output del metodo GetMessage
    // mockClock.Verify(c => c.Now(), Times.Once()); // aggiungendo verifica del comportamento diventa anche MOCK
    }
}
