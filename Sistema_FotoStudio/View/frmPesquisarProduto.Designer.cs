namespace Sistema_FotoStudio.View
{
    partial class frmPesquisarProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPesquisarProduto));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvPesquisaproduto = new System.Windows.Forms.DataGridView();
            this.dtCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtFornecedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtMarca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtQuantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtLote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesquisaproduto)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLimpar);
            this.groupBox1.Controls.Add(this.btnPesquisar);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtDescricao);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtCodigo);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(640, 100);
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
            this.btnLimpar.Location = new System.Drawing.Point(510, 32);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(72, 36);
            this.btnLimpar.TabIndex = 3;
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPesquisar.BackgroundImage")));
            this.btnPesquisar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPesquisar.FlatAppearance.BorderSize = 0;
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisar.Location = new System.Drawing.Point(394, 32);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(72, 36);
            this.btnPesquisar.TabIndex = 2;
            this.btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(129, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Descrição";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(129, 41);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(239, 20);
            this.txtDescricao.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Código Produto";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(21, 41);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(77, 20);
            this.txtCodigo.TabIndex = 0;
            this.txtCodigo.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvPesquisaproduto);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(640, 255);
            this.panel1.TabIndex = 1;
            // 
            // dgvPesquisaproduto
            // 
            this.dgvPesquisaproduto.AllowUserToAddRows = false;
            this.dgvPesquisaproduto.AllowUserToDeleteRows = false;
            this.dgvPesquisaproduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPesquisaproduto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dtCodigo,
            this.dtDescricao,
            this.dtFornecedor,
            this.dtMarca,
            this.dtQuantidade,
            this.dtLote});
            this.dgvPesquisaproduto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPesquisaproduto.Location = new System.Drawing.Point(0, 0);
            this.dgvPesquisaproduto.Name = "dgvPesquisaproduto";
            this.dgvPesquisaproduto.ReadOnly = true;
            this.dgvPesquisaproduto.Size = new System.Drawing.Size(640, 255);
            this.dgvPesquisaproduto.TabIndex = 0;
            // 
            // dtCodigo
            // 
            this.dtCodigo.HeaderText = "Codigo";
            this.dtCodigo.Name = "dtCodigo";
            this.dtCodigo.ReadOnly = true;
            // 
            // dtDescricao
            // 
            this.dtDescricao.HeaderText = "Descrição";
            this.dtDescricao.Name = "dtDescricao";
            this.dtDescricao.ReadOnly = true;
            // 
            // dtFornecedor
            // 
            this.dtFornecedor.HeaderText = "Fornecedor";
            this.dtFornecedor.Name = "dtFornecedor";
            this.dtFornecedor.ReadOnly = true;
            // 
            // dtMarca
            // 
            this.dtMarca.HeaderText = "Marca";
            this.dtMarca.Name = "dtMarca";
            this.dtMarca.ReadOnly = true;
            // 
            // dtQuantidade
            // 
            this.dtQuantidade.HeaderText = "Quantidade";
            this.dtQuantidade.Name = "dtQuantidade";
            this.dtQuantidade.ReadOnly = true;
            // 
            // dtLote
            // 
            this.dtLote.HeaderText = "Lote";
            this.dtLote.Name = "dtLote";
            this.dtLote.ReadOnly = true;
            // 
            // frmPesquisarProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 355);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmPesquisarProduto";
            this.Text = "Pesquisar Produto";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesquisaproduto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvPesquisaproduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtFornecedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtMarca;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtQuantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtLote;
    }
}