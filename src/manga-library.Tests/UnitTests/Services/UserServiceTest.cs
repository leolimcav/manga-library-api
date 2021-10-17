using Xunit;
using FluentAssertions;
using manga_library.Api.Interfaces.Services;
using manga_library.Api.Services;

namespace manga_library.Tests.UnitTests.Services
{
    public class UserServiceTest
    {
        private readonly IReaderService _readerService;

        public UserServiceTest()
        {
            this._readerService = new ReaderService();
        }
        [Fact]
        public void ShouldCreateUser()
        {
            var newReader = _readerService.CreateReader("Leo");

            newReader.Name.Should().Be("Leo");
        }
    }
}