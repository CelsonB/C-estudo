using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portifolio.Fundamentos
{
    internal class LendoDados
    {
        public static void Executar()
        {
            Console.Write("Qual seu nome?");
            String nome = Console.ReadLine();

            Console.Write("Qual é sua idade?");
            int idade = int.Parse(Console.ReadLine());

            Console.Write("Qual é seu salario?");
            double salario = double.Parse(Console.ReadLine());

            Console.Write($"{nome} {idade} {salario}");
        }
    }
}
