using ConceitoInterface.Services;
using ConceitoInterface.Models;

// Instanciamos o Service responsável pelas operações de usuário.
// O Service implementa a interface IUsuarioService.
var usuarioService = new UsuarioService();

Console.Clear();

int escolha = 0;

// O loop mantém o menu executando até a opção 6 ser escolhida.
do
{
    Console.WriteLine("================================");
    Console.WriteLine("       MENU DE OPÇÕES");
    Console.WriteLine("================================");
    Console.WriteLine("1. Cadastrar Usuário");
    Console.WriteLine("2. Atualizar Usuário");
    Console.WriteLine("3. Excluir Usuário");
    Console.WriteLine("4. Obter Usuário por ID");
    Console.WriteLine("5. Obter Todos os Usuários");
    Console.WriteLine("6. Sair");
    Console.WriteLine("================================");
    Console.Write("Escolha uma opção: ");

    // Tenta converter o valor digitado para inteiro.
    if (!int.TryParse(Console.ReadLine(), out escolha))
    {
        Console.WriteLine("Opção inválida! Digite um número.");
        continue;
    }

    switch (escolha)
    {
        // ==========================================
        // CREATE - Cadastrar usuário
        // ==========================================
        case 1:

            Console.Write("Digite o nome do usuário: ");
            var nome = Console.ReadLine();

            Console.Write("Digite o sobrenome do usuário: ");
            var sobrenome = Console.ReadLine();

            Console.Write("Digite o email do usuário: ");
            var email = Console.ReadLine();

            Console.Write("Digite a senha do usuário: ");
            var senha = Console.ReadLine();

            // Instanciamos um novo objeto Usuario.
            var novoUsuario = new Usuario
            {
                Nome = nome,
                Sobrenome = sobrenome,
                Email = email
            };

            // Senha é privada, por isso utilizamos um método
            // para realizar sua alteração.
            novoUsuario.SetSenha(senha);

            // O Service realiza o cadastro do usuário.
            usuarioService.CadastrarUsuario(novoUsuario);

            break;


        // ==========================================
        // UPDATE - Atualizar usuário
        // ==========================================
        case 2:

            Console.Write("Digite o ID do usuário a ser atualizado: ");

            if (!int.TryParse(Console.ReadLine(), out int idAtualizar))
            {
                Console.WriteLine("ID inválido! Digite um número.");
                break;
            }

            Console.Write("Digite o novo nome do usuário: ");
            var nomeAtualizado = Console.ReadLine();

            Console.Write("Digite o novo sobrenome do usuário: ");
            var sobrenomeAtualizado = Console.ReadLine();

            Console.Write("Digite o novo email do usuário: ");
            var emailAtualizado = Console.ReadLine();

            Console.Write("Digite a nova senha do usuário: ");
            var senhaAtualizada = Console.ReadLine();

            // Criamos um objeto contendo os novos dados.
            var usuarioAtualizado = new Usuario
            {
                Id = idAtualizar,
                Nome = nomeAtualizado,
                Sobrenome = sobrenomeAtualizado,
                Email = emailAtualizado
            };

            usuarioAtualizado.SetSenha(senhaAtualizada);

            // O Service localiza o usuário pelo ID
            // e realiza a atualização.
            usuarioService.AtualizarUsuario(usuarioAtualizado);

            break;


        // ==========================================
        // DELETE - Excluir usuário
        // ==========================================
        case 3:

            Console.Write("Digite o ID do usuário a ser excluído: ");

            if (int.TryParse(Console.ReadLine(), out int idExcluir))
            {
                // O Service verifica se o usuário existe
                // e realiza a exclusão.
                usuarioService.ExcluirUsuario(idExcluir);
            }
            else
            {
                Console.WriteLine("ID inválido! Digite um número.");
            }

            break;


        // ==========================================
        // READ - Obter usuário por ID
        // ==========================================
        case 4:

            Console.Write("Digite o ID do usuário: ");

            if (int.TryParse(Console.ReadLine(), out int idObter))
            {
                // O Service realiza a busca pelo ID.
                var usuarioObtido = usuarioService.ObterUsuarioPorId(idObter);

                if (usuarioObtido != null)
                {
                    Console.WriteLine(
                        $"ID: {usuarioObtido.Id}, " +
                        $"Nome: {usuarioObtido.Nome}, " +
                        $"Sobrenome: {usuarioObtido.Sobrenome}, " +
                        $"Email: {usuarioObtido.Email}"
                    );
                }
                else
                {
                    Console.WriteLine("Usuário não encontrado.");
                }
            }
            else
            {
                Console.WriteLine("ID inválido! Digite um número.");
            }

            break;


        // ==========================================
        // READ - Obter todos os usuários
        // ==========================================
        case 5:

            // O Service retorna todos os usuários cadastrados.
            var todosUsuarios = usuarioService.ObterTodosUsuarios();

            if (todosUsuarios.Count > 0)
            {
                foreach (var usuario in todosUsuarios)
                {
                    Console.WriteLine(
                        $"ID: {usuario.Id}, " +
                        $"Nome: {usuario.Nome}, " +
                        $"Sobrenome: {usuario.Sobrenome}, " +
                        $"Email: {usuario.Email}"
                    );
                }
            }
            else
            {
                Console.WriteLine("Nenhum usuário encontrado.");
            }

            break;


        // ==========================================
        // SAIR / OPÇÃO INVÁLIDA
        // ==========================================
        default:

            if (escolha != 6)
            {
                Console.WriteLine(
                    "Opção inválida! Escolha uma opção de 1 a 6."
                );
            }

            break;
    }

} while (escolha != 6);