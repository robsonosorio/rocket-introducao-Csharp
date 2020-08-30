using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuloCalculadora
{
    public static class OperacoesAritimeticas
    {
        public static double Adicao(double parcela1, double parcela2)
        {
            return parcela1 + parcela2;
        }
        public static double Subtracao(double minuando, double subtraindo)
        {
            return minuando - subtraindo;
        }
        public static double Multiplicacao(double multiplicando, double multiplicador)
        {
            return multiplicando * multiplicador;
        }
        public static double Divisao(double dividendo, double divisor)
        {
            return dividendo / divisor;
        }
    }
}
