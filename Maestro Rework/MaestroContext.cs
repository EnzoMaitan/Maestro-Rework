using Maestro_Rework.Classes;
using Microsoft.EntityFrameworkCore;

namespace Maestro_Rework
{
     public class MaestroContext : DbContext
    {
        public DbSet<Alternativa> Alternativas { get; private set; }
        public DbSet<AlternativaCorreta> AlternativaCorretas { get; private set; }
        public DbSet<AnexoConteudo> AnexoConteudos { get; private set; }
        public DbSet<Conteudo> Conteudos { get; private set; }
        public DbSet<Questao> Questoes { get; private set; }    
        public DbSet<Questionario> Questionarios { get; private set; }
        public DbSet<QuestionarioUsuario> QuestionarioUsuarios { get; private set; }
        public DbSet<RegistroUsuario> RegistroUsuarios { get; private set; }
        public DbSet<RegistroConteudo> RegistroConteudos { get; private set; }
        public DbSet<RegistraQuestionario> RegistroQuestionarios { get; private set; }

        public DbSet<Usuario> Usuarios { get; set; }

        public DbSet<UsuarioConteudo> UsuarioConteudos { get; private set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Usuario>().HasDiscriminator<int>("Nivel")
                .HasValue<Aluno>(1)
                .HasValue<Professor>(2)
                .HasValue<Administrador>(3);

            modelBuilder
                .Entity<UsuarioConteudo>()
                .HasKey(uc => new { uc.UsuarioID, uc.ConteudoID });

            modelBuilder
                .Entity<AlternativaCorreta>()
                .HasKey(ac => new { ac.QuestionarioUsuarioID , ac.AlternativaID});

            modelBuilder
                .Entity<QuestionarioUsuario>()
                .HasKey(qu => qu.Id);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Enzo\Documents\MaestroDB.mdf;Integrated Security=True;Connect Timeout=30");
        }
    }
}
