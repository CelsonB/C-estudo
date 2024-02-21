using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portifolio.OrientadoAObjetos
{
    internal class ConstrutorThis
    {
        
        public class Animal
        {
            public string Nome
            {
                get; set;
            }
            public Animal(String nome)
            {
                this.Nome = nome;
            }

        }

        public class Cachorro : Animal
        {
            public double Altura {  get; set; }

            public Cachorro(String nome) : base(nome) {
                Console.WriteLine($"Cachorro {nome} inicializado");

            }

            public Cachorro (String nome, double altura): this(nome)
            {
                this.Altura = altura;
            }


            public override string ToString()
            {
                return $"{Nome} tem {Altura} cm de altura";
            }

        }




        public static void Executar()
        {
            var spike = new Cachorro("Spike");
            var max = new Cachorro("max", 50);

            Console.WriteLine(spike);
            Console.WriteLine(max.ToString() );
            
        }
    }
}
