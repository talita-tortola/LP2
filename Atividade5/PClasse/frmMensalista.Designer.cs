
namespace PClasse
{
    partial class frmMensalista
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnInstMenPar = new System.Windows.Forms.Button();
            this.BtnInstMensalista = new System.Windows.Forms.Button();
            this.TxtDataEntrada = new System.Windows.Forms.TextBox();
            this.TxtSalMensal = new System.Windows.Forms.TextBox();
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.TxtMatricula = new System.Windows.Forms.TextBox();
            this.LblDataEntrada = new System.Windows.Forms.Label();
            this.LblSalMensal = new System.Windows.Forms.Label();
            this.LblNome = new System.Windows.Forms.Label();
            this.LblMatricula = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnInstMenPar
            // 
            this.BtnInstMenPar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInstMenPar.Location = new System.Drawing.Point(439, 287);
            this.BtnInstMenPar.Name = "BtnInstMenPar";
            this.BtnInstMenPar.Size = new System.Drawing.Size(248, 62);
            this.BtnInstMenPar.TabIndex = 19;
            this.BtnInstMenPar.Text = "Instanciar Mensalista Passando Parâmetros";
            this.BtnInstMenPar.UseVisualStyleBackColor = true;
            this.BtnInstMenPar.Click += new System.EventHandler(this.BtnInstMenPar_Click);
            // 
            // BtnInstMensalista
            // 
            this.BtnInstMensalista.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInstMensalista.Location = new System.Drawing.Point(105, 287);
            this.BtnInstMensalista.Name = "BtnInstMensalista";
            this.BtnInstMensalista.Size = new System.Drawing.Size(248, 62);
            this.BtnInstMensalista.TabIndex = 18;
            this.BtnInstMensalista.Text = "Instanciar Mensalista";
            this.BtnInstMensalista.UseVisualStyleBackColor = true;
            this.BtnInstMensalista.Click += new System.EventHandler(this.BtnInstMensalista_Click);
            // 
            // TxtDataEntrada
            // 
            this.TxtDataEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDataEntrada.Location = new System.Drawing.Point(355, 185);
            this.TxtDataEntrada.Name = "TxtDataEntrada";
            this.TxtDataEntrada.Size = new System.Drawing.Size(332, 29);
            this.TxtDataEntrada.TabIndex = 17;
            // 
            // TxtSalMensal
            // 
            this.TxtSalMensal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSalMensal.Location = new System.Drawing.Point(355, 149);
            this.TxtSalMensal.Name = "TxtSalMensal";
            this.TxtSalMensal.Size = new System.Drawing.Size(332, 29);
            this.TxtSalMensal.TabIndex = 16;
            // 
            // TxtNome
            // 
            this.TxtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNome.Location = new System.Drawing.Point(355, 110);
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(332, 29);
            this.TxtNome.TabIndex = 15;
            // 
            // TxtMatricula
            // 
            this.TxtMatricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMatricula.Location = new System.Drawing.Point(355, 74);
            this.TxtMatricula.Name = "TxtMatricula";
            this.TxtMatricula.Size = new System.Drawing.Size(332, 29);
            this.TxtMatricula.TabIndex = 14;
            // 
            // LblDataEntrada
            // 
            this.LblDataEntrada.AutoSize = true;
            this.LblDataEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDataEntrada.Location = new System.Drawing.Point(101, 188);
            this.LblDataEntrada.Name = "LblDataEntrada";
            this.LblDataEntrada.Size = new System.Drawing.Size(224, 24);
            this.LblDataEntrada.TabIndex = 13;
            this.LblDataEntrada.Text = "Data Entrada na Empresa";
            // 
            // LblSalMensal
            // 
            this.LblSalMensal.AutoSize = true;
            this.LblSalMensal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSalMensal.Location = new System.Drawing.Point(101, 152);
            this.LblSalMensal.Name = "LblSalMensal";
            this.LblSalMensal.Size = new System.Drawing.Size(133, 24);
            this.LblSalMensal.TabIndex = 12;
            this.LblSalMensal.Text = "Salário Mensal";
            // 
            // LblNome
            // 
            this.LblNome.AutoSize = true;
            this.LblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNome.Location = new System.Drawing.Point(101, 113);
            this.LblNome.Name = "LblNome";
            this.LblNome.Size = new System.Drawing.Size(62, 24);
            this.LblNome.TabIndex = 11;
            this.LblNome.Text = "Nome";
            // 
            // LblMatricula
            // 
            this.LblMatricula.AutoSize = true;
            this.LblMatricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMatricula.Location = new System.Drawing.Point(101, 77);
            this.LblMatricula.Name = "LblMatricula";
            this.LblMatricula.Size = new System.Drawing.Size(85, 24);
            this.LblMatricula.TabIndex = 10;
            this.LblMatricula.Text = "Matrícula";
            // 
            // frmMensalista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnInstMenPar);
            this.Controls.Add(this.BtnInstMensalista);
            this.Controls.Add(this.TxtDataEntrada);
            this.Controls.Add(this.TxtSalMensal);
            this.Controls.Add(this.TxtNome);
            this.Controls.Add(this.TxtMatricula);
            this.Controls.Add(this.LblDataEntrada);
            this.Controls.Add(this.LblSalMensal);
            this.Controls.Add(this.LblNome);
            this.Controls.Add(this.LblMatricula);
            this.Name = "frmMensalista";
            this.Text = "frmMensalista";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnInstMenPar;
        private System.Windows.Forms.Button BtnInstMensalista;
        private System.Windows.Forms.TextBox TxtDataEntrada;
        private System.Windows.Forms.TextBox TxtSalMensal;
        private System.Windows.Forms.TextBox TxtNome;
        private System.Windows.Forms.TextBox TxtMatricula;
        private System.Windows.Forms.Label LblDataEntrada;
        private System.Windows.Forms.Label LblSalMensal;
        private System.Windows.Forms.Label LblNome;
        private System.Windows.Forms.Label LblMatricula;
    }
}