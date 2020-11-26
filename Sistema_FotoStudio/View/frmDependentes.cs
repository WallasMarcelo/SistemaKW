using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema_FotoStudio.Controller;
using Sistema_FotoStudio.Model;


namespace Sistema_FotoStudio.View
{
    public partial class frmDependentes : frmBase
    {
        public frmDependentes()
        {
            InitializeComponent();
        }

        private string CPFCliente
        {
            get
            {
                mskCPFCliente.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                string texto = mskCPFCliente.Text;
                mskCPFCliente.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
                return texto;
            }

            set
            {
                mskCPFCliente.Text = value;
            }
        }

        public string cod_Cliente;
        
        private string cod_dependente { get => txtCodigo.Text; set => txtCodigo.Text = value; }

        private string NomeCliente { get => txtNomePais.Text; set => txtNomePais.Text = value; }
        private string NomeDependente { get => txtNomeDependente.Text; set => txtNomeDependente.Text = value; }
        private DateTime DataNasc_Depentente { get => dptDependente.Value; set => dptDependente.Value = value; }

        private void frmDependentes_Load(object sender, EventArgs e)
        {
            btnDelete.Enabled = false;
            btnAlterar.Enabled = false;
            btnSalvar.Enabled = false;
            btnCancelar.Enabled = false;

            mskCPFCliente.Enabled = false;
            txtNomePais.Enabled = false;
            txtNomeDependente.Enabled = false;
            
            dptDependente.Enabled = false;

        }

        private void mskCPFCliente_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void mskCPFCliente_Leave(object sender, EventArgs e)
        {
            buscaCliente();
        }

        public void buscaCliente()
        {
            DependenteController dependenteController = new DependenteController();

            DataTable infoCliente = dependenteController.pegaCliente(CPFCliente);

            NomeCliente = infoCliente.Rows[0]["Nome"].ToString();

            cod_Cliente = infoCliente.Rows[0]["cod_cliente"].ToString();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (NomeCliente == "" || NomeDependente == "" || CPFCliente == "")
            {
                MessageBox.Show("Preencha os campos obrigatórios", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DependenteController dependenteController = new DependenteController();
                //alterar pra pegar o codigo do fornecedore pelo nome pra joogar aqui como parametro
                if ((dependenteController.CadastrarDependente(cod_Cliente,NomeDependente,DataNasc_Depentente.ToString(),cod_dependente) == 0))
                {
                    MessageBox.Show("Salvo com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    limpaCampo();
                    btnNovo.Enabled = true;
                    btnPesquisar.Enabled = true;
                    
                }
                else
                {
                    MessageBox.Show("Erro", "Erro:", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            btnCancelar.Enabled = true;
            btnSalvar.Enabled = true;

            mskCPFCliente.Enabled = true;
            txtNomePais.Enabled = true;
            txtNomeDependente.Enabled = true;
            dptDependente.Enabled = true;

            txtCodigo.Enabled = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnDelete.Enabled = false;
            btnAlterar.Enabled = false;
            btnSalvar.Enabled = false;
            btnCancelar.Enabled = false;
            txtCodigo.Enabled = true;
            mskCPFCliente.Enabled = false;
            txtNomePais.Enabled = false;
            txtNomeDependente.Enabled = false;

            dptDependente.Enabled = false;

            limpaCampo();
        }

        public void limpaCampo()
        {
            txtCodigo.Text = "";
            txtNomeDependente.Text = "";
            txtNomePais.Text = "";
            mskCPFCliente.Text = "";   
        }

        public void PassarValoresCampo(Dependente dependente)
        {
            mskCPFCliente.Text = dependente.cpf_pais;
            txtCodigo.Text = dependente.cod_dependente;
            txtNomeDependente.Text = dependente.nome_dependente;
            txtNomePais.Text = dependente.nomePais;
            cod_Cliente = dependente.cod_cliente;
            dptDependente.Value = Convert.ToDateTime(dependente.data_nascimento);

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {

            btnAlterar.Enabled = true;
            btnCancelar.Enabled = true;

            DependenteController dependenteController = new DependenteController();


            if (!cod_dependente.Equals(""))
            {
                Dependente dependente = dependenteController.PesquisarPorCodigo(cod_dependente);

                PassarValoresCampo(dependente);
                return;

            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            btnSalvar.Enabled = true;
            txtCodigo.Enabled = false;
            mskCPFCliente.Enabled = true;
            txtNomePais.Enabled = true;
            txtNomeDependente.Enabled = true;
            dptDependente.Enabled = true;
        }
    }
}
