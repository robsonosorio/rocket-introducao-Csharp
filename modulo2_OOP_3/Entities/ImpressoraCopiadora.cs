using System;
using System.Collections.Generic;
using System.Text;

namespace modulo2_OOP_3.Entities
{
    class ImpressoraCopiadora : IImpressora, ICopiadora
    {
        public string Copiar(string texto)
        {
            return $"Copiar texto: {texto}";
        }
        public string Imprimir(string texto)
        {
            return $"Imprimir texto: {texto}";
        }
    }
}
