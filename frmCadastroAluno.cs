using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace consultaAluno
{
    public partial class frmCadastroAluno : Form
    {
        int idAluno = 0;
        public frmCadastroAluno(int idAluno)
        {
            InitializeComponent();
            this.idAluno = idAluno;

            if (this.idAluno > 0)
                GetAluno(idAluno);
        }

        public frmCadastroAluno()
        {
        }

        private void GetAluno(int idAluno)
        {
            try
            {

                using (SqlConnection cn = new SqlConnection(conexao.IniciarCon))
                {
                    cn.Open();
                    var sql = "select * from alunos where idAlunos=" + idAluno;
                    using (SqlCommand cmd = new SqlCommand(sql, cn))
                    {
                        using (SqlDataReader dr = cmd.ExecuteReader())
                            if (dr.HasRows)
                            {
                                if (dr.Read())
                                {
                                    txtNome.Text = dr["nomeAluno"].ToString();
                                    txtData.Text = dr["dataNascAluno"].ToString();
                                    txtEmail.Text = dr["emailAluno"].ToString();
                                    txtTel.Text = dr["telefoneAluno"].ToString();
                                    txtAno.Text = dr["anoAluno"].ToString();


                                }
                            }
                    }
                }
            
         }
        
                       catch (Exception ex)
                       {
                         MessageBox.Show("Dados não atualizados.\n\n"+ex.Message);
                        }
}


         

       


        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //os blocos try e catch são usados para tratamento de exceções, ou seja, para lidar com erros que podem ocorrer durante a execução do código.
            try
            {
                using (SqlConnection cn = new SqlConnection(conexao.IniciarCon)) //cria uma nova conexão com banco
                {
                    cn.Open(); //Abre a conexão com o banco de dados. Sem isso, não é possível executar comandos SQL
                    var sql = "INSERT INTO alunos (nomeAluno, dataNascAluno, emailAluno, telefoneAluno, anoAluno) VALUES (@nome, @dataNascAluno, @emailAluno, @tel, @ano)";
                    //Define a consulta SQL que será executada.
                    using (SqlCommand cmd = new SqlCommand(sql, cn))
                    //Cria um objeto SqlCommand que representa o comando SQL a ser executado.
                    {
                        //Adiciona os valores dos parâmetros ao comando SQL. Cada parâmetro é associado a um valor obtido dos controles do formulário (txtNome.Text, txtData.Text, etc)
                        cmd.Parameters.AddWithValue("@nome", txtNome.Text);
                        cmd.Parameters.AddWithValue("@dataNascAluno", txtData.Text);
                        cmd.Parameters.AddWithValue("@emailAluno", txtEmail.Text);
                        cmd.Parameters.AddWithValue("@tel", txtTel.Text);
                        cmd.Parameters.AddWithValue("@ano", txtAno.Text);
                        cmd.ExecuteNonQuery(); //Executa o comando SQL no banco de dados

                        MessageBox.Show("Salvo com sucesso"); //Se o comando SQL for executado com sucesso, uma mensagem é exibida ao usuário

                    }
                }
            }

            //Se ocorrer algum erro durante a execução do código no bloco try, o controle será passado para o bloco catch.
            catch (Exception ex) //Exception ex: Captura a exceção gerada.

            {
                MessageBox.Show("Dados não salvos.\n\n" + ex.Message); //Exibe uma mensagem de erro ao usuário, incluindo a mensagem de exceção (ex.Message)
            }
        }
    }
}


