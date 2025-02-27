
using Academico.Models;
using Microsoft.EntityFrameworkCore;

namespace Academico.Data
{
    //a classe ApplicationDbContext herda de DbContext, 
    //que é a classe base do Entity Framework Core para interação com o banco de dados.
    public class ApplicationDbContext:DbContext
    {
        //o construtor contém configurações necessárias para conectar ao banco de dados.
        //o parâmetro 'options' é passado para o construtor da classe base (DbContext).
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options){}
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Curso> Cursos { get; set; }
        public DbSet<Disciplina> Disciplinas { get; set; }
        public DbSet<Matricula> Matriculas { get; set; }
    }
}
