using Moq;
using Registration.DomainBase.Entities.Registrations;
using Registration.DomainCore.ContextAbstraction;
using Registration.Handlers.Handlers.Registrations;
using Serilog;

namespace HandlersTest;

public class UnitTest1
{
    //GiveWhenThen

    //AAA
    //Arrange
    //Act
    //Assert

    [Fact]
    public void ShoudCreateNewUser()
    {
        var loger = new Mock<ILogger>();
        var repository = new Mock<IChurchRepository>();

        repository.Setup(x => x.Post(It.IsAny<Church>()));

        //var handler = new ChurchHandler(repository.Object, loger.Object);

        Assert.Equal(1, 1);
    }
}