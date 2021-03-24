using System;

namespace ControleRemoto
{
    class Program
    {
        static void Main(string[] args)
        {
            IControleRemoto philco = new Televisao("Philco","MultiVision");
            IControleRemoto dvdGradiente = new DvdPlayer("Gradiente", "D22");

            philco.ligar();
            dvdGradiente.ligar();

            Console.WriteLine("---------------------");
            Console.WriteLine("Aparelhos iniciais: ");
            Console.WriteLine(philco);
            Console.WriteLine(dvdGradiente);

            Console.WriteLine("---------------------");
            philco.desligar();
            dvdGradiente.aumentarVolume();
            Console.WriteLine();
            Console.WriteLine("Aparelhos ao desligar a TV e abrir o combo do DVD:");
            Console.WriteLine(philco);
            Console.WriteLine(dvdGradiente);

        }
    }
}
