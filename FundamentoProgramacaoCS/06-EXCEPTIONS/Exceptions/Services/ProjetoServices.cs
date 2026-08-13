using Exceptions.Models;

namespace Exceptions.Services
{
    public class ProjetoServices
    {
        private int proximoId = 1;
        List<Projeto> projetos = new List<Projeto>();

        public Projeto? BuscarProjetoId(int id)
        {
            Console.WriteLine("================================");
            Console.WriteLine("       OBTENDO PROJETO POR ID");
            Console.WriteLine("================================");
            return projetos.FirstOrDefault(u => u.Id == id);
        }

        public void CriarProjeto(Projeto projeto)
        {
            projeto.Id = proximoId++;
            projetos.Add(projeto);
        }
    }
}