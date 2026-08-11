namespace Genericos.Models
{
    public class Pessoa
    {
        public string Nome { get; set; } = string.Empty;

        public int Idade { get; set; }

        // Define como o objeto Pessoa será convertido para texto.
        public override string ToString()
        {
            return $"Nome: {Nome} | Idade: {Idade}";
        }
    }
}