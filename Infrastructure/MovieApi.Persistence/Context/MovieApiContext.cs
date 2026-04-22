using Microsoft.EntityFrameworkCore;
using MovieApi.Domain.Entities;

namespace MovieApi.Persistence.Context;

public class MovieApiContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=localhost;Initial Catalog=MovieApi;User Id=sa;Password=P@ssw0rd2025!;TrustServerCertificate=True;");
    }

    public DbSet<Category> Categories { get; set; }
    public DbSet<Movie> Movies { get; set; }
    public DbSet<Review> Reviews { get; set; }
    public DbSet<Tag> Tags { get; set; }
    public DbSet<Cast> Casts { get; set; }
}