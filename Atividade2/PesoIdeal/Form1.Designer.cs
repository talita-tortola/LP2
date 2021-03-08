
namespace PesoIdeal
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
            this.LblAltura = new System.Windows.Forms.Label();
            this.LblSexo = new System.Windows.Forms.Label();
            this.LblPeso = new System.Windows.Forms.Label();
            this.RbtnMasculino = new System.Windows.Forms.RadioButton();
            this.RbtnFeminino = new System.Windows.Forms.RadioButton();
            this.MskbxAltura = new System.Windows.Forms.MaskedTextBox();
            this.MskbxPeso = new System.Windows.Forms.MaskedTextBox();
            this.BtnCalcular = new System.Windows.Forms.Button();
            this.BtnLimpar = new System.Windows.Forms.Button();
            this.BtnSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblAltura
            // 
            this.LblAltura.AutoSize = true;
            this.LblAltura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAltura.Location = new System.Drawing.Point(74, 68);
            this.LblAltura.Name = "LblAltura";
            this.LblAltura.Size = new System.Drawing.Size(62, 20);
            this.LblAltura.TabIndex = 0;
            this.LblAltura.Text = "Altura:";
            // 
            // LblSexo
            // 
            this.LblSexo.AutoSize = true;
            this.LblSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSexo.Location = new System.Drawing.Point(74, 121);
            this.LblSexo.Name = "LblSexo";
            this.LblSexo.Size = new System.Drawing.Size(54, 20);
            this.LblSexo.TabIndex = 1;
            this.LblSexo.Text = "Sexo:";
            // 
            // LblPeso
            // 
            this.LblPeso.AutoSize = true;
            this.LblPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPeso.Location = new System.Drawing.Point(74, 176);
            this.LblPeso.Name = "LblPeso";
            this.LblPeso.Size = new System.Drawing.Size(101, 20);
            this.LblPeso.TabIndex = 2;
            this.LblPeso.Text = "Peso Atual:";
            // 
            // RbtnMasculino
            // 
            this.RbtnMasculino.AutoSize = true;
            this.RbtnMasculino.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbtnMasculino.Location = new System.Drawing.Point(220, 119);
            this.RbtnMasculino.Name = "RbtnMasculino";
            this.RbtnMasculino.Size = new System.Drawing.Size(98, 24);
            this.RbtnMasculino.TabIndex = 2;
            this.RbtnMasculino.TabStop = true;
            this.RbtnMasculino.Text = "Masculino";
            this.RbtnMasculino.UseVisualStyleBackColor = true;
            // 
            // RbtnFeminino
            // 
            this.RbtnFeminino.AutoSize = true;
            this.RbtnFeminino.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbtnFeminino.Location = new System.Drawing.Point(406, 119);
            this.RbtnFeminino.Name = "RbtnFeminino";
            this.RbtnFeminino.Size = new System.Drawing.Size(92, 24);
            this.RbtnFeminino.TabIndex = 3;
            this.RbtnFeminino.TabStop = true;
            this.RbtnFeminino.Text = "Feminino";
            this.RbtnFeminino.UseVisualStyleBackColor = true;
            // 
            // MskbxAltura
            // 
            this.MskbxAltura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MskbxAltura.Location = new System.Drawing.Point(219, 65);
            this.MskbxAltura.Mask = "9.99";
            this.MskbxAltura.Name = "MskbxAltura";
            this.MskbxAltura.Size = new System.Drawing.Size(279, 26);
            this.MskbxAltura.TabIndex = 1;
            this.MskbxAltura.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.MskbxAltura_MaskInputRejected);
            this.MskbxAltura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MskbxAltura_KeyPress);
            // 
            // MskbxPeso
            // 
            this.MskbxPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MskbxPeso.Location = new System.Drawing.Point(219, 173);
            this.MskbxPeso.Mask = "999.99";
            this.MskbxPeso.Name = "MskbxPeso";
            this.MskbxPeso.Size = new System.Drawing.Size(279, 26);
            this.MskbxPeso.TabIndex = 4;
            this.MskbxPeso.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.MskbxPeso_MaskInputRejected);
            this.MskbxPeso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MskbxPeso_KeyPress);
            // 
            // BtnCalcular
            // 
            this.BtnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCalcular.Location = new System.Drawing.Point(219, 252);
            this.BtnCalcular.Name = "BtnCalcular";
            this.BtnCalcular.Size = new System.Drawing.Size(279, 50);
            this.BtnCalcular.TabIndex = 5;
            this.BtnCalcular.Text = "Calcular";
            this.BtnCalcular.UseVisualStyleBackColor = true;
            this.BtnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click);
            // 
            // BtnLimpar
            // 
            this.BtnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLimpar.Location = new System.Drawing.Point(546, 149);
            this.BtnLimpar.Name = "BtnLimpar";
            this.BtnLimpar.Size = new System.Drawing.Size(136, 50);
            this.BtnLimpar.TabIndex = 7;
            this.BtnLimpar.Text = "Limpar";
            this.BtnLimpar.UseVisualStyleBackColor = true;
            this.BtnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // BtnSair
            // 
            this.BtnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSair.Location = new System.Drawing.Point(546, 65);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(136, 50);
            this.BtnSair.TabIndex = 6;
            this.BtnSair.Text = "Sair";
            this.BtnSair.UseVisualStyleBackColor = true;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnSair);
            this.Controls.Add(this.BtnLimpar);
            this.Controls.Add(this.BtnCalcular);
            this.Controls.Add(this.MskbxPeso);
            this.Controls.Add(this.MskbxAltura);
            this.Controls.Add(this.RbtnFeminino);
            this.Controls.Add(this.RbtnMasculino);
            this.Controls.Add(this.LblPeso);
            this.Controls.Add(this.LblSexo);
            this.Controls.Add(this.LblAltura);
            this.Name = "Form1";
            this.Text = "Peso Ideal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblAltura;
        private System.Windows.Forms.Label LblSexo;
        private System.Windows.Forms.Label LblPeso;
        private System.Windows.Forms.RadioButton RbtnMasculino;
        private System.Windows.Forms.RadioButton RbtnFeminino;
        private System.Windows.Forms.MaskedTextBox MskbxAltura;
        private System.Windows.Forms.MaskedTextBox MskbxPeso;
        private System.Windows.Forms.Button BtnCalcular;
        private System.Windows.Forms.Button BtnLimpar;
        private System.Windows.Forms.Button BtnSair;
    }
}

