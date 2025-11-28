using Form1;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Formulario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Classe de conexão corrigida
        public class Connection
        {
            public SqlConnection Connect()
            {
                // COLOQUE SUA STRING DE CONEXÃO AQUI
                SqlConnection conn = new SqlConnection(@"Server= .\BDSENAC; Database=AgendaDB; User Id= senaclivre; Password= senaclivre;");
                conn.Open();
                return conn;
            }
        }

        Connection con = new Connection();

        // Validação de email
        bool EmailValido(string email)
        {
            return Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtNome.Focus();
            AtualizarGrid();
        }

        private void LimparCampos()
        {
            txtID.Clear();
            txtNome.Clear();
            txtTelefone.Clear();
            txtEmail.Clear();
            txtData.Value = DateTime.Now;
            txtNome.Focus();
        }

        // Atualiza DataGridView
        private void AtualizarGrid()
        {
            using (SqlConnection conn = con.Connect())
            {
                string sql = "SELECT * FROM Contatos ORDER BY ID";

                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                Dg.DataSource = dt;
            }
        }

        // Quando clicar no DataGrid
        private void Dg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            txtID.Text = Dg.Rows[e.RowIndex].Cells["ID"].Value.ToString();
            txtNome.Text = Dg.Rows[e.RowIndex].Cells["Nome"].Value.ToString();
            txtTelefone.Text = Dg.Rows[e.RowIndex].Cells["Telefone"].Value.ToString();
            txtEmail.Text = Dg.Rows[e.RowIndex].Cells["Email"].Value.ToString();

            // Tratar DataRegistro nula
            var data = Dg.Rows[e.RowIndex].Cells["DataRegistro"].Value;
            if (data != DBNull.Value)
                txtData.Value = Convert.ToDateTime(data);
            else
                txtData.Value = DateTime.Now;
        }

        // Adicionar registro
        private void Adicionar_Click(object sender, EventArgs e)
        {
            if (!EmailValido(txtEmail.Text))
            {
                MessageBox.Show("E-mail inválido!");
                return;
            }

            try
            {
                using (SqlConnection conn = con.Connect())
                {
                    string sql = @"INSERT INTO Contatos 
                          (Nome, Telefone, Email, DataRegistro)
                          VALUES (@Nome, @Telefone, @Email, @DataRegistro)";

                    SqlCommand cmd = new SqlCommand(sql, conn);

                    cmd.Parameters.Add("@Nome", SqlDbType.VarChar).Value = txtNome.Text;
                    cmd.Parameters.Add("@Telefone", SqlDbType.VarChar).Value = txtTelefone.Text;
                    cmd.Parameters.Add("@Email", SqlDbType.VarChar).Value = txtEmail.Text;
                    cmd.Parameters.Add("@DataRegistro", SqlDbType.Date).Value = txtData.Value;

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Registro inserido!");
                AtualizarGrid();
                LimparCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        // Alterar registro
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "")
            {
                MessageBox.Show("Selecione um registro!");
                return;
            }
            
            using (SqlConnection conn = con.Connect())
            {
                string sql = @"UPDATE Contatos 
                               SET Nome=@Nome, Telefone=@Telefone, Email=@Email, DataRegistro=@DataRegistro
                               WHERE ID=@ID";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.Add("@ID", SqlDbType.Int).Value = int.Parse(txtID.Text);
                cmd.Parameters.Add("@Nome", SqlDbType.VarChar).Value = txtNome.Text;
                cmd.Parameters.Add("@Telefone", SqlDbType.VarChar).Value = txtTelefone.Text;
                cmd.Parameters.Add("@Email", SqlDbType.VarChar).Value = txtEmail.Text;
                cmd.Parameters.Add("@DataRegistro", SqlDbType.Date).Value = txtData.Value;

                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Registro alterado!");
            AtualizarGrid();
            LimparCampos();
        }

        // Excluir registro
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "")
            {
                MessageBox.Show("Selecione um registro!");
                return;
            }

            if (MessageBox.Show("Deseja excluir este registro?", "Confirmação",
                MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            using (SqlConnection conn = con.Connect())
            {
                string sql = "DELETE FROM Contatos WHERE ID=@ID";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add("@ID", SqlDbType.Int).Value = int.Parse(txtID.Text);

                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Registro excluído!");
            AtualizarGrid();
            LimparCampos();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            AtualizarGrid();
        }
    }
}
