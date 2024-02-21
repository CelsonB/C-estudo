using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portifolio.Excecoes
{
    internal class PrimeiraExcecao
    {
        public class Conta
        {
            double Saldo;
            public Conta(Double saldo)
            {
                this.Saldo = saldo;
            }


            public void Sacar(double valor)
            {
                if (valor > this.Saldo)
                {
                    throw new ArgumentException("saldo insuficiente");

                }
                else
                {
                    this.Saldo -= valor;
                }
            }
        }
        public static void Executar()
        {
            var conta = new Conta(1_223.45);

            try
            {
                conta.Sacar(1600);
                Console.WriteLine("Retirada realizada com sucesso");
            }catch (Exception ex) 
            { 
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Obrigado");
            }


        }
    }
}
