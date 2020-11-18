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
    public partial class frmCadastroFornedor : frmBase
    {
        bool alterar = false;
        frmPrincipal principal;
        public frmCadastroFornedor(frmPrincipal principal)
        {
            InitializeComponent();
            Inativar();
            this.principal = principal;

            txtNome.Enabled = true;
            mskCPF.Enabled = true;
            txtCodigo.Enabled = true;
            btnCancelar.Enabled = true;
        }

        public string codigo { get => txtCodigo.Text; set => txtCodigo.Text = value; }
        public string razaoSocial { get => txtRazaoSocial.Text; set => txtRazaoSocial.Text = value; }
        public string NomeFantasia { get => txtNomeFantasia.Text; set => txtNomeFantasia.Text = value; }

        public string cnpj
        {
            get
            {
                mskCNPJ.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                string texto = mskCNPJ.Text;
                mskCNPJ.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
                return texto;
            }

            set
            {
                mskCNPJ.Text = value;
            }
        }
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

        public String tipo_Fornecedor
        {
            get
            {
                if (rdbPFisica.Checked)
                    return "1";

                return "2";
            }

            set
            {
                if (value == "1")
                    rdbPFisica.Checked = true;
                else
                    rdbPJuridica.Checked = true;
            }
        }
       
        public string nome { get => txtNome.Text; set => txtNome.Text = value; }
    
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
        public string bairro { get => txtBairro.Text; set => txtBairro.Text = value; }
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
        public string cidade { get => txtCidade.Text; set => txtCidade.Text = value; }
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

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Ativar();
            alterar = true;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (nome == "" || cpf == "" || cidade == "")
            {
                MessageBox.Show("Preencha os campos obrigatórios");
            }
            else
            {
                FornecedorController controller = new FornecedorController();

                if (controller.cadastrar(cpf, nome, cnpj, razaoSocial, NomeFantasia, tipo_Fornecedor, logradouro, numero, bairro, uf,
                cidade, cep, email, telefone, celular, alterar) == 0)
                {
                    MessageBox.Show("Fornecedor cadastrado com sucesso!");
                    Inativar();
                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar o fornecedor");
                }
            }
        }

        protected void Inativar()
        {
            txtNome.Enabled = false;
            txtLogradouro.Enabled = false;
            txtBairro.Enabled = false;
            txtNumero.Enabled = false;
            txtCidade.Enabled = false;
            txtEmail.Enabled = false;
            txtCodigo.Enabled = false;
            mskCPF.Enabled = false;
            mskCEP.Enabled = false;
            mskTelefone.Enabled = false;
            mskCelular.Enabled = false;
            cmbUF.Enabled = false;
            txtNomeFantasia.Enabled = false;
            gpbTipo.Enabled = false;

            btnAlterar.Enabled = true;
            btnCancelar.Enabled = true;
            btnDelete.Enabled = true;
            btnSalvar.Enabled = true;


        }

        protected void Ativar()
        {
            txtNome.Enabled = true;
            txtLogradouro.Enabled = true;
            txtBairro.Enabled = true;
            txtNumero.Enabled = true;
            txtCidade.Enabled = true;
            txtEmail.Enabled = true;
            mskCPF.Enabled = true;
            mskCEP.Enabled = true;
            mskTelefone.Enabled = true;
            mskCelular.Enabled = true;
            cmbUF.Enabled = true;
            txtNomeFantasia.Enabled = true;
            gpbTipo.Enabled = true;

            btnAlterar.Enabled = true;
            btnCancelar.Enabled = true;
            btnDelete.Enabled = true;
            btnSalvar.Enabled = true;

        }

        protected void Limpar()
        {
            mskCNPJ.Text = "";
            txtNomeFantasia.Text = "";
            txtRazaoSocial.Text = "";
            txtNome.Text = "";
            txtLogradouro.Text = "";
            txtBairro.Text = "";
            txtNumero.Text = "";
            txtCidade.Text = "";
            txtEmail.Text = "";
            txtCodigo.Text = "";
            mskCPF.Text = "";
            mskCEP.Text = "";
            mskTelefone.Text = "";
            mskCelular.Text = "";
            cmbUF.SelectedIndex = -1;
            rdbPFisica.Checked = false;
            rdbPJuridica.Checked = false;
            alterar = false;
        }

    
        public void PassarValores(Fornecedor fornecedor)
        {
            mskCNPJ.Text = fornecedor.CNPJ;
            txtRazaoSocial.Text = fornecedor.RazaoSocial;
            txtNomeFantasia.Text = fornecedor.NomeFantasia;
            txtNome.Text = fornecedor.Nome;
            txtLogradouro.Text = fornecedor.Logradouro;
            txtNumero.Text = Convert.ToString(fornecedor.Numero);
            txtBairro.Text = fornecedor.Bairro;
            txtCidade.Text = fornecedor.Cidade;
            txtEmail.Text = fornecedor.email;
            mskCPF.Text = fornecedor.CPF;
            mskCEP.Text = fornecedor.CEP;
            mskTelefone.Text = fornecedor.telefone;
            mskCelular.Text = fornecedor.celular;
            cmbUF.SelectedItem = fornecedor.UF;
            txtEmail.Text = fornecedor.email;
            tipo_Fornecedor = fornecedor.tipo_fornecedor; 

            Inativar();
            btnAlterar.Enabled = true;
            btnCancelar.Enabled = true;
            btnDelete.Enabled = true;
        }

     
       

        private void rdbPFisica_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbPFisica.Checked)
            {
                mskCNPJ.Enabled = false;
                txtNomeFantasia.Enabled = false;
                txtRazaoSocial.Enabled = false;
            }
        }

        private void rdbPJuridica_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbPJuridica.Checked)
            {
                mskCNPJ.Enabled = true;
                txtNomeFantasia.Enabled = true;
                txtRazaoSocial.Enabled = true;
            }
           
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            Ativar();
            txtCodigo.Enabled = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpar();
            Inativar();

            mskCPF.Enabled = true;
            txtNome.Enabled = true;
            txtCodigo.Enabled = true;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            FornecedorController fornecedorController = new FornecedorController();

            if (!codigo.Equals(""))
            {
                Fornecedor fornecedor = fornecedorController.PesquisarPorCodigo(codigo);

                PassarValores(fornecedor);
                return;

            }

            if (!cpf.Equals("") || !cnpj.Equals(""))
            {
                Fornecedor fornecedor = null;

                if (!cnpj.Equals(""))
                    fornecedor = fornecedorController.PesquisarPorCNPJ(cnpj);
                else
                    fornecedor = fornecedorController.PesquisarPorCPF(cpf);

                PassarValores(fornecedor);
                return;
            }

            if (!razaoSocial.Equals(""))
                fornecedorController.PesquisarPorRazaoSocial(razaoSocial, this,principal);
            else
                fornecedorController.PesquisarPorNome(nome, this,principal);
        }

        public void MenssageVazio()
        {
            MessageBox.Show("Nenhum registro encontrado");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Deseja realmente inativar esse cadastro?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (confirm.ToString().ToUpper() == "YES")
            {
                FornecedorController fornecedorController = new FornecedorController();
                int reultado = fornecedorController.Inativar(cpf);

                if (reultado == 0)
                    MessageBox.Show("Inativado com sucesso!");


            }
        }
    }
}
