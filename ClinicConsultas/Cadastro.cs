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
    
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        private void btnCancelarCadastro_Click(object sender, EventArgs e)
        {
            Painel_principal painel = new Painel_principal();
            this.Hide();
            painel.ShowDialog();
        }

        private void btnConfirmarCadastro_Click(object sender, EventArgs e)
        {
            NpgsqlConnection dbcon = new NpgsqlConnection(Conexao.strConexao);
            Conexao.Conecta();
            NpgsqlCommand dbcmd = dbcon.CreateCommand();
            String nome, cpf, genero, data, telefone, bairro, cidade, nome_rua, num_casa, llcep;
            nome = txtNome.Text;
            cpf = txtCPF.Text;
            genero = cbmGenero.Text;
            data = txtdatan.Text;
            telefone = txtTel.Text;
            bairro = txtBairro.Text;
            cidade = txtCidade.Text;
            nome_rua = txtRua.Text;
            num_casa = txtNCasa.Text;
            llcep = txtCEP.Text;
            int ativado = 1;
            String teste = "";
            if (nome != teste && cpf != teste && genero != teste && data != teste && telefone != teste && bairro != teste && cidade != teste && nome_rua != teste && num_casa != teste && llcep != teste)
            {
                try
                {
                    dbcmd.CommandText = "INSERT INTO tb_paciente (id_paciente, nome_paciente, nmr_cpf, genero, data_nascimento, telefone, bairro, cidade, cep, nome_rua, nmr_casa, excluido_paciente) VALUES (nextval('id_pacientesqc'),'" + nome + "','" + cpf + "','" + genero + "','" + data + "','" + telefone + "','" + bairro + "','" + cidade + "','" + llcep + "','" + nome_rua + "','" + num_casa + "','" + ativado + "');";
                    dbcmd.Connection = Conexao.conexao;
                    dbcmd.ExecuteNonQuery();
                    MessageBox.Show("Paciente Cadastrado!");
                    txtNome.Text = "";
                    txtCPF.Text = "";
                    cbmGenero.Text = "";
                    txtdatan.Text = "";
                    txtTel.Text = "";
                    txtBairro.Text = "";
                    txtCidade.Text = "";
                    txtRua.Text = "";
                    txtNCasa.Text = "";
                    txtCEP.Text = "";
                    cbmGenero.Text = "";
                }
                catch (Exception)
                {
                    MessageBox.Show("Paciente já Cadastrado!");
                }
            }
            else
            {
                MessageBox.Show("Um ou mais dados estão vazios!");
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

        private void txtdatan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
                MessageBox.Show("Digite somente números");
            }
        }

        private void txtTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
                MessageBox.Show("Digite somente números");
            }
        }

        private void txtCEP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
                MessageBox.Show("Digite somente números");
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (txtCPF.Text != "   .   .   -")
            {
                NpgsqlConnection dbcon = new NpgsqlConnection(Conexao.strConexao);
                Conexao.Conecta();
                NpgsqlCommand dbcmd = dbcon.CreateCommand();
                String nome, cpf, genero, data, telefone, bairro, cidade, nome_rua, num_casa, llcep;
                nome = txtNome.Text;
                cpf = txtCPF.Text;
                genero = cbmGenero.Text;
                data = txtdatan.Text;
                telefone = txtTel.Text;
                bairro = txtBairro.Text;
                cidade = txtCidade.Text;
                nome_rua = txtRua.Text;
                num_casa = txtNCasa.Text;
                llcep = txtCEP.Text;
                String teste = "";
                if (nome != teste && cpf != teste && genero != teste && data != teste && telefone != teste && bairro != teste && cidade != teste && nome_rua != teste && num_casa != teste && llcep != teste)
                {
                    try
                    {
                        dbcmd.CommandText = "UPDATE tb_paciente SET nome_paciente = '" + nome + "', genero = '" + genero + "', data_nascimento = '" + data + "', telefone = '" + telefone + "', bairro = '" + bairro + "', cidade = '" + cidade + "', cep = '" + llcep + "', nome_rua = '" + nome_rua + "', nmr_casa = '" + num_casa + "' WHERE nmr_cpf = '" + cpf + "';";
                        dbcmd.Connection = Conexao.conexao;
                        dbcmd.ExecuteNonQuery();
                        MessageBox.Show("Dados do Paciente Alterados!");
                        txtNome.Text = "";
                        txtCPF.Text = "";
                        cbmGenero.Text = "";
                        txtdatan.Text = "";
                        txtTel.Text = "";
                        txtBairro.Text = "";
                        txtCidade.Text = "";
                        txtRua.Text = "";
                        txtNCasa.Text = "";
                        txtCEP.Text = "";
                        cbmGenero.Text = "";
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Paciente não encontrado!");
                    }
                }
                else
                {
                    MessageBox.Show("Um ou mais dados estão vazios!");
                }
                Conexao.Desconecta();
            }
            else 
            {
                MessageBox.Show("Digite o CPF!");
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txtCPF.Text != "   .   .   -")
            {
                NpgsqlConnection dbcon = new NpgsqlConnection(Conexao.strConexao);
                Conexao.Conecta();
                NpgsqlCommand dbcmd = dbcon.CreateCommand();
                String nome, cpf, genero, data, telefone, bairro, cidade, nome_rua, num_casa, llcep;
                nome = txtNome.Text;
                cpf = txtCPF.Text;
                genero = cbmGenero.Text;
                data = txtdatan.Text;
                telefone = txtTel.Text;
                bairro = txtBairro.Text;
                cidade = txtCidade.Text;
                nome_rua = txtRua.Text;
                num_casa = txtNCasa.Text;
                llcep = txtCEP.Text;
                int ativado = 0;
                try
                {
                    dbcmd.CommandText = "UPDATE tb_paciente SET excluido_paciente = '" + ativado + "' WHERE nmr_cpf = '" + cpf + "';";
                    dbcmd.Connection = Conexao.conexao;
                    dbcmd.ExecuteNonQuery();
                    MessageBox.Show("Paciente Excluido!");
                    txtNome.Text = "";
                    txtCPF.Text = "";
                    cbmGenero.Text = "";
                    txtdatan.Text = "";
                    txtTel.Text = "";
                    txtBairro.Text = "";
                    txtCidade.Text = "";
                    txtRua.Text = "";
                    txtNCasa.Text = "";
                    txtCEP.Text = "";
                    cbmGenero.Text = "";
                }
                catch (Exception)
                {
                        MessageBox.Show("Paciente não encontrado!");
                }
                Conexao.Desconecta();
            }
            else 
            {
                MessageBox.Show("Digite o CPF!");
            }
        }
        
    }
}
