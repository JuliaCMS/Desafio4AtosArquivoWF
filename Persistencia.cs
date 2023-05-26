using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.LinkLabel;

namespace Desafio4AtosArquivoWF
{
    internal  static class Persistencia
    {
        public static void ProcessaArquivo(string nomeArquivo, List<Aluno> alunos, List<Pessoa> pessoas)
        {
            try
            {
                using (StreamReader leitor = new StreamReader(nomeArquivo, Encoding.UTF8))
                {
                    string linha;
                    while ((linha = leitor.ReadLine()) != null)
                    {
                        Console.WriteLine("Linha do arquivo: " + linha); // Mensagem de depuração
                        if (linha.StartsWith("Z"))
                        {
                            string[] dadosPessoa = linha.Split('-');
                            string nome = dadosPessoa[1];
                            string telefone = dadosPessoa[2];
                            string cidade = dadosPessoa[3];
                            string rg = dadosPessoa[4];
                            string cpf = dadosPessoa[5];
                            Pessoa pessoa = new Pessoa(nome, telefone, cidade, rg, cpf);
                            pessoas.Add(pessoa);
                            Console.WriteLine("Pessoa adicionada: " + pessoa.Nome); // Mensagem de depuração

                        }
                        else if (linha.StartsWith("Y"))
                        {
                            string[] dadosAluno = linha.Split('-');
                            string matricula = dadosAluno[1];
                            string codigoCurso = dadosAluno[2];
                            string nomeCurso = dadosAluno[3];
                            Aluno aluno = new Aluno(pessoas[pessoas.Count - 1], matricula, codigoCurso, nomeCurso);
                            alunos.Add(aluno);
                            Console.WriteLine("Aluno adicionado: " + aluno.Matricula); // Mensagem de depuração

                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Problemas com o arquivo");
            }
        }

    }
}
