using System.Collections.Generic;
using ConceitoInterface.Models;

namespace ConceitoInterface.Services
{
    // ==================================================
    // INTERFACE
    // ==================================================
    // A interface define um contrato que deve ser seguido
    // pela classe que a implementar.
    //
    // Ela determina quais métodos devem existir,
    // mas não define como eles serão executados.
    //
    // A implementação fica por responsabilidade da classe
    // que utilizar esta interface.

    public interface IUsuarioService
    {
        // Cadastra um novo usuário.
        void CadastrarUsuario(Usuario usuario);


        // Atualiza os dados de um usuário existente.
        void AtualizarUsuario(Usuario usuario);


        // Exclui um usuário utilizando seu ID.
        void ExcluirUsuario(int id);


        // Busca um usuário através do seu ID.
        Usuario ObterUsuarioPorId(int id);


        // Retorna uma lista contendo todos os usuários.
        List<Usuario> ObterTodosUsuarios();
    }
}