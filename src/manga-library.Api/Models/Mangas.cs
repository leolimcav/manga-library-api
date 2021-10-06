using System;

namespace manga_library.Api.Models
{
    public class Mangas
    {
        public int Id { get; set; }
        public int Title { get; set; }
        public int Chapters { get; set; }
        public string Author { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}