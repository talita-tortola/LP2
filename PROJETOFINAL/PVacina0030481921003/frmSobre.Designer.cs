
namespace PVacina0030481921003
{
    partial class frmSobre
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSobre));
            this.lblNomeProjeto = new System.Windows.Forms.Label();
            this.lblIntegrantes = new System.Windows.Forms.Label();
            this.lblIntegrante1 = new System.Windows.Forms.Label();
            this.lblIntegrante2 = new System.Windows.Forms.Label();
            this.lblIntegrante3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNomeProjeto
            // 
            this.lblNomeProjeto.AutoSize = true;
            this.lblNomeProjeto.BackColor = System.Drawing.Color.Orchid;
            this.lblNomeProjeto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeProjeto.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblNomeProjeto.Location = new System.Drawing.Point(308, 66);
            this.lblNomeProjeto.Name = "lblNomeProjeto";
            this.lblNomeProjeto.Size = new System.Drawing.Size(132, 24);
            this.lblNomeProjeto.TabIndex = 0;
            this.lblNomeProjeto.Text = "Projeto Vacina";
            // 
            // lblIntegrantes
            // 
            this.lblIntegrantes.AutoSize = true;
            this.lblIntegrantes.BackColor = System.Drawing.Color.Orchid;
            this.lblIntegrantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIntegrantes.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblIntegrantes.Location = new System.Drawing.Point(288, 121);
            this.lblIntegrantes.Name = "lblIntegrantes";
            this.lblIntegrantes.Size = new System.Drawing.Size(163, 24);
            this.lblIntegrantes.TabIndex = 1;
            this.lblIntegrantes.Text = "Desenvolvido Por:";
            // 
            // lblIntegrante1
            // 
            this.lblIntegrante1.AutoSize = true;
            this.lblIntegrante1.BackColor = System.Drawing.Color.Orchid;
            this.lblIntegrante1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIntegrante1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblIntegrante1.Location = new System.Drawing.Point(297, 183);
            this.lblIntegrante1.Name = "lblIntegrante1";
            this.lblIntegrante1.Size = new System.Drawing.Size(142, 24);
            this.lblIntegrante1.TabIndex = 5;
            this.lblIntegrante1.Text = "Brayan Barbosa";
            // 
            // lblIntegrante2
            // 
            this.lblIntegrante2.AutoSize = true;
            this.lblIntegrante2.BackColor = System.Drawing.Color.Orchid;
            this.lblIntegrante2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIntegrante2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblIntegrante2.Location = new System.Drawing.Point(292, 245);
            this.lblIntegrante2.Name = "lblIntegrante2";
            this.lblIntegrante2.Size = new System.Drawing.Size(148, 24);
            this.lblIntegrante2.TabIndex = 6;
            this.lblIntegrante2.Text = "Christian Coelho";
            // 
            // lblIntegrante3
            // 
            this.lblIntegrante3.AutoSize = true;
            this.lblIntegrante3.BackColor = System.Drawing.Color.Orchid;
            this.lblIntegrante3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIntegrante3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblIntegrante3.Location = new System.Drawing.Point(308, 315);
            this.lblIntegrante3.Name = "lblIntegrante3";
            this.lblIntegrante3.Size = new System.Drawing.Size(117, 24);
            this.lblIntegrante3.TabIndex = 7;
            this.lblIntegrante3.Text = "Talita Tortola";
            // 
            // frmSobre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblIntegrante3);
            this.Controls.Add(this.lblIntegrante2);
            this.Controls.Add(this.lblIntegrante1);
            this.Controls.Add(this.lblIntegrantes);
            this.Controls.Add(this.lblNomeProjeto);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmSobre";
            this.Text = "Sobre";
            this.Load += new System.EventHandler(this.frmSobre_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomeProjeto;
        private System.Windows.Forms.Label lblIntegrantes;
        private System.Windows.Forms.Label lblIntegrante1;
        private System.Windows.Forms.Label lblIntegrante2;
        private System.Windows.Forms.Label lblIntegrante3;
    }
}