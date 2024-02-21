using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Portifolio.Api
{
    internal class ExemploPath
    {
        public static void Executar()
        {
            var arquivo = @"~/exemplo_path_arquivo.txt".ParseHome();
            var pasta = @"~/exemplo_path_pasta.txt".ParseHome();

            if (!File.Exists(arquivo))
            {
                using (StreamWriter sw = File.CreateText(arquivo))
                {
                    sw.WriteLine("um novo arquivo foi criado");
                }
            }


            if (!Directory.Exists(pasta)) 
            {
                Directory.CreateDirectory(pasta);
            } 

            Console.WriteLine(Path.GetExtension(arquivo));
            Console.WriteLine(Path.GetFileNameWithoutExtension(arquivo));
            Console.WriteLine(Path.GetFileName(arquivo));


            Console.WriteLine(Path.GetExtension(pasta));
            Console.WriteLine(Path.GetFileNameWithoutExtension(pasta));
            Console.WriteLine(Path.GetFileName(pasta));
        }
    }
}
