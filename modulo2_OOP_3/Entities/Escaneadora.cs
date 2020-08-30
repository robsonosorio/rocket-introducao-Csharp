using System;
using System.Collections.Generic;
using System.Text;

namespace modulo2_OOP_3.Entities
{
    public class Escaneadora : IEscaneadora
    {
        public string Escanear(string texto)
        {
            return $"Escanear texto: {texto}";
        }
    }
}
