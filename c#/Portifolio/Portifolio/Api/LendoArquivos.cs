using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Portifolio.Api
{
    internal class LendoArquivos
    {
        public static void Executar()
        {

            var path = @"~/lendo_arquivo.txt".ParseHome();
            if (!File.Exists(path))
            {

                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.WriteLine("Produto;preco;qtde");
                    sw.WriteLine("Produto;preco;qtde");
                    sw.WriteLine("Produto;preco;qtde");
                }
            }
                try
                {
                    using (StreamReader sr = new StreamReader(path))
                    {
                        var texto = sr.ReadToEnd();
                        Console.WriteLine(texto);
                    }
                }catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            
        }
    }
}
