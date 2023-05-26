namespace Desafio4AtosArquivoWF
{
    public partial class Form1 : Form
    {
        List<string[]> lista = new List<string[]>();
        List<Pessoa> pessoas = new List<Pessoa>();
        List<Aluno> alunos = new List<Aluno>();
        string nomeArquivo = string.Empty;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonPesquisarArquivo_Click(object sender, EventArgs e)
        {
            nomeArquivo = textBoxNomeArquivo.Text;

            Persistencia.ProcessaArquivo(nomeArquivo, alunos, pessoas);
            ExibirDadosAlunos();
            ExibirDadosPessoas();
        }

        public void ExibirDadosAlunos()
        {
            textBoxAlunos.Text = string.Empty;

            foreach (Aluno aluno in alunos)
            {
                textBoxAlunos.AppendText($"Matricula: {aluno.Matricula} | Nome: {aluno.Nome} | Curso: {aluno.NomeCurso}" + Environment.NewLine);
            }
        }

        public void ExibirDadosPessoas()
        {
            textBoxPessoas.Text = string.Empty;

            foreach (Pessoa pessoa in pessoas)
            {
                textBoxPessoas.AppendText($"Nome: {pessoa.Nome} | Cidade: {pessoa.Cidade} " + Environment.NewLine);
            }
        }

        private void buttonLimparTudo_Click(object sender, EventArgs e)
        {
            textBoxNomeArquivo.Text = string.Empty;
            textBoxAlunos.Text = string.Empty;
            textBoxTotalAlunos.Text = string.Empty;
            textBoxPessoas.Text = string.Empty;
            textBoxTotalPessoas.Text = string.Empty;
        }

    }
}