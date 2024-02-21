using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamento
{
    public class SubCelebridade
    {
        // todos
        public string InfoPublica = "Tenho um instagram";

        protected string CorDoOlho = "Verde";

        internal ulong NumeroCelular = 42999999998;

        //herença
        protected internal string JeitoDeFalar = "uso muitas girias";


        private protected string SegredoFamilia = "bla bla";

        //private é o padrão

        bool UsaMuitoPhotoshop = true;

        public void MeusAcessos()
        {
            Console.WriteLine("subcelebridade....");
            Console.WriteLine(InfoPublica);
            Console.WriteLine(CorDoOlho);
            Console.WriteLine(NumeroCelular);
            Console.WriteLine(JeitoDeFalar);  
            Console.WriteLine(SegredoFamilia);
            Console.WriteLine(UsaMuitoPhotoshop);


        }

            }
}
