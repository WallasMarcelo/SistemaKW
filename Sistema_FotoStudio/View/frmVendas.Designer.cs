namespace Sistema_FotoStudio.View
{
    partial class frmVendas
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
            this.bpbDadosClienteFunc = new System.Windows.Forms.GroupBox();
            this.txtCodigoFuncionario = new System.Windows.Forms.TextBox();
            this.lblNomeFuncionario = new System.Windows.Forms.Label();
            this.lblCodigoFuncionario = new System.Windows.Forms.Label();
            this.txtNomeFuncionario = new System.Windows.Forms.TextBox();
            this.mskCPF = new System.Windows.Forms.MaskedTextBox();
            this.lblNomeCliente = new System.Windows.Forms.Label();
            this.lblCPF = new System.Windows.Forms.Label();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.lblDataVenda = new System.Windows.Forms.Label();
            this.mskDataVenda = new System.Windows.Forms.MaskedTextBox();
            this.txtCodigoVenda = new System.Windows.Forms.TextBox();
            this.lblCodigoVenda = new System.Windows.Forms.Label();
            this.bpbDadoProdutoServico = new System.Windows.Forms.GroupBox();
            this.gpbTipo = new System.Windows.Forms.GroupBox();
            this.rbServico = new System.Windows.Forms.RadioButton();
            this.rbProduto = new System.Windows.Forms.RadioButton();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.lblValorunitario = new System.Windows.Forms.Label();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.lblNomeProduto = new System.Windows.Forms.Label();
            this.txtNomeProduto = new System.Windows.Forms.TextBox();
            this.mskValorunitario = new System.Windows.Forms.MaskedTextBox();
            this.txtCodigoProduto = new System.Windows.Forms.TextBox();
            this.lblCodigoProduto = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTotalInvisivel = new System.Windows.Forms.Label();
            this.dgvItensVenda = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.bpbDadosClienteFunc.SuspendLayout();
            this.bpbDadoProdutoServico.SuspendLayout();
            this.gpbTipo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItensVenda)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAlterar
            // 
            this.btnAlterar.FlatAppearance.BorderSize = 0;
            // 
            // btnNovo
            // 
            this.btnNovo.FlatAppearance.BorderSize = 0;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.FlatAppearance.BorderSize = 0;
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            // 
            // btnSalvar
            // 
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            // 
            // btnDelete
            // 
            this.btnDelete.FlatAppearance.BorderSize = 0;
            // 
            // bpbDadosClienteFunc
            // 
            this.bpbDadosClienteFunc.Controls.Add(this.txtCodigoFuncionario);
            this.bpbDadosClienteFunc.Controls.Add(this.lblNomeFuncionario);
            this.bpbDadosClienteFunc.Controls.Add(this.lblCodigoFuncionario);
            this.bpbDadosClienteFunc.Controls.Add(this.txtNomeFuncionario);
            this.bpbDadosClienteFunc.Controls.Add(this.mskCPF);
            this.bpbDadosClienteFunc.Controls.Add(this.lblNomeCliente);
            this.bpbDadosClienteFunc.Controls.Add(this.lblCPF);
            this.bpbDadosClienteFunc.Controls.Add(this.txtNomeCliente);
            this.bpbDadosClienteFunc.Controls.Add(this.lblDataVenda);
            this.bpbDadosClienteFunc.Controls.Add(this.mskDataVenda);
            this.bpbDadosClienteFunc.Controls.Add(this.txtCodigoVenda);
            this.bpbDadosClienteFunc.Controls.Add(this.lblCodigoVenda);
            this.bpbDadosClienteFunc.Location = new System.Drawing.Point(3, 79);
            this.bpbDadosClienteFunc.Name = "bpbDadosClienteFunc";
            this.bpbDadosClienteFunc.Size = new System.Drawing.Size(584, 127);
            this.bpbDadosClienteFunc.TabIndex = 1;
            this.bpbDadosClienteFunc.TabStop = false;
            this.bpbDadosClienteFunc.Text = "Dados";
            // 
            // txtCodigoFuncionario
            // 
            this.txtCodigoFuncionario.Location = new System.Drawing.Point(11, 86);
            this.txtCodigoFuncionario.Name = "txtCodigoFuncionario";
            this.txtCodigoFuncionario.Size = new System.Drawing.Size(91, 20);
            this.txtCodigoFuncionario.TabIndex = 13;
            // 
            // lblNomeFuncionario
            // 
            this.lblNomeFuncionario.AutoSize = true;
            this.lblNomeFuncionario.Location = new System.Drawing.Point(115, 70);
            this.lblNomeFuncionario.Name = "lblNomeFuncionario";
            this.lblNomeFuncionario.Size = new System.Drawing.Size(93, 13);
            this.lblNomeFuncionario.TabIndex = 11;
            this.lblNomeFuncionario.Text = "Nome Funcionário";
            // 
            // lblCodigoFuncionario
            // 
            this.lblCodigoFuncionario.AutoSize = true;
            this.lblCodigoFuncionario.Location = new System.Drawing.Point(8, 70);
            this.lblCodigoFuncionario.Name = "lblCodigoFuncionario";
            this.lblCodigoFuncionario.Size = new System.Drawing.Size(101, 13);
            this.lblCodigoFuncionario.TabIndex = 10;
            this.lblCodigoFuncionario.Text = "Codigo Funcionário:";
            this.lblCodigoFuncionario.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtNomeFuncionario
            // 
            this.txtNomeFuncionario.Location = new System.Drawing.Point(115, 86);
            this.txtNomeFuncionario.Name = "txtNomeFuncionario";
            this.txtNomeFuncionario.Size = new System.Drawing.Size(323, 20);
            this.txtNomeFuncionario.TabIndex = 9;
            // 
            // mskCPF
            // 
            this.mskCPF.Location = new System.Drawing.Point(61, 38);
            this.mskCPF.Mask = "###.###.###-##";
            this.mskCPF.Name = "mskCPF";
            this.mskCPF.Size = new System.Drawing.Size(174, 20);
            this.mskCPF.TabIndex = 8;
            this.mskCPF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mskCPF_KeyPress);
            // 
            // lblNomeCliente
            // 
            this.lblNomeCliente.AutoSize = true;
            this.lblNomeCliente.Location = new System.Drawing.Point(241, 22);
            this.lblNomeCliente.Name = "lblNomeCliente";
            this.lblNomeCliente.Size = new System.Drawing.Size(70, 13);
            this.lblNomeCliente.TabIndex = 7;
            this.lblNomeCliente.Text = "Nome Cliente";
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(58, 22);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(30, 13);
            this.lblCPF.TabIndex = 6;
            this.lblCPF.Text = "CPF:";
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.Location = new System.Drawing.Point(244, 38);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.Size = new System.Drawing.Size(322, 20);
            this.txtNomeCliente.TabIndex = 5;
            // 
            // lblDataVenda
            // 
            this.lblDataVenda.AutoSize = true;
            this.lblDataVenda.Location = new System.Drawing.Point(454, 70);
            this.lblDataVenda.Name = "lblDataVenda";
            this.lblDataVenda.Size = new System.Drawing.Size(67, 13);
            this.lblDataVenda.TabIndex = 3;
            this.lblDataVenda.Text = "Data Venda:";
            this.lblDataVenda.Click += new System.EventHandler(this.label2_Click);
            // 
            // mskDataVenda
            // 
            this.mskDataVenda.Location = new System.Drawing.Point(457, 86);
            this.mskDataVenda.Mask = "00/00/0000";
            this.mskDataVenda.Name = "mskDataVenda";
            this.mskDataVenda.Size = new System.Drawing.Size(118, 20);
            this.mskDataVenda.TabIndex = 2;
            this.mskDataVenda.ValidatingType = typeof(System.DateTime);
            // 
            // txtCodigoVenda
            // 
            this.txtCodigoVenda.Location = new System.Drawing.Point(10, 38);
            this.txtCodigoVenda.Name = "txtCodigoVenda";
            this.txtCodigoVenda.Size = new System.Drawing.Size(42, 20);
            this.txtCodigoVenda.TabIndex = 1;
            // 
            // lblCodigoVenda
            // 
            this.lblCodigoVenda.AutoSize = true;
            this.lblCodigoVenda.Location = new System.Drawing.Point(9, 21);
            this.lblCodigoVenda.Name = "lblCodigoVenda";
            this.lblCodigoVenda.Size = new System.Drawing.Size(43, 13);
            this.lblCodigoVenda.TabIndex = 0;
            this.lblCodigoVenda.Text = "Código:";
            // 
            // bpbDadoProdutoServico
            // 
            this.bpbDadoProdutoServico.Controls.Add(this.gpbTipo);
            this.bpbDadoProdutoServico.Controls.Add(this.txtQuantidade);
            this.bpbDadoProdutoServico.Controls.Add(this.lblValorunitario);
            this.bpbDadoProdutoServico.Controls.Add(this.lblQuantidade);
            this.bpbDadoProdutoServico.Controls.Add(this.lblNomeProduto);
            this.bpbDadoProdutoServico.Controls.Add(this.txtNomeProduto);
            this.bpbDadoProdutoServico.Controls.Add(this.mskValorunitario);
            this.bpbDadoProdutoServico.Controls.Add(this.txtCodigoProduto);
            this.bpbDadoProdutoServico.Controls.Add(this.lblCodigoProduto);
            this.bpbDadoProdutoServico.Location = new System.Drawing.Point(3, 212);
            this.bpbDadoProdutoServico.Name = "bpbDadoProdutoServico";
            this.bpbDadoProdutoServico.Size = new System.Drawing.Size(584, 133);
            this.bpbDadoProdutoServico.TabIndex = 14;
            this.bpbDadoProdutoServico.TabStop = false;
            this.bpbDadoProdutoServico.Text = "Dados Produto";
            // 
            // gpbTipo
            // 
            this.gpbTipo.Controls.Add(this.rbServico);
            this.gpbTipo.Controls.Add(this.rbProduto);
            this.gpbTipo.Location = new System.Drawing.Point(491, 64);
            this.gpbTipo.Name = "gpbTipo";
            this.gpbTipo.Size = new System.Drawing.Size(82, 59);
            this.gpbTipo.TabIndex = 13;
            this.gpbTipo.TabStop = false;
            this.gpbTipo.Text = "Tipo";
            // 
            // rbServico
            // 
            this.rbServico.AutoSize = true;
            this.rbServico.Location = new System.Drawing.Point(10, 36);
            this.rbServico.Name = "rbServico";
            this.rbServico.Size = new System.Drawing.Size(61, 17);
            this.rbServico.TabIndex = 9;
            this.rbServico.TabStop = true;
            this.rbServico.Text = "Serviço";
            this.rbServico.UseVisualStyleBackColor = true;
            // 
            // rbProduto
            // 
            this.rbProduto.AutoSize = true;
            this.rbProduto.Location = new System.Drawing.Point(10, 16);
            this.rbProduto.Name = "rbProduto";
            this.rbProduto.Size = new System.Drawing.Size(62, 17);
            this.rbProduto.TabIndex = 8;
            this.rbProduto.TabStop = true;
            this.rbProduto.Text = "Produto";
            this.rbProduto.UseVisualStyleBackColor = true;
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(10, 86);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(123, 20);
            this.txtQuantidade.TabIndex = 12;
            // 
            // lblValorunitario
            // 
            this.lblValorunitario.AutoSize = true;
            this.lblValorunitario.Location = new System.Drawing.Point(143, 70);
            this.lblValorunitario.Name = "lblValorunitario";
            this.lblValorunitario.Size = new System.Drawing.Size(73, 13);
            this.lblValorunitario.TabIndex = 11;
            this.lblValorunitario.Text = "Valor Unitário:";
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Location = new System.Drawing.Point(8, 70);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(65, 13);
            this.lblQuantidade.TabIndex = 10;
            this.lblQuantidade.Text = "Quantidade ";
            // 
            // lblNomeProduto
            // 
            this.lblNomeProduto.AutoSize = true;
            this.lblNomeProduto.Location = new System.Drawing.Point(143, 21);
            this.lblNomeProduto.Name = "lblNomeProduto";
            this.lblNomeProduto.Size = new System.Drawing.Size(116, 13);
            this.lblNomeProduto.TabIndex = 7;
            this.lblNomeProduto.Text = "Nome Produto/Serviço";
            // 
            // txtNomeProduto
            // 
            this.txtNomeProduto.Location = new System.Drawing.Point(146, 38);
            this.txtNomeProduto.Name = "txtNomeProduto";
            this.txtNomeProduto.Size = new System.Drawing.Size(427, 20);
            this.txtNomeProduto.TabIndex = 5;
            // 
            // mskValorunitario
            // 
            this.mskValorunitario.Location = new System.Drawing.Point(146, 86);
            this.mskValorunitario.Mask = "#.##";
            this.mskValorunitario.Name = "mskValorunitario";
            this.mskValorunitario.Size = new System.Drawing.Size(118, 20);
            this.mskValorunitario.TabIndex = 2;
            // 
            // txtCodigoProduto
            // 
            this.txtCodigoProduto.Location = new System.Drawing.Point(10, 38);
            this.txtCodigoProduto.Name = "txtCodigoProduto";
            this.txtCodigoProduto.Size = new System.Drawing.Size(123, 20);
            this.txtCodigoProduto.TabIndex = 1;
            // 
            // lblCodigoProduto
            // 
            this.lblCodigoProduto.AutoSize = true;
            this.lblCodigoProduto.Location = new System.Drawing.Point(9, 21);
            this.lblCodigoProduto.Name = "lblCodigoProduto";
            this.lblCodigoProduto.Size = new System.Drawing.Size(124, 13);
            this.lblCodigoProduto.TabIndex = 0;
            this.lblCodigoProduto.Text = "Código Produto/Serviço:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(468, 508);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(66, 25);
            this.lblTotal.TabIndex = 15;
            this.lblTotal.Text = "Total:";
            // 
            // lblTotalInvisivel
            // 
            this.lblTotalInvisivel.AutoSize = true;
            this.lblTotalInvisivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalInvisivel.Location = new System.Drawing.Point(512, 358);
            this.lblTotalInvisivel.Name = "lblTotalInvisivel";
            this.lblTotalInvisivel.Size = new System.Drawing.Size(0, 25);
            this.lblTotalInvisivel.TabIndex = 16;
            // 
            // dgvItensVenda
            // 
            this.dgvItensVenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItensVenda.Location = new System.Drawing.Point(3, 352);
            this.dgvItensVenda.Name = "dgvItensVenda";
            this.dgvItensVenda.Size = new System.Drawing.Size(584, 150);
            this.dgvItensVenda.TabIndex = 17;
            // 
            // frmVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 536);
            this.Controls.Add(this.dgvItensVenda);
            this.Controls.Add(this.lblTotalInvisivel);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.bpbDadoProdutoServico);
            this.Controls.Add(this.bpbDadosClienteFunc);
            this.Name = "frmVendas";
            this.Text = "Vendas";
            this.Load += new System.EventHandler(this.frmVendas_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.bpbDadosClienteFunc, 0);
            this.Controls.SetChildIndex(this.bpbDadoProdutoServico, 0);
            this.Controls.SetChildIndex(this.lblTotal, 0);
            this.Controls.SetChildIndex(this.lblTotalInvisivel, 0);
            this.Controls.SetChildIndex(this.dgvItensVenda, 0);
            this.panel1.ResumeLayout(false);
            this.bpbDadosClienteFunc.ResumeLayout(false);
            this.bpbDadosClienteFunc.PerformLayout();
            this.bpbDadoProdutoServico.ResumeLayout(false);
            this.bpbDadoProdutoServico.PerformLayout();
            this.gpbTipo.ResumeLayout(false);
            this.gpbTipo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItensVenda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox bpbDadosClienteFunc;
        private System.Windows.Forms.Label lblCodigoVenda;
        private System.Windows.Forms.Label lblNomeFuncionario;
        private System.Windows.Forms.Label lblCodigoFuncionario;
        private System.Windows.Forms.TextBox txtNomeFuncionario;
        private System.Windows.Forms.MaskedTextBox mskCPF;
        private System.Windows.Forms.Label lblNomeCliente;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.TextBox txtNomeCliente;
        private System.Windows.Forms.Label lblDataVenda;
        private System.Windows.Forms.MaskedTextBox mskDataVenda;
        private System.Windows.Forms.TextBox txtCodigoVenda;
        private System.Windows.Forms.TextBox txtCodigoFuncionario;
        private System.Windows.Forms.GroupBox bpbDadoProdutoServico;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.Label lblValorunitario;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.Label lblNomeProduto;
        private System.Windows.Forms.TextBox txtNomeProduto;
        private System.Windows.Forms.MaskedTextBox mskValorunitario;
        private System.Windows.Forms.TextBox txtCodigoProduto;
        private System.Windows.Forms.Label lblCodigoProduto;
        private System.Windows.Forms.GroupBox gpbTipo;
        private System.Windows.Forms.RadioButton rbServico;
        private System.Windows.Forms.RadioButton rbProduto;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTotalInvisivel;
        private System.Windows.Forms.DataGridView dgvItensVenda;
    }
}