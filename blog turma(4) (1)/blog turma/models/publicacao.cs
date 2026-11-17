using static System.Runtime.InteropServices.JavaScript.JSType;
public class Publicacao
{
    public int Id { get; set; } = 0;
    public string Titulo{get;set;} =string.Empty;
    public string Texto {get;set;}=string.Empty;
    public DateTime DataCriacao { get; set; } = DateTime.Now;
    public int UsuarioId { get; set; } = 0;
} 
