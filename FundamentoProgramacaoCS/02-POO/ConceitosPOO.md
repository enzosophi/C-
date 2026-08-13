# 📚 Programação Orientada a Objetos (POO) — C#

Este material apresenta os principais conceitos de **Programação Orientada a Objetos (POO)** utilizando C#.

A ideia é utilizar este documento como referência para os códigos do módulo, mantendo um padrão de explicação simples e prático.

---

# 1. O que é POO?

**Programação Orientada a Objetos (POO)** é um paradigma de programação que organiza o código utilizando **objetos**.

Um objeto pode representar algo do mundo real ou uma entidade do sistema.

```csharp
Usuario usuario = new Usuario();
```

Nesse caso:

* `Usuario` → é a **classe**;
* `usuario` → é o **objeto**;
* `new Usuario()` → cria uma **instância** da classe.

A POO ajuda na:

* organização do código;
* reutilização;
* manutenção;
* separação de responsabilidades;
* escalabilidade.

---

# 2. Classe

Uma **classe** funciona como um modelo para criação de objetos.

Ela pode possuir:

* propriedades;
* métodos;
* construtores;
* campos;
* comportamentos.

```csharp
public class Usuario
{
    public string Nome { get; set; }

    public string Email { get; set; }

    public void ExibirInformacoes()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Email: {Email}");
    }
}
```

A classe define **o que um usuário possui** e **o que um usuário pode fazer**.

---

# 3. Objeto

O **objeto** é uma instância de uma classe.

```csharp
var usuario = new Usuario();
```

Podemos utilizar as propriedades e métodos definidos pela classe:

```csharp
usuario.Nome = "João";
usuario.Email = "joao@email.com";

usuario.ExibirInformacoes();
```

Podemos ter vários objetos criados a partir da mesma classe:

```csharp
var usuario1 = new Usuario();
var usuario2 = new Usuario();
var usuario3 = new Usuario();
```

Todos possuem a mesma estrutura definida pela classe, mas podem possuir valores diferentes.

---

# 4. Instanciação

**Instanciar** significa criar um objeto a partir de uma classe.

```csharp
var usuario = new Usuario();
```

O operador `new` cria uma nova instância da classe.

```text
Classe
  ↓
Usuario
  ↓
new Usuario()
  ↓
Objeto
```

---

# 5. Propriedades

As **propriedades** representam características de um objeto.

```csharp
public string Nome { get; set; }

public string Email { get; set; }

public decimal Salario { get; set; }
```

Podemos atribuir valores:

```csharp
usuario.Nome = "João";
usuario.Email = "joao@email.com";
```

### `get` e `set`

```csharp
public string Nome { get; set; }
```

* `get` → permite obter o valor;
* `set` → permite alterar o valor.

---

# 6. Propriedade calculada

Uma propriedade pode calcular seu valor a partir de outras propriedades.

```csharp
public string NomeCompleto
{
    get
    {
        return $"{Nome} {Sobrenome}";
    }
}
```

Se tivermos:

```csharp
Nome = "João";
Sobrenome = "Silva";
```

Então:

```csharp
NomeCompleto
```

retornará:

```text
João Silva
```

---

# 7. Métodos

**Métodos** representam comportamentos ou ações que um objeto pode executar.

```csharp
public void MudarEmail(string novoEmail)
{
    Email = novoEmail;
}
```

Podemos utilizar:

```csharp
usuario.MudarEmail("novo@email.com");
```

Outro exemplo:

```csharp
public void MudarSalario(decimal novoSalario)
{
    Salario = novoSalario;
}
```

---

# 8. Encapsulamento

O **encapsulamento** é um dos principais conceitos da POO.

Ele consiste em controlar o acesso aos dados e comportamentos de uma classe.

Por exemplo:

```csharp
private string Senha { get; set; }
```

A propriedade `Senha` não pode ser acessada diretamente de fora da classe.

Em vez disso, podemos fornecer um método:

```csharp
public void SetSenha(string senha)
{
    Senha = senha;
}
```

