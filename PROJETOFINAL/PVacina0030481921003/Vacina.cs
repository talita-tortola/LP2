using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace PVacina0030481921003
{
    class Vacina
    {
        //atributos
        private int idVacina;
        private string nomeVacina;
        private DateTime dataNascVacina;
        private string endVacina;
        private int cidadeIdCidade; //vai vir da tabela Cidade
        private string cpfVacina;
        private string rgVacina;
        private DateTime dataVacina;
        private char tipoVacina; //1 2 3
        private char comorbidadeVacina; //S ou N
        private char grupoprioriVacina; //S ou N
        private int enfermeiroIdEnfermeiro; //vai vir da tabela Enfermeiro

        //propriedades
        public int IdVacina
        {
            get
            {
                return idVacina;
            }
            set
            {
                idVacina = value;
            }
        }

        public string NomeVacina
        {
            get
            {
                return nomeVacina;
            }
            set
            {
                nomeVacina = value;
            }
        }

        public DateTime DataNascVacina
        {
            get
            {
                return dataNascVacina;
            }
            set
            {
                dataNascVacina = value;
            }
        }

        public string EndVacina
        {
            get
            {
                return endVacina;
            }
            set
            {
                endVacina = value;
            }
        }

        public int CidadeIdCidade
        {
            get
            {
                return cidadeIdCidade;
            }
            set
            {
                cidadeIdCidade = value;
            }
        }

        public string CpfVacina
        {
            get
            {
                return cpfVacina;
            }
            set
            {
                cpfVacina = value;
            }
        }

        public string RgVacina
        {
            get
            {
                return rgVacina;
            }
            set
            {
                rgVacina = value;
            }
        }

        public DateTime DataVacina
        {
            get
            {
                return dataVacina;
            }
            set
            {
                dataVacina = value;
            }
        }

        public char TipoVacina
        {
            get
            {
                return tipoVacina;
            }
            set
            {
                tipoVacina = value;
            }
        }

        public char ComorbidadeVacina
        {
            get
            {
                return comorbidadeVacina;
            }
            set
            {
                comorbidadeVacina = value;
            }
        }

        public char GrupoprioriVacina
        {
            get
            {
                return grupoprioriVacina;
            }
            set
            {
                grupoprioriVacina = value;
            }
        }

        public int EnfermeiroIdEnfermeiro
        {
            get
            {
                return enfermeiroIdEnfermeiro;
            }
            set
            {
                enfermeiroIdEnfermeiro = value;
            }
        }

        //métodos
        public DataTable Listar()
        {
            SqlDataAdapter daVacina;
            DataTable dtVacina = new DataTable();

            try
            {
                daVacina = new SqlDataAdapter("SELECT * FROM VACINA", frmPrincipal.conexao);
                daVacina.Fill(dtVacina);
                daVacina.FillSchema(dtVacina, SchemaType.Source);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dtVacina;
        }

        public int Incluir()
        {
            int retorno = 0;

            try
            {
                SqlCommand mycommand;

                mycommand = new SqlCommand("INSERT INTO VACINA VALUES (@nomeVacina,@dataNascVacina," +
                                "@endVacina,@cidadeIdCidade,@cpfVacina,@rgVacina,@dataVacina," +
                                "@tipoVacina,@comorbidadeVacina,@grupoprioriVacina," +
                                "@enfermeiroIdEnfermeiro)", frmPrincipal.conexao);

                mycommand.Parameters.Add(new SqlParameter("@nomeVacina", SqlDbType.VarChar));
                mycommand.Parameters.Add(new SqlParameter("@dataNascVacina", SqlDbType.DateTime));
                mycommand.Parameters.Add(new SqlParameter("@endVacina", SqlDbType.VarChar));
                mycommand.Parameters.Add(new SqlParameter("@cidadeIdCidade", SqlDbType.Int));
                mycommand.Parameters.Add(new SqlParameter("@cpfVacina", SqlDbType.VarChar));
                mycommand.Parameters.Add(new SqlParameter("@rgVacina", SqlDbType.VarChar));
                mycommand.Parameters.Add(new SqlParameter("@dataVacina", SqlDbType.DateTime));
                mycommand.Parameters.Add(new SqlParameter("@tipoVacina", SqlDbType.Char));
                mycommand.Parameters.Add(new SqlParameter("@comorbidadeVacina", SqlDbType.Char));
                mycommand.Parameters.Add(new SqlParameter("@grupoprioriVacina", SqlDbType.Char));
                mycommand.Parameters.Add(new SqlParameter("@enfermeiroIdEnfermeiro", SqlDbType.Int));

                mycommand.Parameters["@nomeVacina"].Value = NomeVacina;
                mycommand.Parameters["@dataNascVacina"].Value = DataNascVacina;
                mycommand.Parameters["@endVacina"].Value = EndVacina;
                mycommand.Parameters["@cidadeIdCidade"].Value = CidadeIdCidade;
                mycommand.Parameters["@cpfVacina"].Value = CpfVacina;
                mycommand.Parameters["@rgVacina"].Value = RgVacina;
                mycommand.Parameters["@dataVacina"].Value = DataVacina;
                mycommand.Parameters["@tipoVacina"].Value = TipoVacina;
                mycommand.Parameters["@comorbidadeVacina"].Value = ComorbidadeVacina;
                mycommand.Parameters["@grupoprioriVacina"].Value = GrupoprioriVacina;
                mycommand.Parameters["@enfermeiroIdEnfermeiro"].Value = EnfermeiroIdEnfermeiro;

                retorno = mycommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return retorno;
        }

        public int Alterar()
        {
            int retorno = 0;

            try
            {
                SqlCommand mycommand;

                mycommand = new SqlCommand("UPDATE VACINA SET nome_vacina=@nomeVacina," +
                    "datanasc_vacina=@dataNascVacina,end_vacina=@endVacina," +
                    "cidade_id_cidade=@cidadeIdCidade,cpf_vacina=@cpfVacina," +
                    "rg_vacina=@rgVacina,data_vacina=@dataVacina,tipo_vacina=@tipoVacina," +
                    "comorbidade_vacina=@comorbidadeVacina,grupopriori_vacina=@grupoprioriVacina," +
                    "enfermeiro_id_enfermeiro=@enfermeiroIdEnfermeiro WHERE id_vacina=@idVacina", frmPrincipal.conexao);

                mycommand.Parameters.Add(new SqlParameter("@idVacina", SqlDbType.Int));
                mycommand.Parameters.Add(new SqlParameter("@nomeVacina", SqlDbType.VarChar));
                mycommand.Parameters.Add(new SqlParameter("@dataNascVacina", SqlDbType.DateTime));
                mycommand.Parameters.Add(new SqlParameter("@endVacina", SqlDbType.VarChar));
                mycommand.Parameters.Add(new SqlParameter("@cidadeIdCidade", SqlDbType.Int));
                mycommand.Parameters.Add(new SqlParameter("@cpfVacina", SqlDbType.VarChar));
                mycommand.Parameters.Add(new SqlParameter("@rgVacina", SqlDbType.VarChar));
                mycommand.Parameters.Add(new SqlParameter("@dataVacina", SqlDbType.DateTime));
                mycommand.Parameters.Add(new SqlParameter("@tipoVacina", SqlDbType.Char));
                mycommand.Parameters.Add(new SqlParameter("@comorbidadeVacina", SqlDbType.Char));
                mycommand.Parameters.Add(new SqlParameter("@grupoprioriVacina", SqlDbType.Char));
                mycommand.Parameters.Add(new SqlParameter("@enfermeiroIdEnfermeiro", SqlDbType.Int));

                mycommand.Parameters["@idVacina"].Value = IdVacina;
                mycommand.Parameters["@nomeVacina"].Value = NomeVacina;
                mycommand.Parameters["@dataNascVacina"].Value = DataNascVacina;
                mycommand.Parameters["@endVacina"].Value = EndVacina;
                mycommand.Parameters["@cidadeIdCidade"].Value = CidadeIdCidade;
                mycommand.Parameters["@cpfVacina"].Value = CpfVacina;
                mycommand.Parameters["@rgVacina"].Value = RgVacina;
                mycommand.Parameters["@dataVacina"].Value = DataVacina;
                mycommand.Parameters["@tipoVacina"].Value = TipoVacina;
                mycommand.Parameters["@comorbidadeVacina"].Value = ComorbidadeVacina;
                mycommand.Parameters["@grupoprioriVacina"].Value = GrupoprioriVacina;
                mycommand.Parameters["@enfermeiroIdEnfermeiro"].Value = EnfermeiroIdEnfermeiro;

                retorno = mycommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return retorno;
        }

        public int Excluir()
        {
            int retorno = 0;
            
            try
            {
                SqlCommand mycommand;

                mycommand = new SqlCommand("DELETE FROM VACINA WHERE id_vacina=@idVacina", frmPrincipal.conexao);

                mycommand.Parameters.Add(new SqlParameter("@idVacina", SqlDbType.Int));
                
                mycommand.Parameters["@idVacina"].Value = IdVacina;
                
                retorno = mycommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return retorno;
        }

    }
}
