using modulo2_OOP_3.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace modulo2_OOP_3
{
    public class ImpressoraComum : IImpressora
    {
        public string Imprimir(string texto)
        {
            return $"Imprimir texto: {texto}";
        }
    }
}
