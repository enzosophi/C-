using System;

namespace Classes.Class
{
    // ==================================================
    // CLASSE BASE
    // ==================================================
    // Usuario será a classe base para outras classes
    // que precisem representar um usuário do sistema.
    //
    // Ela contém propriedades e comportamentos que
    // podem ser aproveitados por outras classes através
    // do conceito de herança.

    public class Usuario
    {
        // ==================================================
        // PROPRIEDADES
        // ==================================================

        public string Nome { get; set; }

        public string Sobrenome { get; set; }


        // Propriedade calculada.
        //
        // Seu valor não é armazenado diretamente.
        // Ele é obtido através de outras propriedades.
        //
        // Exemplo:
        // Nome = "João"
        // Sobrenome = "Silva"
        //
        // NomeCompleto = "João Silva"

        public string NomeCompleto
        {
            get
            {
                return $"{Nome} {Sobrenome}";
            }
        }


        // ==================================================
        // ENCAPSULAMENTO
        // ==================================================

        // Private restringe o acesso à propriedade.
        // Senha só pode ser acessada diretamente dentro
        // da própria classe Usuario.

        private string Senha { get; set; }


        // O "?" permite que Email receba o valor null.

        public string? Email { get; set; }


        // Como Senha é privada, utilizamos um método público
        // para controlar sua alteração.
        //
        // Esse controle faz parte do encapsulamento.

        public void SetSenha(string senha)
        {
            Senha = senha;
        }


        // ==================================================
        // POLIMORFISMO
        // ==================================================

        // Virtual permite que uma classe derivada,
        // como Gerente, sobrescreva este método utilizando
        // a palavra-chave override.

        public virtual void ExibirInformacoes()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Senha: {Senha}");
            Console.WriteLine($"Email: {Email}");
        }


        // Método responsável por alterar o e-mail
        // do usuário.

        public void MudarEmail(string novoEmail)
        {
            Email = novoEmail;
        }
    }
}