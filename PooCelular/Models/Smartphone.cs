using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Excelular
{
    public abstract class Smartphone
    {

        public Smartphone()
        {
            
        }

        public Smartphone(string numero, string modelo, string imei, string memoria)
        {
            Memoria = memoria;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
        }
        public string Numero { get; set; }
        private string Modelo { get; set; }
        private string IMEI { get; set; }
        private string Memoria { get; set; }


        public void Ligar ()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
           Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
        
    }

}