E utilizar:

```csharp
usuario.SetSenha("123456");
```

Assim, a classe controla como sua senha será alterada.

---

# 9. Modificadores de acesso

Os modificadores determinam quem pode acessar determinado membro.

## `public`

Pode ser acessado de fora da classe.

```csharp
public string Nome { get; set; }
```

## `private`

Pode ser acessado somente dentro da própria classe.

```csharp
private string Senha { get; set; }
```

## `protected`

Pode ser acessado pela própria classe e por classes derivadas.

```csharp
protected string Nome;
```

É bastante utilizado em **herança**.

## `internal`

Permite acesso dentro do mesmo projeto/assembly.

```csharp
internal class Usuario
{
}
```

---

# 10. Herança

A **herança** permite que uma classe reutilize características e comportamentos de outra.

```csharp
public class Gerente : Usuario
```

Temos:

```text
Usuario
   ↑
   |
Gerente
```

`Usuario` é a **classe base**.

`Gerente` é a **classe derivada**.

Por isso, `Gerente` pode utilizar propriedades de `Usuario`:

```csharp
gerente.Nome = "Carlos";
gerente.Email = "carlos@email.com";
```

Mesmo que essas propriedades tenham sido declaradas originalmente em `Usuario`.

---

# 11. Classe base

É a classe que fornece características para outra classe.

```csharp
public class Usuario
{
    public string Nome { get; set; }

    public string Email { get; set; }
}
```

---

# 12. Classe derivada

É a classe que herda de outra.

```csharp
public class Gerente : Usuario
{
    public decimal Salario { get; set; }
}
```

`Gerente` recebe as características de `Usuario` e ainda pode possuir características próprias.

```text
Usuario
├── Nome
├── Email
└── ExibirInformacoes()

        ↓ herança

Gerente
├── Nome
├── Email
├── ExibirInformacoes()
└── Salario
```

---

# 13. Polimorfismo

**Polimorfismo** significa que um mesmo método pode apresentar comportamentos diferentes dependendo do objeto que está sendo utilizado.

Na classe base:

```csharp
public virtual void ExibirInformacoes()
{
    Console.WriteLine($"Nome: {Nome}");
    Console.WriteLine($"Email: {Email}");
}
```

Na classe derivada:

```csharp
public override void ExibirInformacoes()
{
    base.ExibirInformacoes();

    Console.WriteLine($"Salário: {Salario}");
}
```

O método possui o mesmo nome, mas pode apresentar comportamentos diferentes.

---

# 14. `virtual`

`virtual` indica que um método pode ser sobrescrito por uma classe derivada.

```csharp
public virtual void ExibirInformacoes()
{
    Console.WriteLine($"Nome: {Nome}");
}
```

Isso permite que uma classe derivada utilize `override`.

---

# 15. `override`

`override` é utilizado para sobrescrever um método `virtual` ou `abstract` da classe base.

```csharp
public override void ExibirInformacoes()
{
    Console.WriteLine($"Nome: {Nome}");
    Console.WriteLine($"Salário: {Salario}");
}
```

A classe derivada fornece uma nova implementação para o método.

---

# 16. `base`

A palavra-chave `base` permite acessar membros da classe base.

```csharp
base.ExibirInformacoes();
```

Nesse caso, `Gerente` está chamando a implementação original do método em `Usuario`.

Isso permite reutilizar o comportamento da classe base e depois adicionar novos comportamentos.

```csharp
public override void ExibirInformacoes()
{
    base.ExibirInformacoes();

    Console.WriteLine($"Salário: {Salario}");
}
```

---

# 17. Abstração

A **abstração** consiste em representar apenas o que é necessário para determinado contexto, escondendo detalhes de implementação.

Em C#, podemos utilizar classes abstratas:

```csharp
public abstract class Usuario
{
    public string Nome { get; set; }

    public abstract void ExibirInformacoes();
}
```

Uma classe `abstract` não pode ser instanciada diretamente:

