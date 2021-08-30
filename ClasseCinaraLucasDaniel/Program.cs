using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classe
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro carro = new Carro(157, "Meu carrinho fofo", "Vectra 1.6v");
            Console.WriteLine($"Seu carro se chama: {carro.Nome} do modelo: {carro.Modelo}");
            Console.ReadLine();
        }
    }
}
