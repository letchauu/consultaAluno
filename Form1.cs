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
    public partial class frmBuscarAluno : Form
    {
        public frmBuscarAluno()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(conexao.IniciarCon))
                {
                    cn.Open();
                    //MessageBox.Show("Conectar ao banco de dados");
                    var sqlQuery = "select * from alunos";        // sqlQuery - armazena a consulta SQL que será executada
                    using (SqlDataAdapter da = new SqlDataAdapter(sqlQuery, cn)) //SqlDataAdapter - é uma classe usada para preencher o DataTable com dados do banco
                                                                                 //sqlQuery -consulta SQL que será executada
                                                                                 // cn - é a conexão com o banco
                    {
                        using (DataTable dt = new DataTable())
                        //(DataTable dt = new DataTable()) - cria uma instância de DataTable, que é uma tabela em memoria para armazenar os dados recuperados do banco
                        {
                            da.Fill(dt); //método Fill do SqlDataAdapter executa a consulta SQL (sqlQuery)e preenche a DataTable (dt) com resultados da consulta
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            frmCadastroAluno frm = new frmCadastroAluno();
            frm.ShowDialog();
        }

        private void btnAddCurso_Click(object sender, EventArgs e)
        {
            frmCadastroCurso frm = new frmCadastroCurso();
            frm.ShowDialog(); //ShowDialog - abre o formulario como um diálogo modal
        }

        private void btnBuscarAluno_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(conexao.IniciarCon))
                {
                    cn.Open();

                    //var sqlQuery = "select * from alunos where nomeAluno ='" + txtBuscarAluno.Text + "'";
                    var sqlQuery = "select * from alunos where nomeAluno like '%" + txtBuscarAluno.Text + "%'";
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

        private void btnMatricularAluno_Click(object sender, EventArgs e)
        {
            frmMatriculaAluno frm = new frmMatriculaAluno();
            frm.ShowDialog();
        }

        private void btnAtualizarAluno_Click(object sender, EventArgs e)
        {
            // var - palavra-chave do C# especifica que o tipo de variável é determinado automaticamente com base no valor atribuido a ela
            // dataGridView1.CurrentCell.RowIndex - pega o índice da linha atualmente selecionada no DataGridView
            // dataGridView1.Rows[...].Cells[0].Value - acessa o valor da primeira célula (coluna índice 0) dessa linha.
            // a linha inteira serve para obter o id do aluno selecionado
            var idAluno = Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value);


            //cria uma nova instância do formulário frmCadastroAluno, passando idAluno como parâmetro para o construtor.
            frmCadastroAluno frm = new frmCadastroAluno(idAluno);
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmUnidadesEscolares frm = new frmUnidadesEscolares();
            frm.ShowDialog();
        }

        private void txtBuscarAluno_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnConsultarCurso_Click(object sender, EventArgs e)
        {
            frmBuscarCurso frm = new frmBuscarCurso();
            frm.ShowDialog();
        }

        private void btnConsultarEscola_Click(object sender, EventArgs e)
        {
            frmBuscarEscola frm = new frmBuscarEscola();
            frm.ShowDialog();
        }

        private void btnConsultarMatricula_Click(object sender, EventArgs e)
        {
            frmBuscarMatricula frm = new frmBuscarMatricula();
            frm.ShowDialog();
        }
    }
}
   
    

