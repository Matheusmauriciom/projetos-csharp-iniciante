Menu();

static void Menu()
{

    Console.WriteLine("1 - SOMA");
    Console.WriteLine("2 - SUBTRAÇÃO");
    Console.WriteLine("3 - MULTIPLICAÇÃO");
    Console.WriteLine("4 - DIVISÃO");
    Console.WriteLine("5 - SAIR");

    string resp = Console.ReadLine();

    switch(resp)
    {
        case "1" : Soma(); break;
        case "2" : Subtracao(); break;
        case "3" : Multiplicacao(); break;
        case "4" : Divisao(); break;
        case "5" : Console.WriteLine("O programa foi encerrado..."); Environment.Exit(0); break;
        default: Console.WriteLine("Valor inválido..precione enter para voltar ao menu...");
        Console.ReadKey();
        Menu();
        break;
    }
    Console.Clear();
    Console.WriteLine("Precione enter para voltar ao menu...");
    Console.ReadKey();

}

static void Soma()
{
    Console.Clear();

    Console.WriteLine("Primeiro número");
    int n1 = int.Parse(Console.ReadLine());

    Console.WriteLine("Segundo número");
    int n2 = int.Parse(Console.ReadLine());

    int resultado = n1 + n2;
   Console.WriteLine($"A soma de {n1} + {n2} = {resultado}");
   Console.WriteLine("Pressione enter para voltar ao menu... ");
   Console.ReadKey();
   Console.Clear();
   Menu();
   
}

static void Subtracao()
{
    Console.Clear();

    Console.WriteLine("Primeiro número");
    int n1 = int.Parse(Console.ReadLine());

    Console.WriteLine("Segundo número");
    int n2 = int.Parse(Console.ReadLine());

    int resultado = n1 - n2;
   Console.WriteLine($"A subtração de {n1} - {n2} = {resultado}");
   Console.WriteLine("Pressione enter para voltar ao menu... ");
   Console.ReadKey();
   Console.Clear();
   Menu();
   
}

static void Multiplicacao()
{
    Console.Clear();

    Console.WriteLine("Primeiro número");
    int n1 = int.Parse(Console.ReadLine());

    Console.WriteLine("Segundo número");
    int n2 = int.Parse(Console.ReadLine());

    int resultado = n1 * n2;
   Console.WriteLine($"A multiplicação de {n1} * {n2} = {resultado}");
   Console.WriteLine("Pressione enter para voltar ao menu... ");
   Console.ReadKey();
   Console.Clear();
   Menu();
   
}

static void Divisao()
{
    Console.Clear();

    Console.WriteLine("Primeiro número");
    int n1 = int.Parse(Console.ReadLine());

    Console.WriteLine("Segundo número");
    int n2 = int.Parse(Console.ReadLine());

    int resultado = n1 / n2;
   Console.WriteLine($"A divisão de {n1} / {n2} = {resultado}");
   Console.WriteLine("Pressione enter para voltar ao menu... ");
   Console.ReadKey();
   Console.Clear();
   Menu();
   
}