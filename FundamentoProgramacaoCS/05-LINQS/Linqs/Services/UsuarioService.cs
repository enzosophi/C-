
using Linqs.Models;

namespace Linqs.Services
{
    public class UsuarioService
    {
       public List<Usuario> usuarios = new List<Usuario>();

       private int proximoId = 1;


      public List<Usuario> RetornarTodosUsuario()
        {
            List<Usuario> lista = usuarios.ToList();
            return lista;
        } 

      public void AdicionarUsuario(Usuario usuario)
        {
            usuario.Id = proximoId++;
            usuarios.Add(usuario);
        }
    }
}