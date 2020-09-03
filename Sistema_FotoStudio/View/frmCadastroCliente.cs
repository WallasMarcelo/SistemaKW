using System;
using System.IO;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema_FotoStudio.Model;
using Sistema_FotoStudio.Controller;

namespace Sistema_FotoStudio.View
{
    public partial class frmCadastroCliente : frmBase
    {
        public frmCadastroCliente()
        {
            InitializeComponent();
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
                cmbSexo.SelectedIndex = cmbSexo.FindString(value);
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



        private void mskCEP_Leave_1(object sender, EventArgs e)
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
    }
}


