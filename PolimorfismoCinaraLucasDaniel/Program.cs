using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolimorfismoCinaraLucasDaniel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Utilizando a calculadora base:");
            CalculadoraBase calculadora = new CalculadoraBase(15, 25);

            Console.WriteLine($"Valor final: R$:{calculadora.SomarNumeros()}");           
            Console.WriteLine("Utilizando a calculadora de jogos:");
            CalculadoraJogosEsportivos calculadoraJogos = new CalculadoraJogosEsportivos(calculadora.ValorA, calculadora.ValorB, 1.5m);
            Console.WriteLine($"Valor final: R$:{calculadoraJogos.SomarNumeros()}");
            Console.ReadLine();
        }
    }
}
