using MySqlConnector;
using System;
 class PublicacaoController
{
    private readonly PublicacaoView _view;
    private readonly PublicacaoService _service;
    public PublicacaoController(PublicacaoView view, PublicacaoService service)
    {
        _view = view;
        _service = service;
    }

    public void Listar()
    {
        try
        {
            var publicacoes = _service.ListarPublicacoes();

            if (publicacoes.Count == 0)
                _view.ExibirMensagem("Nenhuma publicação cadastrada ainda.");
            else
                _view.ExibirPublicacoes(publicacoes);
        }
        catch (Exception ex)
        {
            _view.ExibirMensagem("Não foi possível listar as publicações: " + ex.Message);
        }
    }
}