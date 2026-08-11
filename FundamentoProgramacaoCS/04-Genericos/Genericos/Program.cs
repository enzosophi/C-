using Genericos.Generics;
using Genericos.Models;

// Cria um objeto do tipo Pessoa.
var pessoa = new Pessoa
{
    Nome = "João",
    Idade = 20
};

// Define Pessoa como o tipo utilizado pela classe genérica.
var pessoaGenerica = new ClassGenerics<Pessoa>(pessoa);

// Exibe o objeto armazenado na classe genérica.
pessoaGenerica.Exibir();