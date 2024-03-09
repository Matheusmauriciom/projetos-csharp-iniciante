using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CRUDAluno.Models;

namespace CRUDAluno.Models
{   // classe criada para os métodos do CRUD.
    public class AlunoMetodos
    {
        //lista para armazenar os alunos.
        private List<Aluno> Alunos = new List<Aluno>();


        //Create
        public void AdicionarAlunos()
        {
            Console.Clear();
            Console.WriteLine("Informe os dados do aluno:");
            Console.WriteLine("------------------------------");

            // Métodos auxiliares recebendo parametros(mensagem)
            string nomeCompleto = SolicitarString("Nome Completo: ");
            Console.WriteLine("-----------");

            int idade = SolicitarInteiro("Idade: ");
            Console.WriteLine("-----------");

            string celular = SolicitarString("Celular: ");
            Console.WriteLine("-----------");

            string curso = SolicitarString("Curso: ");
            Console.WriteLine("-----------");

            char sexo = SolicitarChar("Sexo (M/F): ");
            Console.WriteLine("-----------");

            string email = SolicitarString("Email: ");
            Console.WriteLine("-----------");

            DateTime dataMatricula = SolicitarData("Digite a data da matrícula (DD/MM/AAAA): ");

            try
            {   // Tenta criar um novo objeto Aluno com os dados fornecidos.
                Aluno novoAluno = new Aluno(nomeCompleto, idade, celular, curso, email, sexo, dataMatricula);
                Alunos.Add(novoAluno);
                Console.WriteLine("-------------");
                Console.WriteLine("Aluno adicionado com sucesso!");                
            }
            catch (ArgumentException ex)
            {   // Se ocorrer uma exceção exibe a mensagem de erro
                Console.WriteLine($"Erro ao adicionar aluno: {ex.Message}");
            }
            AguardarTecla();
            Console.Clear();

        }

        //Read
        public void ExibirAlunos()
        {
            Console.Clear();

            if (Alunos.Count == 0)
            {
                Console.WriteLine("Nenhum aluno cadastrado");
            }
            else
            {  Console.Clear();
                Console.WriteLine("Lista de alunos:");
                System.Console.WriteLine();
                // Iterar sobre a lista de alunos e mostrar detalhes de cada aluno
                foreach (var aluno in Alunos)
                {
                    ExibirDetalhesAluno(aluno);
                    Console.WriteLine("------------------------------");
                }
                AguardarTecla();
                Console.Clear();
            }
        }

        //Update
        public void AtualizarAlunos()
        {
            
            Console.WriteLine("Informe o nome completo do aluno que deseja atualizar");
            string nomeCompleto = Console.ReadLine();

            Console.Clear();
            //Encontrar aluno na lista
            Aluno AlunoAtualizar = Alunos.FirstOrDefault(aluno =>
            aluno.NomeCompleto.Equals(nomeCompleto, StringComparison.OrdinalIgnoreCase));

            if (AlunoAtualizar != null)
            {   
                // Mostrar detalhes antes da atualização
                ExibirDetalhesAluno(AlunoAtualizar);
                Console.WriteLine("---------------");    
                Console.WriteLine("O que deseja atualizar?");
                Console.WriteLine("1 - Nome Completo.");
                Console.WriteLine("2 - Idade.");
                Console.WriteLine("3 - Celular.");
                Console.WriteLine("4 - Email.");
                Console.WriteLine("5 - Sexo.");
                Console.WriteLine("6 - Data de matrícula.");
                Console.WriteLine("0 - Voltar ao menu...");
                Console.WriteLine();

                // Reaproveitando o método e aplicando minhas validações.
                int opcao = SolicitarInteiro("Escolha uma opção: ");
                System.Console.WriteLine();

                switch (opcao)
                {   
                    case 1:
                        AlunoAtualizar.NomeCompleto = SolicitarString("Novo nome completo: ");
                        break;
                    case 2:
                        AlunoAtualizar.Idade = SolicitarInteiro("Nova idade: ");
                        break;
                    case 3:
                        AlunoAtualizar.Celular = SolicitarString("Nova celular: ");
                        break;
                    case 4:
                        AlunoAtualizar.Email = SolicitarString("Novo email: ");
                        break;
                    case 5:
                        AlunoAtualizar.Sexo = SolicitarChar("Novo sexo (M/F): ");
                        break;
                    case 6:
                        AlunoAtualizar.DataMatricula = SolicitarData("Nova Data de Matrícula (no formato dd/mm/aaaa): ");
                        break;
                    case 0:
                    Console.Clear();
                    return;

                    default:
                        System.Console.WriteLine("Opção inválida");
                        break;
                }
                Console.WriteLine("Aluno atualizado com sucesso!");
            }
            else
            {
                Console.WriteLine("Aluno não encontrado. Nenhuma alteração feita.");
            }
            AguardarTecla();
            Console.Clear();
        }

