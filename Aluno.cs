using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio4AtosArquivoWF
{
    internal class Aluno : Pessoa
    {
        public string Matricula { get; }
        public string CodigoCurso { get; }
        public string NomeCurso { get; }

        public Aluno(Pessoa pessoa, string matricula, string codigoCurso, string nomeCurso) : base(pessoa.Nome, pessoa.Telefone, pessoa.Cidade, pessoa.RG, pessoa.CPF)
        {
            Matricula = matricula;
            CodigoCurso = codigoCurso;
            NomeCurso = nomeCurso;
        }
    }
}
