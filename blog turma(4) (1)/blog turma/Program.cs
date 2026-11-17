   
/*
Conexao con = new Conexao();

PublicacaoService PService = new PublicacaoService(conexao.CriarConexao());
*/



using dotenv.net;

DotEnv.Load();

var conexao = new Conexao();
var menuView = new MenuView();
var publicacaoView = new PublicacaoView();
var publicacaoService = new PublicacaoService(conexao.CriarConexao());
var publicacaoController = new PublicacaoController(publicacaoView, publicacaoService);

int opcao;
do
{
    opcao = menuView.ExibirMenu();

    if (opcao == 1)
        publicacaoController.Listar();

} while (opcao != 0);

Console.WriteLine("Até logo!");