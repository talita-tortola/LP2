﻿
namespace PVacina0030481921003
{
    partial class frmVacina
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVacina));
            this.bnvVacina = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnNovo = new System.Windows.Forms.ToolStripButton();
            this.btnSalvar = new System.Windows.Forms.ToolStripButton();
            this.btnAlterar = new System.Windows.Forms.ToolStripButton();
            this.btnExcluir = new System.Windows.Forms.ToolStripButton();
            this.btnCancelar = new System.Windows.Forms.ToolStripButton();
            this.btnSair = new System.Windows.Forms.ToolStripButton();
            this.tbVacina = new System.Windows.Forms.TabControl();
            this.tbDados = new System.Windows.Forms.TabPage();
            this.dgvVacina = new System.Windows.Forms.DataGridView();
            this.tbDetalhes = new System.Windows.Forms.TabPage();
            this.cbxEnfermeiro = new System.Windows.Forms.ComboBox();
            this.cbxCidade = new System.Windows.Forms.ComboBox();
            this.mskbxRgVacina = new System.Windows.Forms.MaskedTextBox();
            this.mskbxCpfVacina = new System.Windows.Forms.MaskedTextBox();
            this.cbxGrupoPrioritarioVacina = new System.Windows.Forms.ComboBox();
            this.cbxComorbidadeVacina = new System.Windows.Forms.ComboBox();
            this.cbxTipoVacina = new System.Windows.Forms.ComboBox();
            this.txtEndVacina = new System.Windows.Forms.TextBox();
            this.dtVacina = new System.Windows.Forms.DateTimePicker();
            this.dtNascVacina = new System.Windows.Forms.DateTimePicker();
            this.txtNomeVacina = new System.Windows.Forms.TextBox();
            this.txtIdVacina = new System.Windows.Forms.TextBox();
            this.lblEnfermeiro = new System.Windows.Forms.Label();
            this.lblCidade = new System.Windows.Forms.Label();
            this.lblGrupoPrioritarioVacina = new System.Windows.Forms.Label();
            this.lblComorbidadeVacina = new System.Windows.Forms.Label();
            this.lblTipoVacina = new System.Windows.Forms.Label();
            this.lblDataVacina = new System.Windows.Forms.Label();
            this.lblRgVacina = new System.Windows.Forms.Label();
            this.lblCpfVacina = new System.Windows.Forms.Label();
            this.lblNascVacina = new System.Windows.Forms.Label();
            this.lblEndVacina = new System.Windows.Forms.Label();
            this.lblNomeVacina = new System.Windows.Forms.Label();
            this.lblIdVacina = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bnvVacina)).BeginInit();
            this.bnvVacina.SuspendLayout();
            this.tbVacina.SuspendLayout();
            this.tbDados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVacina)).BeginInit();
            this.tbDetalhes.SuspendLayout();
            this.SuspendLayout();
            // 
            // bnvVacina
            // 
            this.bnvVacina.AddNewItem = null;
            this.bnvVacina.BackColor = System.Drawing.Color.White;
            this.bnvVacina.CountItem = this.bindingNavigatorCountItem;
            this.bnvVacina.DeleteItem = null;
            this.bnvVacina.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bnvVacina.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.btnNovo,
            this.btnSalvar,
            this.btnAlterar,
            this.btnExcluir,
            this.btnCancelar,
            this.btnSair});
            this.bnvVacina.Location = new System.Drawing.Point(0, 0);
            this.bnvVacina.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bnvVacina.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bnvVacina.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bnvVacina.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bnvVacina.Name = "bnvVacina";
            this.bnvVacina.PositionItem = this.bindingNavigatorPositionItem;
            this.bnvVacina.Size = new System.Drawing.Size(800, 27);
            this.bnvVacina.TabIndex = 0;
            this.bnvVacina.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(51, 24);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primeiro";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posição";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(49, 25);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posição atual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Mover próximo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // btnNovo
            // 
            this.btnNovo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnNovo.Image = ((System.Drawing.Image)(resources.GetObject("btnNovo.Image")));
            this.btnNovo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(29, 24);
            this.btnNovo.Text = "NOVO REGISTRO";
            this.btnNovo.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(29, 24);
            this.btnSalvar.Text = "SALVAR";
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAlterar.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterar.Image")));
            this.btnAlterar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(29, 24);
            this.btnAlterar.Text = "ALTERAR";
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(29, 24);
            this.btnExcluir.Text = "EXCLUIR";
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(29, 24);
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSair
            // 
            this.btnSair.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(29, 24);
            this.btnSair.Text = "SAIR";
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // tbVacina
            // 
            this.tbVacina.Controls.Add(this.tbDados);
            this.tbVacina.Controls.Add(this.tbDetalhes);
            this.tbVacina.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F);
            this.tbVacina.Location = new System.Drawing.Point(53, 36);
            this.tbVacina.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbVacina.Name = "tbVacina";
            this.tbVacina.SelectedIndex = 0;
            this.tbVacina.Size = new System.Drawing.Size(688, 402);
            this.tbVacina.TabIndex = 1;
            // 
            // tbDados
            // 
            this.tbDados.BackColor = System.Drawing.Color.Black;
            this.tbDados.Controls.Add(this.dgvVacina);
            this.tbDados.Location = new System.Drawing.Point(4, 26);
            this.tbDados.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbDados.Name = "tbDados";
            this.tbDados.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbDados.Size = new System.Drawing.Size(680, 372);
            this.tbDados.TabIndex = 0;
            this.tbDados.Text = "Dados";
            // 
            // dgvVacina
            // 
            this.dgvVacina.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVacina.Location = new System.Drawing.Point(8, 10);
            this.dgvVacina.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvVacina.Name = "dgvVacina";
            this.dgvVacina.RowHeadersWidth = 51;
            this.dgvVacina.RowTemplate.Height = 24;
            this.dgvVacina.Size = new System.Drawing.Size(656, 356);
            this.dgvVacina.TabIndex = 0;
            // 
            // tbDetalhes
            // 
            this.tbDetalhes.Controls.Add(this.cbxEnfermeiro);
            this.tbDetalhes.Controls.Add(this.cbxCidade);
            this.tbDetalhes.Controls.Add(this.mskbxRgVacina);
            this.tbDetalhes.Controls.Add(this.mskbxCpfVacina);
            this.tbDetalhes.Controls.Add(this.cbxGrupoPrioritarioVacina);
            this.tbDetalhes.Controls.Add(this.cbxComorbidadeVacina);
            this.tbDetalhes.Controls.Add(this.cbxTipoVacina);
            this.tbDetalhes.Controls.Add(this.txtEndVacina);
            this.tbDetalhes.Controls.Add(this.dtVacina);
            this.tbDetalhes.Controls.Add(this.dtNascVacina);
            this.tbDetalhes.Controls.Add(this.txtNomeVacina);
            this.tbDetalhes.Controls.Add(this.txtIdVacina);
            this.tbDetalhes.Controls.Add(this.lblEnfermeiro);
            this.tbDetalhes.Controls.Add(this.lblCidade);
            this.tbDetalhes.Controls.Add(this.lblGrupoPrioritarioVacina);
            this.tbDetalhes.Controls.Add(this.lblComorbidadeVacina);
            this.tbDetalhes.Controls.Add(this.lblTipoVacina);
            this.tbDetalhes.Controls.Add(this.lblDataVacina);
            this.tbDetalhes.Controls.Add(this.lblRgVacina);
            this.tbDetalhes.Controls.Add(this.lblCpfVacina);
            this.tbDetalhes.Controls.Add(this.lblNascVacina);
            this.tbDetalhes.Controls.Add(this.lblEndVacina);
            this.tbDetalhes.Controls.Add(this.lblNomeVacina);
            this.tbDetalhes.Controls.Add(this.lblIdVacina);
            this.tbDetalhes.Location = new System.Drawing.Point(4, 26);
            this.tbDetalhes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbDetalhes.Name = "tbDetalhes";
            this.tbDetalhes.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbDetalhes.Size = new System.Drawing.Size(680, 372);
            this.tbDetalhes.TabIndex = 1;
            this.tbDetalhes.Text = "Detalhes";
            this.tbDetalhes.UseVisualStyleBackColor = true;
            // 
            // cbxEnfermeiro
            // 
            this.cbxEnfermeiro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxEnfermeiro.Enabled = false;
            this.cbxEnfermeiro.FormattingEnabled = true;
            this.cbxEnfermeiro.Location = new System.Drawing.Point(229, 336);
            this.cbxEnfermeiro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxEnfermeiro.Name = "cbxEnfermeiro";
            this.cbxEnfermeiro.Size = new System.Drawing.Size(391, 25);
            this.cbxEnfermeiro.TabIndex = 12;
            // 
            // cbxCidade
            // 
            this.cbxCidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCidade.Enabled = false;
            this.cbxCidade.FormattingEnabled = true;
            this.cbxCidade.Location = new System.Drawing.Point(229, 306);
            this.cbxCidade.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxCidade.Name = "cbxCidade";
            this.cbxCidade.Size = new System.Drawing.Size(391, 25);
            this.cbxCidade.TabIndex = 11;
            // 
            // mskbxRgVacina
            // 
            this.mskbxRgVacina.Enabled = false;
            this.mskbxRgVacina.Location = new System.Drawing.Point(229, 153);
            this.mskbxRgVacina.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mskbxRgVacina.Mask = "999999999";
            this.mskbxRgVacina.Name = "mskbxRgVacina";
            this.mskbxRgVacina.Size = new System.Drawing.Size(391, 25);
            this.mskbxRgVacina.TabIndex = 6;
            // 
            // mskbxCpfVacina
            // 
            this.mskbxCpfVacina.Enabled = false;
            this.mskbxCpfVacina.Location = new System.Drawing.Point(229, 124);
            this.mskbxCpfVacina.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mskbxCpfVacina.Mask = "99999999999";
            this.mskbxCpfVacina.Name = "mskbxCpfVacina";
            this.mskbxCpfVacina.Size = new System.Drawing.Size(391, 25);
            this.mskbxCpfVacina.TabIndex = 5;
            // 
            // cbxGrupoPrioritarioVacina
            // 
            this.cbxGrupoPrioritarioVacina.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxGrupoPrioritarioVacina.Enabled = false;
            this.cbxGrupoPrioritarioVacina.FormattingEnabled = true;
            this.cbxGrupoPrioritarioVacina.Items.AddRange(new object[] {
            "S",
            "N"});
            this.cbxGrupoPrioritarioVacina.Location = new System.Drawing.Point(229, 277);
            this.cbxGrupoPrioritarioVacina.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxGrupoPrioritarioVacina.Name = "cbxGrupoPrioritarioVacina";
            this.cbxGrupoPrioritarioVacina.Size = new System.Drawing.Size(391, 25);
            this.cbxGrupoPrioritarioVacina.TabIndex = 10;
            // 
            // cbxComorbidadeVacina
            // 
            this.cbxComorbidadeVacina.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxComorbidadeVacina.Enabled = false;
            this.cbxComorbidadeVacina.FormattingEnabled = true;
            this.cbxComorbidadeVacina.Items.AddRange(new object[] {
            "S",
            "N"});
            this.cbxComorbidadeVacina.Location = new System.Drawing.Point(229, 246);
            this.cbxComorbidadeVacina.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxComorbidadeVacina.Name = "cbxComorbidadeVacina";
            this.cbxComorbidadeVacina.Size = new System.Drawing.Size(391, 25);
            this.cbxComorbidadeVacina.TabIndex = 9;
            // 
            // cbxTipoVacina
            // 
            this.cbxTipoVacina.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTipoVacina.Enabled = false;
            this.cbxTipoVacina.FormattingEnabled = true;
            this.cbxTipoVacina.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cbxTipoVacina.Location = new System.Drawing.Point(229, 214);
            this.cbxTipoVacina.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxTipoVacina.Name = "cbxTipoVacina";
            this.cbxTipoVacina.Size = new System.Drawing.Size(391, 25);
            this.cbxTipoVacina.TabIndex = 8;
            // 
            // txtEndVacina
            // 
            this.txtEndVacina.Enabled = false;
            this.txtEndVacina.Location = new System.Drawing.Point(229, 66);
            this.txtEndVacina.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEndVacina.MaxLength = 100;
            this.txtEndVacina.Name = "txtEndVacina";
            this.txtEndVacina.Size = new System.Drawing.Size(391, 25);
            this.txtEndVacina.TabIndex = 3;
            // 
            // dtVacina
            // 
            this.dtVacina.CustomFormat = "dd/MM/yyyy";
            this.dtVacina.Enabled = false;
            this.dtVacina.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtVacina.Location = new System.Drawing.Point(229, 183);
            this.dtVacina.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtVacina.Name = "dtVacina";
            this.dtVacina.Size = new System.Drawing.Size(391, 25);
            this.dtVacina.TabIndex = 7;
            // 
            // dtNascVacina
            // 
            this.dtNascVacina.CustomFormat = "dd/MM/yyyy";
            this.dtNascVacina.Enabled = false;
            this.dtNascVacina.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNascVacina.Location = new System.Drawing.Point(229, 95);
            this.dtNascVacina.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtNascVacina.Name = "dtNascVacina";
            this.dtNascVacina.Size = new System.Drawing.Size(391, 25);
            this.dtNascVacina.TabIndex = 4;
            // 
            // txtNomeVacina
            // 
            this.txtNomeVacina.Enabled = false;
            this.txtNomeVacina.Location = new System.Drawing.Point(229, 38);
            this.txtNomeVacina.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNomeVacina.MaxLength = 50;
            this.txtNomeVacina.Name = "txtNomeVacina";
            this.txtNomeVacina.Size = new System.Drawing.Size(391, 25);
            this.txtNomeVacina.TabIndex = 2;
            // 
            // txtIdVacina
            // 
            this.txtIdVacina.Enabled = false;
            this.txtIdVacina.Location = new System.Drawing.Point(229, 9);
            this.txtIdVacina.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIdVacina.Name = "txtIdVacina";
            this.txtIdVacina.Size = new System.Drawing.Size(391, 25);
            this.txtIdVacina.TabIndex = 1;
            // 
            // lblEnfermeiro
            // 
            this.lblEnfermeiro.AutoSize = true;
            this.lblEnfermeiro.Location = new System.Drawing.Point(29, 338);
            this.lblEnfermeiro.Name = "lblEnfermeiro";
            this.lblEnfermeiro.Size = new System.Drawing.Size(109, 17);
            this.lblEnfermeiro.TabIndex = 11;
            this.lblEnfermeiro.Text = "ENFERMEIRO";
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(29, 310);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(67, 17);
            this.lblCidade.TabIndex = 10;
            this.lblCidade.Text = "CIDADE";
            // 
            // lblGrupoPrioritarioVacina
            // 
            this.lblGrupoPrioritarioVacina.AutoSize = true;
            this.lblGrupoPrioritarioVacina.Location = new System.Drawing.Point(29, 281);
            this.lblGrupoPrioritarioVacina.Name = "lblGrupoPrioritarioVacina";
            this.lblGrupoPrioritarioVacina.Size = new System.Drawing.Size(170, 17);
            this.lblGrupoPrioritarioVacina.TabIndex = 9;
            this.lblGrupoPrioritarioVacina.Text = "GRUPO PRIORITÁRIO";
            // 
            // lblComorbidadeVacina
            // 
            this.lblComorbidadeVacina.AutoSize = true;
            this.lblComorbidadeVacina.Location = new System.Drawing.Point(29, 249);
            this.lblComorbidadeVacina.Name = "lblComorbidadeVacina";
            this.lblComorbidadeVacina.Size = new System.Drawing.Size(125, 17);
            this.lblComorbidadeVacina.TabIndex = 8;
            this.lblComorbidadeVacina.Text = "COMORBIDADE";
            // 
            // lblTipoVacina
            // 
            this.lblTipoVacina.AutoSize = true;
            this.lblTipoVacina.Location = new System.Drawing.Point(29, 217);
            this.lblTipoVacina.Name = "lblTipoVacina";
            this.lblTipoVacina.Size = new System.Drawing.Size(133, 17);
            this.lblTipoVacina.TabIndex = 7;
            this.lblTipoVacina.Text = "TIPO DA VACINA";
            // 
            // lblDataVacina
            // 
            this.lblDataVacina.AutoSize = true;
            this.lblDataVacina.Location = new System.Drawing.Point(29, 188);
            this.lblDataVacina.Name = "lblDataVacina";
            this.lblDataVacina.Size = new System.Drawing.Size(147, 17);
            this.lblDataVacina.TabIndex = 6;
            this.lblDataVacina.Text = "DATA VACINAÇÃO";
            // 
            // lblRgVacina
            // 
            this.lblRgVacina.AutoSize = true;
            this.lblRgVacina.Location = new System.Drawing.Point(29, 159);
            this.lblRgVacina.Name = "lblRgVacina";
            this.lblRgVacina.Size = new System.Drawing.Size(31, 17);
            this.lblRgVacina.TabIndex = 5;
            this.lblRgVacina.Text = "RG";
            // 
            // lblCpfVacina
            // 
            this.lblCpfVacina.AutoSize = true;
            this.lblCpfVacina.Location = new System.Drawing.Point(29, 127);
            this.lblCpfVacina.Name = "lblCpfVacina";
            this.lblCpfVacina.Size = new System.Drawing.Size(38, 17);
            this.lblCpfVacina.TabIndex = 4;
            this.lblCpfVacina.Text = "CPF";
            // 
            // lblNascVacina
            // 
            this.lblNascVacina.AutoSize = true;
            this.lblNascVacina.Location = new System.Drawing.Point(29, 100);
            this.lblNascVacina.Name = "lblNascVacina";
            this.lblNascVacina.Size = new System.Drawing.Size(181, 17);
            this.lblNascVacina.TabIndex = 3;
            this.lblNascVacina.Text = "DATA DE NASCIMENTO";
            // 
            // lblEndVacina
            // 
            this.lblEndVacina.AutoSize = true;
            this.lblEndVacina.Location = new System.Drawing.Point(29, 69);
            this.lblEndVacina.Name = "lblEndVacina";
            this.lblEndVacina.Size = new System.Drawing.Size(94, 17);
            this.lblEndVacina.TabIndex = 2;
            this.lblEndVacina.Text = "ENDEREÇO";
            // 
            // lblNomeVacina
            // 
            this.lblNomeVacina.AutoSize = true;
            this.lblNomeVacina.Location = new System.Drawing.Point(29, 41);
            this.lblNomeVacina.Name = "lblNomeVacina";
            this.lblNomeVacina.Size = new System.Drawing.Size(53, 17);
            this.lblNomeVacina.TabIndex = 1;
            this.lblNomeVacina.Text = "NOME";
            // 
            // lblIdVacina
            // 
            this.lblIdVacina.AutoSize = true;
            this.lblIdVacina.Location = new System.Drawing.Point(29, 12);
            this.lblIdVacina.Name = "lblIdVacina";
            this.lblIdVacina.Size = new System.Drawing.Size(24, 17);
            this.lblIdVacina.TabIndex = 0;
            this.lblIdVacina.Text = "ID";
            // 
            // frmVacina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbVacina);
            this.Controls.Add(this.bnvVacina);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmVacina";
            this.Text = "【﻿Ｃａｄａｓｔｒｏ　ｄｅ　Ｖａｃｉｎａçãｏ】";
            this.Load += new System.EventHandler(this.frmVacina_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bnvVacina)).EndInit();
            this.bnvVacina.ResumeLayout(false);
            this.bnvVacina.PerformLayout();
            this.tbVacina.ResumeLayout(false);
            this.tbDados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVacina)).EndInit();
            this.tbDetalhes.ResumeLayout(false);
            this.tbDetalhes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingNavigator bnvVacina;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.TabControl tbVacina;
        private System.Windows.Forms.TabPage tbDados;
        private System.Windows.Forms.DataGridView dgvVacina;
        private System.Windows.Forms.TabPage tbDetalhes;
        private System.Windows.Forms.ToolStripButton btnNovo;
        private System.Windows.Forms.ToolStripButton btnSalvar;
        private System.Windows.Forms.ToolStripButton btnAlterar;
        private System.Windows.Forms.ToolStripButton btnExcluir;
        private System.Windows.Forms.ToolStripButton btnCancelar;
        private System.Windows.Forms.ToolStripButton btnSair;
        private System.Windows.Forms.MaskedTextBox mskbxRgVacina;
        private System.Windows.Forms.MaskedTextBox mskbxCpfVacina;
        private System.Windows.Forms.ComboBox cbxGrupoPrioritarioVacina;
        private System.Windows.Forms.ComboBox cbxComorbidadeVacina;
        private System.Windows.Forms.ComboBox cbxTipoVacina;
        private System.Windows.Forms.TextBox txtEndVacina;
        private System.Windows.Forms.DateTimePicker dtVacina;
        private System.Windows.Forms.DateTimePicker dtNascVacina;
        private System.Windows.Forms.TextBox txtNomeVacina;
        private System.Windows.Forms.TextBox txtIdVacina;
        private System.Windows.Forms.Label lblEnfermeiro;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.Label lblGrupoPrioritarioVacina;
        private System.Windows.Forms.Label lblComorbidadeVacina;
        private System.Windows.Forms.Label lblTipoVacina;
        private System.Windows.Forms.Label lblDataVacina;
        private System.Windows.Forms.Label lblRgVacina;
        private System.Windows.Forms.Label lblCpfVacina;
        private System.Windows.Forms.Label lblNascVacina;
        private System.Windows.Forms.Label lblEndVacina;
        private System.Windows.Forms.Label lblNomeVacina;
        private System.Windows.Forms.Label lblIdVacina;
        private System.Windows.Forms.ComboBox cbxEnfermeiro;
        private System.Windows.Forms.ComboBox cbxCidade;
    }
}