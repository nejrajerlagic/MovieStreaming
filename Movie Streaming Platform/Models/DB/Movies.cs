using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Movie_Streaming_Platform.Models.DB
{
    public partial class Movies
    {
        [Key]
        public int MovieId { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public string ReleaseDate { get; set; }
        public decimal UnitPrice { get; set; }
        public string MemoryLocation { get; set; }
        public string PhotoMemoryLocation { get; set; }
    }
}
