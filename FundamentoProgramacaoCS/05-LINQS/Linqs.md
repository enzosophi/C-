# O que é o LINQ?

> ⚠️ **Observação importante:** Este roadmap é destinado a pessoas que **já possuem conhecimentos básicos de programação**.

## Origem do nome

**LINQ** é a sigla para **Language-Integrated Query**, ou "Consulta Integrada à Linguagem". Como o próprio nome sugere, trata-se de um conjunto de recursos do C# (e de outras linguagens .NET) que permite escrever consultas diretamente dentro do código, de forma integrada à sintaxe da linguagem — sem a necessidade de usar uma linguagem de consulta separada, como o SQL.

## Para que serve

O LINQ funciona de maneira parecida com fórmulas de Excel ou consultas de banco de dados, mas com suas próprias peculiaridades. Ele pode ser usado sobre praticamente qualquer coleção de dados em memória (listas, arrays, dicionários) e também sobre fontes externas, como bancos de dados, arquivos XML e serviços web — não se limitando, portanto, a bancos de dados relacionais.

Entre suas funções principais, o LINQ permite:

- **Filtrar** itens de uma coleção (ex: selecionar apenas pessoas com idade maior que 18 anos);
- **Ordenar** dados por um ou mais critérios;
- **Agrupar** itens com características em comum;
- **Projetar** (transformar) os dados em um novo formato;
- **Agregar** valores, como somas, médias e contagens.

Essas operações tornam o LINQ uma ferramenta poderosa para gerar *insights* a partir de coleções de dados, com uma sintaxe legível e concisa.

## Exemplo prático

```csharp
List<Pessoa> pessoas = new List<Pessoa>
{
    new Pessoa { Nome = "Ana", Idade = 22 },
    new Pessoa { Nome = "Bruno", Idade = 17 },
    new Pessoa { Nome = "Carla", Idade = 30 }
};

// Sintaxe de método
var maioresDeIdade = pessoas
    .Where(p => p.Idade > 18)
    .OrderBy(p => p.Nome)
    .ToList();

// Sintaxe de consulta (query syntax)
var maioresDeIdadeQuery =
    from p in pessoas
    where p.Idade > 18
    orderby p.Nome
    select p;
```

Ambas as sintaxes acima produzem o mesmo resultado: uma lista contendo apenas as pessoas maiores de idade, ordenadas por nome. A escolha entre elas é, na maioria dos casos, uma questão de estilo e legibilidade.

## Próximos passos

Nas próximas seções deste roadmap, vamos explorar os principais métodos do LINQ (`Where`, `Select`, `OrderBy`, `GroupBy`, entre outros) e entender como cada um deles se aplica na prática.