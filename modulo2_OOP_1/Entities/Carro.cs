using System;
using System.Collections.Generic;
using System.Reflection.PortableExecutable;
using System.Text;
using treinamento.Entities.Enums;

namespace treinamento
{
    public class Carro
    {
        public Cor Cor { get; set; }
        public string Modelo { get; }
        public int Portas { get; }

        private bool ligado = false;

        public bool Ligado
        {
            get
            {
                return ligado;
            }
        }

        public Carro(Cor cor, string modelo, int portas)
        {
            Cor = cor;            
            Modelo = modelo;
            Portas = portas;
        }

        public string Ligar()
        {
            ligado = true;
            return "O carro foi ligado !";
        }
        public string Desligar()
        {
            ligado = false;
            return "O carro foi desligado !";
        }
        public string Andar()
        {
            return "O carro está andando !";
        }
    }
}
