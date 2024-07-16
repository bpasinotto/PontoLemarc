namespace Ponto
{
    partial class frmConfiguracoes
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
            this.gbEmailPonte = new System.Windows.Forms.GroupBox();
            this.lblTestarEmail = new System.Windows.Forms.LinkLabel();
            this.cbSSL = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEmailPonte = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txtPorta = new System.Windows.Forms.TextBox();
            this.btnVerSenha = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtSmtp = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.gbEmailContador = new System.Windows.Forms.GroupBox();
            this.txtEmailContabi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gbEmailPonte.SuspendLayout();
            this.gbEmailContador.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbEmailPonte
            // 
            this.gbEmailPonte.Controls.Add(this.lblTestarEmail);
            this.gbEmailPonte.Controls.Add(this.cbSSL);
            this.gbEmailPonte.Controls.Add(this.label2);
            this.gbEmailPonte.Controls.Add(this.txtEmailPonte);
            this.gbEmailPonte.Controls.Add(this.lblSenha);
            this.gbEmailPonte.Controls.Add(this.txtPorta);
            this.gbEmailPonte.Controls.Add(this.btnVerSenha);
            this.gbEmailPonte.Controls.Add(this.label1);
            this.gbEmailPonte.Controls.Add(this.txtSenha);
            this.gbEmailPonte.Controls.Add(this.txtSmtp);
            this.gbEmailPonte.Controls.Add(this.lblEmail);
            this.gbEmailPonte.Font = new System.Drawing.Font("Montserrat Medium", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbEmailPonte.ForeColor = System.Drawing.Color.White;
            this.gbEmailPonte.Location = new System.Drawing.Point(12, 17);
            this.gbEmailPonte.Name = "gbEmailPonte";
            this.gbEmailPonte.Size = new System.Drawing.Size(565, 153);
            this.gbEmailPonte.TabIndex = 29;
            this.gbEmailPonte.TabStop = false;
            this.gbEmailPonte.Text = "E-mail ponte";
            // 
            // lblTestarEmail
            // 
            this.lblTestarEmail.AutoSize = true;
            this.lblTestarEmail.Font = new System.Drawing.Font("Montserrat Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTestarEmail.LinkColor = System.Drawing.Color.White;
            this.lblTestarEmail.Location = new System.Drawing.Point(431, 29);
            this.lblTestarEmail.Name = "lblTestarEmail";
            this.lblTestarEmail.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblTestarEmail.Size = new System.Drawing.Size(109, 21);
            this.lblTestarEmail.TabIndex = 55;
            this.lblTestarEmail.TabStop = true;
            this.lblTestarEmail.Text = "Testar E-mail";
            this.lblTestarEmail.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblTestarEmail_LinkClicked);
            // 
            // cbSSL
            // 
            this.cbSSL.AutoSize = true;
            this.cbSSL.Font = new System.Drawing.Font("Montserrat Medium", 11.25F, System.Drawing.FontStyle.Bold);
            this.cbSSL.Location = new System.Drawing.Point(508, 111);
            this.cbSSL.Name = "cbSSL";
            this.cbSSL.Size = new System.Drawing.Size(56, 25);
            this.cbSSL.TabIndex = 6;
            this.cbSSL.Text = "SSL";
            this.cbSSL.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(393, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 21);
            this.label2.TabIndex = 36;
            this.label2.Text = "Porta:";
            // 
            // txtEmailPonte
            // 
            this.txtEmailPonte.Font = new System.Drawing.Font("Montserrat Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailPonte.ForeColor = System.Drawing.Color.Black;
            this.txtEmailPonte.Location = new System.Drawing.Point(70, 26);
            this.txtEmailPonte.MaxLength = 35;
            this.txtEmailPonte.Name = "txtEmailPonte";
            this.txtEmailPonte.Size = new System.Drawing.Size(319, 26);
            this.txtEmailPonte.TabIndex = 2;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Montserrat Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.ForeColor = System.Drawing.Color.White;
            this.lblSenha.Location = new System.Drawing.Point(8, 71);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(60, 21);
            this.lblSenha.TabIndex = 26;
            this.lblSenha.Text = "Senha:";
            // 
            // txtPorta
            // 
            this.txtPorta.Font = new System.Drawing.Font("Montserrat Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPorta.ForeColor = System.Drawing.Color.Black;
            this.txtPorta.Location = new System.Drawing.Point(453, 110);
            this.txtPorta.MaxLength = 35;
            this.txtPorta.Name = "txtPorta";
            this.txtPorta.Size = new System.Drawing.Size(50, 26);
            this.txtPorta.TabIndex = 5;
            // 
            // btnVerSenha
            // 
            this.btnVerSenha.BackColor = System.Drawing.Color.Transparent;
            this.btnVerSenha.BackgroundImage = global::Ponto.Properties.Resources.olho;
            this.btnVerSenha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVerSenha.FlatAppearance.BorderSize = 0;
            this.btnVerSenha.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.btnVerSenha.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnVerSenha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerSenha.ForeColor = System.Drawing.Color.White;
            this.btnVerSenha.Location = new System.Drawing.Point(397, 68);
            this.btnVerSenha.Name = "btnVerSenha";
            this.btnVerSenha.Size = new System.Drawing.Size(24, 26);
            this.btnVerSenha.TabIndex = 27;
            this.btnVerSenha.TabStop = false;
            this.btnVerSenha.UseVisualStyleBackColor = false;
            this.btnVerSenha.Click += new System.EventHandler(this.btnVerSenha_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(10, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 21);
            this.label1.TabIndex = 34;
            this.label1.Text = "Smtp:";
            // 
            // txtSenha
            // 
            this.txtSenha.Font = new System.Drawing.Font("Montserrat Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Location = new System.Drawing.Point(70, 68);
            this.txtSenha.MaxLength = 20;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(318, 26);
            this.txtSenha.TabIndex = 3;
            this.txtSenha.UseSystemPasswordChar = true;
            // 
            // txtSmtp
            // 
            this.txtSmtp.Font = new System.Drawing.Font("Montserrat Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSmtp.ForeColor = System.Drawing.Color.Black;
            this.txtSmtp.Location = new System.Drawing.Point(70, 110);
            this.txtSmtp.MaxLength = 35;
            this.txtSmtp.Name = "txtSmtp";
            this.txtSmtp.Size = new System.Drawing.Size(319, 26);
            this.txtSmtp.TabIndex = 4;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Montserrat Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.White;
            this.lblEmail.Location = new System.Drawing.Point(8, 29);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(56, 21);
            this.lblEmail.TabIndex = 28;
            this.lblEmail.Text = "Email:";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Montserrat SemiBold", 8.999999F, System.Drawing.FontStyle.Bold);
            this.btnSalvar.ForeColor = System.Drawing.Color.Black;
            this.btnSalvar.Location = new System.Drawing.Point(209, 273);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 8;
            this.btnSalvar.TabStop = false;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Font = new System.Drawing.Font("Montserrat SemiBold", 8.999999F, System.Drawing.FontStyle.Bold);
            this.btnFechar.ForeColor = System.Drawing.Color.Black;
            this.btnFechar.Location = new System.Drawing.Point(305, 273);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(75, 23);
            this.btnFechar.TabIndex = 9;
            this.btnFechar.TabStop = false;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // gbEmailContador
            // 
            this.gbEmailContador.Controls.Add(this.txtEmailContabi);
            this.gbEmailContador.Controls.Add(this.label3);
            this.gbEmailContador.Font = new System.Drawing.Font("Montserrat Medium", 8.249999F, System.Drawing.FontStyle.Bold);
            this.gbEmailContador.ForeColor = System.Drawing.Color.White;
            this.gbEmailContador.Location = new System.Drawing.Point(12, 195);
            this.gbEmailContador.Name = "gbEmailContador";
            this.gbEmailContador.Size = new System.Drawing.Size(565, 59);
            this.gbEmailContador.TabIndex = 32;
            this.gbEmailContador.TabStop = false;
            this.gbEmailContador.Text = "E-mail da Contabilidade";
            // 
            // txtEmailContabi
            // 
            this.txtEmailContabi.Font = new System.Drawing.Font("Montserrat Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailContabi.ForeColor = System.Drawing.Color.Black;
            this.txtEmailContabi.Location = new System.Drawing.Point(70, 20);
            this.txtEmailContabi.MaxLength = 35;
            this.txtEmailContabi.Name = "txtEmailContabi";
            this.txtEmailContabi.Size = new System.Drawing.Size(319, 26);
            this.txtEmailContabi.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(8, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 21);
            this.label3.TabIndex = 30;
            this.label3.Text = "Email:";
            // 
            // frmConfiguracoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(589, 319);
            this.ControlBox = false;
            this.Controls.Add(this.gbEmailContador);
            this.Controls.Add(this.gbEmailPonte);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnFechar);
            this.Name = "frmConfiguracoes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Configurações";
            this.Load += new System.EventHandler(this.frmConfiguracoes_Load);
            this.gbEmailPonte.ResumeLayout(false);
            this.gbEmailPonte.PerformLayout();
            this.gbEmailContador.ResumeLayout(false);
            this.gbEmailContador.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbEmailPonte;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmailPonte;
        private System.Windows.Forms.Button btnVerSenha;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPorta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSmtp;
        private System.Windows.Forms.LinkLabel lblTestarEmail;
        private System.Windows.Forms.CheckBox cbSSL;
        private System.Windows.Forms.GroupBox gbEmailContador;
        private System.Windows.Forms.TextBox txtEmailContabi;
        private System.Windows.Forms.Label label3;
    }
}