namespace ClinicConsultas
{
    partial class Navegador
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Navegador));
            this.txtURL = new System.Windows.Forms.TextBox();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.btnPaginaInicial = new System.Windows.Forms.Button();
            this.btnParar = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnIr = new System.Windows.Forms.Button();
            this.btnAvancar = new System.Windows.Forms.Button();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtURL
            // 
            this.txtURL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtURL.Location = new System.Drawing.Point(268, 12);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(388, 30);
            this.txtURL.TabIndex = 7;
            this.txtURL.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtURL_KeyPress);
            // 
            // webBrowser
            // 
            this.webBrowser.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.webBrowser.Location = new System.Drawing.Point(0, 57);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(943, 509);
            this.webBrowser.TabIndex = 8;
            // 
            // btnPaginaInicial
            // 
            this.btnPaginaInicial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPaginaInicial.ForeColor = System.Drawing.SystemColors.Control;
            this.btnPaginaInicial.Image = global::ClinicConsultas.Properties.Resources.image3388;
            this.btnPaginaInicial.Location = new System.Drawing.Point(856, 2);
            this.btnPaginaInicial.Name = "btnPaginaInicial";
            this.btnPaginaInicial.Size = new System.Drawing.Size(75, 49);
            this.btnPaginaInicial.TabIndex = 6;
            this.btnPaginaInicial.UseVisualStyleBackColor = true;
            this.btnPaginaInicial.Click += new System.EventHandler(this.btnPaginaInicial_Click);
            // 
            // btnParar
            // 
            this.btnParar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnParar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnParar.Image = global::ClinicConsultas.Properties.Resources.image3366;
            this.btnParar.Location = new System.Drawing.Point(187, 2);
            this.btnParar.Name = "btnParar";
            this.btnParar.Size = new System.Drawing.Size(75, 49);
            this.btnParar.TabIndex = 5;
            this.btnParar.UseVisualStyleBackColor = true;
            this.btnParar.Click += new System.EventHandler(this.btnParar_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtualizar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAtualizar.Image = global::ClinicConsultas.Properties.Resources.image3377;
            this.btnAtualizar.Location = new System.Drawing.Point(775, 2);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(75, 49);
            this.btnAtualizar.TabIndex = 4;
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnIr
            // 
            this.btnIr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIr.ForeColor = System.Drawing.SystemColors.Control;
            this.btnIr.Image = global::ClinicConsultas.Properties.Resources.image3410;
            this.btnIr.Location = new System.Drawing.Point(662, 2);
            this.btnIr.Name = "btnIr";
            this.btnIr.Size = new System.Drawing.Size(75, 49);
            this.btnIr.TabIndex = 2;
            this.btnIr.UseVisualStyleBackColor = true;
            this.btnIr.Click += new System.EventHandler(this.btnIr_Click);
            // 
            // btnAvancar
            // 
            this.btnAvancar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAvancar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAvancar.Image = global::ClinicConsultas.Properties.Resources.image3399;
            this.btnAvancar.Location = new System.Drawing.Point(93, 2);
            this.btnAvancar.Name = "btnAvancar";
            this.btnAvancar.Size = new System.Drawing.Size(75, 49);
            this.btnAvancar.TabIndex = 1;
            this.btnAvancar.UseVisualStyleBackColor = true;
            this.btnAvancar.Click += new System.EventHandler(this.btnAvancar_Click);
            // 
            // btnvoltar
            // 
            this.btnvoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnvoltar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnvoltar.Image = global::ClinicConsultas.Properties.Resources.image3355;
            this.btnvoltar.Location = new System.Drawing.Point(12, 2);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(75, 49);
            this.btnvoltar.TabIndex = 0;
            this.btnvoltar.UseVisualStyleBackColor = true;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // navegador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 566);
            this.Controls.Add(this.webBrowser);
            this.Controls.Add(this.txtURL);
            this.Controls.Add(this.btnPaginaInicial);
            this.Controls.Add(this.btnParar);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnIr);
            this.Controls.Add(this.btnAvancar);
            this.Controls.Add(this.btnvoltar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "navegador";
            this.Text = "Navegador - Clínica Bom Viver";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnvoltar;
        private System.Windows.Forms.Button btnAvancar;
        private System.Windows.Forms.Button btnIr;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnParar;
        private System.Windows.Forms.Button btnPaginaInicial;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.WebBrowser webBrowser;
    }
}