using System;
using System.Collections.Generic;

namespace manga_library.Api.Models
{
    public class Scans
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Note { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdateAt { get; set; }
        public List<Projects> Projects { get; set; }
    }
}