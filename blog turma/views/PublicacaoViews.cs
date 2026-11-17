

    public class PublicacaoView
    {
        public void ExibirPublicacoes(List<Publicacao> publicacoes)
        {
            if (publicacoes == null || publicacoes.Count == 0)
            {
                ExibirMensagem("Nenhuma publicação encontrada.");
                return;
            }

            Console.WriteLine("\n=== PUBLICAÇÕES RECENTES ===");
            foreach (var pub in publicacoes)
            {
                Console.WriteLine($"----------------------------------------");
                Console.WriteLine($"ID: {pub.Id}");
                Console.WriteLine($"Título: {pub.Titulo}");
                Console.WriteLine($"Data: {pub.DataCriacao:dd/MM/yyyy HH:mm}");
                Console.WriteLine($"Conteúdo:\n{pub.Texto}");
                Console.WriteLine($"Autor (ID): {pub.UsuarioId}");
            }
            Console.WriteLine("----------------------------------------\n");
        }

        public void ExibirMensagem(string mensagem)
        {
            Console.WriteLine($"\n[AVISO]: {mensagem}\n");
        }
    }

