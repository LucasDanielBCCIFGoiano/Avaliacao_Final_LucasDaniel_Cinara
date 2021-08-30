using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstracaoCinaraLucasDaniel
{
    public class UsuarioLogin : Usuario
    {
        public string TokenSessaoAtual { get; set; }

        public DateTime UltimoLogin { get; set; }
    }
}
