using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio4AtosArquivoWF
{
    internal class Pessoa
    {
        // Propriedades da classe Pessoa
        public string Nome { get; }
        public string Telefone { get; }
        public string Cidade { get; }
        public string RG { get; }
        public string CPF { get; }

        // Construtor da classe Pessoa
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
