using Movie_Streaming_Platform.Models.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movie_Streaming_Platform.ViewModels
{
    public class MoviePageViewModel
    {
        public string Genre { get; set; }
        public List<Movies> Movies { get; set; }
    }
}
