namespace Desafio4AtosArquivoWF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonPesquisarArquivo_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("O botão foi apertado");
            string nomeArquivo = textBoxNomeArquivo.Text;
        }

        private void buttonLimparTudo_Click(object sender, EventArgs e)
        {
            textBoxNomeArquivo.Text = string.Empty;
            textBoxDadosArquivo.Text = string.Empty;
            textBoxAlunos.Text = string.Empty;
            textBoxTotalAlunos.Text = string.Empty;
            textBoxPessoas.Text = string.Empty;
            textBoxTotalPessoas.Text = string.Empty;
        }
    }
}