using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Movie_Streaming_Platform.Models.DB;

using System;
using System.Linq;

namespace MvcMovie.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MoviesContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MoviesContext>>()))
            {
                // Look for any movies.
                if (context.Movies.Any())
                {
                    return;   // DB has been seeded
                }

                context.Movies.AddRange(
                    new Movies
                    {

                        Name = "When Harry Met Sally",
                        ReleaseDate = Convert.ToString(DateTime.Parse("1989-2-12")),
                        Category = "Romantic Comedy",
                        UnitPrice = 7.99M,
                        MemoryLocation = "sample-mp4-file-small.mp4",
                        PhotoMemoryLocation = "/Images/96_Hours.jpeg"
                    },

                    new Movies
                    {

                        Name = "Ghostbusters ",
                        ReleaseDate = Convert.ToString(DateTime.Parse("1984-3-13")),
                        Category = "Comedy",
                        UnitPrice = 8.99M,
                        MemoryLocation = "sample-mp4-file-small - Copy.mp4",
                        PhotoMemoryLocation = "/Images/ghostbusters.jpg"
                    },

                    new Movies
                    {

                        Name = "Ghostbusters 2",
                        ReleaseDate = Convert.ToString(DateTime.Parse("1986-2-23")),
                        Category = "Comedy",
                        UnitPrice = 9.99M,
                        MemoryLocation = "sample-mp4-file-small - Copy (2).mp4",
                        PhotoMemoryLocation = "/Images/ghostbusters2.jpg"
                    },

                    new Movies
                    {

                        Name = "Rio Bravo",
                        ReleaseDate = Convert.ToString(DateTime.Parse("1959-4-15")),
                        Category = "Western",
                        UnitPrice = 3.99M,
                        MemoryLocation = "sample-mp4-file-small - Copy (3).mp4",
                        PhotoMemoryLocation = "/Images/rio_bravo.jpg"
                    }
                ) ;
                context.SaveChanges();
            }
        }
    }
}