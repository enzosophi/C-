
using Exceptions.Models;

namespace Exceptions.Interfaces
{
    public interface IProjetos
    {
        void BuscaProjetosId(int id);
        void CriarProjeto(Projeto projeto); 
    }
}