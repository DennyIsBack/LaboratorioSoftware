namespace Trabalho2.Model
{
    public class Projeto
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public List<Pesquisador>? Pesquisadores { get; set; }
        public Area? AreaDeAtuacao { get; set; }
        public Instituicao? Instituicao { get; set; }
        public Resultado? Resultado { get; set; }
        public DateTime DataInicial { get; set; }
        public DateTime DataFinal { get; set; }
        public string? Tipo { get; set; }
        public int Resultado_id { get; set; }
        public bool Finalizado { get; set; }
        public int AreaAtuacao_ID { get; set; }
        public int Instituicao_ID { get; set; }

    }
}