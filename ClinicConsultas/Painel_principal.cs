using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicConsultas
{
    public partial class Painel_principal : Form
    {
        DateTime data_hora;   
        public Painel_principal()
        {
            InitializeComponent();
            txttime.Enabled = false;
            txt_data.Enabled = false;
            data_hora = DateTime.Now;
            txt_data.Text = data_hora.ToShortDateString();
            btnatendente.Focus();
            btnatendente.Select();
            
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCadastro_cliente_Click(object sender, EventArgs e)
        {
            Cadastro cadastrar_paciente = new Cadastro();
            this.Hide();
            cadastrar_paciente.ShowDialog();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Agendar_consulta consulta = new Agendar_consulta();
            this.Hide();
            consulta.ShowDialog();

        }

        private void btncheckconsult_Click(object sender, EventArgs e)
        {
            Checa_consulta consulta = new Checa_consulta();
            this.Hide();
            consulta.ShowDialog();
        }
           
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            txttime.Text = DateTime.Now.ToLongTimeString(); 
        }     

        private void button3_Click(object sender, EventArgs e)
        {
            Login troca_atendente = new Login();
            this.Hide();
            troca_atendente.ShowDialog();
        }

        private void Painel_principal_Load(object sender, EventArgs e)
        {
            Conexao.Desconecta();
        }

        private void btnNavegador_Click(object sender, EventArgs e)
        {
            Navegador navegar = new Navegador();
            navegar.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
