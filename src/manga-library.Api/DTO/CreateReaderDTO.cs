using System.ComponentModel.DataAnnotations;

namespace manga_library.Api.DTO
{
    public class CreateReaderDTO
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }
}