using MySqlConnector;
using dotenv.net;
using System.Security.Authentication;

public class Conexao
{
   readonly string string_conexao;

   public Conexao()
	{   DotEnv.Load();
		string_conexao = new MySqlConnectionStringBuilder
		{
			Server = "DB_HOST",
			UserID = "DB_USER",
			Password = "DB_PASSWORD",
			Database = "DB_NAME",
		}.ConnectionString;
	}

	public MySqlConnection CriarConexao()
	{
		using var connection = new MySqlConnection(string_conexao);

		return connection;
	}
}