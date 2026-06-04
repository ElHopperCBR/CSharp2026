using Microsoft.EntityFrameworkCore;
using ProjetoWeb01.Classes.Entidades;

namespace ProjetoWeb01.Dados
{
    public class AlunoContext : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Admin> Admins { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Server=(localdb)\MSSQLLocalDB;Database=Aluno;Trusted_Connection=True;TrustServerCertificate=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // TPT
            modelBuilder.Entity<Usuario>().ToTable("Usuario");
            modelBuilder.Entity<Aluno>().ToTable("Alunos");
            modelBuilder.Entity<Admin>().ToTable("Admin");

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Nome).IsRequired();
                entity.Property(e => e.Email).IsRequired();
                entity.Property(e => e.Senha).IsRequired();
                entity.Property(e => e.Regra).IsRequired();
            });

            modelBuilder.Entity<Aluno>(entity =>
            {
                entity.Property(e => e.CursoID).IsRequired();
                entity.Property(e => e.RA).IsRequired();
                entity.Property(e => e.StatusAction).IsRequired();
                entity.Property(e => e.StatusWIFI).IsRequired();
            });
        }
    }
}
