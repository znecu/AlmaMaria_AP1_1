using Microsoft.EntityFrameworkCore;
using AlmaMaria_AP1_1.Models;
namespace AlmaMaria_AP1_1.DAL;

public class Contexto : DbContext
{
    public Contexto(DbContextOptions<Contexto> options) : base(options) {}

    public DbSet<Prestamos> Prestamos { get; set; }

}
