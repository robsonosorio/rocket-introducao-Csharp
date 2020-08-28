using System;
using System.Collections.Generic;
using System.Text;

namespace modulo2_OOP_2.Entities
{
    public class Animal
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public Animal(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }
    }
}
