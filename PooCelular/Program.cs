using Excelular;
using Excelular.Models;

System.Console.WriteLine("Nokia:");
Nokia nokia = new Nokia(numero: "11111", modelo:"xxxx", imei:"11111", memoria: "45");
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

System.Console.WriteLine("--------------");

System.Console.WriteLine("Iphone:");
Iphone iphone = new Iphone(numero: "11111", modelo:"xxxx", imei:"11111", memoria: "45");
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");