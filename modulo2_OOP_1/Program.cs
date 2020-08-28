using System;
using treinamento.Entities.Enums;

namespace treinamento
{
    class Program
    {
        static void Main(string[] args)
        {
            var c = new Carro(Cor.Preto, "Honda", 5 );

            Console.WriteLine("Carro de modelo " + c.Modelo + ", cor " + c.Cor + " e tem " + c.Portas);
            Console.WriteLine("\n" + c.Ligar());
            Console.WriteLine("\nCarro está ligado? " + c.Ligado);
            Console.WriteLine("\n" + c.Andar());
            Console.WriteLine("\n" + c.Desligar());
            Console.WriteLine("\nCarro está desligado? " + c.Ligado);

            c.Cor = Cor.Branco;
            Console.WriteLine("\nNova cor do carro é " + c.Cor);
        }
    }
}
