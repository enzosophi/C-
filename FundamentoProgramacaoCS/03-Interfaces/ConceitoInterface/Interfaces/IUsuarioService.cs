using System.Collections.Generic;
using ConceitoInterface.Models;

namespace ConceitoInterface.Services
{
    public interface IUsuarioService
    {
        void CadastrarUsuario(Usuario usuario);
        void AtualizarUsuario(Usuario usuario);
        void ExcluirUsuario(int id);
        Usuario ObterUsuarioPorId(int id);
        List<Usuario> ObterTodosUsuarios();
    }
}