namespace Ponto
{
    partial class frmRelatorioPonto
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
            this.btnFechar = new System.Windows.Forms.Button();
            this.dtDataInicial = new System.Windows.Forms.DateTimePicker();
            this.dtDataFinal = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cbFuncionario = new System.Windows.Forms.ComboBox();
            this.dgvConsultaPonto = new System.Windows.Forms.DataGridView();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnGrafico = new System.Windows.Forms.Button();
            this.cbAtivo = new System.Windows.Forms.CheckBox();
            this.btnConfiguracoes = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaPonto)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFechar
            // 
            this.btnFechar.Font = new System.Drawing.Font("Montserrat SemiBold", 8.999999F, System.Drawing.FontStyle.Bold);
            this.btnFechar.ForeColor = System.Drawing.Color.Black;
            this.btnFechar.Location = new System.Drawing.Point(695, 529);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(75, 23);
            this.btnFechar.TabIndex = 28;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // dtDataInicial
            // 
            this.dtDataInicial.Checked = false;
            this.dtDataInicial.CustomFormat = "";
            this.dtDataInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtDataInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDataInicial.Location = new System.Drawing.Point(358, 10);
            this.dtDataInicial.Name = "dtDataInicial";
            this.dtDataInicial.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtDataInicial.Size = new System.Drawing.Size(118, 24);
            this.dtDataInicial.TabIndex = 29;
            // 
            // dtDataFinal
            // 
            this.dtDataFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.dtDataFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDataFinal.Location = new System.Drawing.Point(570, 10);
            this.dtDataFinal.Name = "dtDataFinal";
            this.dtDataFinal.Size = new System.Drawing.Size(118, 24);
            this.dtDataFinal.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat SemiBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(264, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 18);
            this.label1.TabIndex = 31;
            this.label1.Text = "Data Inicial";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat SemiBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(484, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 18);
            this.label2.TabIndex = 32;
            this.label2.Text = "Data Final";
            // 
            // btnConsultar
            // 
            this.btnConsultar.Font = new System.Drawing.Font("Montserrat SemiBold", 8.999999F, System.Drawing.FontStyle.Bold);
            this.btnConsultar.ForeColor = System.Drawing.Color.Black;
            this.btnConsultar.Location = new System.Drawing.Point(696, 9);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 26);
            this.btnConsultar.TabIndex = 33;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat SemiBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(10, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 18);
            this.label3.TabIndex = 34;
            this.label3.Text = "Funcionário";
            // 
            // cbFuncionario
            // 
            this.cbFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.cbFuncionario.FormattingEnabled = true;
            this.cbFuncionario.Location = new System.Drawing.Point(108, 10);
            this.cbFuncionario.Name = "cbFuncionario";
            this.cbFuncionario.Size = new System.Drawing.Size(148, 25);
            this.cbFuncionario.TabIndex = 35;
            this.cbFuncionario.Text = "Todos";
            // 
            // dgvConsultaPonto
            // 
            this.dgvConsultaPonto.AllowUserToAddRows = false;
            this.dgvConsultaPonto.AllowUserToDeleteRows = false;
            this.dgvConsultaPonto.BackgroundColor = System.Drawing.Color.White;
            this.dgvConsultaPonto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultaPonto.Location = new System.Drawing.Point(12, 44);
            this.dgvConsultaPonto.Name = "dgvConsultaPonto";
            this.dgvConsultaPonto.ReadOnly = true;
            this.dgvConsultaPonto.RowHeadersWidth = 51;
            this.dgvConsultaPonto.Size = new System.Drawing.Size(760, 476);
            this.dgvConsultaPonto.TabIndex = 36;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Font = new System.Drawing.Font("Montserrat SemiBold", 8.999999F, System.Drawing.FontStyle.Bold);
            this.btnImprimir.ForeColor = System.Drawing.Color.Black;
            this.btnImprimir.Location = new System.Drawing.Point(597, 529);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(75, 23);
            this.btnImprimir.TabIndex = 37;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnGrafico
            // 
            this.btnGrafico.Font = new System.Drawing.Font("Montserrat SemiBold", 8.999999F, System.Drawing.FontStyle.Bold);
            this.btnGrafico.ForeColor = System.Drawing.Color.Black;
            this.btnGrafico.Location = new System.Drawing.Point(499, 529);
            this.btnGrafico.Name = "btnGrafico";
            this.btnGrafico.Size = new System.Drawing.Size(75, 23);
            this.btnGrafico.TabIndex = 38;
            this.btnGrafico.Text = "Gráfico";
            this.btnGrafico.UseVisualStyleBackColor = true;
            this.btnGrafico.Click += new System.EventHandler(this.btnGrafico_Click);
            // 
            // cbAtivo
            // 
            this.cbAtivo.AccessibleDescription = "";
            this.cbAtivo.AutoSize = true;
            this.cbAtivo.BackColor = System.Drawing.SystemColors.HotTrack;
            this.cbAtivo.Checked = true;
            this.cbAtivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbAtivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbAtivo.Font = new System.Drawing.Font("Montserrat SemiBold", 9.749999F, System.Drawing.FontStyle.Bold);
            this.cbAtivo.ForeColor = System.Drawing.Color.White;
            this.cbAtivo.Location = new System.Drawing.Point(13, 530);
            this.cbAtivo.Name = "cbAtivo";
            this.cbAtivo.Size = new System.Drawing.Size(158, 22);
            this.cbAtivo.TabIndex = 39;
            this.cbAtivo.Tag = "";
            this.cbAtivo.Text = "Funcionários Ativos";
            this.cbAtivo.UseVisualStyleBackColor = false;
            this.cbAtivo.CheckedChanged += new System.EventHandler(this.cbAtivo_CheckedChanged);
            // 
            // btnConfiguracoes
            // 
            this.btnConfiguracoes.Font = new System.Drawing.Font("Montserrat SemiBold", 8.999999F, System.Drawing.FontStyle.Bold);
            this.btnConfiguracoes.ForeColor = System.Drawing.Color.Black;
            this.btnConfiguracoes.Location = new System.Drawing.Point(372, 529);
            this.btnConfiguracoes.Name = "btnConfiguracoes";
            this.btnConfiguracoes.Size = new System.Drawing.Size(104, 23);
            this.btnConfiguracoes.TabIndex = 40;
            this.btnConfiguracoes.Text = "Configurações";
            this.btnConfiguracoes.UseVisualStyleBackColor = true;
            this.btnConfiguracoes.Click += new System.EventHandler(this.btnConfiguracoes_Click);
            // 
            // frmRelatorioPonto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.ControlBox = false;
            this.Controls.Add(this.btnConfiguracoes);
            this.Controls.Add(this.cbAtivo);
            this.Controls.Add(this.btnGrafico);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.cbFuncionario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtDataFinal);
            this.Controls.Add(this.dtDataInicial);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.dgvConsultaPonto);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "frmRelatorioPonto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório de Ponto";
            this.Load += new System.EventHandler(this.frmRelatorioPonto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaPonto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.DateTimePicker dtDataInicial;
        private System.Windows.Forms.DateTimePicker dtDataFinal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvConsultaPonto;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnGrafico;
        private System.Windows.Forms.ComboBox cbFuncionario;
        private System.Windows.Forms.CheckBox cbAtivo;
        private System.Windows.Forms.Button btnConfiguracoes;
    }
}