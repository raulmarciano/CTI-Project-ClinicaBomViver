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
    public partial class Navegador : Form
    {
        public Navegador()
        {
            InitializeComponent();
            webBrowser.Navigate("http://google.com/");
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            webBrowser.GoBack();
        }

        private void btnAvancar_Click(object sender, EventArgs e)
        {
            webBrowser.GoForward();
        }

        private void btnParar_Click(object sender, EventArgs e)
        {
            webBrowser.Stop();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            webBrowser.Refresh();
        }

        private void btnIr_Click(object sender, EventArgs e)
        {
            teste_url();
        }

        public void teste_url ()
        {
            if (txtURL.Text != "")
            {
                webBrowser.Navigate(txtURL.Text);
            }
            else
            {
                MessageBox.Show("Digite uma URL Válida!");
            }
        }

        private void btnPaginaInicial_Click(object sender, EventArgs e)
        {
            webBrowser.Navigate("http://google.com/");
        }
        
        private void txtURL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                teste_url();
            }
        }
    }
}
