# Generics

Os **Generics (Genéricos)** são um recurso do C# que permite criar classes, métodos, interfaces e outras estruturas de código que podem trabalhar com diferentes tipos de dados sem precisar duplicar a implementação.

Em vez de definir uma classe ou método para cada tipo (`string`, `int`, `decimal`, etc.), podemos utilizar um **parâmetro de tipo** que será definido quando o código for utilizado.

## Como funciona?

Um tipo genérico normalmente utiliza `<T>` para representar o tipo que será utilizado.

```csharp
public class NomeDaClasse<T>
{
    // Código da classe
}
```

O `T` é uma convenção que significa **Type (Tipo)**. Porém, ele não é uma palavra reservada do C#. Podemos utilizar outros nomes, desde que sejam coerentes com o que o código representa.

Por exemplo:

```csharp
public class Caixa<T>
{
    public T Valor { get; set; }
}
```

Nesse caso, `T` representa o tipo que será definido posteriormente.

Podemos utilizar a mesma classe para diferentes tipos:

```csharp
var caixaInteiro = new Caixa<int>();
var caixaTexto = new Caixa<string>();
var caixaDecimal = new Caixa<decimal>();
```

Assim, a mesma estrutura pode trabalhar com diferentes tipos sem precisar criar:

```text
CaixaInt
CaixaString
CaixaDecimal
```

## Por que utilizar Generics?

O principal objetivo é criar código **reutilizável, seguro em relação aos tipos e evitar duplicação de código**.

Imagine que precisamos criar um método que recebe um valor. Sem Generics, poderíamos precisar criar diferentes métodos:

```csharp
void Exibir(int valor)
{
    Console.WriteLine(valor);
}

void Exibir(string valor)
{
    Console.WriteLine(valor);
}

void Exibir(decimal valor)
{
    Console.WriteLine(valor);
}
```

Com Generics, podemos criar uma única implementação:

```csharp
void Exibir<T>(T valor)
{
    Console.WriteLine(valor);
}
```

E utilizá-la com diferentes tipos:

```csharp
Exibir<int>(10);
Exibir<string>("Olá");
Exibir<decimal>(10.50m);
```

O compilador identifica o tipo utilizado e mantém a segurança de tipos durante a utilização do código.

## Onde encontramos Generics no .NET?

Generics aparecem constantemente no desenvolvimento com .NET.

Um exemplo muito comum é o `List<T>`:

```csharp
List<int> numeros = new List<int>();
List<string> nomes = new List<string>();
List<Usuario> usuarios = new List<Usuario>();
```     

O `T` representa o tipo de dado que a lista irá armazenar.

Por exemplo:

```csharp
List<Usuario>
```

significa que aquela lista foi definida para armazenar objetos do tipo `Usuario`.

## Resumindo

Generics permitem criar estruturas que:

* Trabalham com diferentes tipos de dados;
* Evitam duplicação de código;
* Mantêm a segurança de tipos;
* Tornam o código mais reutilizável;
* São amplamente utilizados nas bibliotecas do .NET.

> **Ideia principal:** em vez de escrever o mesmo código várias vezes para diferentes tipos, criamos uma estrutura genérica e informamos qual tipo ela deverá utilizar quando for necessário.
