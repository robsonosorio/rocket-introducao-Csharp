using System;
using System.Collections.Generic;
using System.Text;

namespace modulo2_OOP_3.Entities
{
    public class Xerox : ICopiadora
    {
        public string Copiar(string texto)
        {
            return $"Copiar texto: {texto}";
        }
    }
}
