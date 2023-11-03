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
    public partial class Administrador : Form
    {
        public Administrador()
        {
            InitializeComponent();
            btnvoltar.Select();
        }

        private void btnCancelarCadastro_Click(object sender, EventArgs e)
        {
            Funcionario_novo funcionario = new Funcionario_novo();
            this.Hide();
            funcionario.ShowDialog();
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.ShowDialog();
        }

        private void btnCadastro_funcionario_Click(object sender, EventArgs e)
        {
            Funcionario_novo funcionario = new Funcionario_novo();
            this.Hide();
            funcionario.ShowDialog();
        }

        private void btnCadastro_Medicos_Click(object sender, EventArgs e)
        {
            Medico_novo medico = new Medico_novo();
            this.Hide();
            medico.ShowDialog();
        }
    }
}
