using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDAluno.Models
{   // Interface IMenu.
    // Define o contrato para exibição de um menu relacionado a operações em um objeto AlunoMetodos.
    public interface IMenu
    {
        void ExibirMenu(AlunoMetodos aluno);
    }

    public class Menu : IMenu // Classe Menu que implementa a interface IMenu.
    {
        // Método para exibir o menu principal e interagir com o usuário
        public void ExibirMenu(AlunoMetodos aluno)
        {
            Console.Clear();

            // Loop principal do menu
            while (true)
            {
                Console.WriteLine("Bem-vindo ao Sistema de Cadastro de Alunos");

                // Exibição das opções do menu
                Console.WriteLine("\nEscolha uma operação:");
                Console.WriteLine("1 - Adicionar aluno");
                Console.WriteLine("2 - Vizualizar alunos matriculados");
                Console.WriteLine("3 - Atualizar Aluno");
                Console.WriteLine("4 - Deletar Aluno");
                Console.WriteLine("0 - Sair");

                // Leitura da opção do usuário
                if (int.TryParse(Console.ReadLine(), out int opcao))
                {
                    // Switch para lidar com a opção escolhida
                    switch (opcao)
                    {
                        case 1:
                            aluno.AdicionarAlunos();
                            break;
                        case 2:
                            aluno.ExibirAlunos();
                            break;
                        case 3:
                            Console.Clear();
                            aluno.AtualizarAlunos();
                            break;
                        case 4:
                            aluno.DeletarAlunos();
                            break;
                        case 0:
                            SairDoSistema();
                            break;
                        default:
                            Console.Clear();
                            Console.WriteLine("Opção inválida. Pressione qualquer tecla para voltar ao menu...");
                            Console.ReadKey();
                            break;
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Opção inválida. Pressione qualquer tecla para voltar ao menu...");
                    Console.ReadKey();
                }
            }
        }

        // Método para sair do sistema
        private static void SairDoSistema()
        {
            Console.Clear();
            Console.WriteLine("Saindo do sistema...");
            Thread.Sleep(1500); // Pausa para exibir a mensagem
            Console.WriteLine("Obrigado!");
            Environment.Exit(0);
        }
    }
}