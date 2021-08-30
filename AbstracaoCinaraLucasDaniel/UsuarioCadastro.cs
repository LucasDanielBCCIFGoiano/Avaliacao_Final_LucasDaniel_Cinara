using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstracaoCinaraLucasDaniel
{
    public class UsuarioCadastro : Usuario
    {
        public DateTime DataNascimento { get; set; }

        public DateTime DataCriacaoConta { get; set; }

        public string HashSenhaBanco { get; set; }        
    }
}
