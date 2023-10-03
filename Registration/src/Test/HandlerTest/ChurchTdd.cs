using HandlersTest.Builders.Dto;
using HandlersTest.Builders.Entities;
using HandlersTest.Builders.Mappers;
using Moq;
using Registration.DomainCore.ContextAbstraction;
using Registration.Handlers.Handlers.Registrations;
using Registration.Handlers.ViewModel;
using Serilog;

namespace HandlersTest
{
    public class ChurchTdd : HandlerTest
    {
        //GiveWhenThen  || //AAA = //Arrange //Act //Assert

        private Mock<IChurchRepository> repository = null!;

        public ChurchTdd()
        {
            viewModel = new ResultViewModel();
            logger = new Mock<ILogger>();
            mapper = ChurchMapperTest.Mapper();

            GetAbstractionContext();
        }

        private void GetAbstractionContext()
        {
            repository = new Mock<IChurchRepository>();
            repository.Setup(x => x.Post(ChurchTest.ValidObjectOne()));
            repository.Setup(x => x.GetOneNoTracking(It.IsAny<int>()))
                .Returns(Task.FromResult(ChurchTest.ValidObjectOne()));

            repository.Setup(x => x.Put(ChurchTest.ValidObjectTwo()));
            repository.Setup(x => x.GetOne(ChurchTest.ValidObjectOne().Id))
                .Returns(Task.FromResult(ChurchTest.ValidObjectOne()));
        }

        [Fact(DisplayName = "Create new church-Success")]
        public async Task ShouldCreateNewChurchWithValidData()
        {
            var churchAddress = ChurchAddressDtoTest.ValidObjectOne();

            var handler = new ChurchHandler(repository.Object, mapper!, viewModel, logger.Object);
            var result = await handler.Create(churchAddress);
            
            dynamic data = result.Data!;
            var erro = result.Errors;

            Assert.NotNull(data);
            Assert.True(erro!.Count == 0);
            Assert.Equal(data.Name, ChurchTest.ValidObjectOne().Name);
        }

        [Fact(DisplayName = "Update a church-Success")]
        public async Task ShouldUpdateChurchWithValidData()
        {
            var churchAddress = ChurchAddressDtoTest.ValidObjectTwo();

            var handler = new ChurchHandler(repository.Object, mapper!, viewModel, logger.Object);
             var result = await handler.Update(churchAddress, ChurchTest.ValidObjectOne().Id);
            //result.Wait();

            dynamic data = result.Data!;
            var erro = result.Errors;

            Assert.NotNull(data);
            Assert.True(erro!.Count == 0);
            Assert.Equal(data.Name, ChurchTest.ValidObjectTwo().Name);
        }


        [Fact(DisplayName = "Create a church-Fail")]
        public async Task ShouldReturnErroWhenCreateChurchWithInvalidData()
        {
            var churchAddress = ChurchAddressDtoTest.InValidObjectOne();

            var handler = new ChurchHandler(repository.Object, mapper!, viewModel, logger.Object);
             var result = await handler.Create(churchAddress);
            //result.Wait();

            dynamic data = result.Data!;
            var erro = result.Errors;

            Assert.Null(data);
            Assert.True(erro!.Count >= 1);
        }

        [Fact(DisplayName = "Update a church-Fail")]
        public async Task ShouldReturnErroWhenUpdateChurchWithInvalidData()
        {
            var churchAddress = ChurchAddressDtoTest.InValidObjectTwo();

            var handler = new ChurchHandler(repository.Object, mapper!, viewModel, logger.Object);
             var result = await handler.Update(churchAddress, ChurchAddressDtoTest.ValidObjectOne().Id);
            //result.Wait();

            dynamic data = result.Data!;
            var erro = result.Errors;

            Assert.Null(data);
            Assert.True(erro!.Count >= 1);
        }
    }
}