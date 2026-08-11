namespace Genericos.Generics
{
    // Classe genérica que pode trabalhar com diferentes tipos.
    //
    // O <T> representa o tipo que será definido quando
    // a classe for instanciada.
    public class ClassGenerics<T>
    {
        // Armazena o valor recebido pela classe.
        private T Valor { get; set; }

        // Recebe um valor do tipo T através do construtor.
        public ClassGenerics(T valor)
        {
            Valor = valor;
        }

        // Exibe o valor armazenado.
        public void Exibir()
        {
            Console.WriteLine(Valor);
        }
    }
}