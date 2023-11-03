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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            txtusuario.PasswordChar='*';
            txtsenha.PasswordChar = '*';
        }

        private void btnlogar_Click_1(object sender, EventArgs e)
        {
            teste_login();
        }

        public void teste_login()
        {
            if(txtsenha.Text != "" && txtusuario.Text != "")
            {
                if (txtusuario.Text == "adminclinica" && txtsenha.Text == "senhaclinica")
                {
                    Administrador funcionario = new Administrador();
                    this.Hide();
                    funcionario.ShowDialog();
                }
                else
                {
                    Boolean btnfound = false;
                    Conexao.Conecta();
                    try
                    {
                        string comandosql = "SELECT * FROM usuario WHERE nomeusuario = '" + txtusuario.Text + "' AND senha = MD5('" + txtsenha.Text + "');";
                        if (Conexao.confirmarusuario(comandosql))
                        {
                            btnfound = true;
                            Painel_principal painel = new Painel_principal();
                            this.Hide();
                            painel.ShowDialog();
                        }

                        if (btnfound == false)
                        {
                            MessageBox.Show("Usuário ou senha incorreto!");
                            txtsenha.Text = "";
                            txtusuario.Text = "";
                            txtusuario.Focus();
                            txtusuario.Select();
                            Conexao.Desconecta();
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Erro Inesperado");
                    }
                    Conexao.Desconecta();
                }
            }
            else 
            {
                MessageBox.Show("Um ou mais dados estão vazios!");
            }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtusuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                teste_login();
            }
        }

        private void txtsenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                teste_login();
            }
        }
    }
}
