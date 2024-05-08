namespace Trabalho2.Model
{
    public class Projeto
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public List<Pesquisador>? Pesquisadores { get; set; }
        public string? AreaDeAtuacao { get; set; }
        public Instituicao? Instituicao { get; set; }
        public string? Tipo { get; set; }
        public int IdResultado { get; set; }
    }
}