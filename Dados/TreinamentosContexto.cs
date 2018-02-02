using Microsoft.EntityFrameworkCore;
using Treinamentos.Models;

namespace Treinamentos.Dados
{
    public class TreinamentosContexto:DbContext
    {
        public TreinamentosContexto(DbContextOptions<TreinamentosContexto>Options):base(Options){
        }

        public DbSet<Areas> Areas{get; set;}

        public DbSet<Cursos> Cursos{get; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder){
            modelBuilder.Entity<Areas>().ToTable("Areas");
            modelBuilder.Entity<Cursos>().ToTable("Cursos");

        }

        
    }
}