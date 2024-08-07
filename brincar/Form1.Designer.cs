namespace Ponto
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblNomeFuncionario = new System.Windows.Forms.Label();
            this.btnLupa = new System.Windows.Forms.Button();
            this.btnVerSenha = new System.Windows.Forms.Button();
            this.lblHora1 = new System.Windows.Forms.Label();
            this.lblHora2 = new System.Windows.Forms.Label();
            this.lblHora3 = new System.Windows.Forms.Label();
            this.lblHora4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tecladoNumerico = new System.Windows.Forms.Panel();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnApagar = new System.Windows.Forms.Button();
            this.num0 = new System.Windows.Forms.Button();
            this.num3 = new System.Windows.Forms.Button();
            this.num2 = new System.Windows.Forms.Button();
            this.num1 = new System.Windows.Forms.Button();
            this.num6 = new System.Windows.Forms.Button();
            this.num5 = new System.Windows.Forms.Button();
            this.num4 = new System.Windows.Forms.Button();
            this.num9 = new System.Windows.Forms.Button();
            this.num8 = new System.Windows.Forms.Button();
            this.num7 = new System.Windows.Forms.Button();
            this.btnRelatorios = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.lblDataAtual = new System.Windows.Forms.Label();
            this.lblHoraAtual = new System.Windows.Forms.Label();
            this.pnHoras = new System.Windows.Forms.Panel();
            this.txtId = new System.Windows.Forms.MaskedTextBox();
            this.txtSenha = new System.Windows.Forms.MaskedTextBox();
            this.txtNomeEmpresa = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.tecladoNumerico.SuspendLayout();
            this.pnHoras.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.BackColor = System.Drawing.Color.Transparent;
            this.lblCodigo.Font = new System.Drawing.Font("Montserrat", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.ForeColor = System.Drawing.Color.White;
            this.lblCodigo.Location = new System.Drawing.Point(58, 67);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(43, 37);
            this.lblCodigo.TabIndex = 6;
            this.lblCodigo.Text = "Id";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.BackColor = System.Drawing.Color.Transparent;
            this.lblSenha.Font = new System.Drawing.Font("Montserrat", 20.25F);
            this.lblSenha.ForeColor = System.Drawing.Color.White;
            this.lblSenha.Location = new System.Drawing.Point(58, 162);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(102, 37);
            this.lblSenha.TabIndex = 7;
            this.lblSenha.Text = "Senha";
            // 
            // lblNomeFuncionario
            // 
            this.lblNomeFuncionario.AutoSize = true;
            this.lblNomeFuncionario.BackColor = System.Drawing.Color.Transparent;
            this.lblNomeFuncionario.Font = new System.Drawing.Font("Montserrat", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeFuncionario.ForeColor = System.Drawing.Color.White;
            this.lblNomeFuncionario.Location = new System.Drawing.Point(59, 287);
            this.lblNomeFuncionario.MaximumSize = new System.Drawing.Size(260, 37);
            this.lblNomeFuncionario.Name = "lblNomeFuncionario";
            this.lblNomeFuncionario.Size = new System.Drawing.Size(248, 37);
            this.lblNomeFuncionario.TabIndex = 14;
            this.lblNomeFuncionario.Text = "Nome Completo";
            // 
            // btnLupa
            // 
            this.btnLupa.BackColor = System.Drawing.Color.Transparent;
            this.btnLupa.BackgroundImage = global::Ponto.Properties.Resources.lupa;
            this.btnLupa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLupa.FlatAppearance.BorderSize = 0;
            this.btnLupa.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.btnLupa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnLupa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLupa.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLupa.ForeColor = System.Drawing.Color.White;
            this.btnLupa.Location = new System.Drawing.Point(211, 112);
            this.btnLupa.Name = "btnLupa";
            this.btnLupa.Size = new System.Drawing.Size(30, 31);
            this.btnLupa.TabIndex = 9;
            this.btnLupa.TabStop = false;
            this.btnLupa.UseVisualStyleBackColor = false;
            this.btnLupa.Click += new System.EventHandler(this.btnLupa_Click);
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
            this.btnVerSenha.Location = new System.Drawing.Point(211, 207);
            this.btnVerSenha.Name = "btnVerSenha";
            this.btnVerSenha.Size = new System.Drawing.Size(30, 31);
            this.btnVerSenha.TabIndex = 4;
            this.btnVerSenha.TabStop = false;
            this.btnVerSenha.UseVisualStyleBackColor = false;
            this.btnVerSenha.Click += new System.EventHandler(this.btnVerSenha_Click);
            // 
            // lblHora1
            // 
            this.lblHora1.AutoSize = true;
            this.lblHora1.BackColor = System.Drawing.Color.Transparent;
            this.lblHora1.Font = new System.Drawing.Font("Montserrat", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora1.ForeColor = System.Drawing.Color.Black;
            this.lblHora1.Location = new System.Drawing.Point(11, 0);
            this.lblHora1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHora1.Name = "lblHora1";
            this.lblHora1.Size = new System.Drawing.Size(94, 37);
            this.lblHora1.TabIndex = 15;
            this.lblHora1.Text = "Vazio";
            // 
            // lblHora2
            // 
            this.lblHora2.AutoSize = true;
            this.lblHora2.BackColor = System.Drawing.Color.Transparent;
            this.lblHora2.Font = new System.Drawing.Font("Montserrat", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora2.ForeColor = System.Drawing.Color.Black;
            this.lblHora2.Location = new System.Drawing.Point(11, 48);
            this.lblHora2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHora2.Name = "lblHora2";
            this.lblHora2.Size = new System.Drawing.Size(94, 37);
            this.lblHora2.TabIndex = 16;
            this.lblHora2.Text = "Vazio";
            // 
            // lblHora3
            // 
            this.lblHora3.AutoSize = true;
            this.lblHora3.BackColor = System.Drawing.Color.Transparent;
            this.lblHora3.Font = new System.Drawing.Font("Montserrat", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora3.ForeColor = System.Drawing.Color.Black;
            this.lblHora3.Location = new System.Drawing.Point(11, 96);
            this.lblHora3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHora3.Name = "lblHora3";
            this.lblHora3.Size = new System.Drawing.Size(94, 37);
            this.lblHora3.TabIndex = 17;
            this.lblHora3.Text = "Vazio";
            // 
            // lblHora4
            // 
            this.lblHora4.AutoSize = true;
            this.lblHora4.BackColor = System.Drawing.Color.Transparent;
            this.lblHora4.Font = new System.Drawing.Font("Montserrat", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora4.ForeColor = System.Drawing.Color.Black;
            this.lblHora4.Location = new System.Drawing.Point(11, 144);
            this.lblHora4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHora4.Name = "lblHora4";
            this.lblHora4.Size = new System.Drawing.Size(94, 37);
            this.lblHora4.TabIndex = 18;
            this.lblHora4.Text = "Vazio";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.tecladoNumerico);
            this.panel1.Controls.Add(this.btnRelatorios);
            this.panel1.Controls.Add(this.btnFechar);
            this.panel1.Controls.Add(this.lblDataAtual);
            this.panel1.Controls.Add(this.lblHoraAtual);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(263, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(537, 600);
            this.panel1.TabIndex = 20;
            // 
            // tecladoNumerico
            // 
            this.tecladoNumerico.BackColor = System.Drawing.Color.Transparent;
            this.tecladoNumerico.BackgroundImage = global::Ponto.Properties.Resources.fundo_teclado;
            this.tecladoNumerico.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tecladoNumerico.Controls.Add(this.btnConfirmar);
            this.tecladoNumerico.Controls.Add(this.btnApagar);
            this.tecladoNumerico.Controls.Add(this.num0);
            this.tecladoNumerico.Controls.Add(this.num3);
            this.tecladoNumerico.Controls.Add(this.num2);
            this.tecladoNumerico.Controls.Add(this.num1);
            this.tecladoNumerico.Controls.Add(this.num6);
            this.tecladoNumerico.Controls.Add(this.num5);
            this.tecladoNumerico.Controls.Add(this.num4);
            this.tecladoNumerico.Controls.Add(this.num9);
            this.tecladoNumerico.Controls.Add(this.num8);
            this.tecladoNumerico.Controls.Add(this.num7);
            this.tecladoNumerico.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tecladoNumerico.Location = new System.Drawing.Point(57, 186);
            this.tecladoNumerico.Name = "tecladoNumerico";
            this.tecladoNumerico.Size = new System.Drawing.Size(420, 379);
            this.tecladoNumerico.TabIndex = 23;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.FlatAppearance.BorderSize = 0;
            this.btnConfirmar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnConfirmar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnConfirmar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmar.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnConfirmar.Location = new System.Drawing.Point(293, 290);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(111, 68);
            this.btnConfirmar.TabIndex = 11;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // btnApagar
            // 
            this.btnApagar.FlatAppearance.BorderSize = 0;
            this.btnApagar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnApagar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnApagar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnApagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApagar.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApagar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnApagar.Location = new System.Drawing.Point(17, 290);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(111, 68);
            this.btnApagar.TabIndex = 10;
            this.btnApagar.Text = "Apagar";
            this.btnApagar.UseVisualStyleBackColor = true;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // num0
            // 
            this.num0.FlatAppearance.BorderSize = 0;
            this.num0.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.num0.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.num0.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.num0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.num0.Font = new System.Drawing.Font("Montserrat", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num0.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.num0.Location = new System.Drawing.Point(155, 290);
            this.num0.Name = "num0";
            this.num0.Size = new System.Drawing.Size(111, 68);
            this.num0.TabIndex = 9;
            this.num0.Text = "0";
            this.num0.UseVisualStyleBackColor = true;
            this.num0.Click += new System.EventHandler(this.num0_Click);
            // 
            // num3
            // 
            this.num3.FlatAppearance.BorderSize = 0;
            this.num3.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.num3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.num3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.num3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.num3.Font = new System.Drawing.Font("Montserrat", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.num3.Location = new System.Drawing.Point(293, 202);
            this.num3.Name = "num3";
            this.num3.Size = new System.Drawing.Size(111, 68);
            this.num3.TabIndex = 8;
            this.num3.Text = "3";
            this.num3.UseVisualStyleBackColor = true;
            this.num3.Click += new System.EventHandler(this.num3_Click);
            // 
            // num2
            // 
            this.num2.FlatAppearance.BorderSize = 0;
            this.num2.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.num2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.num2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.num2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.num2.Font = new System.Drawing.Font("Montserrat", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.num2.Location = new System.Drawing.Point(155, 202);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(111, 68);
            this.num2.TabIndex = 7;
            this.num2.Text = "2";
            this.num2.UseVisualStyleBackColor = true;
            this.num2.Click += new System.EventHandler(this.num2_Click);
            // 
            // num1
            // 
            this.num1.FlatAppearance.BorderSize = 0;
            this.num1.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.num1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.num1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.num1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.num1.Font = new System.Drawing.Font("Montserrat", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.num1.Location = new System.Drawing.Point(17, 202);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(111, 68);
            this.num1.TabIndex = 6;
            this.num1.Text = "1";
            this.num1.UseVisualStyleBackColor = true;
            this.num1.Click += new System.EventHandler(this.num1_Click);
            // 
            // num6
            // 
            this.num6.FlatAppearance.BorderSize = 0;
            this.num6.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.num6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.num6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.num6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.num6.Font = new System.Drawing.Font("Montserrat", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.num6.Location = new System.Drawing.Point(293, 112);
            this.num6.Name = "num6";
            this.num6.Size = new System.Drawing.Size(111, 68);
            this.num6.TabIndex = 5;
            this.num6.Text = "6";
            this.num6.UseVisualStyleBackColor = true;
            this.num6.Click += new System.EventHandler(this.num6_Click);
            // 
            // num5
            // 
            this.num5.FlatAppearance.BorderSize = 0;
            this.num5.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.num5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.num5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.num5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.num5.Font = new System.Drawing.Font("Montserrat", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.num5.Location = new System.Drawing.Point(155, 112);
            this.num5.Name = "num5";
            this.num5.Size = new System.Drawing.Size(111, 68);
            this.num5.TabIndex = 4;
            this.num5.Text = "5";
            this.num5.UseVisualStyleBackColor = true;
            this.num5.Click += new System.EventHandler(this.num5_Click);
            // 
            // num4
            // 
            this.num4.FlatAppearance.BorderSize = 0;
            this.num4.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.num4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.num4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.num4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.num4.Font = new System.Drawing.Font("Montserrat", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.num4.Location = new System.Drawing.Point(17, 112);
            this.num4.Name = "num4";
            this.num4.Size = new System.Drawing.Size(111, 68);
            this.num4.TabIndex = 3;
            this.num4.Text = "4";
            this.num4.UseVisualStyleBackColor = true;
            this.num4.Click += new System.EventHandler(this.num4_Click);
            // 
            // num9
            // 
            this.num9.FlatAppearance.BorderColor = System.Drawing.Color.IndianRed;
            this.num9.FlatAppearance.BorderSize = 0;
            this.num9.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.num9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.num9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.num9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.num9.Font = new System.Drawing.Font("Montserrat", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.num9.Location = new System.Drawing.Point(293, 22);
            this.num9.Name = "num9";
            this.num9.Size = new System.Drawing.Size(111, 68);
            this.num9.TabIndex = 2;
            this.num9.Text = "9";
            this.num9.UseVisualStyleBackColor = true;
            this.num9.Click += new System.EventHandler(this.num9_Click);
            // 
            // num8
            // 
            this.num8.FlatAppearance.BorderSize = 0;
            this.num8.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.num8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.num8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.num8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.num8.Font = new System.Drawing.Font("Montserrat", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.num8.Location = new System.Drawing.Point(155, 22);
            this.num8.Name = "num8";
            this.num8.Size = new System.Drawing.Size(111, 68);
            this.num8.TabIndex = 1;
            this.num8.Text = "8";
            this.num8.UseVisualStyleBackColor = true;
            this.num8.Click += new System.EventHandler(this.num8_Click);
            // 
            // num7
            // 
            this.num7.BackColor = System.Drawing.Color.Transparent;
            this.num7.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.num7.FlatAppearance.BorderSize = 0;
            this.num7.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.num7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.num7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.num7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.num7.Font = new System.Drawing.Font("Montserrat", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.num7.Location = new System.Drawing.Point(17, 22);
            this.num7.Name = "num7";
            this.num7.Size = new System.Drawing.Size(111, 68);
            this.num7.TabIndex = 0;
            this.num7.Text = "7";
            this.num7.UseVisualStyleBackColor = false;
            this.num7.Click += new System.EventHandler(this.num7_Click);
            // 
            // btnRelatorios
            // 
            this.btnRelatorios.FlatAppearance.BorderSize = 0;
            this.btnRelatorios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnRelatorios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnRelatorios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRelatorios.Font = new System.Drawing.Font("Montserrat SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRelatorios.ForeColor = System.Drawing.Color.White;
            this.btnRelatorios.Location = new System.Drawing.Point(345, 65);
            this.btnRelatorios.Name = "btnRelatorios";
            this.btnRelatorios.Size = new System.Drawing.Size(152, 48);
            this.btnRelatorios.TabIndex = 26;
            this.btnRelatorios.Text = "Relatórios";
            this.btnRelatorios.UseVisualStyleBackColor = true;
            this.btnRelatorios.Click += new System.EventHandler(this.btnRelatorios_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.BackgroundImage = global::Ponto.Properties.Resources.fechar;
            this.btnFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnFechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.ForeColor = System.Drawing.Color.White;
            this.btnFechar.Location = new System.Drawing.Point(499, 3);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(38, 33);
            this.btnFechar.TabIndex = 25;
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // lblDataAtual
            // 
            this.lblDataAtual.AutoSize = true;
            this.lblDataAtual.BackColor = System.Drawing.Color.Transparent;
            this.lblDataAtual.Font = new System.Drawing.Font("Montserrat SemiBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataAtual.ForeColor = System.Drawing.Color.White;
            this.lblDataAtual.Location = new System.Drawing.Point(3, 69);
            this.lblDataAtual.Name = "lblDataAtual";
            this.lblDataAtual.Size = new System.Drawing.Size(177, 37);
            this.lblDataAtual.TabIndex = 21;
            this.lblDataAtual.Text = "00/00/0000";
            // 
            // lblHoraAtual
            // 
            this.lblHoraAtual.AutoSize = true;
            this.lblHoraAtual.BackColor = System.Drawing.Color.Transparent;
            this.lblHoraAtual.Font = new System.Drawing.Font("Montserrat SemiBold", 20.25F, System.Drawing.FontStyle.Bold);
            this.lblHoraAtual.ForeColor = System.Drawing.Color.White;
            this.lblHoraAtual.Location = new System.Drawing.Point(200, 69);
            this.lblHoraAtual.Name = "lblHoraAtual";
            this.lblHoraAtual.Size = new System.Drawing.Size(139, 37);
            this.lblHoraAtual.TabIndex = 22;
            this.lblHoraAtual.Text = "00:00:00";
            // 
            // pnHoras
            // 
            this.pnHoras.BackColor = System.Drawing.Color.Transparent;
            this.pnHoras.BackgroundImage = global::Ponto.Properties.Resources.fundo_horas;
            this.pnHoras.Controls.Add(this.lblHora1);
            this.pnHoras.Controls.Add(this.lblHora4);
            this.pnHoras.Controls.Add(this.lblHora2);
            this.pnHoras.Controls.Add(this.lblHora3);
            this.pnHoras.Location = new System.Drawing.Point(61, 376);
            this.pnHoras.Name = "pnHoras";
            this.pnHoras.Size = new System.Drawing.Size(140, 189);
            this.pnHoras.TabIndex = 21;
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Montserrat", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(65, 107);
            this.txtId.Mask = "00000";
            this.txtId.Name = "txtId";
            this.txtId.PromptChar = ' ';
            this.txtId.Size = new System.Drawing.Size(136, 40);
            this.txtId.TabIndex = 22;
            this.txtId.ValidatingType = typeof(int);
            this.txtId.Click += new System.EventHandler(this.txtId_Click);
            this.txtId.TextChanged += new System.EventHandler(this.txtId_TextChanged);
            this.txtId.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtId_KeyDown);
            this.txtId.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtId_MouseDown);
            this.txtId.MouseMove += new System.Windows.Forms.MouseEventHandler(this.txtId_MouseMove);
            // 
            // txtSenha
            // 
            this.txtSenha.Font = new System.Drawing.Font("Montserrat", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Location = new System.Drawing.Point(65, 202);
            this.txtSenha.Mask = "&&&&&&&&&&";
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PromptChar = ' ';
            this.txtSenha.Size = new System.Drawing.Size(136, 40);
            this.txtSenha.TabIndex = 23;
            this.txtSenha.UseSystemPasswordChar = true;
            this.txtSenha.Click += new System.EventHandler(this.txtSenha_Click);
            this.txtSenha.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSenha_KeyDown);
            this.txtSenha.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtSenha_MouseDown);
            this.txtSenha.MouseMove += new System.Windows.Forms.MouseEventHandler(this.txtSenha_MouseMove);
            // 
            // txtNomeEmpresa
            // 
            this.txtNomeEmpresa.BackColor = System.Drawing.SystemColors.HotTrack;
            this.txtNomeEmpresa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNomeEmpresa.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeEmpresa.ForeColor = System.Drawing.Color.White;
            this.txtNomeEmpresa.Location = new System.Drawing.Point(6, 5);
            this.txtNomeEmpresa.MaxLength = 35;
            this.txtNomeEmpresa.Name = "txtNomeEmpresa";
            this.txtNomeEmpresa.Size = new System.Drawing.Size(245, 24);
            this.txtNomeEmpresa.TabIndex = 24;
            this.txtNomeEmpresa.Text = "Nome da Empresa";
            this.txtNomeEmpresa.Enter += new System.EventHandler(this.txtNomeEmpresa_Enter);
            this.txtNomeEmpresa.Leave += new System.EventHandler(this.txtNomeEmpresa_Leave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(3)))), ((int)(((byte)(172)))));
            this.BackgroundImage = global::Ponto.Properties.Resources.fundo4;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.txtNomeEmpresa);
            this.Controls.Add(this.lblNomeFuncionario);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.pnHoras);
            this.Controls.Add(this.btnLupa);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.btnVerSenha);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ponto";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tecladoNumerico.ResumeLayout(false);
            this.pnHoras.ResumeLayout(false);
            this.pnHoras.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnVerSenha;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Button btnLupa;
        private System.Windows.Forms.Label lblNomeFuncionario;
        private System.Windows.Forms.Label lblHora1;
        private System.Windows.Forms.Label lblHora2;
        private System.Windows.Forms.Label lblHora3;
        private System.Windows.Forms.Label lblHora4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Label lblDataAtual;
        private System.Windows.Forms.Label lblHoraAtual;
        private System.Windows.Forms.Panel tecladoNumerico;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Button num0;
        private System.Windows.Forms.Button num3;
        private System.Windows.Forms.Button num2;
        private System.Windows.Forms.Button num1;
        private System.Windows.Forms.Button num6;
        private System.Windows.Forms.Button num5;
        private System.Windows.Forms.Button num4;
        private System.Windows.Forms.Button num9;
        private System.Windows.Forms.Button num8;
        private System.Windows.Forms.Button num7;
        private System.Windows.Forms.Panel pnHoras;
        private System.Windows.Forms.Button btnRelatorios;
        private System.Windows.Forms.MaskedTextBox txtId;
        private System.Windows.Forms.MaskedTextBox txtSenha;
        private System.Windows.Forms.TextBox txtNomeEmpresa;
    }
}

