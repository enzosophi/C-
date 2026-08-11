using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Classes.Class
{
    // O que estamos fazendo agora é criar uma classe Gerente
    // que herda da classe Usuario.
    //
    // Chamamos isso de HERANÇA, que é um dos pilares da
    // Programação Orientada a Objetos (POO).
    //
    // A herança permite que uma classe filha aproveite
    // propriedades e métodos de uma classe base.
    //
    // Nesse caso:
    //
    // Usuario = classe base
    // Gerente = classe filha
    //
    // Como Gerente herda de Usuario, ela pode utilizar
    // os membros que foram herdados da classe Usuario.
    public class Gerente : Usuario
    {
        // Não precisamos criar novamente as propriedades
        // que já existem na classe Usuario.
        //
        // Por exemplo, Nome já pertence a Usuario e é
        // herdado por Gerente.
        //
        // Porém, podemos adicionar propriedades específicas
        // que fazem sentido apenas para um Gerente.

        public string Departamento { get; set; }

        public int Nivel { get; set; }

        public decimal Salario { get; set; }

        public DateTime DataAdmissao { get; set; }


        // Método responsável por alterar o salário do gerente.
        //
        // Recebemos o novo salário como parâmetro e atribuímos
        // esse valor à propriedade Salario.
        public void MudarSalario(decimal novoSalario)
        {
            Salario = novoSalario;
        }

        // Este método exibe as informações específicas do Gerente.
        //O override indica que estamos sobrescrevendo o método ExibirInformacoes() da classe base Usuario.
        public override void ExibirInformacoes()
        {
            // Como Gerente herda de Usuario, podemos utilizar
            // o método ExibirInformacoes() que foi definido
            // na classe base.
            // o base permite acessar membros da classe base, como propriedades e métodos.
            base.ExibirInformacoes();
            // Dessa forma, não precisamos repetir o código
            // responsável por exibir Nome, Senha e Email.

            // Depois de exibir as informações herdadas de Usuario,
            // exibimos as informações específicas do Gerente.
            Console.WriteLine($"Departamento: {Departamento}");
            Console.WriteLine($"Nível: {Nivel}");
            Console.WriteLine($"Salário: {Salario}");
            Console.WriteLine($"Data de Admissão: {DataAdmissao.ToShortDateString()}");
        }
    }
}

