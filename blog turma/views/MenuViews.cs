using System;
using System.Data.SqlTypes;

public class MenuView
    {
        // Operação exigida pelo diagrama: ExibirMenu (retorna uma escolha numérica)
        public int ExibirMenu()
        {

            Console.Clear();
            Console.WriteLine("=======================================");
            Console.WriteLine("            BLOG DA TURMA              ");
            Console.WriteLine("=======================================");
            Console.WriteLine(" 1. Ver Publicaçao");
            Console.WriteLine(" 2.Atualizar publicaçao/comentar");
            Console.WriteLine("3. Excluir publicação.");
            Console.WriteLine("4. Criar Publicaçao");
            Console.WriteLine("5. sair Menu");
            Console.WriteLine("=======================================");
            Console.Write("Escolha uma opção: ");

            string? entrada = Console.ReadLine();

            if (int.TryParse(entrada, out int opcao) && (opcao >= 1 && opcao <=5))
                return opcao;
                
            else return 0;


           }
    }
