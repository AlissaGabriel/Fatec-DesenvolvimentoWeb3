namespace Academico.Models
{
    public class Aluno
    {
        public int AlunoId { get; set; }
        public int? Ra { get; set; }
        public int? UsuarioId { get; set; }
        public Usuario? Usuario { get; set; }
    }
}