        //Delete
        public void DeletarAlunos()
        {
            Console.Clear();
            Console.WriteLine("Informe o nome completo do aluno:");
            string nomeCompleto = Console.ReadLine();
            Console.WriteLine();

            //Encontrar aluno na lista
            Aluno RemoverAluno = Alunos.FirstOrDefault(aluno =>
            aluno.NomeCompleto.Equals(nomeCompleto, StringComparison.OrdinalIgnoreCase));

            if (RemoverAluno != null)
            {
                //Reaproveitando método de detalhes para exibir, antes da remoção
                ExibirDetalhesAluno(RemoverAluno);

                //Loop para confirmar o aluno antes de remover
                while (true)
                {   Console.WriteLine("-----------");
                    Console.WriteLine("Deseja realmente remover este aluno? (S/N)");
                    string resposta = Console.ReadLine().ToUpper();

                    if (resposta == "S")
                    {
                        // Remover o aluno da lista
                        Alunos.Remove(RemoverAluno);
                        Console.WriteLine("Aluno removido com sucesso!");
                        break;
                    }
                    else if (resposta == "N")
                    {
                        Console.WriteLine("Remoção cancelada. Nenhuma alteração feita.");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Resposta inválida. Por favor, digite 'S' para Sim ou 'N' para Não.");
                    }
                }
            }
            else
            {
                Console.WriteLine("Aluno não encontrado. Nenhuma alteração feita.");
            }
            AguardarTecla();
            Console.Clear();
        }


        /* Métodos para simplificar meu desenvolvimento e a leitura do código,
        para lidar com entrada do usuário de forma mais segura e eficiente. */

        private void ExibirDetalhesAluno(Aluno aluno)
        {
            Console.WriteLine($"Nome Completo: {aluno.NomeCompleto}");
            Console.WriteLine($"Idade: {aluno.Idade}");
            Console.WriteLine($"Celular: {aluno.Celular}");
            Console.WriteLine($"Email: {aluno.Email}");
            Console.WriteLine($"Sexo: {aluno.Sexo}");
            Console.WriteLine($"Curso: {aluno.Curso}");
            Console.WriteLine($"Data de Matrícula: {aluno.DataMatriculaFormatada}");
        }

        private string SolicitarString(string mensagem)
        {

            Console.Write(mensagem);
            return Console.ReadLine();
        }

        private int SolicitarInteiro(string mensagem)
        {
            while (true)
            {
                Console.Write(mensagem);
                // Tenta converter a entrada do usuário para um número inteiro
                if (int.TryParse(Console.ReadLine(), out int resultado))
                {
                    return resultado;
                }
                else
                {
                    Console.WriteLine("Erro: Por favor, digite um número inteiro válido.");
                }

            }
        }

        private char SolicitarChar(string mensagem)
        {
            while (true)
            {
                Console.Write(mensagem);
                if (char.TryParse(Console.ReadLine(), out char resultado))
                {
                    return char.ToUpper(resultado); // ou char.ToLower(resultado);
                }
                else
                {
                    Console.WriteLine("Por favor, digite um caractere válido. (M/F)");
                }
            }
        }

        private DateTime SolicitarData(string mensagem)
        {
            while (true)
            {
                Console.Write(mensagem);
                // Tenta converter a entrada do usuário para um objeto DateTime usando o formato específico "dd/MM/yyyy".
                if (DateTime.TryParseExact(Console.ReadLine(), "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime resultado))
                {
                    return resultado;
                }
                else
                {   Console.Clear();
                    Console.WriteLine("Erro: Por favor, digite uma data válida no formato dia/mês/ano.");
                }
            }
        }

        private void AguardarTecla()
        {
            Console.WriteLine("Precione qualquer tecla para voltar ao menu...");
            Console.ReadKey();
        }
    }
}





