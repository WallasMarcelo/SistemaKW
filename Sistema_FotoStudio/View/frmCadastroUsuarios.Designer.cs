namespace Sistema_FotoStudio.View
{
    partial class frmCadastroUsuarios
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
            this.lblCod_Funcionario = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.txtCod_Funcionario = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.rbSim = new System.Windows.Forms.RadioButton();
            this.rbNao = new System.Windows.Forms.RadioButton();
            this.gpbAtivo = new System.Windows.Forms.GroupBox();
            this.cmbTipoUsuario = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.gpbAtivo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAlterar
            // 
            this.btnAlterar.FlatAppearance.BorderSize = 0;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.FlatAppearance.BorderSize = 0;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.FlatAppearance.BorderSize = 0;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.FlatAppearance.BorderSize = 0;
            // 
            // lblCod_Funcionario
            // 
            this.lblCod_Funcionario.AutoSize = true;
            this.lblCod_Funcionario.Location = new System.Drawing.Point(12, 90);
            this.lblCod_Funcionario.Name = "lblCod_Funcionario";
            this.lblCod_Funcionario.Size = new System.Drawing.Size(101, 13);
            this.lblCod_Funcionario.TabIndex = 1;
            this.lblCod_Funcionario.Text = "Codigo Funcionário:";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(131, 90);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(36, 13);
            this.lblLogin.TabIndex = 2;
            this.lblLogin.Text = "Login:";
            this.lblLogin.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtCod_Funcionario
            // 
            this.txtCod_Funcionario.Location = new System.Drawing.Point(12, 106);
            this.txtCod_Funcionario.Name = "txtCod_Funcionario";
            this.txtCod_Funcionario.Size = new System.Drawing.Size(101, 20);
            this.txtCod_Funcionario.TabIndex = 3;
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(306, 106);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(162, 20);
            this.txtSenha.TabIndex = 6;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(307, 90);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(41, 13);
            this.lblSenha.TabIndex = 5;
            this.lblSenha.Text = "Senha:";
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(128, 106);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(162, 20);
            this.txtLogin.TabIndex = 7;
            // 
            // rbSim
            // 
            this.rbSim.AutoSize = true;
            this.rbSim.Location = new System.Drawing.Point(19, 16);
            this.rbSim.Name = "rbSim";
            this.rbSim.Size = new System.Drawing.Size(42, 17);
            this.rbSim.TabIndex = 8;
            this.rbSim.TabStop = true;
            this.rbSim.Text = "Sim";
            this.rbSim.UseVisualStyleBackColor = true;
            // 
            // rbNao
            // 
            this.rbNao.AutoSize = true;
            this.rbNao.Location = new System.Drawing.Point(20, 40);
            this.rbNao.Name = "rbNao";
            this.rbNao.Size = new System.Drawing.Size(45, 17);
            this.rbNao.TabIndex = 9;
            this.rbNao.TabStop = true;
            this.rbNao.Text = "Não";
            this.rbNao.UseVisualStyleBackColor = true;
            // 
            // gpbAtivo
            // 
            this.gpbAtivo.Controls.Add(this.rbNao);
            this.gpbAtivo.Controls.Add(this.rbSim);
            this.gpbAtivo.Location = new System.Drawing.Point(486, 80);
            this.gpbAtivo.Name = "gpbAtivo";
            this.gpbAtivo.Size = new System.Drawing.Size(82, 65);
            this.gpbAtivo.TabIndex = 10;
            this.gpbAtivo.TabStop = false;
            this.gpbAtivo.Text = "Ativo";
            this.gpbAtivo.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cmbTipoUsuario
            // 
            this.cmbTipoUsuario.FormattingEnabled = true;
            this.cmbTipoUsuario.Items.AddRange(new object[] {
            "Usuário",
            "Administração"});
            this.cmbTipoUsuario.Location = new System.Drawing.Point(12, 151);
            this.cmbTipoUsuario.Name = "cmbTipoUsuario";
            this.cmbTipoUsuario.Size = new System.Drawing.Size(121, 21);
            this.cmbTipoUsuario.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Tipo Usuario:";
            // 
            // frmCadastroUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 203);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbTipoUsuario);
            this.Controls.Add(this.gpbAtivo);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.txtCod_Funcionario);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.lblCod_Funcionario);
            this.Name = "frmCadastroUsuarios";
            this.Text = "Cadastro Usuários";
            this.Load += new System.EventHandler(this.frmCadastroUsuarios_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.lblCod_Funcionario, 0);
            this.Controls.SetChildIndex(this.lblLogin, 0);
            this.Controls.SetChildIndex(this.txtCod_Funcionario, 0);
            this.Controls.SetChildIndex(this.lblSenha, 0);
            this.Controls.SetChildIndex(this.txtSenha, 0);
            this.Controls.SetChildIndex(this.txtLogin, 0);
            this.Controls.SetChildIndex(this.gpbAtivo, 0);
            this.Controls.SetChildIndex(this.cmbTipoUsuario, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.panel1.ResumeLayout(false);
            this.gpbAtivo.ResumeLayout(false);
            this.gpbAtivo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCod_Funcionario;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.TextBox txtCod_Funcionario;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.RadioButton rbSim;
        private System.Windows.Forms.RadioButton rbNao;
        private System.Windows.Forms.GroupBox gpbAtivo;
        private System.Windows.Forms.ComboBox cmbTipoUsuario;
        private System.Windows.Forms.Label label1;
    }
}