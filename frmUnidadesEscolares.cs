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
    public partial class frmUnidadesEscolares : Form
    {
        public frmUnidadesEscolares()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvarCadEscola_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(conexao.IniciarCon))
                {
                    cn.Open();
                    var sql = "INSERT INTO escolas (nomeEscola, enderecoEscola, cidadeEscola, telefoneEscola) VALUES (@nomeEscola, @enderecoEscola, @cidadeEscola, @telefoneEscola)";

                    using (SqlCommand cmd = new SqlCommand(sql, cn))

                    {

                        cmd.Parameters.AddWithValue("@nomeEscola", txtNomeEscola.Text);
                        cmd.Parameters.AddWithValue("@enderecoEscola", txtEnderecoEscola.Text);
                        cmd.Parameters.AddWithValue("@cidadeEscola", txtCidadeEscola.Text);
                        cmd.Parameters.AddWithValue("@telefoneEscola", txtTelefoneEscola.Text);
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

        private void txtNomeEscola_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
