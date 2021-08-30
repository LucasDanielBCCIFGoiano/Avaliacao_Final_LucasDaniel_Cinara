using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulamentoCinaraLucasDaniel
{
    public class PessoaFisica : Pessoa
    {
        public PessoaFisica(string nome, string descricao) 
        {
            Nome = nome;
            Descricao = descricao;
            TipoPessoa = "Física";
        }
    }
}
