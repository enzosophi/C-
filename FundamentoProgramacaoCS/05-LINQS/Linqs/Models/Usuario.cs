using System.ComponentModel.DataAnnotations;


namespace Linqs.Models
{
    public class Usuario
    {
        
        public int Id{get; set;}
        [Required(ErrorMessage = "O nome não pode fica vazio. ")]
        public string Nome{get; set;} = string.Empty;
        public int Idade{get; set;}
    }
}