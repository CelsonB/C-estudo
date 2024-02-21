using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portifolio.MetodosEFuncoes
{
    public static class ExtensoesInteiro
    {
        public static int Soma(this int num, int outroNumero) => num + outroNumero;

        public static int Subtracao(this int num, int outroNumero) => num - outroNumero;
        
    }
    internal class MetodosDeExtensao
    {
        public static void Executar()
        {
            int numero = 5;
            double numeroReal = 5.5;

            
            
            Console.WriteLine(numero.Soma(3));
            Console.WriteLine(numero.Subtracao(3));

        }
    }
}
