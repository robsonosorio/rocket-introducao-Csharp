using modulo2_OOP_2.Entities;
using System;

namespace modulo2_OOP_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var c = new Cachorro("Baruk", 13);
            var g = new Gato("Miu", 8);

            Animal o = new Gato("Coisa", 4);

            ImprimiAnimal(c);
            ImprimiAnimal(g);
            ImprimiAnimal(o);
        }

        static void ImprimiAnimal(Animal animal)
        {
            Console.WriteLine($"Nome: {animal.Nome}");
            Console.WriteLine($"Idade: {animal.Idade}\n");
        }
    }
}
