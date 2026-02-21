using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Praktikum02.MovieApp.Models;

namespace Praktikum02.MovieApp.Data;

public class MovieContext : DbContext
{
    public MovieContext(DbContextOptions<MovieContext> options)
        : base(options)
    {
    }

    public DbSet<Movie> Movies => Set<Movie>();
}
