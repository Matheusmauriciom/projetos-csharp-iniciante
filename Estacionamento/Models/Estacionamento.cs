using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExEstacionamento
{
    public class Estacionamento
    {   
        public Estacionamento(decimal precoIncial, decimal precoPorHora)
        {
            this.precoIncialx = precoIncial;
            this.precoPorHorax = precoPorHora;
        }

        private decimal precoIncialx = 0;
        private decimal precoPorHorax = 0;
        private List<string> veiculos = new List<string>();

        public void AdicionarVeiculo ()
        {   Console.Clear();
            Console.WriteLine("Informe a placa do seu veiculo");
            string placa = Console.ReadLine();

            //adicionar na lista veiculos
            veiculos.Add(placa);
            Console.WriteLine($"O veiculo com a placa: {placa}, foi cadastrado com sucesso!");
            Console.WriteLine();
        }

        public void ListarVeiculo ()
        {   Console.Clear();
            if(veiculos.Any())
            {    
                Console.WriteLine("Os veiculos cadastrados são:");
                foreach(var verifica in veiculos)
                {  
                    Console.WriteLine(verifica);
                }
            }
            else
            {
                Console.WriteLine("Não há veiculos cadastrados");
            }
        }

        public void RemoverVeiculo ()
        {   Console.Clear();
           Console.WriteLine("Informe a placa do veiculo");
           string placa = Console.ReadLine();

           if(veiculos.Any( x => x.ToUpper() == placa.ToUpper()))
           {
            Console.WriteLine("Informe a quantiade de horas estacionado");
            int horas = int.Parse(Console.ReadLine());

            decimal valorTotal = (precoIncialx + precoPorHorax) * horas ;
            veiculos.Remove(placa);

             Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
           }
           else Console.WriteLine("Veiculo não cadastrado");
        }

    }
}