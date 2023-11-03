using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace ClinicConsultas
{
    public partial class Checa_consulta : Form
    {
        public Checa_consulta()
        {
            InitializeComponent();
            txtNome.Enabled = false;
            txtGenero.Enabled = false;
            txtTelefone.Enabled = false;
            txtNascimento.Enabled = false;
            txtDoutor.Enabled = false;
            txtEspecialidade.Enabled = false;
            txtPreco.Enabled = false;
            txtData.Enabled = false;
            txtHora.Enabled = false;
            txtObersevacoes.Enabled = false;
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {

            Painel_principal painel = new Painel_principal();
            this.Hide();
            painel.ShowDialog();
        }


        private void btnVerificar_Click(object sender, EventArgs e)
        {
            try
            {
                int ativado = 1;
                string cpf = txtPaciente_CPF.Text;
                NpgsqlConnection dbcon = new NpgsqlConnection(Conexao.strConexao);
                Conexao.Conecta();
                NpgsqlCommand dbcmd = dbcon.CreateCommand();
                dbcmd.CommandText = "SELECT * FROM consulta WHERE nmr_cpf = '" + cpf + "' AND excluido_consulta = '" + ativado + "';";
                
                   
                dbcmd.Connection = Conexao.conexao;
                NpgsqlDataReader reader = dbcmd.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    txtNome.Text = reader["nome_paciente"].ToString();
                    txtGenero.Text = reader["genero"].ToString();
                    txtNascimento.Text = reader["data_nascimento"].ToString();
                    txtTelefone.Text = reader["telefone"].ToString();
                    txtHora.Text = reader["hora_consulta"].ToString();
                    txtObersevacoes.Text = reader["observacoes"].ToString();
                    txtData.Text = reader["data_consulta"].ToString();
                    txtDoutor.Text = reader["id_medico"].ToString();
                    txtPreco.Text = reader["preco"].ToString();
                    txtEspecialidade.Text = reader["especialidade"].ToString();
                }
                else
                {
                    MessageBox.Show("Consulta inexistente!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erro Inesperado");
            }
            Conexao.Desconecta();
        }

        private void btnCancelarConsulta_Click(object sender, EventArgs e)
        {
            if (txtPaciente_CPF.Text != "   .   .   -" && txtNome.Text != "")
            {
                int ativado = 0;
                NpgsqlConnection dbcon = new NpgsqlConnection(Conexao.strConexao);
                Conexao.Conecta();
                NpgsqlCommand dbcmd = dbcon.CreateCommand();
                try
                {
                    String cpftext = txtPaciente_CPF.Text;
                    dbcmd.CommandText = "UPDATE consulta SET excluido_consulta = '" + ativado + "' WHERE nmr_cpf = '" + cpftext + "';";
                    dbcmd.Connection = Conexao.conexao;
                    NpgsqlDataReader reader = dbcmd.ExecuteReader();
                    MessageBox.Show("Consulta cancelada!");
                    txtNome.Text = "";
                    txtGenero.Text = "";
                    txtNascimento.Text = "";
                    txtTelefone.Text = "";
                    txtHora.Text = "";
                    txtObersevacoes.Text = "";
                    txtData.Text = "";
                    txtDoutor.Text = "";
                    txtPreco.Text = "";
                    txtEspecialidade.Text = "";
                    txtPaciente_CPF.Text = "";
                }
                catch (Exception)
                {
                    MessageBox.Show("Erro Inesperado");
                }
                Conexao.Desconecta();
            }
            else
            {
                MessageBox.Show("Digite o CPF e Verifique se existe a consulta!");
            }
        }

        private void txtPaciente_CPF_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
                MessageBox.Show("Digite somente números");
            }
        }
    }
}
