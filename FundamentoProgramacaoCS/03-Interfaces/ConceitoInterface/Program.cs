using ConceitoInterface.Services;
using ConceitoInterface.Models;

// Instancia o Service responsável pelas operações de CRUD dos usuários.
var usuarioService = new UsuarioService();

Console.Clear();

int escolha = 0;

// Mantém o menu sendo executado até o usuário escolher a opção 6.
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

    // Tenta converter a entrada do usuário para um número inteiro.
    // Caso não seja possível, o menu é reiniciado.
    if (!int.TryParse(Console.ReadLine(), out escolha))
    {
        Console.WriteLine("Opção inválida! Por favor, digite um número.");
        continue;
    }

    // Define qual operação será executada de acordo com a opção escolhida.
    switch (escolha)
    {
        // ==========================================
        // CADASTRAR USUÁRIO
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

            // Cria uma nova instância da classe Usuario.
            var novoUsuario = new Usuario
            {
                Nome = nome,
                Sobrenome = sobrenome,
                Email = email
            };

            // Como a senha é privada, utilizamos o método SetSenha().
            novoUsuario.SetSenha(senha);

            // Envia o usuário para o Service realizar o cadastro.
            usuarioService.CadastrarUsuario(novoUsuario);

            break;


        // ==========================================
        // ATUALIZAR USUÁRIO
        // ==========================================
        case 2:

            Console.Write("Digite o ID do usuário a ser atualizado: ");

            // Verifica se o ID informado é um número válido.
            if (!int.TryParse(Console.ReadLine(), out int idAtualizar))
            {
                Console.WriteLine("ID inválido! Por favor, digite um número.");
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

            // Cria um objeto contendo os novos dados do usuário.
            // O ID é mantido para que o Service saiba qual usuário atualizar.
            var usuarioAtualizado = new Usuario
            {
                Id = idAtualizar,
                Nome = nomeAtualizado,
                Sobrenome = sobrenomeAtualizado,
                Email = emailAtualizado
            };

            usuarioAtualizado.SetSenha(senhaAtualizada);

            // Envia os dados para o Service localizar
            // e atualizar o usuário existente na lista.
            usuarioService.AtualizarUsuario(usuarioAtualizado);

            break;


        // ==========================================
        // EXCLUIR USUÁRIO
        // ==========================================
        case 3:

            Console.Write("Digite o ID do usuário a ser excluído: ");

            // Verifica se o ID informado é válido.
            if (int.TryParse(Console.ReadLine(), out int idExcluir))
            {
                // O Service será responsável por verificar
                // se o usuário existe e realizar a exclusão.
                usuarioService.ExcluirUsuario(idExcluir);
            }
            else
            {
                Console.WriteLine("ID inválido! Por favor, digite um número.");
            }

            break;


        // ==========================================
        // OBTER USUÁRIO POR ID
        // ==========================================
        case 4:

            Console.Write("Digite o ID do usuário a ser obtido: ");

            if (int.TryParse(Console.ReadLine(), out int idObter))
            {
                // Busca o usuário através do ID informado.
                var usuarioObtido = usuarioService.ObterUsuarioPorId(idObter);

                // Verifica se o usuário foi encontrado.
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
                Console.WriteLine("ID inválido! Por favor, digite um número.");
            }

            break;


        // ==========================================
        // OBTER TODOS OS USUÁRIOS
        // ==========================================
        case 5:

            // Obtém a lista de usuários armazenada no Service.
            var todosUsuarios = usuarioService.ObterTodosUsuarios();

            // Verifica se existem usuários cadastrados.
            if (todosUsuarios.Count > 0)
            {
                // Percorre todos os usuários da lista.
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
        // OPÇÃO INVÁLIDA
        // ==========================================
        default:

            // A opção 6 não precisa de um case porque
            // ela apenas encerra o loop.
            if (escolha != 6)
            {
                Console.WriteLine(
                    "Opção inválida! Por favor, escolha uma opção válida."
                );
            }

            break;
    }

} while (escolha != 6);

