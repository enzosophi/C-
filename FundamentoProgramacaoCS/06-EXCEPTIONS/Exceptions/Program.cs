using Exceptions.Services;
using Exceptions.Models;


// ==================================================
// MÉTODO PARA CONTINUAR
// ==================================================
// Pausa a execução do programa até o usuário
// pressionar qualquer tecla.

static void Continuar()
{
    Console.WriteLine();
    Console.WriteLine("Pressione qualquer tecla para continuar...");
    Console.ReadKey();
    Console.Clear();
}


// ==================================================
// CRIAÇÃO DO SERVICE
// ==================================================

var projetoService = new ProjetoServices();


// ==================================================
// CRIAÇÃO DO PROJETO
// ==================================================

var projeto1 = new Projeto(
    "Curso de estagiário para Junior em C#",
    new DateTime(2026, 8, 10)
);


// O Service é responsável por gerar o ID
// e armazenar o projeto.

projetoService.CriarProjeto(projeto1);


// ==================================================
// TESTE 1 - BUSCAR PROJETO
// ==================================================

Console.WriteLine("================================");
Console.WriteLine("       TESTE DE EXCEPTION");
Console.WriteLine("================================");

try
{
    var projeto = projetoService.BuscarProjetoId(1);

    Console.WriteLine($"Projeto: {projeto.Nome}");
    Console.WriteLine($"ID: {projeto.Id}");
    Console.WriteLine($"Data de início: {projeto.DataInicio:dd/MM/yyyy}");
}
catch (Exception ex)
{
    Console.WriteLine($"Erro: {ex.Message}");
}

Continuar();


// ==================================================
// TESTE 2 - DATA INVÁLIDA
// ==================================================

Console.WriteLine("================================");
Console.WriteLine("       TESTE DE DATA");
Console.WriteLine("================================");

try
{
    var projeto2 = new Projeto(
        "Projeto Teste",
        new DateTime(2026, 13, 40)
    );

    projetoService.CriarProjeto(projeto2);
}
catch (ArgumentOutOfRangeException ex)
{
    Console.WriteLine($"Erro: {ex.Message}");
}

Continuar();


// ==================================================
// TESTE 3 - DIVISÃO POR ZERO
// ==================================================
//No modelo apresentado o código dá erro antes mesmo de rodar, mas esse é um exemplo de erro utilizado pelo Exception


// Console.WriteLine("================================");
// Console.WriteLine("       TESTE DE DIVISÃO");
// Console.WriteLine("================================");

// try
// {
//     int resultado = 10 / 0;
// }
// catch (DivideByZeroException)
// {
//     Console.WriteLine("Erro: não é possível dividir por zero.");
// }

Continuar();


// ==================================================
// FINALIZAÇÃO
// ==================================================

Console.WriteLine("Todos os testes foram executados!");