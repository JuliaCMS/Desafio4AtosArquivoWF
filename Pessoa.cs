using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio4AtosArquivoWF
{
    internal class Pessoa
    {
        public string Nome { get; }
        public string Telefone { get; }
        public string Cidade { get; }
        public string RG { get; }
        public string CPF { get; }

        public Pessoa(string nome, string telefone, string cidade, string rg, string cpf)
        {
            Nome = nome;
            Telefone = telefone;
            Cidade = cidade;
            RG = rg;
            CPF = cpf;
        }
    }
}
