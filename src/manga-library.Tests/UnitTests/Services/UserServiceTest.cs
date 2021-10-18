using System.Threading.Tasks;
using Xunit;
using Moq;
using FluentAssertions;
using manga_library.Api.DTO;
using manga_library.Api.Interfaces.Repositories;
using manga_library.Api.Interfaces.Services;
using manga_library.Api.Models;
using manga_library.Api.Services;

namespace manga_library.Tests.UnitTests.Services
{
    public class UserServiceTest
    {
        private readonly IReaderService _readerService;

        public UserServiceTest()
        {
            var mock = new Mock<IReaderRepository>();
            mock.Setup(repo => repo.AddAsync(It.IsAny<Readers>()).Result)
                .Returns<Readers>((entity) => (entity));
            _readerService = new ReaderService(mock.Object);
        }
        
        [Fact]
        public async Task ShouldCreateANewReader()
        {
            var readerToCreate = new CreateReaderDTO()
            {
                Name = "Leo",
                Email = "leonardo123k@gmail.com",
                Password = "123456"
            };

            var createdReader = await _readerService.CreateReader(readerToCreate); 

            createdReader.Name.Should().Be("Leo");
        }
    }
}