```csharp
var usuario = new Usuario(); // ❌
```

Ela serve como estrutura base para outras classes.

---

# 18. Método abstrato

Um método abstrato não possui implementação na classe base.

```csharp
public abstract void ExibirInformacoes();
```

Uma classe derivada precisa implementar esse método:

```csharp
public class Gerente : Usuario
{
    public override void ExibirInformacoes()
    {
        Console.WriteLine($"Nome: {Nome}");
    }
}
```

---

# 19. Interface

Uma **interface** define um contrato que uma classe deve seguir.

```csharp
public interface IUsuarioService
{
    void CadastrarUsuario(Usuario usuario);

    void AtualizarUsuario(Usuario usuario);

    void ExcluirUsuario(int id);
}
```

Uma classe que implementar essa interface precisa fornecer esses métodos:

```csharp
public class UsuarioService : IUsuarioService
{
    public void CadastrarUsuario(Usuario usuario)
    {
        // implementação
    }

    public void AtualizarUsuario(Usuario usuario)
    {
        // implementação
    }

    public void ExcluirUsuario(int id)
    {
        // implementação
    }
}
```

A interface define **o que deve existir**, enquanto a classe define **como aquilo será executado**.

---

# 20. Implementação de interface

Utilizamos `:` para indicar que uma classe implementa uma interface:

```csharp
public class UsuarioService : IUsuarioService
```

A classe assume a responsabilidade de implementar os membros definidos no contrato.

---

# 21. Construtor

O **construtor** é executado quando um objeto é criado.

```csharp
public class Usuario
{
    public string Nome { get; set; }

    public Usuario()
    {
        Nome = "Usuário";
    }
}
```

Ao executar:

```csharp
var usuario = new Usuario();
```

o construtor será chamado automaticamente.

---

# 22. Construtor com parâmetros

Podemos exigir informações durante a criação do objeto:

```csharp
public class Usuario
{
    public string Nome { get; set; }

    public Usuario(string nome)
    {
        Nome = nome;
    }
}
```

Agora:

```csharp
var usuario = new Usuario("João");
```

---

# 23. Sobrecarga de métodos — Overloading

Podemos possuir vários métodos com o mesmo nome, desde que seus parâmetros sejam diferentes.

```csharp
public void Exibir(string nome)
{
    Console.WriteLine(nome);
}

public void Exibir(string nome, int idade)
{
    Console.WriteLine($"{nome} - {idade}");
}
```

O C# identifica qual método utilizar com base nos parâmetros fornecidos.

---

# 24. Sobrecarga de construtores

O mesmo conceito pode ser aplicado aos construtores:

```csharp
public Usuario()
{
}

public Usuario(string nome)
{
    Nome = nome;
}

public Usuario(string nome, string email)
{
    Nome = nome;
    Email = email;
}
```

Podemos criar objetos de diferentes maneiras:

```csharp
var usuario1 = new Usuario();

var usuario2 = new Usuario("João");

var usuario3 = new Usuario("João", "joao@email.com");
```

---

# 25. Composição

**Composição** acontece quando uma classe possui outra classe como parte de sua estrutura.

```csharp
public class Endereco
{
    public string Cidade { get; set; }
}

public class Usuario
{
    public string Nome { get; set; }

    public Endereco Endereco { get; set; }
}
```

Agora um `Usuario` possui um `Endereco`.

```text
Usuario
├── Nome
└── Endereco
    └── Cidade
```

Podemos pensar em composição como uma relação de:

> **"possui um"**

Enquanto a herança representa:

> **"é um"**

Exemplo:

```text
Gerente é um Usuario

Usuario possui um Endereco
```

---

# 26. Associação

Associação representa uma relação entre objetos.

Por exemplo:

```csharp
public class Departamento
{
    public string Nome { get; set; }
}

public class Gerente
{
    public Departamento Departamento { get; set; }
}
```

O gerente possui uma relação com um departamento.

---

# 27. Agregação

A agregação é uma relação em que um objeto utiliza outro, mas os objetos podem existir independentemente.

