using Estudante.Classes.Entidades;
using Microsoft.EntityFrameworkCore;

namespace Estudante.Classes.Dados
{
    internal class AlunoContext : DbContext
    {
        public DbSet<Aluno> Alunos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database = AlunoDB; Trusted_Connection=True;TrustServerCertificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Aluno>(entity =>
            {
                entity.HasKey(a => a.Id);
                entity.Property(a => a.RA);
                entity.Property(a => a.Nome).IsRequired().HasMaxLength(50);
                entity.Property(a => a.Curso).HasMaxLength(50);
            }

                );
        }
    }
}
