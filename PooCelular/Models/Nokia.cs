using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Excelular.Models
{
    public class Nokia : Smartphone
    {   
        public Nokia(string numero, string modelo, string imei, string memoria) : base(numero, modelo, imei, memoria)
        {
            
        }

        public Nokia()
        {
            
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            System.Console.WriteLine($"Instalando o {nomeApp}");
        }
    }
}