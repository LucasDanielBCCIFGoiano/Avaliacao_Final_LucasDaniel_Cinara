using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerancaCinaraLucasDaniel
{
    public class Moto : Automovel
    {
        public Moto(string nome, string descricao, string modelo, decimal valor, string cilindradas)
        {
            Nome = nome;
            Descricao = descricao;
            Modelo = modelo;
            Valor = valor;
            Cilindradas = cilindradas;
        }

        public string Cilindradas { get; set; }
    }
}
