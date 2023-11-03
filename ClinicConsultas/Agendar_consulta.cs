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
    public partial class Agendar_consulta : Form
    {
        public Agendar_consulta()
        {
            InitializeComponent();
            txtPreco.Enabled = false;
            txtGenero.Enabled = false;
            txtDtNascimento.Enabled = false;
            txtTelefone.Enabled = false;
            txtCPF.Focus();
            txtCPF.Select();
            txtespecialidade.Enabled = false;
            txtNome.Enabled = false;
            txtCRM.Enabled = false;
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            Painel_principal painel = new Painel_principal();
            this.Hide();
            painel.ShowDialog();
        }

        private void agendarconsulta_Load(object sender, EventArgs e)
        {
            Conexao.Conecta();
            NpgsqlConnection dbcon = new NpgsqlConnection(Conexao.strConexao);
            int ativado = 1;
            try
            {
                string sql = "SELECT * FROM medico WHERE excluido_medico = '" + ativado + "' ORDER BY nome_medico;";
                NpgsqlDataAdapter daMedicos = new NpgsqlDataAdapter(sql, dbcon);
                DataTable dtMedico = new DataTable();
                dtMedico.Clear();
                daMedicos.Fill(dtMedico);
                cmbDoutor.Items.Clear();
                cmbDoutor.DataSource = dtMedico;
                cmbDoutor.DisplayMember = dtMedico.Columns["nome_medico"].ToString();
                cmbDoutor.ValueMember = dtMedico.Columns["id_medico"].ToString();
                if (cmbDoutor.Text != "")
                {
                    cmbDoutor.SelectedIndex = -1;
                }
                else
                {
                    cmbDoutor.Enabled = false;
                    lblAlerta.Text = "Nenhum Médico Cadastrado!";
                    lblAlerta2.Text = "Cadastre um Médico para criar uma Consulta.";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erro Inesperado!");
            }
            Conexao.Desconecta();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            NpgsqlConnection dbcon = new NpgsqlConnection(Conexao.strConexao);
            Conexao.Conecta();
            NpgsqlCommand dbcmd = dbcon.CreateCommand();
            String cpf, hora_consulta, observacoes, dataconsulta, medico, preco, especialidade, nome, genero, data_nascimento, telefone, crm;
            cpf = txtCPF.Text;
            hora_consulta = txtHora.Text;
            observacoes = txtObservacoes.Text;
            dataconsulta = txtData.Text;
            medico = cmbDoutor.Text;
            preco = txtPreco.Text;
            especialidade = txtespecialidade.Text;
            nome = txtNome.Text;
            genero = txtGenero.Text;
            data_nascimento = txtDtNascimento.Text;
            telefone = txtTelefone.Text;
            crm = txtCRM.Text;
            int ativado = 1;
            if (hora_consulta != "  :" && dataconsulta != "  /  /" && cpf != "   .   .   -" && medico != "" && preco != "" && especialidade != "" && nome != "")
            {
                try
                {
                    dbcmd.CommandText = "INSERT INTO consulta (id_consulta, nmr_cpf, nome_paciente, genero , data_nascimento, telefone, hora_consulta, observacoes, data_consulta, id_medico, preco, especialidade, crm_medico, excluido_consulta) VALUES (nextval('id_consultasqc'),'" + cpf + "', '" + nome + "','" + genero + "','" + data_nascimento + "','" + telefone + "','" + hora_consulta + "','" + observacoes + "','" + dataconsulta + "','" + medico + "','" + preco + "','" + especialidade + "','" + crm + "','" + ativado + "');";
                    dbcmd.Connection = Conexao.conexao;
                    dbcmd.ExecuteNonQuery();
                    MessageBox.Show("Consulta Cadastrada com sucesso!");
                    txtCPF.Text = "";
                    txtHora.Text = "";
                    txtObservacoes.Text = "";
                    txtData.Text = "";
                    cmbDoutor.Text = "";
                    txtPreco.Text = "";
                    txtespecialidade.Text = "";
                    txtNome.Text = "";
                    txtGenero.Text = "";
                    txtDtNascimento.Text = "";
                    txtTelefone.Text = "";
                    txtCRM.Text = "";
                }
                catch (Exception)
                {
                    MessageBox.Show("Erro Inesperado");
                }
            }
            else
            {
                MessageBox.Show("Um ou mais dados estão vazios!");
            }
            Conexao.Desconecta();
        } 

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtCPF.Text != "   .   .   -")
            {
                string cpf = txtCPF.Text;
                int ativado = 1;
                NpgsqlConnection dbcon = new NpgsqlConnection(Conexao.strConexao);
                Conexao.Conecta();
                NpgsqlCommand dbcmd = dbcon.CreateCommand();
                try
                {
                    dbcmd.CommandText = "SELECT * FROM tb_paciente WHERE nmr_cpf = '" + cpf + "' AND excluido_paciente = '" + ativado + "';";
                    dbcmd.Connection = Conexao.conexao;
                    NpgsqlDataReader reader = dbcmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        reader.Read();
                        txtNome.Text = reader["nome_paciente"].ToString();
                        txtGenero.Text = reader["genero"].ToString();
                        txtTelefone.Text = reader["telefone"].ToString();
                        txtDtNascimento.Text = reader["data_nascimento"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Paciente inexistente!");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Erro Inesperado");
                }
                Conexao.Desconecta();
            }
            else 
            {
                MessageBox.Show("Digite o CPF!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string medico = cmbDoutor.Text;
            int ativado = 1;
            NpgsqlConnection dbcona = new NpgsqlConnection(Conexao.strConexao);
            Conexao.Conecta();
            NpgsqlCommand dbcmda = dbcona.CreateCommand();
            try
            {
                dbcmda.CommandText = "SELECT * FROM medico WHERE nome_medico = '" + medico + "' AND excluido_medico = '" + ativado + "';";
                dbcmda.Connection = Conexao.conexao;
                NpgsqlDataReader reader = dbcmda.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    txtespecialidade.Text = reader["especialidade"].ToString();
                    txtPreco.Text = reader["preco"].ToString();
                    txtCRM.Text = reader["crm_medico"].ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erro Inesperado");
            }
            Conexao.Desconecta();
        }

        private void txtCPF_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
                MessageBox.Show("Digite somente números");
            }
        }

        private void txtData_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
                MessageBox.Show("Digite somente números");
            }
        }

        private void txtHora_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
                MessageBox.Show("Digite somente números");
            }
        }

        private void txtCPF_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
                MessageBox.Show("Digite somente números");
            }
        }

        private void txtData_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
                MessageBox.Show("Digite somente números");
            }
        }

        private void txtHora_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
                MessageBox.Show("Digite somente números");
            }
        }
    }
}
