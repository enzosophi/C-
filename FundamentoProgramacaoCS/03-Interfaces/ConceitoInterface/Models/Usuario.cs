using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConceitoInterface.Models
{
    public class Usuario
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Sobrenome { get; set; }

        public string Email { get; set; }

        private string Senha { get; set; }

        public void SetSenha(string senha)
        {
            Senha = senha;
        }
    }
}