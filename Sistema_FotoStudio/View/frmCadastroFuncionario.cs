using Sistema_FotoStudio.Controller;
using Sistema_FotoStudio.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_FotoStudio.View
{
    public partial class frmCadastroFuncionario : frmBase
    {
        bool alterar = false;
        frmPrincipal principal = null;

        public frmCadastroFuncionario(frmPrincipal principal)
        {
            InitializeComponent();
            Inativar();
            this.principal = principal;

            mskCPF.Enabled = true;
            txtNome.Enabled = true;
            txtCodigo.Enabled = true;
            btnCancelar.Enabled = true;
        }

        public string codigo { get => txtCodigo.Text; set => txtCodigo.Text = value; }
        public string cpf
        {
            get
            {
                mskCPF.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                string texto = mskCPF.Text;
                mskCPF.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
                return texto;
            }

            set
            {
                mskCPF.Text = value;
            }
        }
        public string rg
        {
            get
            {
                mskRG.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                string texto = mskRG.Text;
                mskRG.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
                return texto;
            }

            set
            {
                mskRG.Text = value;
            }
        }
        public string sexo
        {
            get
            {
                return cmbSexo.Text;
            }

            set
            {
                if (value == "M")
                {
                    cmbSexo.SelectedIndex = cmbSexo.FindString("Masculino");
                }
                else
                {

                    cmbSexo.SelectedIndex = cmbSexo.FindString("Feminino");
                }
            }
        }
        public string nome { get => txtNome.Text; set => txtNome.Text = value; }
        public string sobrenome { get => txtSobrenome.Text; set => txtSobrenome.Text = value; }
        public DateTime dataNasc { get => dtpDataNasc.Value; set => dtpDataNasc.Value = value; }
        public string logradouro { get => txtLogradouro.Text; set => txtLogradouro.Text = value; }
        public int numero
        {

            get
            {
                int.TryParse(txtNumero.Text, out int n);
                return n;
            }

            set
            {
                txtNumero.Text = value.ToString();
            }

        }
        public string cidade { get => txtBairro.Text; set => txtBairro.Text = value; }
        public string uf
        {
            get
            {
                return cmbUF.Text;
            }

            set
            {
                cmbUF.SelectedIndex = cmbUF.FindString(value);
            }
        }
        public string bairro { get => txtCidade.Text; set => txtCidade.Text = value; }
        public string cep
        {
            get
            {
                mskCEP.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                string texto = mskCEP.Text;
                mskCEP.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
                return texto;
            }

            set
            {
                mskCEP.Text = value;
            }
        }
        public string email { get => txtEmail.Text; set => txtEmail.Text = value; }
        public string telefone
        {
            get
            {
                mskTelefone.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                string texto = mskTelefone.Text;
                mskTelefone.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
                return texto;
            }

            set
            {
                mskTelefone.Text = value;
            }
        }
        public string celular
        {
            get
            {
                mskCelular.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                string texto = mskCelular.Text;
                mskCelular.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
                return texto;
            }

            set
            {
                mskCelular.Text = value;
            }
        }


        private void mskCEP_Leave(object sender, EventArgs e)
        {
            if (this.cep.Length < 8 || this.cep.Length > 9)
            {
                MessageBox.Show("Informe um CEP válido!");
            }
            else
            {
                BuscaCEPController controller = new BuscaCEPController();
                CEP retCEP = controller.solicitarCEP(this.cep);

                txtLogradouro.Text = retCEP.logradouro;
                txtBairro.Text = retCEP.bairro;
                txtCidade.Text = retCEP.cidade;
                cmbUF.SelectedItem = retCEP.uf;


            }
        }

        public void PassarValores(Funcionario funcionario)
        {
            nome = funcionario.Nome;
            sobrenome = funcionario.Sobrenome;
            cep = funcionario.CEP;
            logradouro = funcionario.Logradouro;
            numero = funcionario.Numero;
            bairro = funcionario.Bairro;
            cidade = funcionario.Cidade;
            email = funcionario.email;
            cpf = funcionario.CPF;
            cep = funcionario.CEP;
            rg = funcionario.RG;
            telefone = funcionario.telefone;
            celular = funcionario.celular;
            sexo = funcionario.Sexo;
            uf = funcionario.UF;
            dataNasc = funcionario.Data_Nasc;
            email = funcionario.email;

            Inativar();
            btnAlterar.Enabled = true;
            btnCancelar.Enabled = true;
            btnDelete.Enabled = true;
        }


        protected void Inativar()
        {
            txtCodigo.Enabled = false;
            txtNome.Enabled = false;
            txtSobrenome.Enabled = false;
            txtLogradouro.Enabled = false;
            txtBairro.Enabled = false;
            txtNumero.Enabled = false;
            txtCidade.Enabled = false;
            txtEmail.Enabled = false;
            txtCodigo.Enabled = false;
            mskCPF.Enabled = false;
            mskRG.Enabled = false;
            mskCEP.Enabled = false;
            mskTelefone.Enabled = false;
            mskCelular.Enabled = false;
            cmbSexo.Enabled = false;
            cmbUF.Enabled = false;
            dtpDataNasc.Enabled = false;

            btnAlterar.Enabled = false;
            btnCancelar.Enabled = false;
            btnDelete.Enabled = false;
            btnSalvar.Enabled = false;


        }

        protected void Ativar()
        {
            txtNome.Enabled = true;
            txtSobrenome.Enabled = true;
            txtLogradouro.Enabled = true;
            txtBairro.Enabled = true;
            txtNumero.Enabled = true;
            txtCidade.Enabled = true;
            txtEmail.Enabled = true;
            mskCPF.Enabled = true;
            mskRG.Enabled = true;
            mskCEP.Enabled = true;
            mskTelefone.Enabled = true;
            mskCelular.Enabled = true;
            cmbSexo.Enabled = true;
            cmbUF.Enabled = true;
            dtpDataNasc.Enabled = true;

            btnAlterar.Enabled = true;
            btnCancelar.Enabled = true;
            btnDelete.Enabled = true;
            btnSalvar.Enabled = true;

        }

        protected void Limpar()
        {
            txtCodigo.Text = "";
            txtNome.Text = "";
            txtSobrenome.Text = "";
            txtLogradouro.Text = "";
            txtBairro.Text = "";
            txtNumero.Text = "";
            txtCidade.Text = "";
            txtEmail.Text = "";
            txtCodigo.Text = "";
            mskCPF.Text = "";
            mskRG.Text = "";
            mskCEP.Text = "";
            mskTelefone.Text = "";
            mskCelular.Text = "";
            cmbSexo.SelectedIndex = -1;
            cmbUF.SelectedIndex = -1;
            alterar = false;

        }

        private void btnSalvar_Click_1(object sender, EventArgs e)
        {
            if (nome == "" || sobrenome == "" || cpf == "" || cidade == "")
            {
                MessageBox.Show("Preencha os campos obrigatórios");
            }
            else
            {
                FuncionarioController controller = new FuncionarioController();

                if (controller.cadastrar(cpf, rg, sexo, nome, sobrenome, dataNasc, logradouro, numero, bairro, uf,
                cidade, cep, email, telefone, celular, alterar) == 0)
                {
                    MessageBox.Show("Funcionário cadastrado com sucesso!");
                    Inativar();
                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar o funcionário");
                }
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            Ativar();
            txtCodigo.Enabled = false;
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Ativar();
            alterar = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpar();
            Inativar();

            mskCPF.Enabled = true;
            txtNome.Enabled = true;
            txtCodigo.Enabled = true;
        }

        private void btnPesquisar_Click_1(object sender, EventArgs e)
        {
            FuncionarioController funcionarioController = new FuncionarioController();

            if (!codigo.Equals(""))
            {
                Funcionario funcionario = funcionarioController.PesquisarPorCodigo(codigo);

                PassarValores(funcionario);
                return;

            }

            if (!cpf.Equals(""))
            {
                Funcionario funcionario = funcionarioController.PesquisarPorCPF(cpf);

                PassarValores(funcionario);
                return;

            }

            funcionarioController.PesquisarPorNome(nome, this, this.principal);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Deseja realmente inativar esse cadastro?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (confirm.ToString().ToUpper() == "YES")
            {
                FuncionarioController funcionarioController = new FuncionarioController();
                int reultado = funcionarioController.Inativar(cpf);

                if (reultado == 0)
                    MessageBox.Show("Inativado com sucesso!");


            }
        }
    }
}
