namespace Sistema_FotoStudio.View
{
    partial class frmPesquisaFornecedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPesquisaFornecedor));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.gbPFisica = new System.Windows.Forms.GroupBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.mskCPF = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbPFJuridica = new System.Windows.Forms.GroupBox();
            this.txtrazaoSocial = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.mskCNPJ = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.dataGridFornecedor = new System.Windows.Forms.DataGridView();
            this.groupBox2.SuspendLayout();
            this.gbPFisica.SuspendLayout();
            this.gbPFJuridica.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFornecedor)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnLimpar);
            this.groupBox2.Controls.Add(this.gbPFisica);
            this.groupBox2.Controls.Add(this.gbPFJuridica);
            this.groupBox2.Controls.Add(this.btnPesquisar);
            this.groupBox2.Location = new System.Drawing.Point(6, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(594, 171);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.Transparent;
            this.btnLimpar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLimpar.BackgroundImage")));
            this.btnLimpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLimpar.FlatAppearance.BorderSize = 0;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Location = new System.Drawing.Point(529, 101);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(61, 47);
            this.btnLimpar.TabIndex = 12;
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // gbPFisica
            // 
            this.gbPFisica.Controls.Add(this.txtNome);
            this.gbPFisica.Controls.Add(this.mskCPF);
            this.gbPFisica.Controls.Add(this.label4);
            this.gbPFisica.Controls.Add(this.label2);
            this.gbPFisica.Location = new System.Drawing.Point(7, 89);
            this.gbPFisica.Name = "gbPFisica";
            this.gbPFisica.Size = new System.Drawing.Size(464, 70);
            this.gbPFisica.TabIndex = 11;
            this.gbPFisica.TabStop = false;
            this.gbPFisica.Text = "Pessoa Física:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(225, 39);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(233, 20);
            this.txtNome.TabIndex = 7;
            // 
            // mskCPF
            // 
            this.mskCPF.Location = new System.Drawing.Point(8, 39);
            this.mskCPF.Mask = "999.999.999-99";
            this.mskCPF.Name = "mskCPF";
            this.mskCPF.Size = new System.Drawing.Size(197, 20);
            this.mskCPF.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(222, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "CPF:";
            // 
            // gbPFJuridica
            // 
            this.gbPFJuridica.Controls.Add(this.txtrazaoSocial);
            this.gbPFJuridica.Controls.Add(this.label3);
            this.gbPFJuridica.Controls.Add(this.mskCNPJ);
            this.gbPFJuridica.Controls.Add(this.label1);
            this.gbPFJuridica.Location = new System.Drawing.Point(9, 14);
            this.gbPFJuridica.Name = "gbPFJuridica";
            this.gbPFJuridica.Size = new System.Drawing.Size(462, 68);
            this.gbPFJuridica.TabIndex = 10;
            this.gbPFJuridica.TabStop = false;
            this.gbPFJuridica.Text = "Pessoa Jurídica:";
            // 
            // txtrazaoSocial
            // 
            this.txtrazaoSocial.Location = new System.Drawing.Point(223, 39);
            this.txtrazaoSocial.Name = "txtrazaoSocial";
            this.txtrazaoSocial.Size = new System.Drawing.Size(233, 20);
            this.txtrazaoSocial.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(220, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Razão Social:";
            // 
            // mskCNPJ
            // 
            this.mskCNPJ.Location = new System.Drawing.Point(6, 39);
            this.mskCNPJ.Mask = "99.999.9999/9999-99";
            this.mskCNPJ.Name = "mskCNPJ";
            this.mskCNPJ.Size = new System.Drawing.Size(197, 20);
            this.mskCNPJ.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CNPJ:";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.Color.Transparent;
            this.btnPesquisar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPesquisar.BackgroundImage")));
            this.btnPesquisar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPesquisar.FlatAppearance.BorderSize = 0;
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisar.Location = new System.Drawing.Point(527, 35);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(61, 47);
            this.btnPesquisar.TabIndex = 8;
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // dataGridFornecedor
            // 
            this.dataGridFornecedor.AllowUserToAddRows = false;
            this.dataGridFornecedor.AllowUserToDeleteRows = false;
            this.dataGridFornecedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridFornecedor.Location = new System.Drawing.Point(6, 182);
            this.dataGridFornecedor.Name = "dataGridFornecedor";
            this.dataGridFornecedor.ReadOnly = true;
            this.dataGridFornecedor.Size = new System.Drawing.Size(585, 222);
            this.dataGridFornecedor.TabIndex = 2;
            // 
            // frmPesquisaFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 412);
            this.Controls.Add(this.dataGridFornecedor);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmPesquisaFornecedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisa de Fornecedor";
            this.groupBox2.ResumeLayout(false);
            this.gbPFisica.ResumeLayout(false);
            this.gbPFisica.PerformLayout();
            this.gbPFJuridica.ResumeLayout(false);
            this.gbPFJuridica.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFornecedor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MaskedTextBox mskCPF;
        private System.Windows.Forms.MaskedTextBox mskCNPJ;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtrazaoSocial;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.GroupBox gbPFisica;
        private System.Windows.Forms.GroupBox gbPFJuridica;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.DataGridView dataGridFornecedor;
    }
}