Por exemplo:

```text
Empresa
   ↓
Funcionários
```

Os funcionários podem existir como objetos independentemente da empresa.

É uma relação mais fraca do que composição.

---

# 28. Os 4 pilares da POO

Os quatro conceitos tradicionalmente considerados os principais pilares da POO são:

```text
┌──────────────────────────┐
│           POO            │
├──────────────────────────┤
│ 1. Encapsulamento        │
│ 2. Herança               │
│ 3. Polimorfismo          │
│ 4. Abstração             │
└──────────────────────────┘
```

## Encapsulamento

Controla o acesso aos dados e comportamentos.

```csharp
private string Senha;
```

## Herança

Permite reutilizar características de uma classe.

```csharp
public class Gerente : Usuario
```

## Polimorfismo

Permite diferentes comportamentos através de um mesmo método ou contrato.

```csharp
public virtual void ExibirInformacoes()
```

```csharp
public override void ExibirInformacoes()
```

## Abstração

Representa apenas os aspectos necessários e esconde detalhes de implementação.

```csharp
public abstract class Usuario
```

ou:

```csharp
public interface IUsuarioService
```

---

# 29. Resumo dos conceitos

| Conceito       | O que significa                        | Exemplo                  |
| -------------- | -------------------------------------- | ------------------------ |
| Classe         | Modelo para objetos                    | `class Usuario`          |
| Objeto         | Instância de uma classe                | `new Usuario()`          |
| Propriedade    | Característica do objeto               | `Nome`                   |
| Método         | Comportamento do objeto                | `MudarEmail()`           |
| Encapsulamento | Controle de acesso                     | `private Senha`          |
| Herança        | Reutilização entre classes             | `Gerente : Usuario`      |
| Polimorfismo   | Diferentes comportamentos              | `virtual` / `override`   |
| Abstração      | Esconder detalhes desnecessários       | `abstract`               |
| Interface      | Contrato                               | `IUsuarioService`        |
| Construtor     | Inicialização do objeto                | `Usuario()`              |
| Overloading    | Mesmo método com parâmetros diferentes | `Exibir()`               |
| Composição     | Objeto possui outro objeto             | `Usuario → Endereco`     |
| Associação     | Relação entre objetos                  | `Gerente → Departamento` |
| Agregação      | Relação entre objetos independentes    | `Empresa → Funcionários` |

---

# 30. Mapa mental

```text
                    POO
                     │
       ┌─────────────┼─────────────┐
       │             │             │
    Classes        Objetos      Métodos
       │
       ├── Propriedades
       ├── Construtores
       └── Comportamentos

       Pilares
          │
   ┌──────┼────────┬──────────┐
   │      │        │          │
Encaps.  Herança  Polim.   Abstração
   │      │        │          │
 private  :      virtual    abstract
 public           override   interface
```

---

# 31. Padrão de documentação dos códigos

Para os códigos deste módulo, podemos utilizar o seguinte padrão:

```csharp
// ==================================================
// NOME DO CONCEITO
// ==================================================

// Explicação simples do que está acontecendo.
//
// Explicação da palavra-chave utilizada.
//
// Exemplo de utilização:
```

A organização dos exemplos pode seguir:

```text
01 - Classes
02 - Objetos
03 - Propriedades
04 - Métodos
05 - Encapsulamento
06 - Construtores
07 - Herança
08 - Polimorfismo
09 - Abstração
10 - Interfaces
11 - Composição
12 - Associação
13 - Agregação
14 - Sobrecarga
```

---

## 📌 Objetivo do módulo

O objetivo deste módulo é compreender os principais conceitos da **Programação Orientada a Objetos em C#** através de exemplos práticos.

Os códigos devem priorizar:

* clareza;
* exemplos simples;
* comentários explicativos;
* aplicação prática;
* organização;
* reutilização de conceitos.

> **A ideia não é apenas decorar os conceitos de POO, mas entender quando e por que utilizá-los em um projeto real.**
