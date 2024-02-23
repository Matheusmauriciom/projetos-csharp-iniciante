using ExEstacionamento;

//Coloca o encoding para UTF8 para exibir acentuação
Console.OutputEncoding = System.Text.Encoding.UTF8;


// declarar variaveis preco hora, precoInicial
decimal precoIncial = 0;
decimal precoPorHora = 0;

Console.WriteLine("Informe o preço inicial:");
precoIncial = int.Parse(Console.ReadLine());

Console.WriteLine("Informe o preço por hora:");
precoPorHora = int.Parse(Console.ReadLine());

// Instanciar a classe estacionamento
Estacionamento es = new Estacionamento(precoIncial, precoPorHora);


//menu
bool controle = true;
while(controle)
{   Console.Clear();    

    Console.WriteLine("Selecione uma opção:");
    Console.WriteLine("1 - Adicionar Veiculos");
    Console.WriteLine("2 - Listar Veiculos");
    Console.WriteLine("3 - Remover Veiculos");
    Console.WriteLine("4 - Sair");

    switch(Console.ReadLine())
{   
     
    case "1": es.AdicionarVeiculo(); break;
    case "2": es.ListarVeiculo(); break;
    case "3": es.RemoverVeiculo(); break;
    case "4": controle = false; Console.WriteLine("O programa se encerrou...Obrigado"); Environment.Exit(0);  break;
    default:
    Console.WriteLine("Opção inválida."); 
    break;
}
    Console.WriteLine("Pressione uma tecla para continuar...");
    //Console.ReadLine();
    Console.ReadKey();
}



