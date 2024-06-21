using Ponto;

namespace Ponto
{
    partial class frmCadFuncionario
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
            this.nomeLabel1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblDesativarCadastro = new System.Windows.Forms.LinkLabel();
            this.lblAlterarEmail = new System.Windows.Forms.LinkLabel();
            this.lblAlterarNome = new System.Windows.Forms.LinkLabel();
            this.lblAlterarSenha = new System.Windows.Forms.LinkLabel();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnVerSenha = new System.Windows.Forms.Button();
            this.lblSenha = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nomeLabel1
            // 
            this.nomeLabel1.AutoSize = true;
            this.nomeLabel1.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeLabel1.ForeColor = System.Drawing.Color.White;
            this.nomeLabel1.Location = new System.Drawing.Point(6, 33);
            this.nomeLabel1.Name = "nomeLabel1";
            this.nomeLabel1.Size = new System.Drawing.Size(76, 26);
            this.nomeLabel1.TabIndex = 21;
            this.nomeLabel1.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(91, 31);
            this.txtNome.MaxLength = 35;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(404, 31);
            this.txtNome.TabIndex = 22;
            // 
            // txtSenha
            // 
            this.txtSenha.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Location = new System.Drawing.Point(91, 147);
            this.txtSenha.MaxLength = 10;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(206, 31);
            this.txtSenha.TabIndex = 24;
            this.txtSenha.UseSystemPasswordChar = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSenha);
            this.groupBox1.Controls.Add(this.lblDesativarCadastro);
            this.groupBox1.Controls.Add(this.lblAlterarEmail);
            this.groupBox1.Controls.Add(this.lblAlterarNome);
            this.groupBox1.Controls.Add(this.lblAlterarSenha);
            this.groupBox1.Controls.Add(this.lblEmail);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.btnVerSenha);
            this.groupBox1.Controls.Add(this.lblSenha);
            this.groupBox1.Controls.Add(this.nomeLabel1);
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Location = new System.Drawing.Point(43, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(506, 204);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            // 
            // lblDesativarCadastro
            // 
            this.lblDesativarCadastro.AutoSize = true;
            this.lblDesativarCadastro.Font = new System.Drawing.Font("Montserrat Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesativarCadastro.LinkColor = System.Drawing.Color.White;
            this.lblDesativarCadastro.Location = new System.Drawing.Point(342, 152);
            this.lblDesativarCadastro.Name = "lblDesativarCadastro";
            this.lblDesativarCadastro.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblDesativarCadastro.Size = new System.Drawing.Size(154, 21);
            this.lblDesativarCadastro.TabIndex = 32;
            this.lblDesativarCadastro.TabStop = true;
            this.lblDesativarCadastro.Text = "Desativar Cadastro";
            this.lblDesativarCadastro.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblDesativarCadastro_LinkClicked);
            // 
            // lblAlterarEmail
            // 
            this.lblAlterarEmail.AutoSize = true;
            this.lblAlterarEmail.Font = new System.Drawing.Font("Montserrat Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlterarEmail.LinkColor = System.Drawing.Color.White;
            this.lblAlterarEmail.Location = new System.Drawing.Point(91, 121);
            this.lblAlterarEmail.Name = "lblAlterarEmail";
            this.lblAlterarEmail.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblAlterarEmail.Size = new System.Drawing.Size(107, 21);
            this.lblAlterarEmail.TabIndex = 31;
            this.lblAlterarEmail.TabStop = true;
            this.lblAlterarEmail.Text = "Alterar Email";
            this.lblAlterarEmail.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblAlterarEmail_LinkClicked);
            // 
            // lblAlterarNome
            // 
            this.lblAlterarNome.AutoSize = true;
            this.lblAlterarNome.Font = new System.Drawing.Font("Montserrat Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlterarNome.LinkColor = System.Drawing.Color.White;
            this.lblAlterarNome.Location = new System.Drawing.Point(91, 62);
            this.lblAlterarNome.Name = "lblAlterarNome";
            this.lblAlterarNome.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblAlterarNome.Size = new System.Drawing.Size(111, 21);
            this.lblAlterarNome.TabIndex = 30;
            this.lblAlterarNome.TabStop = true;
            this.lblAlterarNome.Text = "Alterar Nome";
            this.lblAlterarNome.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblAlterarNome_LinkClicked);
            // 
            // lblAlterarSenha
            // 
            this.lblAlterarSenha.AutoSize = true;
            this.lblAlterarSenha.Font = new System.Drawing.Font("Montserrat Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlterarSenha.LinkColor = System.Drawing.Color.White;
            this.lblAlterarSenha.Location = new System.Drawing.Point(91, 177);
            this.lblAlterarSenha.Name = "lblAlterarSenha";
            this.lblAlterarSenha.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblAlterarSenha.Size = new System.Drawing.Size(111, 21);
            this.lblAlterarSenha.TabIndex = 29;
            this.lblAlterarSenha.TabStop = true;
            this.lblAlterarSenha.Text = "Alterar Senha";
            this.lblAlterarSenha.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblAlterarSenha_LinkClicked);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.White;
            this.lblEmail.Location = new System.Drawing.Point(6, 91);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(74, 26);
            this.lblEmail.TabIndex = 28;
            this.lblEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtEmail.Location = new System.Drawing.Point(91, 89);
            this.txtEmail.MaxLength = 35;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(404, 31);
            this.txtEmail.TabIndex = 23;
            this.txtEmail.Text = "Usado para redefinir a senha";
            this.txtEmail.Enter += new System.EventHandler(this.txtEmail_Enter);
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
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
            this.btnVerSenha.Location = new System.Drawing.Point(302, 147);
            this.btnVerSenha.Name = "btnVerSenha";
            this.btnVerSenha.Size = new System.Drawing.Size(30, 31);
            this.btnVerSenha.TabIndex = 27;
            this.btnVerSenha.TabStop = false;
            this.btnVerSenha.UseVisualStyleBackColor = false;
            this.btnVerSenha.Click += new System.EventHandler(this.btnVerSenha_Click);
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.ForeColor = System.Drawing.Color.White;
            this.lblSenha.Location = new System.Drawing.Point(6, 149);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(79, 26);
            this.lblSenha.TabIndex = 26;
            this.lblSenha.Text = "Senha:";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Montserrat SemiBold", 8.999999F, System.Drawing.FontStyle.Bold);
            this.btnSalvar.ForeColor = System.Drawing.Color.Black;
            this.btnSalvar.Location = new System.Drawing.Point(206, 262);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 28;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Font = new System.Drawing.Font("Montserrat SemiBold", 8.999999F, System.Drawing.FontStyle.Bold);
            this.btnFechar.ForeColor = System.Drawing.Color.Black;
            this.btnFechar.Location = new System.Drawing.Point(302, 262);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(75, 23);
            this.btnFechar.TabIndex = 27;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // frmCadFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(589, 319);
            this.ControlBox = false;
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmCadFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cadastrar Funcionário";
            this.Load += new System.EventHandler(this.frmCadFuncionario_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label nomeLabel1;
        private System.Windows.Forms.Button btnVerSenha;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.LinkLabel lblAlterarSenha;
        private System.Windows.Forms.LinkLabel lblAlterarEmail;
        private System.Windows.Forms.LinkLabel lblAlterarNome;
        private System.Windows.Forms.LinkLabel lblDesativarCadastro;
    }
}