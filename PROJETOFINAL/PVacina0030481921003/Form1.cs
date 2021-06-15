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
    public partial class frmPrincipal : Form
    {

        public static SqlConnection conexao;

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            try
            {
                //string de conexao da máquina local
                conexao = new SqlConnection("Data Source=YEOGIJEOGI\\SQLEXPRESS;Initial Catalog=LP2;Integrated Security=True");
                conexao.Open();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erro de banco de dados " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Outros tipos de erros " + ex.Message);
            }

            
        }

        private void cadastroDeVacinaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["frmVacina"];

            if (fc != null)
                fc.Close();

            frmVacina objVacina = new frmVacina();
            objVacina.MdiParent = this;
            objVacina.WindowState = FormWindowState.Maximized;
            objVacina.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["frmSobre"];

            if (fc != null)
                fc.Close();

            frmSobre objSobre = new frmSobre();
            objSobre.MdiParent = this;
            objSobre.WindowState = FormWindowState.Maximized;
            objSobre.Show();
        }
    }
}
