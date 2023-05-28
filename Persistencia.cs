using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.LinkLabel;

namespace Desafio4AtosArquivoWF
{
    /// <summary>
    /// Classe responsável por ler e processar o arquivo recebido 
    /// </summary>
    internal  static class Persistencia
    {
        /// <summary>
        /// Método de classe responsável por ler um arquivo linha a linha e transformar os dados de interesse em objetos
        /// </summary>
        /// <param name="caminhoArquivo"></param>
        /// <param name="alunos"></param>
        /// <param name="pessoas"></param>
        public static void ProcessaArquivo(string caminhoArquivo, List<Aluno> alunos, List<Pessoa> pessoas)
        {
            try
            {
                // Abre o arquivo para leitura
                using (StreamReader leitor = new StreamReader(caminhoArquivo, Encoding.UTF8))
                {
                    string linha;
                    // Lê cada linha do arquivo
                    while ((linha = leitor.ReadLine()) != null)
                    {
                        // Se a linha começa com "Z", é uma pessoa
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
                        }
                        // Se a linha começa com "Y", o "Z" de cima é um aluno
                        else if (linha.StartsWith("Y"))
                        {
                            string[] dadosAluno = linha.Split('-');
                            string matricula = dadosAluno[1];
                            string codigoCurso = dadosAluno[2];
                            string nomeCurso = dadosAluno[3];
                            Aluno aluno = new Aluno(pessoas[pessoas.Count - 1], matricula, codigoCurso, nomeCurso);
                            alunos.Add(aluno);
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
