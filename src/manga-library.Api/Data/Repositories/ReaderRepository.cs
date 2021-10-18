using manga_library.Api.Interfaces.Repositories;
using manga_library.Api.Models;

namespace manga_library.Api.Data.Repositories
{
    public class ReaderRepository : Repository<Readers>, IReaderRepository
    {
        public ReaderRepository(AppDbContext context) : base(context)
        {
        }
    }
}