using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Portifolio.Api
{
    internal class Diretorios
    {
        public static void Executar()
        {
            var novoDir = @"/pastaCSharp".ParseHome();
            var novoDirDestino = @"/pastaCSharpDestino".ParseHome();
            var dirProjeto = @"~/source/repos/portifolio/portifolio".ParseHome();

            if (Directory.Exists(novoDir))
            {
                Directory.Delete(novoDir,true);
            }
            
            if (Directory.Exists(novoDirDestino))
            {
                Directory.Delete(novoDirDestino, true);
            }

            Directory.CreateDirectory(novoDir);
            Directory.CreateDirectory(novoDirDestino);

            Console.WriteLine("=============pastas==========================");
            var pastas = Directory.GetDirectories(dirProjeto);
            foreach (var pasta in pastas)
            {
                Console.WriteLine($"{pasta}");
            }



            Console.WriteLine("=============arquivos==========================");
            var arquivos = Directory.GetFiles(dirProjeto);
            foreach (var arq in arquivos)
            {
                Console.WriteLine(arq);
            }
            Console.WriteLine("=============================diretorio raiz=============================");
            Console.WriteLine(Directory.GetDirectoryRoot(novoDir));

            Directory.Move(novoDir, novoDirDestino);
                }
    }
}
