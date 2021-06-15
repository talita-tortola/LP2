using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace PVacina0030481921003
{
    public partial class frmVacina : Form
    {
        private BindingSource bnVacina = new BindingSource();
        private bool bInclusao = false;
        private DataSet dsVacina = new DataSet();

        private BindingSource bnCidade = new BindingSource();
        private DataSet dsCidade = new DataSet();

        private BindingSource bnEnfermeiro = new BindingSource();
        private DataSet dsEnfermeiro = new DataSet();


        public frmVacina()
        {
            InitializeComponent();
        }

        private void frmVacina_Load(object sender, EventArgs e)
        {
            try
            {
                Vacina RegVac = new Vacina();
                dsVacina.Tables.Add(RegVac.Listar());
                bnVacina.DataSource = dsVacina.Tables["Vacina"];
                dgvVacina.DataSource = bnVacina;
                bnvVacina.BindingSource = bnVacina;

                txtIdVacina.DataBindings.Add("Text", bnVacina, "id_vacina");
                txtNomeVacina.DataBindings.Add("Text", bnVacina, "nome_vacina");
                txtEndVacina.DataBindings.Add("Text", bnVacina, "end_vacina");
                dtNascVacina.DataBindings.Add("Text", bnVacina, "datanasc_vacina");
                dtVacina.DataBindings.Add("Text", bnVacina, "data_vacina");
                mskbxCpfVacina.DataBindings.Add("Text", bnVacina, "cpf_vacina");
                mskbxRgVacina.DataBindings.Add("Text", bnVacina, "rg_vacina");
                cbxComorbidadeVacina.DataBindings.Add("SelectedItem", bnVacina, "comorbidade_vacina");
                cbxGrupoPrioritarioVacina.DataBindings.Add("SelectedItem", bnVacina, "grupopriori_vacina");
                cbxTipoVacina.DataBindings.Add("SelectedItem", bnVacina, "tipo_vacina");

                Cidade Cid = new Cidade();
                dsCidade.Tables.Add(Cid.Listar());
                cbxCidade.DataSource = dsCidade.Tables["Cidade"];

                Enfermeiro Enf = new Enfermeiro();
                dsEnfermeiro.Tables.Add(Enf.Listar());
                cbxEnfermeiro.DataSource = dsEnfermeiro.Tables["Enfermeiro"];

                cbxCidade.DataBindings.Add("SelectedValue", bnVacina, "cidade_id_cidade");
                cbxEnfermeiro.DataBindings.Add("SelectedValue", bnVacina, "enfermeiro_id_enfermeiro");

                cbxCidade.DisplayMember = "nome_cidade";
                cbxCidade.ValueMember = "id_cidade";

                cbxEnfermeiro.DisplayMember = "nome_enfermeiro";
                cbxEnfermeiro.ValueMember = "id_enfermeiro";


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (tbVacina.SelectedIndex == 0)
            {
                tbVacina.SelectTab(1);
            }

            bnVacina.AddNew();

            txtNomeVacina.Enabled = true;
            txtEndVacina.Enabled = true;
            dtNascVacina.Enabled = true;
            dtVacina.Enabled = true;
            mskbxCpfVacina.Enabled = true;
            mskbxRgVacina.Enabled = true;
            cbxCidade.Enabled = true;
            cbxEnfermeiro.Enabled = true;
            cbxComorbidadeVacina.Enabled = true;
            cbxGrupoPrioritarioVacina.Enabled = true;
            cbxTipoVacina.Enabled = true;

            cbxComorbidadeVacina.SelectedIndex = 0;
            cbxGrupoPrioritarioVacina.SelectedIndex = 0;
            cbxTipoVacina.SelectedIndex = 0;

            cbxCidade.SelectedIndex = 0;
            cbxEnfermeiro.SelectedIndex = 0;

            btnSalvar.Enabled = true;
            btnAlterar.Enabled = false;
            btnNovo.Enabled = false;
            btnExcluir.Enabled = false;
            btnCancelar.Enabled = true;

            bInclusao = true;

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            // validar os dados

            if (txtNomeVacina.Text == "")
                MessageBox.Show("Nome vazio");
            else
            if (txtEndVacina.Text == "")
                MessageBox.Show("Endereço vazio");
            else
            if (mskbxCpfVacina.Text == "")
                MessageBox.Show("cpf vazio");
            else
            if (mskbxRgVacina.Text == "")
                MessageBox.Show("rg vazio");

            else
            {
                Vacina RegVac = new Vacina();

                RegVac.NomeVacina = txtNomeVacina.Text;
                RegVac.EndVacina = txtEndVacina.Text;
                RegVac.DataNascVacina = Convert.ToDateTime(dtNascVacina.Text);
                RegVac.DataVacina = Convert.ToDateTime(dtVacina.Text);
                RegVac.CpfVacina = mskbxCpfVacina.Text;
                RegVac.RgVacina = mskbxRgVacina.Text;
                RegVac.GrupoprioriVacina = Convert.ToChar(cbxGrupoPrioritarioVacina.SelectedItem.ToString());
                RegVac.TipoVacina = Convert.ToChar(cbxTipoVacina.SelectedItem.ToString());
                RegVac.ComorbidadeVacina = Convert.ToChar(cbxComorbidadeVacina.SelectedItem.ToString());
                RegVac.CidadeIdCidade = Convert.ToInt32(cbxCidade.SelectedValue.ToString());
                RegVac.EnfermeiroIdEnfermeiro = Convert.ToInt32(cbxEnfermeiro.SelectedValue.ToString());

                if (bInclusao)
                {
                    if (RegVac.Incluir() > 0)
                    {
                        MessageBox.Show("Vacina adicionada com sucesso!");

                        bInclusao = false;

                        txtNomeVacina.Enabled = false;
                        txtEndVacina.Enabled = false;
                        dtNascVacina.Enabled = false;
                        dtVacina.Enabled = false;
                        mskbxCpfVacina.Enabled = false;
                        mskbxRgVacina.Enabled = false;
                        cbxCidade.Enabled = false;
                        cbxEnfermeiro.Enabled = false;
                        cbxComorbidadeVacina.Enabled = false;
                        cbxGrupoPrioritarioVacina.Enabled = false;
                        cbxTipoVacina.Enabled = false;

                        btnSalvar.Enabled = false;
                        btnAlterar.Enabled = true;
                        btnNovo.Enabled = true;
                        btnExcluir.Enabled = true;
                        btnCancelar.Enabled = false;

                        // recarrega o grid
                        dsVacina.Tables.Clear();
                        dsVacina.Tables.Add(RegVac.Listar());
                        bnVacina.DataSource = dsVacina.Tables["vacina"];

                    }
                    else
                    {
                        MessageBox.Show("Erro ao gravar vacina!");
                    }
                }
                else
                {
                    RegVac.IdVacina = Convert.ToInt32(txtIdVacina.Text);

                    if (RegVac.Alterar() > 0)
                    {
                        MessageBox.Show("Vacina alterada com sucesso!");

                        txtNomeVacina.Enabled = false;
                        txtEndVacina.Enabled = false;
                        dtNascVacina.Enabled = false;
                        dtVacina.Enabled = false;
                        mskbxCpfVacina.Enabled = false;
                        mskbxRgVacina.Enabled = false;
                        cbxCidade.Enabled = false;
                        cbxEnfermeiro.Enabled = false;
                        cbxComorbidadeVacina.Enabled = false;
                        cbxGrupoPrioritarioVacina.Enabled = false;
                        cbxTipoVacina.Enabled = false;

                        btnSalvar.Enabled = false;
                        btnAlterar.Enabled = true;
                        btnNovo.Enabled = true;
                        btnExcluir.Enabled = true;
                        btnCancelar.Enabled = false;

                        // recarrega o grid
                        dsVacina.Tables.Clear();
                        dsVacina.Tables.Add(RegVac.Listar());
                        bnVacina.DataSource = dsVacina.Tables["vacina"];

                    }
                    else
                    {
                        MessageBox.Show("Erro ao alterar vacina!");
                    }

                }
            }

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (tbVacina.SelectedIndex == 0)
            {
                tbVacina.SelectTab(1);
            }

            txtNomeVacina.Enabled = true;
            txtEndVacina.Enabled = true;
            dtNascVacina.Enabled = true;
            dtVacina.Enabled = true;
            mskbxCpfVacina.Enabled = true;
            mskbxRgVacina.Enabled = true;
            cbxCidade.Enabled = true;
            cbxEnfermeiro.Enabled = true;
            cbxComorbidadeVacina.Enabled = true;
            cbxGrupoPrioritarioVacina.Enabled = true;
            cbxTipoVacina.Enabled = true;

            btnSalvar.Enabled = true;
            btnAlterar.Enabled = false;
            btnNovo.Enabled = false;
            btnExcluir.Enabled = false;
            btnCancelar.Enabled = true;

            bInclusao = false;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (tbVacina.SelectedIndex == 0)
            {
                tbVacina.SelectTab(1);
            }

            Vacina RegVac = new Vacina();

            RegVac.IdVacina = Convert.ToInt32(txtIdVacina.Text);

            if (MessageBox.Show("Confirma exclusão?", "Sim ou Não", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                if (RegVac.Excluir() == 0)
                    MessageBox.Show("Erro ao excluir vacina");
                else
                {
                    MessageBox.Show("Vacina excluida com sucesso");

                    // recarrega o grid
                    dsVacina.Tables.Clear();
                    dsVacina.Tables.Add(RegVac.Listar());
                    bnVacina.DataSource = dsVacina.Tables["vacina"];
                }

            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            bnVacina.CancelEdit();

            txtNomeVacina.Enabled = false;
            txtEndVacina.Enabled = false;
            dtNascVacina.Enabled = false;
            dtVacina.Enabled = false;
            mskbxCpfVacina.Enabled = false;
            mskbxRgVacina.Enabled = false;
            cbxCidade.Enabled = false;
            cbxEnfermeiro.Enabled = false;
            cbxComorbidadeVacina.Enabled = false;
            cbxGrupoPrioritarioVacina.Enabled = false;
            cbxTipoVacina.Enabled = false;

            btnSalvar.Enabled = false;
            btnAlterar.Enabled = true;
            btnNovo.Enabled = true;
            btnExcluir.Enabled = true;
            btnCancelar.Enabled = false;
        }
    }
}
