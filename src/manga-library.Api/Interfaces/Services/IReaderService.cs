using System.Threading.Tasks;
using manga_library.Api.Models;

namespace manga_library.Api.Interfaces.Services
{
    public interface IReaderService
    {
        Readers CreateReader(string name);
    }
}