using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulamentoCinaraLucasDaniel
{
    public class Pessoa
    {
        public Pessoa()
        {
            Id = new Random().Next();
        }

        private long Id { get; }

        protected string TipoPessoa { get; set; }

        public string Nome { get; set; }

        public string Descricao { get; set; }
    }
}
