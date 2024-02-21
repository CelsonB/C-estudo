using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Encapsulamento;


namespace Portifolio.OrientadoAObjetos
{

    public class FilhoReconhecido : SubCelebridade
    {
        public new void MeusAcessos()
        {
            Console.WriteLine("Filho não reconhecido...");
            Console.WriteLine(InfoPublica);
            Console.WriteLine(CorDoOlho);
            //Console.WriteLine(NumeroCelular);
            Console.WriteLine(JeitoDeFalar);
            //Console.WriteLine(SegredoFamilia);
            //Console.WriteLine(UsaMuitoPhotoshop);
        }

    }


    public class AmigoDistante
    {
        public readonly SubCelebridade amiga = new SubCelebridade();
        public void MeusAcessos()
        {
           Console.WriteLine(amiga.InfoPublica);
           // Console.WriteLine(amiga.CorDoOlho); 
           // Console.WriteLine(amiga.NumeroCelular);
           // Console.WriteLine(amiga.JeitoDeFalar);
           // Console.WriteLine(amiga.SegredoFamilia);
           // Console.WriteLine(amiga.UsaMuitoPhotoshop);
        }
    }

    class Encapsulamento
    {
        public static void Executar()
        {
            SubCelebridade sub = new SubCelebridade();
            sub.MeusAcessos();

            new FilhoReconhecido().MeusAcessos();
            new AmigoProximo().MeusAcessos();
            new FilhoReconhecido().MeusAcessos();
            new AmigoDistante().MeusAcessos();
        }
    }
    
}
