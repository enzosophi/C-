using Classes.Class;

// Limpa o terminal antes de iniciar o programa.
Console.Clear();

Console.WriteLine("=================================");
Console.WriteLine("       INFORMAÇÕES DO USUÁRIO");
Console.WriteLine("=================================");

var usuario = new Usuario();

usuario.Nome = "João";
usuario.Email = "joao@email.com";

usuario.SetSenha("123456");

usuario.ExibirInformacoes();


// Aguarda o usuário pressionar uma tecla antes de continuar.
Console.WriteLine();
Console.WriteLine("Pressione qualquer tecla para visualizar as informações do Gerente...");
Console.ReadKey();


// Limpa o terminal para deixar a próxima demonstração organizada.
Console.Clear();

Console.WriteLine("=================================");
Console.WriteLine("       INFORMAÇÕES DO GERENTE");
Console.WriteLine("=================================");

var gerente = new Gerente();

gerente.Nome = "Carlos";
gerente.Email = "carlos@email.com";
gerente.Departamento = "Tecnologia";
gerente.Nivel = 2;
gerente.Salario = 8500;
gerente.DataAdmissao = new DateTime(2024, 5, 10);

gerente.MudarSalario(9000);

// Exibe as informações específicas do Gerente.
gerente.ExibirInformacoes();


// Aguarda antes de finalizar o programa.
Console.WriteLine();
Console.WriteLine("=================================");
Console.WriteLine("Pressione qualquer tecla para finalizar...");
Console.ReadKey();

Console.Clear();
