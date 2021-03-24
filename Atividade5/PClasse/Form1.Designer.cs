
namespace PClasse
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
            this.BtnMensalista = new System.Windows.Forms.Button();
            this.BtnHorista = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnMensalista
            // 
            this.BtnMensalista.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMensalista.Location = new System.Drawing.Point(146, 177);
            this.BtnMensalista.Name = "BtnMensalista";
            this.BtnMensalista.Size = new System.Drawing.Size(207, 95);
            this.BtnMensalista.TabIndex = 0;
            this.BtnMensalista.Text = "Mensalista";
            this.BtnMensalista.UseVisualStyleBackColor = true;
            this.BtnMensalista.Click += new System.EventHandler(this.BtnMensalista_Click);
            // 
            // BtnHorista
            // 
            this.BtnHorista.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnHorista.Location = new System.Drawing.Point(446, 177);
            this.BtnHorista.Name = "BtnHorista";
            this.BtnHorista.Size = new System.Drawing.Size(207, 95);
            this.BtnHorista.TabIndex = 1;
            this.BtnHorista.Text = "Horista";
            this.BtnHorista.UseVisualStyleBackColor = true;
            this.BtnHorista.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnHorista);
            this.Controls.Add(this.BtnMensalista);
            this.Name = "Form1";
            this.Text = "Classes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnMensalista;
        private System.Windows.Forms.Button BtnHorista;
    }
}

