using System.IO;
using System.Runtime.InteropServices;

Menu();


static void Menu ()
{
    Console.Clear();
    Console.WriteLine("O que você deseja fazer?");
    Console.WriteLine("1 - Abrir Arquivo");
    Console.WriteLine("2 - Criar novo Arquivo");
    Console.WriteLine("0 - Sair");

    short option = short.Parse(Console.ReadLine());

    switch(option)
    {
        case 0: Environment.Exit(0); break;
        case 1: Abrir (); break;
        case 2: Editar (); break;
        default: Menu (); break;
    }
}

static void Abrir()
{
    // Limpa a tela do console para uma melhor experiência de usuário
    Console.Clear();

    // Solicita ao usuário que insira o caminho do arquivo que deseja abrir
    System.Console.WriteLine("Qual caminho do arquivo?");
    string path = Console.ReadLine();

    // Utilizando a instrução 'using' para garantir que o recurso seja liberado corretamente
    using (var file = new StreamReader(path))
    {
        // Lê o conteúdo do arquivo até o final
        string text = file.ReadToEnd();

        // Exibe o conteúdo do arquivo no console
        System.Console.WriteLine(text);
    }

    // Adiciona uma linha em branco para melhor formatação
    System.Console.WriteLine("");

    // Aguarda o usuário pressionar Enter antes de retornar ao menu principal
    Console.ReadLine();

    // Chama o método Menu() para retornar ao menu principal
    Menu();
}

static void Editar()
{
    // Limpa a tela do console para uma melhor experiência de usuário
    Console.Clear();

    // Solicita ao usuário que digite o texto desejado, indicando como sair do loop
    Console.WriteLine("Digite seu texto abaixo (ESC para sair)");
    Console.WriteLine("------------");

    // Inicializa uma string vazia para armazenar o texto inserido pelo usuário
    string text = "";

    // Loop que continua até que o usuário pressione a tecla ESC
    do
    {
        // Adiciona a linha de texto digitada pelo usuário à string 'text'
        text += Console.ReadLine();
        
        // Adiciona uma nova linha para separar as linhas de texto
        text += Environment.NewLine;
    }
    // Continua no loop enquanto o usuário não pressionar a tecla ESC
    while (Console.ReadKey().Key != ConsoleKey.Escape);

    // Chama o método Salvar(), passando o texto inserido pelo usuário
    Salvar(text);
}

static void Salvar(string text)
{
    // Limpa a tela do console para uma melhor experiência de usuário
    Console.Clear();

    // Solicita ao usuário que insira o caminho onde deseja salvar o arquivo
    Console.WriteLine("Qual caminho para salvar o arquivo?");

    // Obtém o caminho inserido pelo usuário
    var path = Console.ReadLine();

    // Utilizando a instrução 'using' para garantir que o recurso seja liberado corretamente
    using (var file = new StreamWriter(path)) // StreamWriter = fluxo de escrita
    {
        // Escreve o texto no arquivo
        file.Write(text);  
    }

    // Exibe uma mensagem indicando que o arquivo foi salvo com sucesso, incluindo o caminho
    Console.WriteLine($"Arquivo {path} salvo com sucesso!");

    // Aguarda o usuário pressionar Enter antes de retornar ao menu principal
    Console.ReadLine();

    // Chama o método Menu() para retornar ao menu principal
    Menu();
}




