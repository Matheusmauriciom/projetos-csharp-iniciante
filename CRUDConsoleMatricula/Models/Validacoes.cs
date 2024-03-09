using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDAluno.Models
{
    public class Validacoes
    {
        // Verifica se a string contém apenas dígitos numéricos.
        // Retorna true se TODOS os caracteres na string forem dígitos numéricos (0-9). Usa char.IsDigit.
        // Retorna false se PELO MENOS UM caractere não for um dígito numérico. Usa .All para verificar todos os caracteres.
        public static bool ContainsOnlyNumbers(string valor) => valor.All(char.IsDigit);


        // Verifica se uma string contém apenas letras e espaços
        // Retorna true se TODOS os caracteres na string forem letras ou espaços em branco. Usa char.IsLetter e char.IsWhiteSpace.
        // Retorna false se PELO MENOS UM caractere não for uma letra ou um espaço em branco. Usa .All para verificar todos os caracteres.
        public static bool IsValidCurso(string valor) => valor.All(c => char.IsLetter(c) || char.IsWhiteSpace(c));

        // Verifica se a string NÃO é composta apenas por espaços em branco ou é nula.
        // Retorna true se a string NÃO for vazia e NÃO consistir apenas em espaços em branco. Usa !string.IsNullOrWhiteSpace.
        // Retorna false se a string for nula, vazia ou consistir apenas em espaços em branco.
        public static bool IsNotWhiteSpace(string valor) => !string.IsNullOrWhiteSpace(valor);

        // Verifica se a string contém um caractere específico.
        // Retorna true se a string contiver o caractere especificado.
        // Retorna false se o caractere não estiver presente na string. Usa valor.Contains.
        public static bool ContainsChar(string valor, char caractere) => valor.Contains(caractere);

        // Verifica se a string contém apenas letras.
        // Retorna true se TODOS os caracteres na string forem letras ou espaços em branco. Usa char.IsLetter e char.IsWhiteSpace.
        // Retorna false se PELO MENOS UM caractere não for uma letra ou um espaço em branco. Usa .All para verificar todos os caracteres.
        public static bool ContainsOnlyLetters(string valor) => valor.All(c => char.IsLetter(c) || char.IsWhiteSpace(c));


        // Método para ler a entrada do usuário e converter para o tipo desejado, lê e retorna uma entrada do usuário de tipo genérico T.
        private static T LerInput<T>()
        {
            string input = Console.ReadLine();

            // Se o tipo for int, usa TryParse para garantir que a entrada seja um número válido
            if (typeof(T) == typeof(int))
            {
                while (!int.TryParse(input, out int resultado))
                {
                    Console.WriteLine("Erro: Digite um número válido.");
                    Console.WriteLine($"Digite um número válido:");
                    input = Console.ReadLine();
                }
                return (T)Convert.ChangeType(input, typeof(T));
            }

            return (T)Convert.ChangeType(input, typeof(T));
        }



        // Valida e atribui um valor a uma propriedade com base em um critério de validação.
        // Parâmetros:
        //   - valor: O valor a ser validado e atribuído.
        //   - propriedadeField: Referência à propriedade que será definida se a validação for bem-sucedida.
        //   - criterioValidacao: Função que define o critério de validação. Deve retornar true se o valor for válido, false caso contrário.
        //   - mensagemErro: Mensagem de erro a ser lançada em caso de validação malsucedida.
        public static void ValidateAndSetProperty<T>(T valor, ref T propriedadeField, Func<T, bool> criterioValidacao, string mensagemErro)
        {
            // Número máximo de tentativas permitidas
            int tentativasRestantes = 3;

            // Loop para permitir um número limitado de tentativas
            while (tentativasRestantes > 0)
            {
                try
                {
                    // Verifica se o valor atende aos critérios de validação
                    if (criterioValidacao(valor))
                    {
                        // Se atender aos critérios, atribui o valor à variável específica da instância e sai do loop
                        propriedadeField = valor;
                        break;
                    }
                    else
                    {
                        // Se não atender aos critérios, lança uma exceção com a mensagem de erro
                        throw new ArgumentException(mensagemErro);
                    }
                }
                catch (ArgumentException ex)
                {
                    Console.Clear();
                    // Informa quantas tentativas restantes
                    Console.WriteLine($"Tentativas restantes: {tentativasRestantes}");
                    System.Console.WriteLine("-------------------------");
                    // Se ocorrer uma exceção, imprime a mensagem de erro
                    Console.WriteLine($"Erro: {ex.Message}");

                    // Adiciona validação específica para o nome
                    if (mensagemErro.ToLower() == "nome" && !ContainsOnlyLetters(valor.ToString()))
                    {   Console.WriteLine();
                        Console.WriteLine("Por favor, digite um nome válido contendo apenas letras.");
                        
                    }
                    // Mensagem explicativa específica para o campo 'Sexo'
                    else if (mensagemErro.ToLower() == "sexo")
                    {
                        Console.WriteLine("Por favor, digite 'M' para Masculino ou 'F' para Feminino.");
                    }
                    // Mensagem específica para o campo 'E-mail' quando o '@' está ausente
                    else if (mensagemErro.ToLower() == "e-mail" && !ContainsChar(valor.ToString(), '@'))
                    {
                        Console.WriteLine("Por favor, inclua o caractere '@' no e-mail (exemplo@email.com).");
                    }
                    // Adiciona validação específica para o telefone
                    else if (mensagemErro.ToLower() == "telefone" && !ContainsOnlyNumbers(valor.ToString()))
                    {
                        Console.WriteLine("Por favor, digite um número de telefone válido contendo apenas números.");
                    }
                    // Adiciona validação específica para o curso
                    else if (mensagemErro.ToLower() == "curso" && !IsValidCurso(valor.ToString()))
                    {
                        Console.WriteLine("Por favor, digite um nome de curso válido contendo apenas letras e espaços.");
                    }
                    else
                    {
                        Console.WriteLine($"Por favor, forneça uma {mensagemErro.ToLower()} válida.");
                    }

                    // Solicita ao usuário que insira um valor válido
                    Console.Write($"{mensagemErro}: ");

                    // Lê a entrada do usuário novamente
                    valor = LerInput<T>();
                    tentativasRestantes--;
                }
            }

            // Se o número de tentativas chegar a zero, lança uma exceção indicando que o número máximo de tentativas foi excedido
            if (tentativasRestantes == 0)
            {
                throw new InvalidOperationException($"Número máximo de tentativas excedido. Operação cancelada para {mensagemErro.ToLower()}.");
            }
        }
    }
}