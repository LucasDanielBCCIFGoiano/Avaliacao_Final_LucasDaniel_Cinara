using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolimorfismoCinaraLucasDaniel
{
    public class CalculadoraBase
    {
        public CalculadoraBase(decimal valorA, decimal valorB) {
            ValorA = valorA;
            ValorB = valorB;
        }

        public decimal ValorA { get; set; }

        public decimal ValorB { get; set; }

        public virtual decimal SomarNumeros()
        {
            return ValorA + ValorB;
        }
    }
}
