namespace Sistema_FotoStudio.View
{
    partial class frmPesquisaServico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPesquisaServico));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTipoServico = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvPesquisaServico = new System.Windows.Forms.DataGridView();
            this.dtCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtServico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesquisaServico)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLimpar);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtTipoServico);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtCodigo);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(647, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados";
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLimpar.BackgroundImage")));
            this.btnLimpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLimpar.FlatAppearance.BorderSize = 0;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Location = new System.Drawing.Point(517, 36);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(72, 36);
            this.btnLimpar.TabIndex = 4;
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(400, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 36);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(170, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tipo Servico";
            // 
            // txtTipoServico
            // 
            this.txtTipoServico.Location = new System.Drawing.Point(173, 45);
            this.txtTipoServico.Name = "txtTipoServico";
            this.txtTipoServico.Size = new System.Drawing.Size(198, 20);
            this.txtTipoServico.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Código Seviço";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(25, 45);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 0;
            this.txtCodigo.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvPesquisaServico);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(647, 239);
            this.panel1.TabIndex = 1;
            // 
            // dgvPesquisaServico
            // 
            this.dgvPesquisaServico.AllowUserToAddRows = false;
            this.dgvPesquisaServico.AllowUserToDeleteRows = false;
            this.dgvPesquisaServico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPesquisaServico.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dtCodigo,
            this.dtServico,
            this.dtDescricao,
            this.dtValor});
            this.dgvPesquisaServico.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPesquisaServico.Location = new System.Drawing.Point(0, 0);
            this.dgvPesquisaServico.Name = "dgvPesquisaServico";
            this.dgvPesquisaServico.ReadOnly = true;
            this.dgvPesquisaServico.Size = new System.Drawing.Size(647, 239);
            this.dgvPesquisaServico.TabIndex = 5;
            // 
            // dtCodigo
            // 
            this.dtCodigo.HeaderText = "código";
            this.dtCodigo.Name = "dtCodigo";
            this.dtCodigo.ReadOnly = true;
            // 
            // dtServico
            // 
            this.dtServico.HeaderText = "Tipo de serviço";
            this.dtServico.Name = "dtServico";
            this.dtServico.ReadOnly = true;
            // 
            // dtDescricao
            // 
            this.dtDescricao.HeaderText = "Descrição";
            this.dtDescricao.Name = "dtDescricao";
            this.dtDescricao.ReadOnly = true;
            // 
            // dtValor
            // 
            this.dtValor.HeaderText = "Valor";
            this.dtValor.Name = "dtValor";
            this.dtValor.ReadOnly = true;
            // 
            // frmPesquisaServico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 339);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmPesquisaServico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisa Serviço";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesquisaServico)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTipoServico;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvPesquisaServico;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtServico;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtValor;
    }
}