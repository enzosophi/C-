using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Exceptions.Models
{
    public class Projeto
    {
       public int Id{get;set;}
       [Required(ErrorMessage ="Entrada vázia invalida")]
       public string Nome{get;set;} = string.Empty;
       [Required(ErrorMessage = "Entrada vázia invalida")]
       public DateTime DataInicio{get;set;}

        public Projeto(string nome, DateTime dataInicio)
        {
            Nome = nome;
            DataInicio = dataInicio;
        } 
    }
}