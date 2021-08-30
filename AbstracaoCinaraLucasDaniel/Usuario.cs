﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstracaoCinaraLucasDaniel
{
    public abstract class Usuario
    {
        // Atributos comuns para todos usuários
        public long Id { get; set; }

        public string Nome { get; set; }

        public string Email { get; set; }

        public string Senha { get; set; }

        public string Tipo { get; set; }
    }
}
