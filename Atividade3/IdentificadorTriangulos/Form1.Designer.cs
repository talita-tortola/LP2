
namespace IdentificadorTriangulos
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
            this.LblLadoA = new System.Windows.Forms.Label();
            this.LblLadoB = new System.Windows.Forms.Label();
            this.LblLadoC = new System.Windows.Forms.Label();
            this.BtnVerificar = new System.Windows.Forms.Button();
            this.TxtLadoA = new System.Windows.Forms.TextBox();
            this.TxtLadoB = new System.Windows.Forms.TextBox();
            this.TxtLadoC = new System.Windows.Forms.TextBox();
            this.BtnLimpar = new System.Windows.Forms.Button();
            this.BtnSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblLadoA
            // 
            this.LblLadoA.AutoSize = true;
            this.LblLadoA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLadoA.Location = new System.Drawing.Point(115, 68);
            this.LblLadoA.Name = "LblLadoA";
            this.LblLadoA.Size = new System.Drawing.Size(71, 20);
            this.LblLadoA.TabIndex = 0;
            this.LblLadoA.Text = "Lado A:";
            // 
            // LblLadoB
            // 
            this.LblLadoB.AutoSize = true;
            this.LblLadoB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLadoB.Location = new System.Drawing.Point(115, 109);
            this.LblLadoB.Name = "LblLadoB";
            this.LblLadoB.Size = new System.Drawing.Size(71, 20);
            this.LblLadoB.TabIndex = 1;
            this.LblLadoB.Text = "Lado B:";
            // 
            // LblLadoC
            // 
            this.LblLadoC.AutoSize = true;
            this.LblLadoC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLadoC.Location = new System.Drawing.Point(115, 152);
            this.LblLadoC.Name = "LblLadoC";
            this.LblLadoC.Size = new System.Drawing.Size(71, 20);
            this.LblLadoC.TabIndex = 2;
            this.LblLadoC.Text = "Lado C:";
            // 
            // BtnVerificar
            // 
            this.BtnVerificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVerificar.Location = new System.Drawing.Point(214, 221);
            this.BtnVerificar.Name = "BtnVerificar";
            this.BtnVerificar.Size = new System.Drawing.Size(261, 60);
            this.BtnVerificar.TabIndex = 4;
            this.BtnVerificar.Text = "Verificar";
            this.BtnVerificar.UseVisualStyleBackColor = true;
            this.BtnVerificar.Click += new System.EventHandler(this.BtnVerificar_Click);
            // 
            // TxtLadoA
            // 
            this.TxtLadoA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtLadoA.Location = new System.Drawing.Point(214, 65);
            this.TxtLadoA.Name = "TxtLadoA";
            this.TxtLadoA.Size = new System.Drawing.Size(261, 26);
            this.TxtLadoA.TabIndex = 1;
            this.TxtLadoA.TextChanged += new System.EventHandler(this.TxtLadoA_TextChanged);
            this.TxtLadoA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtLadoA_KeyPress);
            // 
            // TxtLadoB
            // 
            this.TxtLadoB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtLadoB.Location = new System.Drawing.Point(214, 106);
            this.TxtLadoB.Name = "TxtLadoB";
            this.TxtLadoB.Size = new System.Drawing.Size(261, 26);
            this.TxtLadoB.TabIndex = 2;
            this.TxtLadoB.TextChanged += new System.EventHandler(this.TxtLadoB_TextChanged);
            this.TxtLadoB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtLadoB_KeyPress);
            // 
            // TxtLadoC
            // 
            this.TxtLadoC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtLadoC.Location = new System.Drawing.Point(214, 149);
            this.TxtLadoC.Name = "TxtLadoC";
            this.TxtLadoC.Size = new System.Drawing.Size(261, 26);
            this.TxtLadoC.TabIndex = 3;
            this.TxtLadoC.TextChanged += new System.EventHandler(this.TxtLadoC_TextChanged);
            this.TxtLadoC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtLadoC_KeyPress);
            // 
            // BtnLimpar
            // 
            this.BtnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLimpar.Location = new System.Drawing.Point(521, 65);
            this.BtnLimpar.Name = "BtnLimpar";
            this.BtnLimpar.Size = new System.Drawing.Size(128, 48);
            this.BtnLimpar.TabIndex = 5;
            this.BtnLimpar.Text = "Limpar";
            this.BtnLimpar.UseVisualStyleBackColor = true;
            this.BtnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // BtnSair
            // 
            this.BtnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSair.Location = new System.Drawing.Point(521, 127);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(128, 48);
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
            this.Controls.Add(this.TxtLadoC);
            this.Controls.Add(this.TxtLadoB);
            this.Controls.Add(this.TxtLadoA);
            this.Controls.Add(this.BtnVerificar);
            this.Controls.Add(this.LblLadoC);
            this.Controls.Add(this.LblLadoB);
            this.Controls.Add(this.LblLadoA);
            this.Name = "Form1";
            this.Text = "Identificador de Triângulos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblLadoA;
        private System.Windows.Forms.Label LblLadoB;
        private System.Windows.Forms.Label LblLadoC;
        private System.Windows.Forms.Button BtnVerificar;
        private System.Windows.Forms.TextBox TxtLadoA;
        private System.Windows.Forms.TextBox TxtLadoB;
        private System.Windows.Forms.TextBox TxtLadoC;
        private System.Windows.Forms.Button BtnLimpar;
        private System.Windows.Forms.Button BtnSair;
    }
}

