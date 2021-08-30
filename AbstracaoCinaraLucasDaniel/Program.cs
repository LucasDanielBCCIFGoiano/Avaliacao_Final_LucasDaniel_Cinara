using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstracaoCinaraLucasDaniel
{
    class Program
    {
        static void Main(string[] args)
        {
            // Agora vamos usar abstração e entender que não dá pra instanciar classes abstratas, elas são só a forma
            // Primeiro vemos que não tem como instanciar Usuario, pois ele é abstrato:
            // Usuario usuario = new Usuario();

            // Agora podemos instanciar UsuarioCadastro e perceber q ele tem atributos comuns e outros diferentes de UsuarioLogin
            UsuarioCadastro usuarioCadastro = new UsuarioCadastro();
            usuarioCadastro.Id = 1435;
            usuarioCadastro.Nome = "Cicero Pompeu";
            usuarioCadastro.Email = "ciceroPeu@gmail.com";
            usuarioCadastro.Senha = "londres2585";
            usuarioCadastro.Tipo = "Básico";
            // Aqui temos as diferenças no cadastro:
            usuarioCadastro.DataCriacaoConta = DateTime.Now;
            usuarioCadastro.DataNascimento = new DateTime(2021, 5, 28);
            
            UsuarioLogin usuarioLogin = new UsuarioLogin();
            usuarioLogin.Id = 1435;
            usuarioLogin.Nome = "Cicero Pompeu";
            usuarioLogin.Email = "ciceroPeu@gmail.com";
            usuarioLogin.Senha = "londres2585";
            usuarioLogin.Tipo = "Básico";

            // Aqui temos as diferenças no login:
            usuarioLogin.UltimoLogin = DateTime.Now;
            usuarioLogin.TokenSessaoAtual = "396e33da544cd05176eaefbb0cce732b";

        }
    }
}
