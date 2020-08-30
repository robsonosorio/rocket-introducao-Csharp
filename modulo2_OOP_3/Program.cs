using modulo2_OOP_3.Entities;
using System;
using System.ComponentModel.DataAnnotations;

namespace modulo2_OOP_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var i = new ImpressoraComum();
            var c = new ImpressoraCopiadora();
            Console.WriteLine(i.Imprimir("Testando 1 !\n"));
            Console.WriteLine(c.Copiar("Testando 2 !\n"));

            CopiaDocumento(new Xerox(), "Testando 3 !\n");

            var escaneadora = new Escaneadora();
            var textoEscaneado = escaneadora.Escanear("The book is on the table !\n");
            Console.WriteLine(textoEscaneado);

            var multifuncional = new Multifuncional();
            var impresasao = multifuncional.Imprimir("teste impressão !\n");
            Console.WriteLine(impresasao);

            var copia = multifuncional.Copiar("teste cópia !\n");
            Console.WriteLine(copia);

            var escaneado = multifuncional.Escanear("teste escaneamento !");
            Console.WriteLine(escaneado);
        }

        static void CopiaDocumento(ICopiadora c, string texto)
        {
            Console.WriteLine("Copiando o texto a seguir :" + c.Copiar(texto));
        }
    }
}
