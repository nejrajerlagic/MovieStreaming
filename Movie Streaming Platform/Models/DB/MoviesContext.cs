using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Movie_Streaming_Platform.Models.DB
{
    public partial class MoviesContext : DbContext
    {
        public MoviesContext()
        {
        }

        public MoviesContext(DbContextOptions<MoviesContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Movies> Movies { get; set; }

        // NOTE: This is here to protect editing of data, not necceseary in our case but good to have for a later date.
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Movies>(entity =>
        //    {
        //        entity.HasKey(e => e.MovieId)
        //            .HasName("PK__Movies__4BD2943AA3C81201");

        //        entity.Property(e => e.MovieId).HasColumnName("MovieID");

        //        entity.Property(e => e.Category)
        //            .HasMaxLength(100)
        //            .IsUnicode(false);

        //        entity.Property(e => e.Name)
        //            .IsRequired()
        //            .HasMaxLength(100)
        //            .IsUnicode(false);

        //        entity.Property(e => e.ReleaseDate)
        //            .HasMaxLength(20)
        //            .IsUnicode(false);

        //        entity.Property(e => e.UnitPrice).HasColumnType("decimal(18, 0)");
        //    });

        //    OnModelCreatingPartial(modelBuilder);
        //}

        //partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
