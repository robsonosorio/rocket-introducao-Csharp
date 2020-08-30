using System;
using System.Collections.Generic;
using System.Text;

namespace modulo2_OOP_3.Entities
{
    public class Multifuncional : IImpressora, ICopiadora, IEscaneadora
    {
        public string Copiar(string texto)
        {
            return $"Copiar texto: {texto}";
        }
        public string Escanear(string texto)
        {
            return $"Escanear texto: {texto}";
        }
        public string Imprimir(string texto)
        {
            return $"Imprimir texto: {texto}";
        }
    }
}
