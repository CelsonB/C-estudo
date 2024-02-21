using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.CompilerServices;

namespace Portifolio.Api
{
    public static class ExtensaoString
    {
        public static string ParseHome(this string path)
        {
            String home = (
                Environment.OSVersion.Platform == PlatformID.Unix 
                || Environment.OSVersion.Platform == PlatformID.MacOSX)
                ? Environment.GetEnvironmentVariable("HOME")
                : Environment.ExpandEnvironmentVariables("%HOMEDRIVE%%HOMEPATH%");
            return path.Replace("~", home);
            }
    }
    internal class PrimeiroArquivo
    {
        public static void Executar()
        { var path = @"~/primeiro_arquivo.txt".ParseHome();
            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine("teste");
                    sw.WriteLine("eu amo ");
                    sw.WriteLine("a gabriela");
                    sw.WriteLine("por favor ");
                    sw.WriteLine("volta ");

                }
            }

            using (StreamWriter sw = File.AppendText(path))
                {
                    sw.WriteLine("Eu realmente sinto sua falta");
                    sw.WriteLine("por favor volte");
                }
            
        }
    }
}
