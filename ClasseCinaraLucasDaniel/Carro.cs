using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classe
{
    public class Carro
    {      

        public Carro(long carroId, string nome, string modelo)
        {
            CarroId = carroId;
            Nome = nome;
            Modelo = modelo;
        }

        public long CarroId { get; set; }

        public string Nome { get; set; }

        public string Modelo { get; set; }
    }
}
