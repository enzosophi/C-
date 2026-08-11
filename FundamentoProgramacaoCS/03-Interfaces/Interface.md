# Como funciona uma Interface?

Uma **interface** é um recurso muito importante da Programação Orientada a Objetos (POO).

Muitas vezes você verá uma interface sendo chamada de **"contrato"**. Isso acontece porque ela define **o que uma classe deve fazer**, mas não define necessariamente **como ela deve fazer**.

Pense em uma montadora de carros.

Antes de um carro sair da fábrica, ele precisa atender a determinados requisitos. Por exemplo:

* Possuir sistema de freios;
* Possuir motor;
* Possuir sistema de iluminação;
* Possuir cintos de segurança.

A montadora define esses requisitos, mas a forma como cada componente funciona internamente pode ser diferente.

Na programação, uma interface funciona de maneira parecida.

---

## O que uma Interface define?

Imagine que temos uma interface para trabalhar com clientes:

```csharp
public interface ICliente
{
    void ExibirListaClientes();
}
```

Nesse caso, estamos dizendo:

> **Qualquer classe que implementar `ICliente` deverá possuir o método `ExibirListaClientes()`.**

A interface não está preocupada em saber **como** a lista será obtida.

O programador poderia utilizar:

* `for`;
* `while`;
* `foreach`;
* Banco de dados;
* API;
* Uma biblioteca;
* LINQ;
* Qualquer outra lógica necessária.

O importante é que o método exigido pela interface exista e cumpra seu propósito.

---

## Implementando a Interface

Agora podemos criar uma classe que implemente nossa interface:

```csharp
public class ClienteService : ICliente
{
    public void ExibirListaClientes()
    {
        Console.WriteLine("Exibindo lista de clientes...");
    }
}
```

Ao escrever:

```csharp
public class ClienteService : ICliente
```

estamos dizendo que `ClienteService` está **implementando o contrato definido por `ICliente`**.

Se a classe não implementar o método obrigatório:

```csharp
public void ExibirListaClientes()
```

o código apresentará um erro de compilação.

---

## O que a Interface não determina?

A interface determina **o que deve existir**, mas não necessariamente **como deve funcionar**.

Por exemplo:

```csharp
public interface ICliente
{
    void ExibirListaClientes();
}
```

A interface não sabe se a implementação será:

```text
Banco de Dados
      ↓
SQL Server
      ↓
Entity Framework
```

ou:

```text
API
 ↓
HTTP
 ↓
JSON
```

ou até mesmo:

```text
Lista em memória
      ↓
foreach
```

Todas essas implementações podem cumprir o mesmo contrato.

---

## Por que isso é útil?

Imagine que inicialmente sua aplicação busca clientes diretamente de um banco de dados.

Depois, você decide que os clientes deverão ser obtidos através de uma API.

Se seu código estiver bem estruturado utilizando interfaces, podemos trocar a implementação sem necessariamente alterar todo o restante da aplicação.

Podemos ter:

```text
          ICliente
             │
       ┌─────┴─────┐
       ↓           ↓
ClienteService   ClienteApi
       │           │
       ↓           ↓
 Banco de Dados    API
```

As duas classes possuem formas diferentes de trabalhar, mas seguem o mesmo contrato.

---

## Resumindo

Podemos pensar em uma interface desta forma:

> **Interface = contrato**

Ela define:

```text
O QUE deve ser feito
```

Mas deixa para a implementação decidir:

```text
COMO será feito
```

Por isso, interfaces ajudam a criar sistemas mais **flexíveis, organizados e fáceis de modificar**.

### Uma frase para lembrar:

> **A interface define o contrato; a classe define a implementação.**
