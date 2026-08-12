using Linqs.Models;
using Linqs.Services;
using System.Linq;

// Instancia o Service responsável pelo gerenciamento dos usuários.
UsuarioService service = new UsuarioService();

// Lista de usuários que serão cadastrados.
// Cada posição possui o nome e a idade do usuário.
var usuarios = new[]
{
    new { Nome = "Enzo Pinheiro de Oliveira", Idade = 20 },
    new { Nome = "Valentina Souza Santos", Idade = 17 },
    new { Nome = "Gabriel Rodrigues Silva", Idade = 25 },
    new { Nome = "Maria Eduarda Costa", Idade = 19 },
    new { Nome = "Lucas Ferreira Lima", Idade = 30 },
    new { Nome = "Beatriz Alves Pereira", Idade = 16 },
    new { Nome = "João Pedro Carvalho", Idade = 22 },
    new { Nome = "Ana Clara Ribeiro", Idade = 28 },
    new { Nome = "Matheus Gomes Martins", Idade = 35 },
    new { Nome = "Laura Barbosa Almeida", Idade = 21 },
    new { Nome = "Felipe Melo Soares", Idade = 18 },
    new { Nome = "Mariana Rocha Dias", Idade = 24 },
    new { Nome = "Guilherme Silva Santos", Idade = 31 },
    new { Nome = "Camila Fernandes Cruz", Idade = 15 },
    new { Nome = "Thiago Neves Rocha", Idade = 27 },
    new { Nome = "Larissa Mendes Cavalcanti", Idade = 23 },
    new { Nome = "Bruno Castro Oliveira", Idade = 40 },
    new { Nome = "Isabela Vieira Nunes", Idade = 17 },
    new { Nome = "Rodrigo Cardoso Machado", Idade = 33 },
    new { Nome = "Amanda Teixeira Freitas", Idade = 26 }
};


// ==========================================
// CADASTRANDO USUÁRIOS
// ==========================================

// Percorre a lista de usuários e adiciona cada um
// através do Service.
foreach (var usuario in usuarios)
{
    Usuario novoUsuario = new Usuario
    {
        Nome = usuario.Nome,
        Idade = usuario.Idade
    };

    service.AdicionarUsuario(novoUsuario);
}


// ==========================================
// OBTENDO TODOS OS USUÁRIOS
// ==========================================

List<Usuario> listaUsuarios = service.RetornarTodosUsuario();

Console.WriteLine("=================================");
Console.WriteLine("       TODOS OS USUÁRIOS");
Console.WriteLine("=================================");

foreach (var usuario in listaUsuarios)
{
    Console.WriteLine(
        $"ID: {usuario.Id} | " +
        $"Nome: {usuario.Nome} | " +
        $"Idade: {usuario.Idade}"
    );
}


// ==========================================
// FILTRO POR PRIMEIRA LETRA
// ==========================================

// Where() filtra os elementos de uma coleção.
//
// Neste caso, estamos buscando apenas os usuários
// cujo nome começa com a letra "A".
Console.WriteLine();
Console.WriteLine("=================================");
Console.WriteLine("       NOMES COM A LETRA A");
Console.WriteLine("=================================");

foreach (var usuario in listaUsuarios.Where(u => u.Nome.StartsWith("A")))
{
    Console.WriteLine(
        $"ID: {usuario.Id} | " +
        $"Nome: {usuario.Nome}"
    );
}


// ==========================================
// FILTRO POR ID
// ==========================================

// Busca somente os usuários cujo ID é maior que 10.
Console.WriteLine();
Console.WriteLine("=================================");
Console.WriteLine("       USUÁRIOS COM ID > 10");
Console.WriteLine("=================================");

foreach (var usuario in listaUsuarios.Where(u => u.Id > 10))
{
    Console.WriteLine(
        $"ID: {usuario.Id} | " +
        $"Nome: {usuario.Nome}"
    );
}


// ==========================================
// FILTRO POR IDADE
// ==========================================

// Busca somente usuários maiores de idade.
Console.WriteLine();
Console.WriteLine("=================================");
Console.WriteLine("       MAIORES DE IDADE");
Console.WriteLine("=================================");

foreach (var usuario in listaUsuarios.Where(u => u.Idade >= 18))
{
    Console.WriteLine(
        $"Nome: {usuario.Nome} | " +
        $"Idade: {usuario.Idade}"
    );
}


// ==========================================
// MÉDIA DE IDADE
// ==========================================

// Average() calcula a média dos valores de uma coleção.
//
// O Select() pega somente a propriedade Idade
// de cada usuário.
double mediaIdade = listaUsuarios
    .Select(u => u.Idade)
    .Average();

Console.WriteLine();
Console.WriteLine("=================================");
Console.WriteLine("       MÉDIA DE IDADE");
Console.WriteLine("=================================");
Console.WriteLine($"Média de idade: {mediaIdade:F1} anos");


// ==========================================
// MAIOR IDADE
// ==========================================

// Max() retorna o maior valor encontrado.
int maiorIdade = listaUsuarios
    .Select(u => u.Idade)
    .Max();

Console.WriteLine();
Console.WriteLine($"Maior idade cadastrada: {maiorIdade} anos");


// ==========================================
// MENOR IDADE
// ==========================================

// Min() retorna o menor valor encontrado.
int menorIdade = listaUsuarios
    .Select(u => u.Idade)
    .Min();

Console.WriteLine($"Menor idade cadastrada: {menorIdade} anos");


// ==========================================
// ORDENANDO POR IDADE
// ==========================================

// OrderBy() organiza os usuários em ordem crescente
// de acordo com a idade.
Console.WriteLine();
Console.WriteLine("=================================");
Console.WriteLine("       ORDENADOS POR IDADE");
Console.WriteLine("=================================");

foreach (var usuario in listaUsuarios.OrderBy(u => u.Idade))
{
    Console.WriteLine(
        $"Nome: {usuario.Nome} | " +
        $"Idade: {usuario.Idade}"
    );
}