using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace consultaAluno
{
    public partial class frmMatriculaAluno : Form
    {
        public class ComboboxItem
        {
            public string Text { get; set; }
            public object Value { get; set; }

            public override string ToString()
            {
                return Text;
            }
        }
        private string connectionString = conexao.IniciarCon;
        public frmMatriculaAluno()
        {
            InitializeComponent();
            CarregarAlunos();
            CarregarCursos();


        }

        private void CarregarAlunos()
        {
            using (SqlConnection cn = new SqlConnection(connectionString))
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand("select idAluno, nomeAluno from alunos", cn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cmbNomeAluno.Items.Add(new ComboboxItem
                    {
                        Text = reader["nomeAluno"].ToString(),
                        Value = reader["idAluno"]
                    });
                }
            }
        }


        private void CarregarCursos()
        {
            using (SqlConnection cn = new SqlConnection(connectionString))
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand("SELECT idCurso, nomeCurso FROM cursos", cn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cmbNomeCurso.Items.Add(new ComboboxItem
                    {
                        Text = reader["nomeCurso"].ToString(),
                        Value = reader["idCurso"]
                    });
                }
            }
        }
      

    
        

        private void btnSalvarMatricula_Click(object sender, EventArgs e)
        {
            if (cmbNomeAluno.SelectedItem == null || cmbNomeCurso.SelectedItem == null)
            {
                MessageBox.Show("Selecione um aluno e um curso.");
                return;
            }
            int idAluno = (int)(cmbNomeAluno.SelectedItem as ComboboxItem).Value;
            int idCurso = (int)(cmbNomeCurso.SelectedItem as ComboboxItem).Value;
            DateTime dataMatricula = dtpDataMatricula2.Value;
            string statusMatricula = cmbStatusMatricula.SelectedItem.ToString();

            using (SqlConnection cn = new SqlConnection(connectionString))
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO matriculas (idAluno, idCurso, dataMatricula, statusMatricula) VALUES (@idAluno, @idCurso, @dataMatricula, @statusMatricula)", cn);
                cmd.Parameters.AddWithValue("@idAluno", idAluno);
                cmd.Parameters.AddWithValue("@idCurso", idCurso);
                cmd.Parameters.AddWithValue("@dataMatricula", dataMatricula);
                cmd.Parameters.AddWithValue("@statusMatricula", statusMatricula);
                cmd.ExecuteNonQuery();
            }
            MessageBox.Show("Matrícula realizada com sucesso!");
        }
    }
    }
    


