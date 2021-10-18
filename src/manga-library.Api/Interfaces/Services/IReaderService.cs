using System.Threading.Tasks;
using manga_library.Api.DTO;
using manga_library.Api.Models;
using manga_library.Api.ViewModels;

namespace manga_library.Api.Interfaces.Services
{
    public interface IReaderService
    {
        Task<CreatedReaderViewModel> CreateReader(CreateReaderDTO createReaderDto);
    }
}