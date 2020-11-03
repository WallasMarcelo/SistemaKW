namespace Sistema_FotoStudio.View
{
    partial class frmPesquisaFuncionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPesquisaFuncionario));
            this.gbConjuntoCampos = new System.Windows.Forms.GroupBox();
            this.gbPesquisarPor = new System.Windows.Forms.GroupBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.mskCPF = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.DataGridFuncionario = new System.Windows.Forms.DataGridView();
            this.gbConjuntoCampos.SuspendLayout();
            this.gbPesquisarPor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridFuncionario)).BeginInit();
            this.SuspendLayout();
            // 
            // gbConjuntoCampos
            // 
            this.gbConjuntoCampos.Controls.Add(this.gbPesquisarPor);
            this.gbConjuntoCampos.Controls.Add(this.btnPesquisar);
            this.gbConjuntoCampos.Location = new System.Drawing.Point(6, 2);
            this.gbConjuntoCampos.Name = "gbConjuntoCampos";
            this.gbConjuntoCampos.Size = new System.Drawing.Size(594, 143);
            this.gbConjuntoCampos.TabIndex = 2;
            this.gbConjuntoCampos.TabStop = false;
            // 
            // gbPesquisarPor
            // 
            this.gbPesquisarPor.Controls.Add(this.txtNome);
            this.gbPesquisarPor.Controls.Add(this.label3);
            this.gbPesquisarPor.Controls.Add(this.mskCPF);
            this.gbPesquisarPor.Controls.Add(this.label1);
            this.gbPesquisarPor.Location = new System.Drawing.Point(9, 14);
            this.gbPesquisarPor.Name = "gbPesquisarPor";
            this.gbPesquisarPor.Size = new System.Drawing.Size(462, 118);
            this.gbPesquisarPor.TabIndex = 10;
            this.gbPesquisarPor.TabStop = false;
            this.gbPesquisarPor.Text = "Pesquisar por:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(223, 39);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(233, 20);
            this.txtNome.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(220, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nome:";
            // 
            // mskCPF
            // 
            this.mskCPF.Location = new System.Drawing.Point(6, 39);
            this.mskCPF.Mask = "999.999.999-99";
            this.mskCPF.Name = "mskCPF";
            this.mskCPF.Size = new System.Drawing.Size(197, 20);
            this.mskCPF.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CPF:";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.Color.Transparent;
            this.btnPesquisar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPesquisar.BackgroundImage")));
            this.btnPesquisar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPesquisar.FlatAppearance.BorderSize = 0;
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisar.Location = new System.Drawing.Point(488, 37);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(61, 47);
            this.btnPesquisar.TabIndex = 8;
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.Transparent;
            this.btnLimpar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLimpar.BackgroundImage")));
            this.btnLimpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLimpar.FlatAppearance.BorderSize = 0;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Location = new System.Drawing.Point(575, 39);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(61, 47);
            this.btnLimpar.TabIndex = 11;
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // DataGridFuncionario
            // 
            this.DataGridFuncionario.AllowUserToAddRows = false;
            this.DataGridFuncionario.AllowUserToDeleteRows = false;
            this.DataGridFuncionario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridFuncionario.Location = new System.Drawing.Point(6, 111);
            this.DataGridFuncionario.Name = "DataGridFuncionario";
            this.DataGridFuncionario.ReadOnly = true;
            this.DataGridFuncionario.Size = new System.Drawing.Size(650, 316);
            this.DataGridFuncionario.TabIndex = 3;
            // 
            // frmPesquisaFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 433);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.DataGridFuncionario);
            this.Controls.Add(this.gbConjuntoCampos);
            this.Name = "frmPesquisaFuncionario";
            this.Text = "Pesquisa de Funcionário";
            this.gbConjuntoCampos.ResumeLayout(false);
            this.gbPesquisarPor.ResumeLayout(false);
            this.gbPesquisarPor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridFuncionario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbConjuntoCampos;
        private System.Windows.Forms.GroupBox gbPesquisarPor;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mskCPF;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.DataGridView DataGridFuncionario;
        private System.Windows.Forms.Button btnLimpar;
    }
}