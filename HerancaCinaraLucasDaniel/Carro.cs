using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerancaCinaraLucasDaniel
{
    public class Carro : Automovel
    {
        public Carro(string nome, string descricao, string modelo, decimal valor, string potenciaMotor)
        {
            Nome = nome;
            Descricao = descricao;
            Modelo = modelo;
            Valor = valor;
            PotenciaMotor = potenciaMotor;
        }

        public string PotenciaMotor { get; set; }        
    }
}
