using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulamentoCinaraLucasDaniel
{
    class Program
    {
        static void Main(string[] args)
        {
            PessoaFisica pessoaF = new PessoaFisica("Cícero", "Zelador");
            Console.WriteLine($"Nome: {pessoaF.Nome} - Profissão: {pessoaF.Descricao}");
            // Perceba que não dá pra acessar nem o Id tampouco o TipoPessoa (pois agora estamos em um foldr diferente)
            // Já o Id, só é acessivel inner class, o mesmo acontece para pessoa jurídica, veja:
            PessoaJuridica pessoaJ = new PessoaJuridica("E.R Comercio E Varejo", "Fornecedor de cigarro Palheiros");
            Console.WriteLine($"Nome da empresa: {pessoaJ.Nome} - Setor: {pessoaJ.Descricao}");

            Console.ReadLine();
        }
    }
}
