using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TreinoEstaci.Models;


namespace TreinoEstaci.Models
{   // Interface que define o contrato para interação com o menu
     public interface IMenu
    {
        void ExibirMenu(ContaCorrente conta);
    }

    // Implementação da interface IMenu
    public class Menu : IMenu
    {
         public void ExibirMenu(ContaCorrente conta)
        {
            Console.Clear();

            while (true)
            {
                Console.WriteLine("Bem-vindo ao Sistema de Conta Corrente");

                Console.WriteLine("\nEscolha uma operação:");
                Console.WriteLine("1 - Depositar");
                Console.WriteLine("2 - Sacar");
                Console.WriteLine("3 - Consultar Saldo");
                Console.WriteLine("0 - Sair");

                int escolha = int.Parse(Console.ReadLine());

                switch (escolha)
                {
                    case 1:
                        Console.Write("Digite o valor para depósito: ");
                        double valorDeposito = double.Parse(Console.ReadLine());
                        conta.Depositar(valorDeposito);
                        break;

                    case 2:
                        Console.Write("Digite o valor para sacar: ");
                        double valorSaque = double.Parse(Console.ReadLine());
                        conta.Sacar(valorSaque);
                        break;

                    case 3:
                        conta.ConsultarSaldo();
                        break;

                    case 0:
                        Console.Clear();
                        Console.WriteLine("Saindo do sistema...");
                        System.Threading.Thread.Sleep(1500);
                        Console.WriteLine("Obrigado!");
                        Environment.Exit(0);
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("Opção inválida. Pressione qualquer tecla para voltar ao menu...");
                        Console.ReadKey();
                        break;
                }
            }
        }
    }
}