using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portifolio.MetodosEFuncoes
{
    internal class DelegateComParametros
    {
        public delegate int Operacao(int x, int z);

        public static int Soma(int x, int y)
        {
            return x+y; 
        }
        public static string Calculadora(Operacao op, int x, int y)
        {
            var resultado = op(x,y);
            return $"Resultado: {resultado}";
        }
        public static void Executar()
        {
            Operacao subtracao = (int a, int b) => a - b;
            Console.WriteLine(Calculadora(subtracao,3,2));

            Console.WriteLine(Calculadora(Soma,3,2 ));
        }
    }
}
