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
    public partial class frmCadastroServico : frmBase
    {
        public frmCadastroServico()
        {
            InitializeComponent();
        }


        public string codServico  { get => txtCodServico.Text; set => txtCodServico.Text = value; }

        public string tipoServico { get => txtTipoServico.Text; set => txtTipoServico.Text = value; }
        public string valor { get => txtValor.Text; set => txtValor.Text = value; }
        public string descricaoServico { get => txtDescricaoServico.Text; set => txtDescricaoServico.Text = value; }

              
        public void Ativar()
        {
            btnAlterar.Enabled = true;
            btnCancelar.Enabled = true;
            btnDelete.Enabled = true;
            btnNovo.Enabled = true;
            btnPesquisar.Enabled = true;
            btnSalvar.Enabled = true;
        }

        public void Desativar()
        {
            btnAlterar.Enabled = true;
            btnCancelar.Enabled = true;
            btnDelete.Enabled = true;
            btnNovo.Enabled = true;
            btnPesquisar.Enabled = true;
            btnSalvar.Enabled = true;
        }

        public void limpaCampos()
        {
            txtCodServico.Text = "";
            txtDescricaoServico.Text = "";
            txtTipoServico.Text = "";
            txtValor.Text = "";
        }

        public void PassarValores(Servico servico)
        {
            txtDescricaoServico.Text = servico.Descricao;
            txtTipoServico.Text = servico.Tipo;
            txtValor.Text = servico.Valor.ToString();
            
            btnAlterar.Enabled = true;
            btnCancelar.Enabled = true;
            btnDelete.Enabled = true;
        }

        private void frmCadastroServico_Load(object sender, EventArgs e)
        {
            btnAlterar.Enabled = false;
            btnSalvar.Enabled = false;
            btnDelete.Enabled = false;
            btnCancelar.Enabled = false;
            

            txtCodServico.Enabled = true;
            txtTipoServico.Enabled = false;//valor descri
            txtValor.Enabled = false;
            txtDescricaoServico.Enabled = false;
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            txtCodServico.Enabled = false;
            txtTipoServico.Enabled = true;//valor descri
            txtValor.Enabled = true;
            txtDescricaoServico.Enabled = true;

            btnSalvar.Enabled = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnAlterar.Enabled = false;
            btnSalvar.Enabled = false;
            btnDelete.Enabled = false;
            btnCancelar.Enabled = false;

            txtCodServico.Enabled = true;
            txtTipoServico.Enabled = false;//valor descri
            txtValor.Enabled = false;
            txtDescricaoServico.Enabled = false;

            limpaCampos();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            txtCodServico.Enabled = false;
            txtTipoServico.Enabled = true;//valor descri
            txtValor.Enabled = true;
            txtDescricaoServico.Enabled = true;

            btnCancelar.Enabled = true;
            btnSalvar.Enabled = true;
            
            //salvar cancelar
        }


        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (tipoServico == "" || valor == "" || descricaoServico == "")
            {
                MessageBox.Show("Preencha os campos obrigatórios!", "Atenção.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                ServicoController controller = new ServicoController();

                if (controller.cadastrarServico(codServico.ToString(),tipoServico, descricaoServico, valor) == 0)
                {
                    MessageBox.Show("Salvo com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    limpaCampos();
                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar o Serviço", "Erro.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            btnAlterar.Enabled = true;
            btnCancelar.Enabled = true;

            ServicoController servicoController = new ServicoController();


            if (!codServico.Equals(""))
            {
                Servico servico = servicoController.PesquisarPorCodigo(Convert.ToInt32(codServico));

                PassarValores(servico);
                return;

            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            DialogResult confirm = MessageBox.Show("Deseja realmente inativar esse cadastro?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (confirm.ToString().ToUpper() == "YES")
            {
                ServicoController servicoController = new ServicoController();
                int reultado = servicoController.Inativar(Convert.ToInt32(codServico));

                if (reultado == 0)
                    MessageBox.Show("Inativado com sucesso!", "Sucesso.", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
        }
    }
}
