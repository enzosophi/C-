using System;
using System.Collections.Generic;
using System.Linq;
using ConceitoInterface.Models;

namespace ConceitoInterface.Services
{
    // ==================================================
    // SERVICE
    // ==================================================
    // UsuarioService implementa a interface IUsuarioService.
    //
    // Isso significa que esta classe precisa implementar
    // todos os métodos definidos no contrato da interface.
    //
    // Aqui ficam as operações que trabalham com os usuários,
    // como cadastrar, atualizar, excluir e consultar.

    public class UsuarioService : IUsuarioService
    {
        // ==================================================
        // ARMAZENAMENTO
        // ==================================================

        // Lista utilizada para armazenar os usuários
        // enquanto a aplicação estiver em execução.
        //
        // Neste exemplo não estamos utilizando um banco
        // de dados. Por isso, os dados ficam armazenados
        // apenas em memória.

        private List<Usuario> usuarios = new List<Usuario>();


        // Controla o próximo ID que será atribuído
        // automaticamente a um novo usuário.

        private int proximoId = 1;


        // ==================================================
        // CREATE
        // ==================================================

        // Cadastra um novo usuário.
        //
        // O ID é gerado automaticamente antes de adicionar
        // o usuário à lista.

        public void CadastrarUsuario(Usuario usuario)
        {
            usuario.Id = proximoId++;

            usuarios.Add(usuario);

            Console.WriteLine("================================");
            Console.WriteLine("       CADASTRO DE USUÁRIO");
            Console.WriteLine("================================");
            Console.WriteLine($"Usuário {usuario.Nome} cadastrado com sucesso!");
            Console.WriteLine($"ID: {usuario.Id}");
        }


        // ==================================================
        // UPDATE
        // ==================================================

        // Atualiza os dados de um usuário existente.
        //
        // Primeiro procuramos o usuário através do ID.
        // Se ele não existir, a operação é interrompida.

        public void AtualizarUsuario(Usuario usuario)
        {
            // Find percorre a lista procurando um usuário
            // que possua o mesmo ID informado.

            var usuarioExistente = usuarios.Find(u => u.Id == usuario.Id);

            if (usuarioExistente == null)
            {
                Console.WriteLine("Usuário não encontrado.");
                return;
            }


            // Atualizamos os dados do usuário encontrado.

            usuarioExistente.Nome = usuario.Nome;
            usuarioExistente.Sobrenome = usuario.Sobrenome;
            usuarioExistente.Email = usuario.Email;


            Console.WriteLine("================================");
            Console.WriteLine("       ATUALIZAÇÃO DE USUÁRIO");
            Console.WriteLine("================================");
            Console.WriteLine($"Usuário {usuarioExistente.Nome} atualizado com sucesso!");
        }


        // ==================================================
        // DELETE
        // ==================================================

        // Exclui um usuário utilizando seu ID.

        public void ExcluirUsuario(int id)
        {
            // Procuramos o usuário que possui o ID informado.

            var usuario = usuarios.Find(u => u.Id == id);

            if (usuario == null)
            {
                Console.WriteLine($"Usuário de ID {id} não encontrado.");
                return;
            }


            // Remove o usuário encontrado da lista.

            usuarios.Remove(usuario);

            Console.WriteLine("================================");
            Console.WriteLine("       EXCLUSÃO DE USUÁRIO");
            Console.WriteLine("================================");
            Console.WriteLine($"Usuário {id} excluído com sucesso!");
        }


        // ==================================================
        // READ - POR ID
        // ==================================================

        // Busca um usuário específico através do seu ID.

        public Usuario ObterUsuarioPorId(int id)
        {
            Console.WriteLine("================================");
            Console.WriteLine("       OBTENDO USUÁRIO POR ID");
            Console.WriteLine("================================");

            // FirstOrDefault retorna o primeiro usuário
            // encontrado ou null caso nenhum seja encontrado.

            return usuarios.FirstOrDefault(u => u.Id == id);
        }


        // ==================================================
        // READ - TODOS
        // ==================================================

        // Retorna todos os usuários cadastrados.

        public List<Usuario> ObterTodosUsuarios()
        {
            Console.WriteLine("================================");
            Console.WriteLine("       OBTENDO TODOS OS USUÁRIOS");
            Console.WriteLine("================================");

            return usuarios;
        }
    }
}