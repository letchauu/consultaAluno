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
    public partial class frmBuscarMatricula: Form
    {
        public frmBuscarMatricula()
        {
            InitializeComponent();
        }

        private void btnBuscarMatricula_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(conexao.IniciarCon))
                {
                    cn.Open();

                    //var sqlQuery = "select * from alunos where nomeAluno ='" + txtBuscarAluno.Text + "'";
                    var sqlQuery = "select a.idAluno, a.nomeAluno, m.idCurso, m.statusMatricula, m.idEscola FROM alunos a JOIN matriculas m ON a.idAluno = m.idAluno WHERE a.nomeAluno LIKE'%" + txtBuscarMatricula.Text + "%'";
                    using (SqlDataAdapter da = new SqlDataAdapter(sqlQuery, cn))
                    {
                        using (DataTable dt = new DataTable())

                        {
                            da.Fill(dt);
                            dataGridView1.DataSource = dt;
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

