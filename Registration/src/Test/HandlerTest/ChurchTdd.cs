using AutoMapper;
using HandlersTest.Builders.Dto;
using HandlersTest.Builders.Entities;
using HandlersTest.Builders.Mappers;
using Moq;
using Registration.DomainBase.Entities.Registrations;
using Registration.DomainCore.ContextAbstraction;
using Registration.DomainCore.ViewModelAbstraction;
using Registration.Handlers.Handlers.Registrations;
using Registration.Handlers.ViewModel;
using Registration.Mapper.DTOs.Registration.ChurchAddress;
using Serilog;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace HandlersTest
{
    public class ChurchTdd : HandTest
    {
        //GiveWhenThen  || //AAA = //Arrange //Act //Assert

        private readonly IMapper mapper = ChurchMapperTest.Mapper();

        public ChurchTdd()
        {
            viewModel = new ResultViewModel();
            logger = new Mock<ILogger>();
        }

        private IChurchRepository GetAbstractionContextChurch()
        {
            var repository = new Mock<IChurchRepository>();
            repository.Setup(x => x.Post(ChurchTest.ValidObjectOne()));
            repository.Setup(x => x.GetOneNoTracking(0))
                .Returns(Task.FromResult(ChurchTest.ValidObjectOne()));

            repository.Setup(x => x.Put(ChurchTest.ValidObjectTwo()));
            repository.Setup(x => x.GetOne(ChurchTest.ValidObjectOne().Id))
                .Returns(Task.FromResult(ChurchTest.ValidObjectOne()));

            return repository.Object;   
        }

        [Fact(DisplayName = "Create new church-Success")]
        public void ShouldCreateNewChurchWithValidData()
        {
            var churchAddress = ChurchAddressTest.ValidObjectOne();

            var repository = GetAbstractionContextChurch();

            var handler = new ChurchHandler(repository, mapper, viewModel, logger.Object);
            var result = handler.Create(churchAddress);
            result.Wait();

            dynamic data = result.Result.Data!;
            var erro = result.Result.Errors;

            Assert.NotNull(data);
            Assert.True(erro!.Count == 0);
            Assert.Equal(data.Name, ChurchTest.ValidObjectOne().Name);
        }

        [Fact(DisplayName = "Update a church-Success")]
        public void ShouldUpdateChurchWithValidData()
        {
            var churchAddress = ChurchAddressTest.ValidObjectTwo();

            var repository = GetAbstractionContextChurch();

            var handler = new ChurchHandler(repository, mapper, viewModel, logger.Object);
            var result = handler.Update(churchAddress, ChurchTest.ValidObjectOne().Id);
            result.Wait();

            dynamic data = result.Result.Data!;
            var erro = result.Result.Errors;

            Assert.NotNull(data);
            Assert.True(erro!.Count == 0);
            Assert.Equal(data.Name, ChurchTest.ValidObjectTwo().Name);
        }


        [Fact(DisplayName = "Create a church-Fail")]
        public void ShouldReturnErroWhenCreateChurchWithInvalidData()
        {
            var churchAddress = ChurchAddressTest.InValidObjectOne();

            var repository = GetAbstractionContextChurch();

            var handler = new ChurchHandler(repository, mapper, viewModel, logger.Object);
            var result = handler.Create(churchAddress);
            result.Wait();

            dynamic data = result.Result.Data!;
            var erro = result.Result.Errors;

            Assert.Null(data);
            Assert.True(erro!.Count >= 1);
        }

        [Fact(DisplayName = "Update a church-Fail")]
        public void ShouldReturnErroWhenUpdateChurchWithInvalidData()
        {
            var churchAddress = ChurchAddressTest.InValidObjectTwo();

            var repository = GetAbstractionContextChurch();

            var handler = new ChurchHandler(repository, mapper, viewModel, logger.Object);
            var result = handler.Update(churchAddress, ChurchAddressTest.ValidObjectOne().Id);
            result.Wait();

            dynamic data = result.Result.Data!;
            var erro = result.Result.Errors;

            Assert.Null(data);
            Assert.True(erro!.Count >= 1);
        }
    }
}