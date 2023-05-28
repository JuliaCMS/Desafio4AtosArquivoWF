namespace Desafio4AtosArquivoWF
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonPesquisarArquivo = new Button();
            labelCabecalho = new Label();
            textBoxCaminhoArquivo = new TextBox();
            labelCaminhoArquivo = new Label();
            labelTexto = new Label();
            labelAlunos = new Label();
            textBoxAlunos = new TextBox();
            labelPessoas = new Label();
            labelTotalAlunos = new Label();
            textBoxPessoas = new TextBox();
            labelTotalPessoas = new Label();
            textBoxTotalAlunos = new TextBox();
            textBoxTotalPessoas = new TextBox();
            buttonNovaPesquisa = new Button();
            SuspendLayout();
            // 
            // buttonPesquisarArquivo
            // 
            buttonPesquisarArquivo.Font = new Font("Calibri", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            buttonPesquisarArquivo.Location = new Point(717, 114);
            buttonPesquisarArquivo.Name = "buttonPesquisarArquivo";
            buttonPesquisarArquivo.Size = new Size(94, 29);
            buttonPesquisarArquivo.TabIndex = 0;
            buttonPesquisarArquivo.Text = "Pesquisar";
            buttonPesquisarArquivo.UseVisualStyleBackColor = true;
            buttonPesquisarArquivo.Click += buttonPesquisarArquivo_Click;
            // 
            // labelCabecalho
            // 
            labelCabecalho.AutoSize = true;
            labelCabecalho.Font = new Font("Calibri", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            labelCabecalho.Location = new Point(19, 21);
            labelCabecalho.Name = "labelCabecalho";
            labelCabecalho.Size = new Size(289, 41);
            labelCabecalho.TabIndex = 1;
            labelCabecalho.Text = "Pesquisa de Alunos";
            // 
            // textBoxCaminhoArquivo
            // 
            textBoxCaminhoArquivo.Location = new Point(184, 116);
            textBoxCaminhoArquivo.Name = "textBoxCaminhoArquivo";
            textBoxCaminhoArquivo.Size = new Size(527, 27);
            textBoxCaminhoArquivo.TabIndex = 2;
            // 
            // labelCaminhoArquivo
            // 
            labelCaminhoArquivo.AutoSize = true;
            labelCaminhoArquivo.Font = new Font("Calibri", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            labelCaminhoArquivo.Location = new Point(22, 122);
            labelCaminhoArquivo.Name = "labelCaminhoArquivo";
            labelCaminhoArquivo.Size = new Size(156, 21);
            labelCaminhoArquivo.TabIndex = 3;
            labelCaminhoArquivo.Text = "Caminho do arquivo:";
            // 
            // labelTexto
            // 
            labelTexto.AutoSize = true;
            labelTexto.Font = new Font("Calibri", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelTexto.Location = new Point(22, 78);
            labelTexto.Name = "labelTexto";
            labelTexto.Size = new Size(741, 21);
            labelTexto.TabIndex = 4;
            labelTexto.Text = "Para pesquisar se um arquivo contém dados de alunos da instituição, insira abaixo o caminho do arquivo.";
            // 
            // labelAlunos
            // 
            labelAlunos.AutoSize = true;
            labelAlunos.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelAlunos.Location = new Point(22, 198);
            labelAlunos.Name = "labelAlunos";
            labelAlunos.Size = new Size(140, 18);
            labelAlunos.TabIndex = 7;
            labelAlunos.Text = "Alunos da instituição:";
            // 
            // textBoxAlunos
            // 
            textBoxAlunos.Enabled = false;
            textBoxAlunos.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxAlunos.Location = new Point(22, 225);
            textBoxAlunos.Multiline = true;
            textBoxAlunos.Name = "textBoxAlunos";
            textBoxAlunos.ReadOnly = true;
            textBoxAlunos.ScrollBars = ScrollBars.Both;
            textBoxAlunos.Size = new Size(564, 303);
            textBoxAlunos.TabIndex = 8;
            // 
            // labelPessoas
            // 
            labelPessoas.AutoSize = true;
            labelPessoas.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelPessoas.Location = new Point(651, 198);
            labelPessoas.Name = "labelPessoas";
            labelPessoas.Size = new Size(194, 18);
            labelPessoas.TabIndex = 9;
            labelPessoas.Text = "Todas as pessoas encontradas:";
            // 
            // labelTotalAlunos
            // 
            labelTotalAlunos.AutoSize = true;
            labelTotalAlunos.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelTotalAlunos.Location = new Point(22, 547);
            labelTotalAlunos.Name = "labelTotalAlunos";
            labelTotalAlunos.Size = new Size(138, 18);
            labelTotalAlunos.TabIndex = 10;
            labelTotalAlunos.Text = "Total de ocorrências: ";
            // 
            // textBoxPessoas
            // 
            textBoxPessoas.Enabled = false;
            textBoxPessoas.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPessoas.Location = new Point(651, 225);
            textBoxPessoas.Multiline = true;
            textBoxPessoas.Name = "textBoxPessoas";
            textBoxPessoas.ReadOnly = true;
            textBoxPessoas.ScrollBars = ScrollBars.Both;
            textBoxPessoas.Size = new Size(421, 303);
            textBoxPessoas.TabIndex = 11;
            // 
            // labelTotalPessoas
            // 
            labelTotalPessoas.AutoSize = true;
            labelTotalPessoas.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelTotalPessoas.Location = new Point(651, 543);
            labelTotalPessoas.Name = "labelTotalPessoas";
            labelTotalPessoas.Size = new Size(138, 18);
            labelTotalPessoas.TabIndex = 12;
            labelTotalPessoas.Text = "Total de ocorrências: ";
            // 
            // textBoxTotalAlunos
            // 
            textBoxTotalAlunos.Enabled = false;
            textBoxTotalAlunos.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxTotalAlunos.Location = new Point(156, 539);
            textBoxTotalAlunos.Name = "textBoxTotalAlunos";
            textBoxTotalAlunos.ReadOnly = true;
            textBoxTotalAlunos.Size = new Size(49, 26);
            textBoxTotalAlunos.TabIndex = 13;
            // 
            // textBoxTotalPessoas
            // 
            textBoxTotalPessoas.Enabled = false;
            textBoxTotalPessoas.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxTotalPessoas.Location = new Point(785, 534);
            textBoxTotalPessoas.Name = "textBoxTotalPessoas";
            textBoxTotalPessoas.ReadOnly = true;
            textBoxTotalPessoas.Size = new Size(49, 26);
            textBoxTotalPessoas.TabIndex = 14;
            // 
            // buttonNovaPesquisa
            // 
            buttonNovaPesquisa.Enabled = false;
            buttonNovaPesquisa.Font = new Font("Calibri", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            buttonNovaPesquisa.Location = new Point(819, 114);
            buttonNovaPesquisa.Name = "buttonNovaPesquisa";
            buttonNovaPesquisa.Size = new Size(124, 29);
            buttonNovaPesquisa.TabIndex = 15;
            buttonNovaPesquisa.Text = "Nova pesquisa";
            buttonNovaPesquisa.UseVisualStyleBackColor = true;
            buttonNovaPesquisa.Click += buttonNovaPesquisa_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1091, 602);
            Controls.Add(buttonNovaPesquisa);
            Controls.Add(textBoxTotalPessoas);
            Controls.Add(textBoxTotalAlunos);
            Controls.Add(labelTotalPessoas);
            Controls.Add(textBoxPessoas);
            Controls.Add(labelTotalAlunos);
            Controls.Add(labelPessoas);
            Controls.Add(textBoxAlunos);
            Controls.Add(labelAlunos);
            Controls.Add(labelTexto);
            Controls.Add(labelCaminhoArquivo);
            Controls.Add(textBoxCaminhoArquivo);
            Controls.Add(labelCabecalho);
            Controls.Add(buttonPesquisarArquivo);
            Name = "Form1";
            Padding = new Padding(10);
            Text = "Processador de Dados";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonPesquisarArquivo;
        private Label labelCabecalho;
        private TextBox textBoxCaminhoArquivo;
        private Label labelCaminhoArquivo;
        private Label labelTexto;
        private Label labelAlunos;
        private TextBox textBoxAlunos;
        private Label labelPessoas;
        private Label labelTotalAlunos;
        private TextBox textBoxPessoas;
        private Label labelTotalPessoas;
        private TextBox textBoxTotalAlunos;
        private TextBox textBoxTotalPessoas;
        private Button buttonNovaPesquisa;

    }
}