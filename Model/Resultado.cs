using System.Windows.Forms.Design;

namespace Trabalho2.Model
{
    public class Resultado
    {
        public int Id { get; set; }
        public string? id_projeto { get; set; }
        public string nome_arquivo {get; set;}
        public byte[]? Arquivo { get; set; }
    }
}