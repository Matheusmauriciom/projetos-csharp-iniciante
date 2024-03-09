using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDAluno.Models
{
    public class Aluno
    {
        // Construtores para criar instâncias.
        public Aluno() { }

        public Aluno(string nomecompleto, int idade, string celular, string curso, string email, char sexo, DateTime datamatricula)
        {
            NomeCompleto = nomecompleto;
            Idade = idade;
            Celular = celular;
            Curso = curso;
            Email = email;
            Sexo = sexo;
            DataMatricula = datamatricula;
        }



        // Propriedades privadas
        private string _nomeCompleto;
        private int _idade;
        private string _celular;
        private string _curso;
        private string _email;
        private char _sexo;
        private DateTime _dataMatricula;


        //propriedades

        public string NomeCompleto
        {
            // - O getter retorna o valor do campo _nomeCompleto convertido para maiúsculas.
            // - O setter utiliza a função ValidateAndSetProperty para validar e atribuir o valor, garantindo que:
            //   1. O nome não é composto apenas por espaços em branco.
            //   2. O nome contém apenas letras.
            get => _nomeCompleto.ToUpper();
            set => Validacoes.ValidateAndSetProperty(value, ref _nomeCompleto,
                    nome => Validacoes.IsNotWhiteSpace(nome) && Validacoes.ContainsOnlyLetters(nome), "Nome");
        }
        public int Idade
        {   
            // - O getter retorna o valor do campo _idade.
            // - O setter utiliza a função ValidateAndSetProperty para validar e atribuir o valor, garantindo que:
            //   1. A idade é um número não negativo.
            get => _idade;
            set => Validacoes.ValidateAndSetProperty(value, ref _idade, idade => idade >= 0, "Idade");
        }
        public string Celular
        {   // - O getter retorna o valor do campo _celular.
            // - O setter utiliza a função ValidateAndSetProperty para validar e atribuir o valor, garantindo que:
            //   1. O celular não é composto apenas por espaços em branco.
            //   2. O celular contém apenas números.
            get => _celular;
            set => Validacoes.ValidateAndSetProperty(value, ref _celular,
                    Celular => Validacoes.IsNotWhiteSpace(Celular) && Validacoes.ContainsOnlyNumbers(Celular), "Celular");
        }
        public string Curso
        {
            // - O getter retorna o valor do campo _curso convertido para maiúsculas.
            // - O setter utiliza a função ValidateAndSetProperty para validar e atribuir o valor, garantindo que:
            //   1. O curso não é composto apenas por espaços em branco.
            //   2. O curso é válido de acordo com o critério especificado em IsValidCurso.
            get => _curso.ToUpper();
            set => Validacoes.ValidateAndSetProperty(value, ref _curso,
                    curso => Validacoes.IsNotWhiteSpace(curso) && Validacoes.IsValidCurso(curso), "Curso");
        }
        public string Email
        {
            // - O getter retorna o valor do campo _email.
            // - O setter utiliza a função ValidateAndSetProperty para validar e atribuir o valor, garantindo que:
            //   1. O e-mail não é composto apenas por espaços em branco.
            //   2. O e-mail contém o caractere '@'.
            get => _email;
            set => Validacoes.ValidateAndSetProperty(value, ref _email, email => Validacoes.IsNotWhiteSpace(email) && Validacoes.ContainsChar(email, '@'), "E-mail");
        }
        public char Sexo
        {
            // - O getter retorna o valor do campo _sexo.
            // - O setter utiliza a função ValidateAndSetProperty para validar e atribuir o valor, garantindo que:
            //   1. O sexo não é composto apenas por espaços em branco.
            //   2. O sexo é 'M' (masculino) ou 'F' (feminino), ignorando maiúsculas ou minúsculas.
            get => _sexo;
            set => Validacoes.ValidateAndSetProperty(value, ref _sexo, sexo =>
            {
                char sexoUpper = char.ToUpper(sexo);
                return sexoUpper == 'M' || sexoUpper == 'F';
            }, "Sexo");
        }
        public DateTime DataMatricula
        {
            // - O getter retorna o valor do campo _dataMatricula.
            // - O setter utiliza a função ValidateAndSetProperty para validar e atribuir o valor, garantindo que:
            //   1. O ano da data de matrícula é igual ou superior a 1900.
            //   2. O ano da data de matrícula é menor ou igual ao ano atual.
            get => _dataMatricula;
            set => Validacoes.ValidateAndSetProperty(value, ref _dataMatricula,
                    data => data.Year >= 1900 && data.Year <= DateTime.Now.Year, "Data de matrícula");
        }

        
        // Propriedade de apenas leitura DataMatriculaFormatada.
        public string DataMatriculaFormatada => DataMatricula.ToString("dd/MM/yyyy");

    }
}