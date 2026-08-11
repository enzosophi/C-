# Como funciona a estrutura de criação de Classes

## O que são Classes?

Na programação, muitas vezes precisamos representar coisas que existem no mundo real ou conceitos que fazem parte de um sistema.

Por exemplo, imagine que estamos desenvolvendo o sistema de uma **distribuidora**. Esse sistema pode precisar representar diferentes elementos:

* Cliente
* Produto
* Funcionário
* Veículo
* Cidade
* Pedido
* Fornecedor

Cada um desses elementos possui **características** e pode realizar **ações**.

Uma forma simples de entender uma classe é pensar nela como uma **receita de bolo**.

A receita não é o bolo em si. Ela define quais ingredientes e etapas são necessários para criar o bolo.

Da mesma forma, uma **classe é uma estrutura que define quais informações e comportamentos um determinado objeto pode possuir**.

---

## Classes como uma "receita"

Imagine que precisamos representar um cliente no nosso sistema.

Um cliente pode possuir características como:

```text
Nome
CPF
Telefone
Idade
E-mail
Endereço
```

Se não utilizássemos classes, poderíamos acabar criando várias variáveis separadas:

```csharp
string nome;
string cpf;
string telefone;
int idade;
string email;
```

Isso funciona, mas conforme o sistema cresce, organizar essas informações dessa maneira pode se tornar complicado.

Em vez disso, podemos criar uma classe:

```csharp
public class Cliente
{
    public string Nome { get; set; }
    public string CPF { get; set; }
    public string Telefone { get; set; }
    public int Idade { get; set; }
    public string Email { get; set; }
}
```

Agora temos uma estrutura que representa um **Cliente**.

---

## Classe não é o mesmo que objeto

É importante entender essa diferença.

A **classe** funciona como o modelo ou a receita.

O **objeto** é uma instância criada a partir dessa classe.

Por exemplo:

```csharp
Cliente cliente1 = new Cliente();

cliente1.Nome = "João";
cliente1.CPF = "12345678900";
cliente1.Idade = 30;
```

Nesse exemplo:

```text
Classe:
Cliente

Objeto:
cliente1
```

Podemos criar vários objetos utilizando a mesma classe:

```csharp
Cliente cliente1 = new Cliente();
Cliente cliente2 = new Cliente();
Cliente cliente3 = new Cliente();
```

Todos são objetos do tipo `Cliente`, mas cada um pode possuir informações diferentes.

---

# Atributos e Propriedades

Quando falamos que um cliente possui características, estamos falando dos **dados que descrevem esse objeto**.

Em C#, normalmente representamos essas informações utilizando **propriedades**:

```csharp
public string Nome { get; set; }
public string CPF { get; set; }
public int Idade { get; set; }
```

Podemos pensar nelas como informações que pertencem ao objeto.

Por exemplo:

```text
Cliente
│
├── Nome
├── CPF
├── Telefone
└── Idade
```

Cada objeto `Cliente` poderá possuir seus próprios valores.

---

# Métodos: ações que o objeto pode realizar

Uma classe não serve apenas para armazenar informações.

Ela também pode possuir **métodos**, que representam comportamentos ou ações que aquele objeto pode realizar.

Por exemplo, um cliente pode possuir uma ação para atualizar seus dados:

```csharp
public class Cliente
{
    public string Nome { get; set; }
    public string Telefone { get; set; }

    public void AtualizarTelefone(string novoTelefone)
    {
        Telefone = novoTelefone;
    }
}
```

Agora podemos utilizar:

```csharp
Cliente cliente = new Cliente();

cliente.Nome = "João";
cliente.Telefone = "11999999999";

cliente.AtualizarTelefone("11888888888");
```

O método:

```csharp
AtualizarTelefone()
```

representa uma **ação** que o objeto pode realizar.

---

# Por que utilizar Classes?

Imagine um sistema grande contendo:

```text
10.000 Clientes
5.000 Produtos
300 Funcionários
200 Veículos
50 Cidades
```

Se todas as informações fossem armazenadas em variáveis espalhadas pelo código, seria muito difícil organizar e manter esse sistema.

As classes permitem **agrupar dados e comportamentos relacionados**, deixando o código mais organizado.

Além disso, elas são fundamentais para conceitos importantes da programação orientada a objetos, como:

* Encapsulamento
* Herança
* Polimorfismo
* Abstração

Esses conceitos serão estudados posteriormente.

---

# Um exemplo mais próximo de um sistema real

Imagine que temos uma distribuidora.

Podemos representar nosso sistema dessa maneira:

```text
Distribuidora
│
├── Cliente
│   ├── Nome
│   ├── CPF
│   ├── Telefone
│   └── Endereço
│
├── Produto
│   ├── Nome
│   ├── Preço
│   ├── Estoque
│   └── Código
│
├── Funcionário
│   ├── Nome
│   ├── CPF
│   ├── Cargo
│   └── Salário
│
└── Veículo
    ├── Placa
    ├── Modelo
    ├── Marca
    └── Ano
```

Cada classe representa uma parte do sistema.

E cada objeto criado a partir dessas classes representa uma entidade específica.

Por exemplo:

```text
Classe: Cliente

Objetos:

cliente1 → João
cliente2 → Maria
cliente3 → Carlos
```

A classe define **como um Cliente deve ser representado**.

Os objetos armazenam **os dados específicos de cada Cliente**.

---

# 📌 Resumindo

Podemos pensar da seguinte maneira:

```text
CLASSE
   ↓
Define a estrutura
   ↓
Propriedades + Métodos
   ↓
Permite criar OBJETOS
   ↓
Cada objeto possui seus próprios dados
```

Ou, de uma maneira ainda mais simples:

> **Classe = modelo/receita**
>
> **Objeto = algo criado a partir desse modelo**
>
> **Propriedade = característica**
>
> **Método = ação/comportamento**

---

## O que você aprenderá neste bloco?

Neste bloco, você entenderá como as classes funcionam e por que elas são tão importantes no desenvolvimento de software.

Ao longo dos próximos conteúdos, veremos:

- [x] Como criar uma classe em C#  
- [x] Como criar objetos
- [x] Propriedades
- [x] Métodos
- [x] Modificadores de acesso
- [x] Encapsulamento
- [x] Herança
- [x] Polimorfismo
- [x] Abstração

O objetivo é que, ao final desse bloco, você não apenas saiba **criar uma classe**, mas também entenda **quando e por que utilizá-la em um projeto real**.
