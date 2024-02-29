using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Excelular.Models
{
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, string memoria) : base(numero, modelo, imei, memoria)
        {
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            System.Console.WriteLine($"Instalando o {nomeApp}");
        }
    }
}