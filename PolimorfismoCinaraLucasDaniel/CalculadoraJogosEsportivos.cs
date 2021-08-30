using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolimorfismoCinaraLucasDaniel
{
    public class CalculadoraJogosEsportivos : CalculadoraBase
    {
        public CalculadoraJogosEsportivos(decimal valorA, decimal valorB, decimal pesoOddJogo) : base(valorA, valorB)
        {
            PesoOddJogo = pesoOddJogo;
        }

        public decimal PesoOddJogo { get; set; } // Todo jogo esportivo tem um adicional do valor de aposta que é o ODD

        public override decimal SomarNumeros()
        {
            return base.SomarNumeros()*PesoOddJogo;
        }
    }
}
