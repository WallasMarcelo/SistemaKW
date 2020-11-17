﻿namespace Sistema_FotoStudio.View
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serviçosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.fornecedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pesquisaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pesquisaClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pesquisaProdutosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pesquisaServiçosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pesquisaFuncionarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pesquisaFornecedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pesquisaUsuáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pesquisaVendasToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.movimentaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.contratosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.relatóriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.servçosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAniversario = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarToolStripMenuItem,
            this.pesquisaToolStripMenuItem,
            this.movimentaçãoToolStripMenuItem,
            this.contratosToolStripMenuItem,
            this.relatóriosToolStripMenuItem,
            this.sobreToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastrarToolStripMenuItem
            // 
            this.cadastrarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteToolStripMenuItem,
            this.produtoToolStripMenuItem,
            this.serviçosToolStripMenuItem1,
            this.fornecedorToolStripMenuItem,
            this.funcionárioToolStripMenuItem,
            this.usuárioToolStripMenuItem});
            this.cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            this.cadastrarToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.cadastrarToolStripMenuItem.Text = "Cadastro";
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("clienteToolStripMenuItem.BackgroundImage")));
            this.clienteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("clienteToolStripMenuItem.Image")));
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.clienteToolStripMenuItem.Text = "Clientes";
            this.clienteToolStripMenuItem.Click += new System.EventHandler(this.clienteToolStripMenuItem_Click);
            // 
            // produtoToolStripMenuItem
            // 
            this.produtoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("produtoToolStripMenuItem.Image")));
            this.produtoToolStripMenuItem.Name = "produtoToolStripMenuItem";
            this.produtoToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.produtoToolStripMenuItem.Text = "Produtos";
            this.produtoToolStripMenuItem.Click += new System.EventHandler(this.produtoToolStripMenuItem_Click);
            // 
            // serviçosToolStripMenuItem1
            // 
            this.serviçosToolStripMenuItem1.Name = "serviçosToolStripMenuItem1";
            this.serviçosToolStripMenuItem1.Size = new System.Drawing.Size(145, 22);
            this.serviçosToolStripMenuItem1.Text = "Serviços";
            // 
            // fornecedorToolStripMenuItem
            // 
            this.fornecedorToolStripMenuItem.Name = "fornecedorToolStripMenuItem";
            this.fornecedorToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.fornecedorToolStripMenuItem.Text = "Fornecedores";
            this.fornecedorToolStripMenuItem.Click += new System.EventHandler(this.fornecedorToolStripMenuItem_Click);
            // 
            // funcionárioToolStripMenuItem
            // 
            this.funcionárioToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("funcionárioToolStripMenuItem.Image")));
            this.funcionárioToolStripMenuItem.Name = "funcionárioToolStripMenuItem";
            this.funcionárioToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.funcionárioToolStripMenuItem.Text = "Funcionário";
            this.funcionárioToolStripMenuItem.Click += new System.EventHandler(this.funcionárioToolStripMenuItem_Click);
            // 
            // usuárioToolStripMenuItem
            // 
            this.usuárioToolStripMenuItem.Name = "usuárioToolStripMenuItem";
            this.usuárioToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.usuárioToolStripMenuItem.Text = "Usuário";
            this.usuárioToolStripMenuItem.Click += new System.EventHandler(this.usuárioToolStripMenuItem_Click);
            // 
            // pesquisaToolStripMenuItem
            // 
            this.pesquisaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pesquisaClientesToolStripMenuItem,
            this.pesquisaProdutosToolStripMenuItem,
            this.pesquisaServiçosToolStripMenuItem,
            this.pesquisaFuncionarioToolStripMenuItem,
            this.pesquisaFornecedoresToolStripMenuItem,
            this.pesquisaUsuáriosToolStripMenuItem,
            this.pesquisaVendasToolStripMenuItem2});
            this.pesquisaToolStripMenuItem.Name = "pesquisaToolStripMenuItem";
            this.pesquisaToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.pesquisaToolStripMenuItem.Text = "Pesquisa";
            // 
            // pesquisaClientesToolStripMenuItem
            // 
            this.pesquisaClientesToolStripMenuItem.Name = "pesquisaClientesToolStripMenuItem";
            this.pesquisaClientesToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.pesquisaClientesToolStripMenuItem.Text = "Clientes";
            this.pesquisaClientesToolStripMenuItem.Click += new System.EventHandler(this.pesquisaClientesToolStripMenuItem_Click);
            // 
            // pesquisaProdutosToolStripMenuItem
            // 
            this.pesquisaProdutosToolStripMenuItem.Name = "pesquisaProdutosToolStripMenuItem";
            this.pesquisaProdutosToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.pesquisaProdutosToolStripMenuItem.Text = "Produtos";
            this.pesquisaProdutosToolStripMenuItem.Click += new System.EventHandler(this.pesquisaProdutosToolStripMenuItem_Click);
            // 
            // pesquisaServiçosToolStripMenuItem
            // 
            this.pesquisaServiçosToolStripMenuItem.Name = "pesquisaServiçosToolStripMenuItem";
            this.pesquisaServiçosToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.pesquisaServiçosToolStripMenuItem.Text = "Serviços";
            this.pesquisaServiçosToolStripMenuItem.Click += new System.EventHandler(this.pesquisaServiçosToolStripMenuItem_Click);
            // 
            // pesquisaFuncionarioToolStripMenuItem
            // 
            this.pesquisaFuncionarioToolStripMenuItem.Name = "pesquisaFuncionarioToolStripMenuItem";
            this.pesquisaFuncionarioToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.pesquisaFuncionarioToolStripMenuItem.Text = "Funcionario";
            this.pesquisaFuncionarioToolStripMenuItem.Click += new System.EventHandler(this.pesquisaFuncionarioToolStripMenuItem_Click);
            // 
            // pesquisaFornecedoresToolStripMenuItem
            // 
            this.pesquisaFornecedoresToolStripMenuItem.Name = "pesquisaFornecedoresToolStripMenuItem";
            this.pesquisaFornecedoresToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.pesquisaFornecedoresToolStripMenuItem.Text = "Fornecedores";
            this.pesquisaFornecedoresToolStripMenuItem.Click += new System.EventHandler(this.pesquisaFornecedoresToolStripMenuItem_Click);
            // 
            // pesquisaUsuáriosToolStripMenuItem
            // 
            this.pesquisaUsuáriosToolStripMenuItem.Name = "pesquisaUsuáriosToolStripMenuItem";
            this.pesquisaUsuáriosToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.pesquisaUsuáriosToolStripMenuItem.Text = "Usuários";
            this.pesquisaUsuáriosToolStripMenuItem.Click += new System.EventHandler(this.pesquisaUsuáriosToolStripMenuItem_Click);
            // 
            // pesquisaVendasToolStripMenuItem2
            // 
            this.pesquisaVendasToolStripMenuItem2.Name = "pesquisaVendasToolStripMenuItem2";
            this.pesquisaVendasToolStripMenuItem2.Size = new System.Drawing.Size(145, 22);
            this.pesquisaVendasToolStripMenuItem2.Text = "Vendas";
            this.pesquisaVendasToolStripMenuItem2.Click += new System.EventHandler(this.pesquisaVendasToolStripMenuItem2_Click);
            // 
            // movimentaçãoToolStripMenuItem
            // 
            this.movimentaçãoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vendasToolStripMenuItem1});
            this.movimentaçãoToolStripMenuItem.Name = "movimentaçãoToolStripMenuItem";
            this.movimentaçãoToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.movimentaçãoToolStripMenuItem.Text = "Movimentação";
            // 
            // vendasToolStripMenuItem1
            // 
            this.vendasToolStripMenuItem1.Name = "vendasToolStripMenuItem1";
            this.vendasToolStripMenuItem1.Size = new System.Drawing.Size(111, 22);
            this.vendasToolStripMenuItem1.Text = "Vendas";
            this.vendasToolStripMenuItem1.Click += new System.EventHandler(this.vendasToolStripMenuItem1_Click);
            // 
            // contratosToolStripMenuItem
            // 
            this.contratosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteToolStripMenuItem1});
            this.contratosToolStripMenuItem.Name = "contratosToolStripMenuItem";
            this.contratosToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.contratosToolStripMenuItem.Text = "Contrato";
            // 
            // clienteToolStripMenuItem1
            // 
            this.clienteToolStripMenuItem1.Name = "clienteToolStripMenuItem1";
            this.clienteToolStripMenuItem1.Size = new System.Drawing.Size(116, 22);
            this.clienteToolStripMenuItem1.Text = "Clientes";
            // 
            // relatóriosToolStripMenuItem
            // 
            this.relatóriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vendasToolStripMenuItem,
            this.clienteToolStripMenuItem2,
            this.servçosToolStripMenuItem});
            this.relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            this.relatóriosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.relatóriosToolStripMenuItem.Text = "Relatórios";
            // 
            // vendasToolStripMenuItem
            // 
            this.vendasToolStripMenuItem.Name = "vendasToolStripMenuItem";
            this.vendasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.vendasToolStripMenuItem.Text = "Vendas";
            this.vendasToolStripMenuItem.Click += new System.EventHandler(this.vendasToolStripMenuItem_Click);
            // 
            // clienteToolStripMenuItem2
            // 
            this.clienteToolStripMenuItem2.Name = "clienteToolStripMenuItem2";
            this.clienteToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.clienteToolStripMenuItem2.Text = "Clientes";
            this.clienteToolStripMenuItem2.Click += new System.EventHandler(this.clienteToolStripMenuItem2_Click);
            // 
            // servçosToolStripMenuItem
            // 
            this.servçosToolStripMenuItem.Name = "servçosToolStripMenuItem";
            this.servçosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.servçosToolStripMenuItem.Text = "Serviços +";
            this.servçosToolStripMenuItem.Click += new System.EventHandler(this.servçosToolStripMenuItem_Click);
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.sobreToolStripMenuItem.Text = "Sobre";
            // 
            // btnAniversario
            // 
            this.btnAniversario.Location = new System.Drawing.Point(690, 57);
            this.btnAniversario.Name = "btnAniversario";
            this.btnAniversario.Size = new System.Drawing.Size(75, 23);
            this.btnAniversario.TabIndex = 5;
            this.btnAniversario.Text = "button1";
            this.btnAniversario.UseVisualStyleBackColor = true;
            this.btnAniversario.Click += new System.EventHandler(this.btnAniversario_Click_1);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAniversario);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.Text = "FotoStudio";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem movimentaçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem contratosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem relatóriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem fornecedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem funcionárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem servçosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pesquisaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pesquisaClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pesquisaProdutosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pesquisaServiçosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pesquisaFuncionarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serviçosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pesquisaFornecedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pesquisaUsuáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pesquisaVendasToolStripMenuItem2;
        private System.Windows.Forms.Button btnAniversario;
    }
}