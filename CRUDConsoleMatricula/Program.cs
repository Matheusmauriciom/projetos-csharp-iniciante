using CRUDAluno.Models;

// Criando uma instância da classe AlunoMetodos para realizar operações com alunos
AlunoMetodos aluno = new AlunoMetodos();

// Criando uma instância da classe Menu para exibir e interagir com o menu do programa
Menu menu = new Menu();

// Chamando o método ExibirMenu da instância do Menu e passando a instância do AlunoMetodos como parâmetro
menu.ExibirMenu(aluno);



/* 

Organização e Estrutura:
    - Eu dividi meu código em classes separadas (Aluno, Validacoes, AlunoMetodos, Menu) para manter uma estrutura organizada e lógica.

Uso de Classes e Objetos:
    -Estou usando classes para representar objetos (alunos) e métodos para realizar operações específicas sobre esses objetos. Essa abordagem é fundamental na programação orientada a objetos.

Encapsulamento e Propriedades:
    Utilizei propriedades encapsuladas nas classes Aluno e Validacoes para controlar o acesso e manipulação dos dados, seguindo as boas práticas de encapsulamento.

Tratamento de Exceções:
    Implementei tratamento de exceções em várias partes do meu código para lidar com situações imprevistas, tornando o programa mais robusto e resistente a erros.

Interfaces:
    Introduzi a interface Imenu, o que demonstra minha compreensão sobre como usar interfaces para definir contratos e promover flexibilidade no código.

Menu Interativo:
    Desenvolvi um menu interativo para facilitar a interação do usuário, e a estrutura do menu está clara e fácil de entender.

*/