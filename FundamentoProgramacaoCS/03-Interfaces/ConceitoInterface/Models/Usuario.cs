namespace ConceitoInterface.Models
{
    // ==================================================
    // MODEL - USUARIO
    // ==================================================
    // O Model representa os dados que serão utilizados
    // pela aplicação.
    //
    // Neste caso, Usuario representa as informações
    // que pertencem a um usuário do sistema.
    //
    // A responsabilidade principal do Model é representar
    // os dados, enquanto regras e operações do sistema
    // podem ficar em outras camadas, como Services.

    public class Usuario
    {
        // Identificador único do usuário.
        public int Id { get; set; }


        // Informações básicas do usuário.
        public string Nome { get; set; }

        public string Sobrenome { get; set; }

        public string Email { get; set; }


        // A senha é privada para impedir que outras classes
        // acessem seu valor diretamente.
        //
        // O acesso é controlado através do método SetSenha().

        private string Senha { get; set; }


        // Define ou altera a senha do usuário.
        //
        // Como Senha é private, utilizamos este método
        // para controlar sua alteração.

        public void SetSenha(string senha)
        {
            Senha = senha;
        }
    }
}