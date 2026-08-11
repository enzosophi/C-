using System;

namespace Classes.Class
{
    public class Usuario
    {
        public string Nome { get; set; }

        public string Sobrenome { get; set; }


        // Propriedade calculada: seu valor é obtido
        // através de outras propriedades da classe.
        public string NomeCompleto
        {
            get
            {
                return $"{Nome} {Sobrenome}";
            }
        }


        // Private restringe o acesso à propriedade
        // somente dentro da própria classe.
        private string Senha { get; set; }


        // O "?" permite que a propriedade receba null.
        public string? Email { get; set; }


        // Como Senha é privada, utilizamos um método
        // para controlar sua alteração.
        public void SetSenha(string senha)
        {
            Senha = senha;
        }


        // Virtual permite que classes derivadas sobrescrevam
        // o comportamento deste método utilizando override.
        public virtual void ExibirInformacoes()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Senha: {Senha}");
            Console.WriteLine($"Email: {Email}");
        }


        public void MudarEmail(string novoEmail)
        {
            Email = novoEmail;
        }
    }

    // Volte para o Program.cs e veja como a classe Usuario
    // é instanciada e como suas propriedades e métodos são utilizados.
}

