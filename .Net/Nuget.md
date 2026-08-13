# 📦 Para que serve o NuGet?

O **NuGet** é o gerenciador de pacotes do ecossistema **.NET**.

Ele permite instalar, atualizar, remover e gerenciar **bibliotecas e ferramentas de terceiros** que podem ser utilizadas em projetos C#.

Em vez de baixar manualmente uma biblioteca pelo site do desenvolvedor, podemos utilizar o NuGet para adicionar essa dependência diretamente ao projeto através do terminal ou de uma IDE.

Por exemplo:

```bash
dotnet add package Newtonsoft.Json
```

Depois desse comando, o pacote passa a fazer parte das dependências do projeto.

---

# 🤔 Por que utilizar o NuGet?

## 📚 1. Gerenciamento de bibliotecas

Imagine que estamos desenvolvendo uma aplicação e precisamos utilizar uma biblioteca chamada **Biblioteca A**.

Porém, a Biblioteca A depende de outra biblioteca chamada **Biblioteca B**.

O NuGet consegue identificar e instalar as **dependências necessárias** para que o pacote funcione corretamente.

Isso evita que o desenvolvedor precise procurar e instalar manualmente cada biblioteca.

---

## 🔄 2. Controle de versões

O NuGet permite definir qual versão de um pacote queremos utilizar.

Por exemplo:

```bash
dotnet add package Newtonsoft.Json --version 13.0.3
```

Isso é importante porque uma versão mais recente de uma biblioteca pode apresentar alterações incompatíveis com o código existente.

Dessa forma, podemos controlar quais versões estão sendo utilizadas no projeto.

> ⚠️ O NuGet não atualiza automaticamente todos os pacotes por padrão. A atualização das dependências precisa ser realizada pelo desenvolvedor ou por ferramentas/processos configurados para isso.

---

## 👥 3. Padronização da equipe

Quando adicionamos um pacote NuGet ao projeto, essa dependência fica registrada no arquivo `.csproj`.

Por exemplo:

```xml
<ItemGroup>
    <PackageReference Include="Newtonsoft.Json" Version="13.0.3" />
</ItemGroup>
```

Isso é extremamente útil em projetos desenvolvidos por várias pessoas.

Imagine que um programador adicionou uma biblioteca ao projeto e enviou o código para o Git.

Outro desenvolvedor pode simplesmente clonar o projeto e executar:

```bash
dotnet restore
```

O .NET irá analisar as dependências do projeto e restaurar os pacotes necessários.

Assim, todos os desenvolvedores conseguem trabalhar com as mesmas dependências e versões definidas no projeto.

---

## 📦 4. Instalação pelo CLI

Podemos instalar pacotes diretamente pelo terminal:

```bash
dotnet add package NomeDoPacote
```

Exemplo:

```bash
dotnet add package Newtonsoft.Json
```

Também podemos especificar uma versão:

```bash
dotnet add package Newtonsoft.Json --version 13.0.3
```

---

## 🗑️ 5. Removendo pacotes

Caso uma biblioteca não seja mais necessária:

```bash
dotnet remove package Newtonsoft.Json
```

---

## 🔍 6. Visualizando os pacotes instalados

Podemos consultar quais pacotes o projeto utiliza:

```bash
dotnet list package
```

Isso facilita a identificação das dependências utilizadas pela aplicação.

---

## 🔄 7. Restaurando os pacotes

Quando baixamos um projeto existente, as bibliotecas podem não estar presentes localmente.

Podemos restaurá-las utilizando:

```bash
dotnet restore
```

O comando verifica as dependências definidas no projeto e baixa os pacotes necessários.

---

# 🧠 Como o NuGet se encaixa no projeto?

Quando adicionamos um pacote:

```bash
dotnet add package Newtonsoft.Json
```

o projeto registra essa dependência no arquivo `.csproj`:

```xml
<ItemGroup>
    <PackageReference Include="Newtonsoft.Json" Version="13.0.3" />
</ItemGroup>
```

Podemos pensar no fluxo dessa forma:

```text
Projeto C#
     │
     ▼
Arquivo .csproj
     │
     ▼
PackageReference
     │
     ▼
NuGet
     │
     ▼
Pacote + Dependências
```

---

# 📋 Principais comandos

| Comando | Função |
|---|---|
| `dotnet add package` | Adiciona um pacote |
| `dotnet remove package` | Remove um pacote |
| `dotnet list package` | Lista os pacotes utilizados |
| `dotnet restore` | Restaura as dependências |
| `dotnet build` | Compila o projeto e pode restaurar dependências quando necessário |

---

# 🎯 Resumindo

O **NuGet** funciona como um **gerenciador de dependências para projetos .NET**.

Ele facilita:

- 📚 Instalação de bibliotecas;
- 🔄 Controle de versões;
- 🔗 Gerenciamento de dependências;
- 🗑️ Remoção de pacotes;
- 👥 Padronização entre desenvolvedores;
- 📥 Restauração de dependências;
- 🛠️ Integração com o .NET CLI.

> 💡 **Em resumo:** o NuGet evita que precisemos gerenciar manualmente as bibliotecas utilizadas pelo projeto. Ele centraliza as dependências, suas versões e seus relacionamentos, tornando o desenvolvimento e a colaboração entre programadores muito mais simples.