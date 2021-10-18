using System;
using System.Threading.Tasks;
using manga_library.Api.DTO;
using manga_library.Api.Interfaces.Repositories;
using manga_library.Api.Interfaces.Services;
using manga_library.Api.Models;
using manga_library.Api.ViewModels;

namespace manga_library.Api.Services
{
    public class ReaderService : IReaderService
    {
        private readonly IReaderRepository _readerRepository;
        public ReaderService(IReaderRepository readerRepository)
        {
            _readerRepository = readerRepository;
        }
        
        public async Task<CreatedReaderViewModel> CreateReader(CreateReaderDTO createReaderDto)
        {
            var createdReader = await _readerRepository.AddAsync(new Readers()
            {
                Name = createReaderDto.Name,
                Email = createReaderDto.Email,
                Password = BCrypt.Net.BCrypt.HashPassword(createReaderDto.Password),
                Avatar = "",
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow 
            });
            
            return new CreatedReaderViewModel()
            {
                Id = createdReader.Id,
                Name = createdReader.Name,
                Email = createdReader.Email,
                Avatar = createdReader.Avatar,
                CreatedAt = createdReader.CreatedAt,
                UpdatedAt = createdReader.UpdatedAt
            };
        }
    }
}