namespace ClinicConsultas
{
    partial class Checa_consulta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Checa_consulta));
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupbox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPaciente_CPF = new System.Windows.Forms.MaskedTextBox();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.gpbcarregado = new System.Windows.Forms.GroupBox();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.txtHora = new System.Windows.Forms.TextBox();
            this.txtData = new System.Windows.Forms.TextBox();
            this.txtNascimento = new System.Windows.Forms.TextBox();
            this.txtGenero = new System.Windows.Forms.TextBox();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtEspecialidade = new System.Windows.Forms.TextBox();
            this.txtDoutor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtObersevacoes = new System.Windows.Forms.TextBox();
            this.btnCancelarConsulta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupbox.SuspendLayout();
            this.gpbcarregado.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(218, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Checagem de Consulta";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ClinicConsultas.Properties.Resources.ssdsd2631;
            this.pictureBox1.Location = new System.Drawing.Point(391, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(443, 276);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupbox
            // 
            this.groupbox.Controls.Add(this.label1);
            this.groupbox.Controls.Add(this.txtPaciente_CPF);
            this.groupbox.Controls.Add(this.btnVerificar);
            this.groupbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupbox.Location = new System.Drawing.Point(12, 54);
            this.groupbox.Name = "groupbox";
            this.groupbox.Size = new System.Drawing.Size(373, 68);
            this.groupbox.TabIndex = 12;
            this.groupbox.TabStop = false;
            this.groupbox.Text = "Identificação";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 17);
            this.label1.TabIndex = 33;
            this.label1.Text = "CPF:";
            // 
            // txtPaciente_CPF
            // 
            this.txtPaciente_CPF.Location = new System.Drawing.Point(50, 26);
            this.txtPaciente_CPF.Mask = "999,999,999-99";
            this.txtPaciente_CPF.Name = "txtPaciente_CPF";
            this.txtPaciente_CPF.Size = new System.Drawing.Size(195, 23);
            this.txtPaciente_CPF.TabIndex = 32;
            this.txtPaciente_CPF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPaciente_CPF_KeyPress);
            // 
            // btnVerificar
            // 
            this.btnVerificar.Location = new System.Drawing.Point(273, 18);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(75, 38);
            this.btnVerificar.TabIndex = 32;
            this.btnVerificar.Text = "Verificar";
            this.btnVerificar.UseVisualStyleBackColor = true;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // btnvoltar
            // 
            this.btnvoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvoltar.Location = new System.Drawing.Point(262, 388);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(123, 41);
            this.btnvoltar.TabIndex = 15;
            this.btnvoltar.Text = "Voltar";
            this.btnvoltar.UseVisualStyleBackColor = true;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Nome:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "Telefone:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 17);
            this.label6.TabIndex = 19;
            this.label6.Text = "Data de Nascimento:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(7, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 17);
            this.label7.TabIndex = 20;
            this.label7.Text = "Doutor:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(7, 175);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 17);
            this.label8.TabIndex = 21;
            this.label8.Text = "Preço:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(7, 148);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 17);
            this.label9.TabIndex = 22;
            this.label9.Text = "Especialidade:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(7, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 17);
            this.label10.TabIndex = 23;
            this.label10.Text = "Nome:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(7, 200);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 17);
            this.label11.TabIndex = 24;
            this.label11.Text = "Hora:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(7, 46);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 17);
            this.label12.TabIndex = 25;
            this.label12.Text = "Gênero:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(6, 227);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(42, 17);
            this.label14.TabIndex = 27;
            this.label14.Text = "Data:";
            // 
            // gpbcarregado
            // 
            this.gpbcarregado.Controls.Add(this.txtTelefone);
            this.gpbcarregado.Controls.Add(this.txtHora);
            this.gpbcarregado.Controls.Add(this.txtData);
            this.gpbcarregado.Controls.Add(this.txtNascimento);
            this.gpbcarregado.Controls.Add(this.txtGenero);
            this.gpbcarregado.Controls.Add(this.txtPreco);
            this.gpbcarregado.Controls.Add(this.txtNome);
            this.gpbcarregado.Controls.Add(this.label14);
            this.gpbcarregado.Controls.Add(this.txtEspecialidade);
            this.gpbcarregado.Controls.Add(this.label12);
            this.gpbcarregado.Controls.Add(this.txtDoutor);
            this.gpbcarregado.Controls.Add(this.label11);
            this.gpbcarregado.Controls.Add(this.label10);
            this.gpbcarregado.Controls.Add(this.label9);
            this.gpbcarregado.Controls.Add(this.label8);
            this.gpbcarregado.Controls.Add(this.label7);
            this.gpbcarregado.Controls.Add(this.label6);
            this.gpbcarregado.Controls.Add(this.label4);
            this.gpbcarregado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbcarregado.Location = new System.Drawing.Point(12, 123);
            this.gpbcarregado.Name = "gpbcarregado";
            this.gpbcarregado.Size = new System.Drawing.Size(373, 259);
            this.gpbcarregado.TabIndex = 28;
            this.gpbcarregado.TabStop = false;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(153, 93);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(115, 23);
            this.txtTelefone.TabIndex = 33;
            // 
            // txtHora
            // 
            this.txtHora.Location = new System.Drawing.Point(153, 198);
            this.txtHora.Name = "txtHora";
            this.txtHora.Size = new System.Drawing.Size(132, 23);
            this.txtHora.TabIndex = 34;
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(153, 224);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(108, 23);
            this.txtData.TabIndex = 31;
            // 
            // txtNascimento
            // 
            this.txtNascimento.Location = new System.Drawing.Point(153, 67);
            this.txtNascimento.Name = "txtNascimento";
            this.txtNascimento.Size = new System.Drawing.Size(104, 23);
            this.txtNascimento.TabIndex = 30;
            // 
            // txtGenero
            // 
            this.txtGenero.Location = new System.Drawing.Point(153, 43);
            this.txtGenero.Name = "txtGenero";
            this.txtGenero.Size = new System.Drawing.Size(34, 23);
            this.txtGenero.TabIndex = 29;
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(153, 172);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(100, 23);
            this.txtPreco.TabIndex = 32;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(153, 17);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(195, 23);
            this.txtNome.TabIndex = 28;
            // 
            // txtEspecialidade
            // 
            this.txtEspecialidade.Location = new System.Drawing.Point(153, 145);
            this.txtEspecialidade.Name = "txtEspecialidade";
            this.txtEspecialidade.Size = new System.Drawing.Size(100, 23);
            this.txtEspecialidade.TabIndex = 30;
            // 
            // txtDoutor
            // 
            this.txtDoutor.Location = new System.Drawing.Point(153, 118);
            this.txtDoutor.Name = "txtDoutor";
            this.txtDoutor.Size = new System.Drawing.Size(100, 23);
            this.txtDoutor.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(388, 280);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 17);
            this.label3.TabIndex = 29;
            this.label3.Text = "Oberservações";
            // 
            // txtObersevacoes
            // 
            this.txtObersevacoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObersevacoes.Location = new System.Drawing.Point(391, 306);
            this.txtObersevacoes.Multiline = true;
            this.txtObersevacoes.Name = "txtObersevacoes";
            this.txtObersevacoes.Size = new System.Drawing.Size(437, 123);
            this.txtObersevacoes.TabIndex = 30;
            // 
            // btnCancelarConsulta
            // 
            this.btnCancelarConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarConsulta.Location = new System.Drawing.Point(12, 388);
            this.btnCancelarConsulta.Name = "btnCancelarConsulta";
            this.btnCancelarConsulta.Size = new System.Drawing.Size(143, 41);
            this.btnCancelarConsulta.TabIndex = 31;
            this.btnCancelarConsulta.Text = "Cancelar Consulta";
            this.btnCancelarConsulta.UseVisualStyleBackColor = true;
            this.btnCancelarConsulta.Click += new System.EventHandler(this.btnCancelarConsulta_Click);
            // 
            // Checa_consulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 441);
            this.Controls.Add(this.btnCancelarConsulta);
            this.Controls.Add(this.txtObersevacoes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gpbcarregado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnvoltar);
            this.Controls.Add(this.groupbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Checa_consulta";
            this.Text = "Checagem de Consulta - Clínica Bom Viver";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupbox.ResumeLayout(false);
            this.groupbox.PerformLayout();
            this.gpbcarregado.ResumeLayout(false);
            this.gpbcarregado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupbox;
        private System.Windows.Forms.Button btnvoltar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox gpbcarregado;
        private System.Windows.Forms.TextBox txtNascimento;
        private System.Windows.Forms.TextBox txtGenero;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtEspecialidade;
        private System.Windows.Forms.TextBox txtDoutor;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.TextBox txtHora;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtObersevacoes;
        private System.Windows.Forms.Button btnCancelarConsulta;
        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.MaskedTextBox txtPaciente_CPF;
        private System.Windows.Forms.Label label1;
    }
}