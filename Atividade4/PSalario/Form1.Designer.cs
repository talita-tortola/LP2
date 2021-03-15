
namespace PSalario
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnVerificar = new System.Windows.Forms.Button();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblSalarioBruto = new System.Windows.Forms.Label();
            this.lblNumFilhos = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.cbxNumFilhos = new System.Windows.Forms.ComboBox();
            this.lblAliINSS = new System.Windows.Forms.Label();
            this.lblAliIRPF = new System.Windows.Forms.Label();
            this.lblDescINSS = new System.Windows.Forms.Label();
            this.lblDescIRPF = new System.Windows.Forms.Label();
            this.lblSalFamilia = new System.Windows.Forms.Label();
            this.lblSalLiquido = new System.Windows.Forms.Label();
            this.lblMensagem = new System.Windows.Forms.Label();
            this.gbxSexo = new System.Windows.Forms.GroupBox();
            this.rbtnMasc = new System.Windows.Forms.RadioButton();
            this.rbtnFem = new System.Windows.Forms.RadioButton();
            this.gbxEstCivil = new System.Windows.Forms.GroupBox();
            this.rbtnSolteiro = new System.Windows.Forms.RadioButton();
            this.rbtnCasado = new System.Windows.Forms.RadioButton();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.mskbxSalBruto = new System.Windows.Forms.MaskedTextBox();
            this.txtDescINSS = new System.Windows.Forms.TextBox();
            this.txtDescIRPF = new System.Windows.Forms.TextBox();
            this.txtSalLiquido = new System.Windows.Forms.TextBox();
            this.txtAliINSS = new System.Windows.Forms.TextBox();
            this.txtAliIRPF = new System.Windows.Forms.TextBox();
            this.txtSalFamilia = new System.Windows.Forms.TextBox();
            this.gbxSexo.SuspendLayout();
            this.gbxEstCivil.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnVerificar
            // 
            this.btnVerificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerificar.Location = new System.Drawing.Point(272, 189);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(236, 42);
            this.btnVerificar.TabIndex = 8;
            this.btnVerificar.Text = "Verificar Descontos";
            this.btnVerificar.UseVisualStyleBackColor = true;
            this.btnVerificar.Click += new System.EventHandler(this.BtnVerificar_Click);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(48, 32);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(138, 20);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome Funcionário";
            // 
            // lblSalarioBruto
            // 
            this.lblSalarioBruto.AutoSize = true;
            this.lblSalarioBruto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalarioBruto.Location = new System.Drawing.Point(48, 92);
            this.lblSalarioBruto.Name = "lblSalarioBruto";
            this.lblSalarioBruto.Size = new System.Drawing.Size(101, 20);
            this.lblSalarioBruto.TabIndex = 2;
            this.lblSalarioBruto.Text = "Salário Bruto";
            // 
            // lblNumFilhos
            // 
            this.lblNumFilhos.AutoSize = true;
            this.lblNumFilhos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumFilhos.Location = new System.Drawing.Point(48, 144);
            this.lblNumFilhos.Name = "lblNumFilhos";
            this.lblNumFilhos.Size = new System.Drawing.Size(133, 20);
            this.lblNumFilhos.TabIndex = 3;
            this.lblNumFilhos.Text = "Número de Filhos";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(187, 29);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(490, 26);
            this.txtNome.TabIndex = 1;
            // 
            // cbxNumFilhos
            // 
            this.cbxNumFilhos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxNumFilhos.FormattingEnabled = true;
            this.cbxNumFilhos.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.cbxNumFilhos.Location = new System.Drawing.Point(187, 141);
            this.cbxNumFilhos.Name = "cbxNumFilhos";
            this.cbxNumFilhos.Size = new System.Drawing.Size(125, 28);
            this.cbxNumFilhos.TabIndex = 3;
            this.cbxNumFilhos.SelectedIndexChanged += new System.EventHandler(this.CbxFilhos_SelectedIndexChanged);
            // 
            // lblAliINSS
            // 
            this.lblAliINSS.AutoSize = true;
            this.lblAliINSS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAliINSS.Location = new System.Drawing.Point(48, 284);
            this.lblAliINSS.Name = "lblAliINSS";
            this.lblAliINSS.Size = new System.Drawing.Size(109, 20);
            this.lblAliINSS.TabIndex = 7;
            this.lblAliINSS.Text = "Alíquota INSS";
            // 
            // lblAliIRPF
            // 
            this.lblAliIRPF.AutoSize = true;
            this.lblAliIRPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAliIRPF.Location = new System.Drawing.Point(48, 333);
            this.lblAliIRPF.Name = "lblAliIRPF";
            this.lblAliIRPF.Size = new System.Drawing.Size(108, 20);
            this.lblAliIRPF.TabIndex = 8;
            this.lblAliIRPF.Text = "Alíquota IRPF";
            // 
            // lblDescINSS
            // 
            this.lblDescINSS.AutoSize = true;
            this.lblDescINSS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescINSS.Location = new System.Drawing.Point(395, 284);
            this.lblDescINSS.Name = "lblDescINSS";
            this.lblDescINSS.Size = new System.Drawing.Size(120, 20);
            this.lblDescINSS.TabIndex = 9;
            this.lblDescINSS.Text = "Desconto INSS";
            // 
            // lblDescIRPF
            // 
            this.lblDescIRPF.AutoSize = true;
            this.lblDescIRPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescIRPF.Location = new System.Drawing.Point(395, 333);
            this.lblDescIRPF.Name = "lblDescIRPF";
            this.lblDescIRPF.Size = new System.Drawing.Size(119, 20);
            this.lblDescIRPF.TabIndex = 10;
            this.lblDescIRPF.Text = "Desconto IRPF";
            // 
            // lblSalFamilia
            // 
            this.lblSalFamilia.AutoSize = true;
            this.lblSalFamilia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalFamilia.Location = new System.Drawing.Point(48, 384);
            this.lblSalFamilia.Name = "lblSalFamilia";
            this.lblSalFamilia.Size = new System.Drawing.Size(112, 20);
            this.lblSalFamilia.TabIndex = 11;
            this.lblSalFamilia.Text = "Salário Família";
            // 
            // lblSalLiquido
            // 
            this.lblSalLiquido.AutoSize = true;
            this.lblSalLiquido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalLiquido.Location = new System.Drawing.Point(395, 384);
            this.lblSalLiquido.Name = "lblSalLiquido";
            this.lblSalLiquido.Size = new System.Drawing.Size(113, 20);
            this.lblSalLiquido.TabIndex = 12;
            this.lblSalLiquido.Text = "Salário Líquido";
            // 
            // lblMensagem
            // 
            this.lblMensagem.AutoSize = true;
            this.lblMensagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensagem.Location = new System.Drawing.Point(48, 189);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(51, 20);
            this.lblMensagem.TabIndex = 19;
            this.lblMensagem.Text = "label1";
            this.lblMensagem.Visible = false;
            // 
            // gbxSexo
            // 
            this.gbxSexo.Controls.Add(this.rbtnMasc);
            this.gbxSexo.Controls.Add(this.rbtnFem);
            this.gbxSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxSexo.Location = new System.Drawing.Point(328, 69);
            this.gbxSexo.Name = "gbxSexo";
            this.gbxSexo.Size = new System.Drawing.Size(174, 100);
            this.gbxSexo.TabIndex = 20;
            this.gbxSexo.TabStop = false;
            this.gbxSexo.Text = "Sexo";
            // 
            // rbtnMasc
            // 
            this.rbtnMasc.AutoSize = true;
            this.rbtnMasc.Location = new System.Drawing.Point(42, 55);
            this.rbtnMasc.Name = "rbtnMasc";
            this.rbtnMasc.Size = new System.Drawing.Size(98, 24);
            this.rbtnMasc.TabIndex = 5;
            this.rbtnMasc.TabStop = true;
            this.rbtnMasc.Text = "Masculino";
            this.rbtnMasc.UseVisualStyleBackColor = true;
            // 
            // rbtnFem
            // 
            this.rbtnFem.AutoSize = true;
            this.rbtnFem.Checked = true;
            this.rbtnFem.Location = new System.Drawing.Point(42, 25);
            this.rbtnFem.Name = "rbtnFem";
            this.rbtnFem.Size = new System.Drawing.Size(92, 24);
            this.rbtnFem.TabIndex = 4;
            this.rbtnFem.TabStop = true;
            this.rbtnFem.Text = "Feminino";
            this.rbtnFem.UseVisualStyleBackColor = true;
            // 
            // gbxEstCivil
            // 
            this.gbxEstCivil.Controls.Add(this.rbtnSolteiro);
            this.gbxEstCivil.Controls.Add(this.rbtnCasado);
            this.gbxEstCivil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxEstCivil.Location = new System.Drawing.Point(508, 69);
            this.gbxEstCivil.Name = "gbxEstCivil";
            this.gbxEstCivil.Size = new System.Drawing.Size(169, 100);
            this.gbxEstCivil.TabIndex = 21;
            this.gbxEstCivil.TabStop = false;
            this.gbxEstCivil.Text = "Estado Civil";
            // 
            // rbtnSolteiro
            // 
            this.rbtnSolteiro.AutoSize = true;
            this.rbtnSolteiro.Location = new System.Drawing.Point(44, 55);
            this.rbtnSolteiro.Name = "rbtnSolteiro";
            this.rbtnSolteiro.Size = new System.Drawing.Size(94, 24);
            this.rbtnSolteiro.TabIndex = 7;
            this.rbtnSolteiro.TabStop = true;
            this.rbtnSolteiro.Text = "Solteiro/a";
            this.rbtnSolteiro.UseVisualStyleBackColor = true;
            // 
            // rbtnCasado
            // 
            this.rbtnCasado.AutoSize = true;
            this.rbtnCasado.Checked = true;
            this.rbtnCasado.Location = new System.Drawing.Point(44, 25);
            this.rbtnCasado.Name = "rbtnCasado";
            this.rbtnCasado.Size = new System.Drawing.Size(95, 24);
            this.rbtnCasado.TabIndex = 6;
            this.rbtnCasado.TabStop = true;
            this.rbtnCasado.Text = "Casado/a";
            this.rbtnCasado.UseVisualStyleBackColor = true;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(541, 189);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(136, 42);
            this.btnLimpar.TabIndex = 9;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // mskbxSalBruto
            // 
            this.mskbxSalBruto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskbxSalBruto.Location = new System.Drawing.Point(187, 89);
            this.mskbxSalBruto.Mask = "999999.99";
            this.mskbxSalBruto.Name = "mskbxSalBruto";
            this.mskbxSalBruto.Size = new System.Drawing.Size(125, 26);
            this.mskbxSalBruto.TabIndex = 2;
            // 
            // txtDescINSS
            // 
            this.txtDescINSS.Enabled = false;
            this.txtDescINSS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescINSS.Location = new System.Drawing.Point(541, 281);
            this.txtDescINSS.Name = "txtDescINSS";
            this.txtDescINSS.Size = new System.Drawing.Size(136, 26);
            this.txtDescINSS.TabIndex = 24;
            // 
            // txtDescIRPF
            // 
            this.txtDescIRPF.Enabled = false;
            this.txtDescIRPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescIRPF.Location = new System.Drawing.Point(541, 330);
            this.txtDescIRPF.Name = "txtDescIRPF";
            this.txtDescIRPF.Size = new System.Drawing.Size(136, 26);
            this.txtDescIRPF.TabIndex = 25;
            // 
            // txtSalLiquido
            // 
            this.txtSalLiquido.Enabled = false;
            this.txtSalLiquido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalLiquido.Location = new System.Drawing.Point(541, 381);
            this.txtSalLiquido.Name = "txtSalLiquido";
            this.txtSalLiquido.Size = new System.Drawing.Size(136, 26);
            this.txtSalLiquido.TabIndex = 26;
            // 
            // txtAliINSS
            // 
            this.txtAliINSS.Enabled = false;
            this.txtAliINSS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAliINSS.Location = new System.Drawing.Point(187, 281);
            this.txtAliINSS.Name = "txtAliINSS";
            this.txtAliINSS.Size = new System.Drawing.Size(136, 26);
            this.txtAliINSS.TabIndex = 27;
            // 
            // txtAliIRPF
            // 
            this.txtAliIRPF.Enabled = false;
            this.txtAliIRPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAliIRPF.Location = new System.Drawing.Point(187, 330);
            this.txtAliIRPF.Name = "txtAliIRPF";
            this.txtAliIRPF.Size = new System.Drawing.Size(136, 26);
            this.txtAliIRPF.TabIndex = 28;
            // 
            // txtSalFamilia
            // 
            this.txtSalFamilia.Enabled = false;
            this.txtSalFamilia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalFamilia.Location = new System.Drawing.Point(187, 381);
            this.txtSalFamilia.Name = "txtSalFamilia";
            this.txtSalFamilia.Size = new System.Drawing.Size(136, 26);
            this.txtSalFamilia.TabIndex = 29;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 450);
            this.Controls.Add(this.txtSalFamilia);
            this.Controls.Add(this.txtAliIRPF);
            this.Controls.Add(this.txtAliINSS);
            this.Controls.Add(this.txtSalLiquido);
            this.Controls.Add(this.txtDescIRPF);
            this.Controls.Add(this.txtDescINSS);
            this.Controls.Add(this.mskbxSalBruto);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.gbxEstCivil);
            this.Controls.Add(this.gbxSexo);
            this.Controls.Add(this.lblMensagem);
            this.Controls.Add(this.lblSalLiquido);
            this.Controls.Add(this.lblSalFamilia);
            this.Controls.Add(this.lblDescIRPF);
            this.Controls.Add(this.lblDescINSS);
            this.Controls.Add(this.lblAliIRPF);
            this.Controls.Add(this.lblAliINSS);
            this.Controls.Add(this.cbxNumFilhos);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNumFilhos);
            this.Controls.Add(this.lblSalarioBruto);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.btnVerificar);
            this.Name = "Form1";
            this.Text = "Cálculo de Salário Líquido de Funcionário";
            this.gbxSexo.ResumeLayout(false);
            this.gbxSexo.PerformLayout();
            this.gbxEstCivil.ResumeLayout(false);
            this.gbxEstCivil.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblSalarioBruto;
        private System.Windows.Forms.Label lblNumFilhos;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.ComboBox cbxNumFilhos;
        private System.Windows.Forms.Label lblAliINSS;
        private System.Windows.Forms.Label lblAliIRPF;
        private System.Windows.Forms.Label lblDescINSS;
        private System.Windows.Forms.Label lblDescIRPF;
        private System.Windows.Forms.Label lblSalFamilia;
        private System.Windows.Forms.Label lblSalLiquido;
        private System.Windows.Forms.Label lblMensagem;
        private System.Windows.Forms.GroupBox gbxSexo;
        private System.Windows.Forms.RadioButton rbtnMasc;
        private System.Windows.Forms.RadioButton rbtnFem;
        private System.Windows.Forms.GroupBox gbxEstCivil;
        private System.Windows.Forms.RadioButton rbtnSolteiro;
        private System.Windows.Forms.RadioButton rbtnCasado;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.MaskedTextBox mskbxSalBruto;
        private System.Windows.Forms.TextBox txtDescINSS;
        private System.Windows.Forms.TextBox txtDescIRPF;
        private System.Windows.Forms.TextBox txtSalLiquido;
        private System.Windows.Forms.TextBox txtAliINSS;
        private System.Windows.Forms.TextBox txtAliIRPF;
        private System.Windows.Forms.TextBox txtSalFamilia;
    }
}

