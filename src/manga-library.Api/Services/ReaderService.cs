using System.Threading.Tasks;
using manga_library.Api.Interfaces.Services;
using manga_library.Api.Models;

namespace manga_library.Api.Services
{
    public class ReaderService : IReaderService
    {
        public Readers CreateReader(string name)
        {
            return new Readers()
            {
                Name = name
            };
        }
    }
}