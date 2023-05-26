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
            textBoxNomeArquivo = new TextBox();
            labelNomeArquivo = new Label();
            labelTexto = new Label();
            textBoxDadosArquivo = new TextBox();
            labelDadosArquivo = new Label();
            labelAlunos = new Label();
            textBoxAlunos = new TextBox();
            labelPessoas = new Label();
            labelTotalAlunos = new Label();
            textBoxPessoas = new TextBox();
            labelTotalPessoas = new Label();
            textBoxTotalAlunos = new TextBox();
            textBoxTotalPessoas = new TextBox();
            buttonLimparTudo = new Button();
            SuspendLayout();
            // 
            // buttonPesquisarArquivo
            // 
            buttonPesquisarArquivo.Location = new Point(459, 113);
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
            labelCabecalho.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            labelCabecalho.Location = new Point(22, 19);
            labelCabecalho.Name = "labelCabecalho";
            labelCabecalho.Size = new Size(306, 46);
            labelCabecalho.TabIndex = 1;
            labelCabecalho.Text = "Pesquisa de Alunos";
            // 
            // textBoxNomeArquivo
            // 
            textBoxNomeArquivo.Location = new Point(157, 115);
            textBoxNomeArquivo.Name = "textBoxNomeArquivo";
            textBoxNomeArquivo.Size = new Size(296, 27);
            textBoxNomeArquivo.TabIndex = 2;
            // 
            // labelNomeArquivo
            // 
            labelNomeArquivo.AutoSize = true;
            labelNomeArquivo.Location = new Point(22, 122);
            labelNomeArquivo.Name = "labelNomeArquivo";
            labelNomeArquivo.Size = new Size(129, 20);
            labelNomeArquivo.TabIndex = 3;
            labelNomeArquivo.Text = "Nome do arquivo:";
            // 
            // labelTexto
            // 
            labelTexto.AutoSize = true;
            labelTexto.Location = new Point(22, 78);
            labelTexto.Name = "labelTexto";
            labelTexto.Size = new Size(686, 20);
            labelTexto.TabIndex = 4;
            labelTexto.Text = "Para pesquisar se um arquivo contém dados de alunos da instituição, insira abaixo o nome do arquivo.";
            // 
            // textBoxDadosArquivo
            // 
            textBoxDadosArquivo.Enabled = false;
            textBoxDadosArquivo.Location = new Point(22, 195);
            textBoxDadosArquivo.Multiline = true;
            textBoxDadosArquivo.Name = "textBoxDadosArquivo";
            textBoxDadosArquivo.ReadOnly = true;
            textBoxDadosArquivo.ScrollBars = ScrollBars.Both;
            textBoxDadosArquivo.Size = new Size(411, 358);
            textBoxDadosArquivo.TabIndex = 5;
            // 
            // labelDadosArquivo
            // 
            labelDadosArquivo.AutoSize = true;
            labelDadosArquivo.Location = new Point(22, 172);
            labelDadosArquivo.Name = "labelDadosArquivo";
            labelDadosArquivo.Size = new Size(211, 20);
            labelDadosArquivo.TabIndex = 6;
            labelDadosArquivo.Text = "Dados do arquivo pesquisado:";
            // 
            // labelAlunos
            // 
            labelAlunos.AutoSize = true;
            labelAlunos.Location = new Point(479, 172);
            labelAlunos.Name = "labelAlunos";
            labelAlunos.Size = new Size(150, 20);
            labelAlunos.TabIndex = 7;
            labelAlunos.Text = "Alunos da instituição:";
            // 
            // textBoxAlunos
            // 
            textBoxAlunos.Enabled = false;
            textBoxAlunos.Location = new Point(479, 195);
            textBoxAlunos.Multiline = true;
            textBoxAlunos.Name = "textBoxAlunos";
            textBoxAlunos.ReadOnly = true;
            textBoxAlunos.ScrollBars = ScrollBars.Both;
            textBoxAlunos.Size = new Size(429, 141);
            textBoxAlunos.TabIndex = 8;
            // 
            // labelPessoas
            // 
            labelPessoas.AutoSize = true;
            labelPessoas.Location = new Point(479, 391);
            labelPessoas.Name = "labelPessoas";
            labelPessoas.Size = new Size(111, 20);
            labelPessoas.TabIndex = 9;
            labelPessoas.Text = "Outras pessoas:";
            // 
            // labelTotalAlunos
            // 
            labelTotalAlunos.AutoSize = true;
            labelTotalAlunos.Location = new Point(479, 346);
            labelTotalAlunos.Name = "labelTotalAlunos";
            labelTotalAlunos.Size = new Size(150, 20);
            labelTotalAlunos.TabIndex = 10;
            labelTotalAlunos.Text = "Total de ocorrências: ";
            // 
            // textBoxPessoas
            // 
            textBoxPessoas.Enabled = false;
            textBoxPessoas.Location = new Point(479, 414);
            textBoxPessoas.Multiline = true;
            textBoxPessoas.Name = "textBoxPessoas";
            textBoxPessoas.ReadOnly = true;
            textBoxPessoas.ScrollBars = ScrollBars.Both;
            textBoxPessoas.Size = new Size(429, 139);
            textBoxPessoas.TabIndex = 11;
            // 
            // labelTotalPessoas
            // 
            labelTotalPessoas.AutoSize = true;
            labelTotalPessoas.Location = new Point(479, 563);
            labelTotalPessoas.Name = "labelTotalPessoas";
            labelTotalPessoas.Size = new Size(150, 20);
            labelTotalPessoas.TabIndex = 12;
            labelTotalPessoas.Text = "Total de ocorrências: ";
            // 
            // textBoxTotalAlunos
            // 
            textBoxTotalAlunos.Enabled = false;
            textBoxTotalAlunos.Location = new Point(625, 339);
            textBoxTotalAlunos.Name = "textBoxTotalAlunos";
            textBoxTotalAlunos.ReadOnly = true;
            textBoxTotalAlunos.Size = new Size(49, 27);
            textBoxTotalAlunos.TabIndex = 13;
            // 
            // textBoxTotalPessoas
            // 
            textBoxTotalPessoas.Enabled = false;
            textBoxTotalPessoas.Location = new Point(625, 556);
            textBoxTotalPessoas.Name = "textBoxTotalPessoas";
            textBoxTotalPessoas.ReadOnly = true;
            textBoxTotalPessoas.Size = new Size(49, 27);
            textBoxTotalPessoas.TabIndex = 14;
            // 
            // buttonLimparTudo
            // 
            buttonLimparTudo.Location = new Point(414, 629);
            buttonLimparTudo.Name = "buttonLimparTudo";
            buttonLimparTudo.Size = new Size(124, 29);
            buttonLimparTudo.TabIndex = 15;
            buttonLimparTudo.Text = "Limpar tudo";
            buttonLimparTudo.UseVisualStyleBackColor = true;
            buttonLimparTudo.Click += buttonLimparTudo_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(950, 678);
            Controls.Add(buttonLimparTudo);
            Controls.Add(textBoxTotalPessoas);
            Controls.Add(textBoxTotalAlunos);
            Controls.Add(labelTotalPessoas);
            Controls.Add(textBoxPessoas);
            Controls.Add(labelTotalAlunos);
            Controls.Add(labelPessoas);
            Controls.Add(textBoxAlunos);
            Controls.Add(labelAlunos);
            Controls.Add(labelDadosArquivo);
            Controls.Add(textBoxDadosArquivo);
            Controls.Add(labelTexto);
            Controls.Add(labelNomeArquivo);
            Controls.Add(textBoxNomeArquivo);
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
        private TextBox textBoxNomeArquivo;
        private Label labelNomeArquivo;
        private Label labelTexto;
        private TextBox textBoxDadosArquivo;
        private Label labelDadosArquivo;
        private Label labelAlunos;
        private TextBox textBoxAlunos;
        private Label labelPessoas;
        private Label labelTotalAlunos;
        private TextBox textBoxPessoas;
        private Label labelTotalPessoas;
        private TextBox textBoxTotalAlunos;
        private TextBox textBoxTotalPessoas;
        private Button buttonLimparTudo;

    }
}