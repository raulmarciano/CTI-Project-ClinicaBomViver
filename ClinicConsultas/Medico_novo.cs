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
    public partial class Medico_novo : Form
    {
        public Medico_novo()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtCRM.Text != "" && txtespecialidade.Text != "" && txtnome.Text != "" && txtpreco.Text != "R$    ,")
            {
                NpgsqlConnection dbcon = new NpgsqlConnection(Conexao.strConexao);
                Conexao.Conecta();
                NpgsqlCommand dbcmd = dbcon.CreateCommand();
                String nome, especialidade, preco, crm;
                nome = txtnome.Text;
                especialidade = txtespecialidade.Text;
                preco = txtpreco.Text;
                crm = txtCRM.Text;
                int ativado = 1;
                try
                {
                    dbcmd.CommandText = "INSERT INTO medico (id_medico, nome_medico, especialidade, preco, crm_medico, excluido_medico) VALUES (nextval('id_medicosqc'),'" + nome + "','" + especialidade + "','" + preco + "','" + crm + "','" + ativado + "');";
                    dbcmd.Connection = Conexao.conexao;
                    dbcmd.ExecuteNonQuery();
                    MessageBox.Show("Médico Cadastrado com Sucesso!");
                    txtnome.Text = "";
                    txtespecialidade.Text = "";
                    txtpreco.Text = "";
                    txtCRM.Text = "";
                }
                catch (Exception)
                {
                    MessageBox.Show("CRM já Cadastrado!");
                }
                Conexao.Desconecta();
            }
            else 
            {
                 MessageBox.Show("Um ou mais dados estão vazios!");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Administrador adm = new Administrador();
            this.Hide();
            adm.ShowDialog();
        }

        private void txtCRM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
                MessageBox.Show("Digite somente números");
            }
        }

        private void txtExcluir_Click(object sender, EventArgs e)
        {
            if (txtCRM.Text != "")
            {
                NpgsqlConnection dbcon = new NpgsqlConnection(Conexao.strConexao);
                Conexao.Conecta();
                NpgsqlCommand dbcmd = dbcon.CreateCommand();
                int ativado = 0;
                try
                {
                    string crm = txtCRM.Text;
                    dbcmd.CommandText = "UPDATE medico SET excluido_medico = '" + ativado + "' WHERE crm_medico = '" + crm + "';";
                    dbcmd.Connection = Conexao.conexao;
                    NpgsqlDataReader reader = dbcmd.ExecuteReader();
                    MessageBox.Show("Médico Excluido!");
                    txtCRM.Text = "";
                    txtespecialidade.Text = "";
                    txtpreco.Text = "";
                    txtnome.Text = "";
                }
                catch (Exception)
                {
                    MessageBox.Show("CRM não encontrado!");
                }
                Conexao.Desconecta();
            }
            else
            {
                MessageBox.Show("Digite o CRM para excluír o Médico!");
            }
        }
    }
}
