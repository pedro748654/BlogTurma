using System.Diagnostics.Contracts;
using System.Dynamic;

public class Comentario
{
    public int Id { get; set; } = 0;
    public string Texto { get;set;}= string.Empty;
    public DateTime DataCriacao { get; set; } = DateTime.Now;
    public int UsuarioId { get; set; } = 0;
    public int PublicacaoId { get; set; } = 0;

}

 /*public int Id { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public int Estoque { get; set; }
        public DateTime DataCadastro { get; set; } ;*/