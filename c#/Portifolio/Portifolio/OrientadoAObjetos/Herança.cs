using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portifolio.OrientadoAObjetos
{

    public class Carro
    {
        protected readonly int VelocidadeMaxima;
        int VelocidadeAtual;

        public Carro(int velocidadeMaxima)
        {
            this.VelocidadeMaxima = velocidadeMaxima; 

        }
        
        protected int AlterarVelocidade(int delta)
        {
            int novaVelocidade = VelocidadeAtual+delta;
            if (novaVelocidade < 0)
            {

                this.VelocidadeAtual = 0;

            }
            else if (novaVelocidade > this.VelocidadeMaxima) 
            {
                this.VelocidadeAtual = this.VelocidadeMaxima;
            }else
            {
                this.VelocidadeAtual = novaVelocidade;
            }
            return VelocidadeAtual;
        }

        public virtual int Acelerar()
        {
            return AlterarVelocidade(5);
        }
        public int Freiar()
        {
            return AlterarVelocidade(-5);
        }
    }



    public class Uno : Carro
    {
        public Uno() : base(200)
        {

        }
    }
    public class Ferrari : Carro
    {
        public Ferrari() : base(350) { 
        
        }

        public override int Acelerar()
        {
            return AlterarVelocidade(15);
        }
        public new int Freiar()
        {
            return AlterarVelocidade(-15);
        }
    }




    class Heranca
    {
        public static void Executar()
        {
            Console.WriteLine("uno...");
            Uno carro1 = new Uno();
            Console.WriteLine(carro1.Acelerar());
            Console.WriteLine(carro1.Acelerar());

            Console.WriteLine(carro1.Freiar());
            Console.WriteLine(carro1.Freiar());



            Console.WriteLine("Ferrari...");
            Ferrari carro2 = new Ferrari();
            Console.WriteLine(carro2.Acelerar());
            Console.WriteLine(carro2.Acelerar());

            Console.WriteLine(carro2.Freiar());
            Console.WriteLine(carro2.Freiar());

            Console.WriteLine("ferrari com tipo carro...");
            Carro carro3 = new Ferrari();

            Console.WriteLine(carro3.Acelerar());
            Console.WriteLine(carro3.Acelerar());

            Console.WriteLine(carro3.Freiar());
            Console.WriteLine(carro3.Freiar());
        }
    }
}
