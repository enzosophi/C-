using System;

namespace Classes.Class
{
    // ==================================================
    // HERANÇA
    // ==================================================
    // Gerente herda da classe Usuario.
    //
    // Usuario = classe base
    // Gerente = classe derivada
    //
    // Isso permite que Gerente utilize propriedades
    // e métodos definidos em Usuario sem precisar
    // recriá-los.

    public class Gerente : Usuario
    {
        // ==================================================
        // PROPRIEDADES ESPECÍFICAS
        // ==================================================

        // Essas propriedades pertencem especificamente
        // ao Gerente.

        public string Departamento { get; set; }

        public int Nivel { get; set; }

        public decimal Salario { get; set; }

        public DateTime DataAdmissao { get; set; }


        // ==================================================
        // MÉTODOS
        // ==================================================

        // Altera o salário do gerente.

        public void MudarSalario(decimal novoSalario)
        {
            Salario = novoSalario;
        }


        // ==================================================
        // POLIMORFISMO
        // ==================================================

        // Override sobrescreve o comportamento do método
        // ExibirInformacoes() que foi definido na classe
        // base Usuario.

        public override void ExibirInformacoes()
        {
            // base.ExibirInformacoes() chama a implementação
            // original do método que está em Usuario.
            //
            // Assim, não precisamos repetir aqui a lógica
            // responsável por exibir Nome, Senha e Email.

            base.ExibirInformacoes();


            // Depois exibimos as informações específicas
            // da classe Gerente.

            Console.WriteLine($"Departamento: {Departamento}");
            Console.WriteLine($"Nível: {Nivel}");
            Console.WriteLine($"Salário: {Salario}");
            Console.WriteLine($"Data de Admissão: {DataAdmissao.ToShortDateString()}");
        }
    }
}