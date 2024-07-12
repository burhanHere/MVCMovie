using Microsoft.CodeAnalysis.Options;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using MVCMovie.Models;

namespace MVCMovie.Data
{
    public class MVCMovieDbContext(DbContextOptions<MVCMovieDbContext> options) : DbContext(options)
    {
        public DbSet<Movie> Movies { get; set; }
    }
}