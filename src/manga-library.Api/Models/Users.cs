using System;
using System.Collections.Generic;

namespace manga_library.Api.Models
{
    public class Users
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public List<Mangas> Favorites { get; set; }
    }
}