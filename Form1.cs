namespace Desafio4AtosArquivoWF
{
    public partial class Form1 : Form
    {
        List<Pessoa> pessoas = new List<Pessoa>();
        List<Aluno> alunos = new List<Aluno>();
        string caminhoArquivo = string.Empty;

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Evento do botão "Pesquisar Arquivo" que exibe na tela os resultados encontrados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonPesquisarArquivo_Click(object sender, EventArgs e)
        {
            caminhoArquivo = textBoxCaminhoArquivo.Text;

            // Processa o arquivo e preenche as listas de alunos e pessoas
            Persistencia.ProcessaArquivo(caminhoArquivo, alunos, pessoas);

            ExibirDadosAlunos();
            ExibirDadosPessoas();
            ExibirContagemAlunos();
            ExibirContagemPessoas();
            buttonNovaPesquisa.Enabled = true;
        }

        /// <summary>
        /// método que exibe os dados dos alunos no TextBox textBoxAlunos
        /// </summary>
        public void ExibirDadosAlunos()
        {
            textBoxAlunos.Text = string.Empty;

            foreach (Aluno aluno in alunos)
            {
                textBoxAlunos.AppendText($"Matricula: {aluno.Matricula} | Nome: {aluno.Nome} | Curso: {aluno.NomeCurso}" + Environment.NewLine);
            }
        }

        /// <summary>
        /// Método que exibe os dados dos alunos no TextBox textBoxPessoas
        /// </summary>
        public void ExibirDadosPessoas()
        {
            textBoxPessoas.Text = string.Empty;

            foreach (Pessoa pessoa in pessoas)
            {
                textBoxPessoas.AppendText($"Nome: {pessoa.Nome}" + Environment.NewLine);
            }
        }

        /// <summary>
        /// Método que exibe a contagem de alunos no TextBox textBoxTotalAlunos
        /// </summary>
        public void ExibirContagemAlunos()
        {
            textBoxTotalAlunos.Text = alunos.Count.ToString();
        }

        /// <summary>
        /// Método que exibe a contagem de pessoas no TextBox textBoxTotalPessoas
        /// </summary>
        public void ExibirContagemPessoas()
        {
            textBoxTotalPessoas.Text = pessoas.Count.ToString();
        }

        /// <summary>
        /// Evento do botão "Nova Pesquisa" que limpa todos os campos e listas para ser realizada uma nova pesquisa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonNovaPesquisa_Click_1(object sender, EventArgs e)
        {
            textBoxCaminhoArquivo.Text = string.Empty;
            textBoxAlunos.Text = string.Empty;
            textBoxTotalAlunos.Text = string.Empty;
            textBoxPessoas.Text = string.Empty;
            textBoxTotalPessoas.Text = string.Empty;
            alunos.Clear();
            pessoas.Clear();
            buttonNovaPesquisa.Enabled = false;
        }
    }
}