using MySqlConnector;
using dotenv.net;
using System.Collections.Generic;
  class PublicacaoService
{
    
    private readonly MySqlConnection _Conexao;

    public PublicacaoService (MySqlConnection conexao)
    {
        _Conexao = conexao;
    }

    public List<Publicacao> ListarPublicacoes()
    {
        List<Publicacao> publicacoes = new List<Publicacao>();
        _Conexao.Open();

        using var command = new MySqlCommand("SELECT * FROM publicacoes;", _Conexao);
        using var leitor = command.ExecuteReader();
        while (leitor.Read())
            {
                publicacoes.Add(new Publicacao
                {
                Id = leitor.GetInt32("id"),
                Titulo = leitor.GetString("titulo"),
                Texto = leitor.GetString("texto"),
                DataCriacao = leitor.GetDateTime("data_criacao"),
                UsuarioId= leitor.GetInt32("usuario_id")
                });

            
            }
            return publicacoes;
    }

}
