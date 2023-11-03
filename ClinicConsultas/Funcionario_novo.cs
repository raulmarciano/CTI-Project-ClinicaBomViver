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
    public partial class Funcionario_novo : Form
    {
        public Funcionario_novo()
        {
            InitializeComponent();
        }

        private void funcionarionovo_Load(object sender, EventArgs e)
        {
            txtSenha.PasswordChar = '*';

        }


        private void button2_Click(object sender, EventArgs e)
        {
            if (txtNome.Text != "" && txtSenha.Text != "" && txtUsuario.Text != "")
            {
                NpgsqlConnection dbcon = new NpgsqlConnection(Conexao.strConexao);
                Conexao.Conecta();
                NpgsqlCommand dbcmd = dbcon.CreateCommand();
                String nome, usuario, senha;
                nome = txtNome.Text;
                usuario = txtUsuario.Text;
                senha = txtSenha.Text;
                try
                {
                    dbcmd.CommandText = "INSERT INTO usuario (id_usuario, nome, nomeusuario, senha) VALUES (nextval('id_usuariosqc'),'" + nome + "','" + usuario + "',MD5('" + senha + "'));";
                    dbcmd.Connection = Conexao.conexao;
                    dbcmd.ExecuteNonQuery();

                    MessageBox.Show("Usuário Cadastrado com Sucesso!");
                    txtNome.Text = "";
                    txtUsuario.Text = "";
                    txtSenha.Text = "";
                }
                catch (Exception)
                {
                    MessageBox.Show("Usuário já existente!");
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

        private void bntExcluir_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text != "")
            {
                NpgsqlConnection dbcon = new NpgsqlConnection(Conexao.strConexao);
                Conexao.Conecta();
                NpgsqlCommand dbcmd = dbcon.CreateCommand();
                String nome, usuario, senha;
                nome = txtNome.Text;
                usuario = txtUsuario.Text;
                senha = txtSenha.Text;
                try
                {
                    dbcmd.CommandText = "DELETE FROM usuario WHERE nomeusuario = '" + usuario + "';";
                    dbcmd.Connection = Conexao.conexao;
                    dbcmd.ExecuteNonQuery();
                    MessageBox.Show("Usuário Excluido com Sucesso!");
                    txtNome.Text = "";
                    txtUsuario.Text = "";
                    txtSenha.Text = "";
                }
                catch (Exception)
                {
                    MessageBox.Show("Usuário inexistente!");
                }
                Conexao.Desconecta();
            }
            else
            {
                MessageBox.Show("Digite o Usuário!");
            }
        }
    }
}
