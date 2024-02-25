using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TreinoEstaci.Models;


namespace TreinoEstaci.Models
{
  public class ContaCorrente : IMenu
    {
        private double saldo;

        public ContaCorrente()
        {

        }

        public void Depositar(double valor)
        {
            Console.Clear();
            saldo += valor;
            Console.WriteLine($"Depósito de R$ {valor} realizado com sucesso. Novo saldo: R${saldo}");
            Console.WriteLine("Pressione qualquer tecla para voltar ao menu...");
            Console.ReadKey();

            ExibirMenu(this); // Chamando o método ExibirMenu da interface IMenu
            Console.Clear();
        }

        public void Sacar(double valor)
        {
            Console.Clear();
            if (valor > saldo)
            {
                Console.WriteLine("Saldo insuficiente!");
            }
            else
            {
                saldo -= valor;
                Console.WriteLine($"Saque de R$ {valor} realizado com sucesso. Novo saldo: R$ {saldo}");
            }
            Console.WriteLine("Pressione qualquer tecla para voltar ao menu...");
            Console.ReadKey();

            ExibirMenu(this); // Chamando o método ExibirMenu da interface IMenu
        }

        public void ConsultarSaldo()
        {
            Console.Clear();
            Console.WriteLine($"Saldo atual: R$ {saldo}");
            Console.WriteLine("Pressione qualquer tecla para voltar ao menu...");
            Console.ReadKey();

            ExibirMenu(this); // Chamando o método ExibirMenu da interface IMenu
        }

        public void ExibirMenu(ContaCorrente conta)
        {
            // Implementação vazia aqui, pois estamos usando a implementação da classe Menu
        }
    }
}
