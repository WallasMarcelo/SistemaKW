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
    public partial class frmPesquisaServico : Form
    {
        public frmPesquisaServico()
        {
            InitializeComponent();
        }

        public string codigoServico { get => txtCodigo.Text; set => txtCodigo.Text = value; }

        public string tipoServico { get => txtTipoServico.Text; set => txtTipoServico.Text = value; }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtCodigo.Text = "";
            txtTipoServico.Text = "";

            gridPesquisaServico.DataSource = null;
            gridPesquisaServico.Rows.Clear();
            gridPesquisaServico.Refresh();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            ServicoController servicoController = new ServicoController();

            if (!codigoServico.Equals("")) 
            {
                ListarDados(servicoController.pesquisaPorCodServico(codigoServico.ToString()));
                return;
            }
            if (!tipoServico.Equals(""))
            {
                ListarDados(servicoController.pesquisaPorTipoServico(tipoServico));
                return;
            }

            ListarDados(servicoController.pesquisaTodosServicos());

            
        }

        public void ListarDados(DataTable tabela)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = tabela;

            gridPesquisaServico.DataSource = bs;//Colocar dados no DataGrid

        }
    }
}
