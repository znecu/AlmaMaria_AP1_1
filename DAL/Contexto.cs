using Microsoft.EntityFrameworkCore;
using AlmaMaria_AP1_1.Models;
namespace AlmaMaria_AP1_1.DAL;

public class Contexto : DbContext
{
    public Contexto(DbContextOptions<Contexto> options) : base(options) { }

    public DbSet<Prestamos> Prestamos { get; set; }

    public DbSet<Deudores> Deudores { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Deudores>().HasData(new List<Deudores>()
        {
        new Deudores() { DeudorId=1, Nombres="Alma"},
        new Deudores() { DeudorId=2, Nombres="Jane"},
        new Deudores() { DeudorId=3, Nombres="DjMarte"},
        new Deudores() { DeudorId=4, Nombres="Franniel"}

        });

    }

}
