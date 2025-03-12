using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace consultaAluno
{
    public partial class frmBuscarEscola: Form
    {
        public frmBuscarEscola()
        {
            InitializeComponent();
        }

        private void btnBuscarEscola_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(conexao.IniciarCon))
                {
                    cn.Open();


                    var sqlQuery = "select * from escolas where nomeEscola like '%" + txtBuscarEscola.Text + "%'";
                    using (SqlDataAdapter da = new SqlDataAdapter(sqlQuery, cn))
                    {
                        using (DataTable dt = new DataTable())

                        {
                            da.Fill(dt);
                            dgvBuscarEscola.DataSource = dt;
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao tentar conectar\n\n" + ex.Message);
            }
        }

        private void btnTodasEscolas_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(conexao.IniciarCon))
                {
                    cn.Open();
                    //MessageBox.Show("Conectar ao banco de dados");
                    var sqlQuery = "select * from escolas";        // sqlQuery - armazena a consulta SQL que será executada
                    using (SqlDataAdapter da = new SqlDataAdapter(sqlQuery, cn)) //SqlDataAdapter - é uma classe usada para preencher o DataTable com dados do banco
                                                                                 //sqlQuery -consulta SQL que será executada
                                                                                 // cn - é a conexão com o banco
                    {
                        using (DataTable dt = new DataTable())
                        //(DataTable dt = new DataTable()) - cria uma instância de DataTable, que é uma tabela em memoria para armazenar os dados recuperados do banco
                        {
                            da.Fill(dt); //método Fill do SqlDataAdapter executa a consulta SQL (sqlQuery)e preenche a DataTable (dt) com resultados da consulta
                            dgvBuscarEscola.DataSource = dt;
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao tentar conectar\n\n" + ex.Message);


            }
        }
    }
}
        


