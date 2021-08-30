using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerancaCinaraLucasDaniel
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro carroMeu = new Carro("Golzinho bola", "Gol rebaixado com som no talo", "Fiat 1.0v", 35000, "132Cv");
            Console.WriteLine($"Seu carro é {carroMeu.Nome}, valor atual: R${carroMeu.Valor} e possui {carroMeu.PotenciaMotor}");

            Moto motoMinha = new Moto("Titan", "Titan 160 debochada", "Honda", 140000, "160cc");
            Console.WriteLine($"Sua moto é {motoMinha.Nome}, valor atual: R${motoMinha.Valor} e possui {motoMinha.Cilindradas}");

            Console.ReadLine();
        }
    }
}
