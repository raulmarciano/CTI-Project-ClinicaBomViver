namespace ClinicConsultas
{
    partial class Painel_principal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Painel_principal));
            this.btnCadastro_cliente = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btncheckconsult = new System.Windows.Forms.Button();
            this.btnatendente = new System.Windows.Forms.Button();
            this.txttime = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txt_data = new System.Windows.Forms.TextBox();
            this.btnNavegador = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCadastro_cliente
            // 
            this.btnCadastro_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastro_cliente.Location = new System.Drawing.Point(321, 378);
            this.btnCadastro_cliente.Name = "btnCadastro_cliente";
            this.btnCadastro_cliente.Size = new System.Drawing.Size(144, 51);
            this.btnCadastro_cliente.TabIndex = 21;
            this.btnCadastro_cliente.Text = "Cadastrar Paciente";
            this.btnCadastro_cliente.UseVisualStyleBackColor = true;
            this.btnCadastro_cliente.Click += new System.EventHandler(this.btnCadastro_cliente_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(471, 378);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 51);
            this.button1.TabIndex = 22;
            this.button1.Text = "Agendar Consulta";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(12, 378);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(120, 51);
            this.btnSair.TabIndex = 25;
            this.btnSair.Text = "Fechar";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btncheckconsult
            // 
            this.btncheckconsult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncheckconsult.Location = new System.Drawing.Point(616, 378);
            this.btncheckconsult.Name = "btncheckconsult";
            this.btncheckconsult.Size = new System.Drawing.Size(133, 51);
            this.btncheckconsult.TabIndex = 26;
            this.btncheckconsult.Text = "Checar Consulta";
            this.btncheckconsult.UseVisualStyleBackColor = true;
            this.btncheckconsult.Click += new System.EventHandler(this.btncheckconsult_Click);
            // 
            // btnatendente
            // 
            this.btnatendente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnatendente.Location = new System.Drawing.Point(171, 378);
            this.btnatendente.Name = "btnatendente";
            this.btnatendente.Size = new System.Drawing.Size(144, 51);
            this.btnatendente.TabIndex = 27;
            this.btnatendente.Text = "Trocar Atendente";
            this.btnatendente.UseVisualStyleBackColor = true;
            this.btnatendente.Click += new System.EventHandler(this.button3_Click);
            // 
            // txttime
            // 
            this.txttime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttime.Location = new System.Drawing.Point(600, 53);
            this.txttime.Name = "txttime";
            this.txttime.Size = new System.Drawing.Size(61, 21);
            this.txttime.TabIndex = 29;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // txt_data
            // 
            this.txt_data.Location = new System.Drawing.Point(676, 53);
            this.txt_data.Name = "txt_data";
            this.txt_data.Size = new System.Drawing.Size(73, 20);
            this.txt_data.TabIndex = 31;
            // 
            // btnNavegador
            // 
            this.btnNavegador.Location = new System.Drawing.Point(632, 80);
            this.btnNavegador.Name = "btnNavegador";
            this.btnNavegador.Size = new System.Drawing.Size(75, 23);
            this.btnNavegador.TabIndex = 32;
            this.btnNavegador.Text = "Navegador";
            this.btnNavegador.UseVisualStyleBackColor = true;
            this.btnNavegador.Click += new System.EventHandler(this.btnNavegador_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ClinicConsultas.Properties.Resources.d1;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(761, 372);
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Painel_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 441);
            this.Controls.Add(this.btnNavegador);
            this.Controls.Add(this.txt_data);
            this.Controls.Add(this.txttime);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnatendente);
            this.Controls.Add(this.btncheckconsult);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCadastro_cliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Painel_principal";
            this.Text = "Painel Principal - Clínica Bom Viver";
            this.Load += new System.EventHandler(this.Painel_principal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCadastro_cliente;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btncheckconsult;
        private System.Windows.Forms.Button btnatendente;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txttime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txt_data;
        private System.Windows.Forms.Button btnNavegador;

    }
}