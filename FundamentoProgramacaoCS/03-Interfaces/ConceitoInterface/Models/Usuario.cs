using System.ComponentModel.DataAnnotations;

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
        [Required]
        public string Nome { get; set; } = string.Empty;

        [Required]
        public string Sobrenome { get; set; } = string.Empty;

        [Required]
        public string Email { get; set; } = string.Empty;


        // A senha é privada para impedir que outras classes
        // acessem seu valor diretamente.
        //
        // O acesso é controlado através do método SetSenha().
        [Required]
        [MinLength(8)]
        private string Senha { get; set; } = string.Empty;


        // Define ou altera a senha do usuário.
        //
        // Como Senha é private, utilizamos este método
        // para controlar sua alteração.

        public void SetSenha(string senha)
        {
            Senha = senha;
        }

        static bool CampoObrigatorio(string? valor, string nomeCampo)
        {
            if (string.IsNullOrWhiteSpace(valor))
            {
                Console.WriteLine($"{nomeCampo} não pode ser vazio.");
                return false;
            }

            return true;
        }
    }
}