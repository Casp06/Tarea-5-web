using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Videojuego> Videojuegos { get; set; }
    public DbSet<Personaje> Personajes { get; set; }
    public DbSet<Plataforma> Plataformas { get; set; }
}

