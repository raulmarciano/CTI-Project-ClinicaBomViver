namespace ClinicConsultas
{
    partial class Administrador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Administrador));
            this.label1 = new System.Windows.Forms.Label();
            this.btnCadastro_Medicos = new System.Windows.Forms.Button();
            this.btnCadastro_funcionario = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnvoltar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(121, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 25);
            this.label1.TabIndex = 22;
            this.label1.Text = "Bem-Vindo Administrador";
            // 
            // btnCadastro_Medicos
            // 
            this.btnCadastro_Medicos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastro_Medicos.Location = new System.Drawing.Point(12, 256);
            this.btnCadastro_Medicos.Name = "btnCadastro_Medicos";
            this.btnCadastro_Medicos.Size = new System.Drawing.Size(208, 35);
            this.btnCadastro_Medicos.TabIndex = 25;
            this.btnCadastro_Medicos.Text = "Cadastro de Médicos";
            this.btnCadastro_Medicos.UseVisualStyleBackColor = true;
            this.btnCadastro_Medicos.Click += new System.EventHandler(this.btnCadastro_Medicos_Click);
            // 
            // btnCadastro_funcionario
            // 
            this.btnCadastro_funcionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastro_funcionario.Location = new System.Drawing.Point(225, 256);
            this.btnCadastro_funcionario.Name = "btnCadastro_funcionario";
            this.btnCadastro_funcionario.Size = new System.Drawing.Size(208, 35);
            this.btnCadastro_funcionario.TabIndex = 24;
            this.btnCadastro_funcionario.Text = "Cadastro de Funcionários";
            this.btnCadastro_funcionario.UseVisualStyleBackColor = true;
            this.btnCadastro_funcionario.Click += new System.EventHandler(this.btnCadastro_funcionario_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(440, 212);
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // btnvoltar
            // 
            this.btnvoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvoltar.Location = new System.Drawing.Point(12, 6);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(89, 26);
            this.btnvoltar.TabIndex = 26;
            this.btnvoltar.Text = "Voltar";
            this.btnvoltar.UseVisualStyleBackColor = true;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // Administrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 296);
            this.Controls.Add(this.btnvoltar);
            this.Controls.Add(this.btnCadastro_Medicos);
            this.Controls.Add(this.btnCadastro_funcionario);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Administrador";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Administrador";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCadastro_Medicos;
        private System.Windows.Forms.Button btnCadastro_funcionario;
        private System.Windows.Forms.Button btnvoltar;
    }
}