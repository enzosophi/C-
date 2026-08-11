
using System;
using System.Collections.Generic;
using ConceitoInterface.Models;


namespace ConceitoInterface.Services
{
    // A classe Usuario está implementando a interface IUsuarioService.
    //
    // Ao utilizar ": IUsuarioService", a classe assume o compromisso
    // de implementar todos os métodos definidos na interface.
    public class UsuarioService : IUsuarioService
    {
        private List<Usuario> usuarios = new List<Usuario>();

        private int proximoId = 1;

        // Método responsável por realizar o cadastro de um usuário.
        //
        // O parâmetro "usuario" recebe um objeto da classe Usuario
        // que contém os dados que serão utilizados no cadastro.
        public void CadastrarUsuario(Usuario usuario)
        {
            usuario.Id = proximoId++;
            Console.WriteLine("================================");
            Console.WriteLine("       CADASTRO DE USUÁRIO");
            Console.WriteLine("================================");
            Console.WriteLine($"Usuário {usuario.Nome} cadastrado com sucesso!");
            usuarios.Add(usuario);

        }



        // Método responsável por atualizar os dados de um usuário.
        //
        // Recebemos um objeto Usuario para identificar
        // quais informações deverão ser atualizadas.
        public void AtualizarUsuario(Usuario usuario)
        {
            var usuarioExistente = usuarios.Find(u => u.Id == usuario.Id);
            if(usuarioExistente == null)
            {
                System.Console.WriteLine("Usuario Não encontrado");
                return;
            }
            usuarioExistente.Nome = usuario.Nome;
            usuarioExistente.Email = usuario.Sobrenome;
            usuarioExistente.Email = usuario.Email;

            Console.WriteLine("================================");
            Console.WriteLine("       ATUALIZAÇÃO DE USUÁRIO");
            Console.WriteLine("================================");
            Console.WriteLine($"Usuário {usuarioExistente.Nome} atualizado com sucesso!");
            
        }


        // Método responsável por excluir um usuário.
        //
        // O ID é utilizado para identificar qual usuário
        // deverá ser excluído.
        public void ExcluirUsuario(int id)
        {
            var usuario = usuarios.Find(u => u.Id ==id);

            if(usuario == null)
            {
                Console.WriteLine($"Usuario de Id {id} não encontrado");
                return;
            }
            Console.WriteLine("================================");
            Console.WriteLine("       EXCLUSÃO DE USUÁRIO");
            Console.WriteLine("================================");
            usuarios.Remove(usuario);
            Console.WriteLine($"Usuário {id} excluído com sucesso!");
            
        }


        // Método responsável por buscar um usuário através do seu ID.
        //
        // O retorno é um objeto Usuario.
        //
        // Neste exemplo, ainda não estamos buscando os dados em
        // um banco de dados. Por isso, estamos apenas retornando
        // uma nova instância da classe Usuario.
        public Usuario ObterUsuarioPorId(int id)
        {
            Console.WriteLine("================================");
            Console.WriteLine("       OBTENDO USUÁRIO POR ID");
            Console.WriteLine("================================");

            return usuarios.FirstOrDefault(u => u.Id == id);
        }


        // Método responsável por obter todos os usuários.
        //
        // O retorno é uma lista contendo objetos do tipo Usuario.
        //
        // Neste exemplo, a lista ainda está vazia porque não
        // estamos utilizando um banco de dados ou outra fonte
        // de armazenamento.
        public List<Usuario> ObterTodosUsuarios()
        {
            Console.WriteLine("================================");
            Console.WriteLine("       OBTENDO TODOS OS USUÁRIOS");
            Console.WriteLine("================================");
            return usuarios;
        }
    }
}

