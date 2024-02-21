using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portifolio.Excecoes
{

    public class NegativoException : Exception
    {
        public NegativoException(String message) : base(message)
        {
            //
        }
        public NegativoException(string message, Exception inner) : base(message, inner)
        {
            //
        }

    }
    public class ImparException : Exception
    {
        public ImparException(String message) : base(message)
        {
            //
        }
    }

    internal class ExcecoesPersonalizada
    {
        public static int PositivoPar()
        {
            Random random = new Random();   
            int valor = random.Next(-30,30);
            if (valor < 0) throw new NegativoException("Numero Negativo... :(");
            if (valor % 2 == 1) throw new ImparException("Numero impar... :/");

            return valor;
        }
               public static void Executar()
        {
            try
            {
                Console.WriteLine(PositivoPar());
            }catch(NegativoException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (ImparException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("O numero é positivo e par");
            }

        }
    }
}
