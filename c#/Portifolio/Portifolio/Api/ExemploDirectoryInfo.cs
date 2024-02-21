using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Portifolio.Api
{
    internal class ExemploDirectoryInfo
    {
   
        public static void Executar()
        {
            var dirProjeto = @"~/source/repos/portifolio/portifolio".ParseHome();
            var dirInfo = new DirectoryInfo(dirProjeto);

            if (!dirInfo.Exists)
            {
                dirInfo.Create();
            }
            Console.WriteLine("ARQUIVOS");
            var arquivos = dirInfo.GetFiles();
            foreach (var arq in arquivos) Console.WriteLine(arq);

            Console.WriteLine("\ndiretorios");
            var pastas = dirInfo.GetDirectories();
            foreach (var pasta in pastas) Console.WriteLine(pasta);

            Console.WriteLine(dirInfo.CreationTime);
            Console.WriteLine(dirInfo.FullName);
            Console.WriteLine(dirInfo.Root);
            Console.WriteLine(dirInfo.Parent);
        }
    }
}
