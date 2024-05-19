namespace Trabalho2.Model
{
    public class Pesquisador
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Email { get; set; }
        public string? Instituicao { get; set; }
        public string? Lattes { get; set; }
        public string? Tipo { get; set; }
        public Area? AreaAtuacao { get; set; }
    }
}