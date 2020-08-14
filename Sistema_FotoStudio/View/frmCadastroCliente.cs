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

        private void mskCEP_Leave(object sender, EventArgs e)
        {
            try
            {
                string CEP = mskCEP.Text;

                if (CEP.Length < 8 || CEP.Length > 9)
                {
                    MessageBox.Show("Informe um CEP válido!");
                    return;
                }


                System.Net.HttpWebRequest requisicao = (System.Net.HttpWebRequest)System.Net.WebRequest.Create("https://viacep.com.br/ws/" + CEP + "/json/");

                requisicao.AllowAutoRedirect = false;
                System.Net.HttpWebResponse ChecaServidor = (System.Net.HttpWebResponse)requisicao.GetResponse();

                if (ChecaServidor.StatusCode != System.Net.HttpStatusCode.OK)
                {
                    MessageBox.Show("Servidor indisponível");
                    return;
                }


                using (Stream webStream = ChecaServidor.GetResponseStream())
                {
                    if (webStream != null)
                    {
                        using (StreamReader responseReader = new StreamReader(webStream))
                        {
                            string response = responseReader.ReadToEnd();
                            response = System.Text.RegularExpressions.Regex.Replace(response, "[{},]", string.Empty);
                            response = response.Replace("\"", "");

                            String[] substrings = response.Split('\n');

                            int cont = 0;
                            foreach (var substring in substrings)
                            {
                                if (cont == 1)
                                {
                                    string[] valor = substring.Split(":".ToCharArray());
                                    if (valor[0] == "  erro")
                                    {
                                        MessageBox.Show("CEP não encontrado");
                                        mskCEP.Focus();
                                        return;
                                    }
                                }

                                //Logradouro
                                if (cont == 2)
                                {
                                    string[] valor = substring.Split(":".ToCharArray());
                                    txtLogradouro.Text = valor[1];
                                }

                                //Bairro
                                if (cont == 4)
                                {
                                    string[] valor = substring.Split(":".ToCharArray());
                                    txtBairro.Text = valor[1];
                                }

                                //Localidade (Cidade)
                                if (cont == 5)
                                {
                                    string[] valor = substring.Split(":".ToCharArray());
                                    txtCidade.Text = valor[1];
                                }

                                //Estado (UF)
                                if (cont == 6)
                                {
                                    string[] valor = substring.Split(":".ToCharArray());
                                    cmbUF.SelectedItem = valor[1].Trim();
                                }

                                cont++;
                            }
                        }
                    }
                }

            }
            catch (Exception erro)
            {
                MessageBox.Show("Algo deu errado. Detalhes: " + erro.Message);
            }
        }
    }

}


