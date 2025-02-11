namespace Atividade.Controllers
{
    public class LivrosTeste
    {
        public Guid LivroId { get; set; }
        public string Titulo { get; set; }
        public LivrosTeste() { }
        public LivrosTeste(Guid livroId, string titulo)
        {
            LivroId = livroId;
            Titulo = titulo;
        }
    }
}
