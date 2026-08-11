using Classes.Class;

// ==================================================
// 01 - INSTANCIAÇÃO DE CLASSE
// ==================================================
// Criamos um objeto a partir da classe Usuario.
// "new Usuario()" cria uma nova instância da classe.

Console.Clear();

Console.WriteLine("=================================");
Console.WriteLine("       INFORMAÇÕES DO USUÁRIO");
Console.WriteLine("=================================");

var usuario = new Usuario();

// ==================================================
// 02 - PROPRIEDADES
// ==================================================
// Atribuímos valores às propriedades públicas
// definidas na classe Usuario.

usuario.Nome = "João";
usuario.Email = "[joao@email.com](mailto:joao@email.com)";

// ==================================================
// 03 - ENCAPSULAMENTO
// ==================================================
// A propriedade Senha é privada e, por isso,
// não pode ser acessada diretamente.
// Utilizamos um método público para alterar seu valor.

usuario.SetSenha("123456");

// ==================================================
// 04 - MÉTODOS
// ==================================================
// Chamamos um método definido dentro da classe
// para executar uma ação.

usuario.ExibirInformacoes();

// ==================================================
// 05 - HERANÇA
// ==================================================
// A classe Gerente herda características e
// comportamentos da classe Usuario.
//
// Gerente : Usuario
//
// Por isso, podemos utilizar propriedades e métodos
// que foram definidos originalmente em Usuario.

Console.WriteLine();
Console.WriteLine("Pressione qualquer tecla para visualizar as informações do Gerente...");
Console.ReadKey();

Console.Clear();

Console.WriteLine("=================================");
Console.WriteLine("       INFORMAÇÕES DO GERENTE");
Console.WriteLine("=================================");

var gerente = new Gerente();

gerente.Nome = "Carlos";
gerente.Email = "[carlos@email.com](mailto:carlos@email.com)";

// ==================================================
// 06 - PROPRIEDADES DA CLASSE DERIVADA
// ==================================================
// Além das propriedades herdadas de Usuario,
// Gerente possui propriedades próprias.

gerente.Departamento = "Tecnologia";
gerente.Nivel = 2;
gerente.Salario = 8500;
gerente.DataAdmissao = new DateTime(2024, 5, 10);

// ==================================================
// 07 - MÉTODOS DA CLASSE DERIVADA
// ==================================================
// Gerente possui seus próprios métodos,
// além dos métodos herdados de Usuario.

gerente.MudarSalario(9000);

// ==================================================
// 08 - POLIMORFISMO
// ==================================================
// ExibirInformacoes() foi definido como virtual
// em Usuario e pode ser sobrescrito em Gerente
// utilizando override.
//
// Dessa forma, o mesmo método pode apresentar
// comportamentos diferentes dependendo da classe
// que está sendo utilizada.

gerente.ExibirInformacoes();

// ==================================================
// FINALIZAÇÃO
// ==================================================

Console.WriteLine();
Console.WriteLine("=================================");
Console.WriteLine("Pressione qualquer tecla para finalizar...");
Console.ReadKey();

Console.Clear();
