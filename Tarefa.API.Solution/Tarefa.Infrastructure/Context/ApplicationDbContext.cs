using Microsoft.EntityFrameworkCore;
using Tarefa.Domain.Entidades;

namespace Tarefa.Infrastructure.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Projeto> Projetos { get; set; }
        public DbSet<Domain.Entidades.Tarefa> Tarefas { get; set; }
        public DbSet<Comentario> Comentarios { get; set; }
        public DbSet<HistoricoAtualizacao> Historicos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Projeto>().ToTable("Projetos");
            modelBuilder.Entity<Domain.Entidades.Tarefa>().ToTable("Tarefas");
            modelBuilder.Entity<Comentario>().ToTable("Comentarios");
            modelBuilder.Entity<HistoricoAtualizacao>().ToTable("Historicos");
        }
    }
}
