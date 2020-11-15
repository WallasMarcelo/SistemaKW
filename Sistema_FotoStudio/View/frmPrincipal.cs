using Sistema_FotoStudio.Controller;
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
    public partial class frmPrincipal : Form
    {
        DataTable aniversario = null;

        public frmPrincipal() 
        { 
            InitializeComponent();

        }

        public frmPrincipal(String tipoUsuario)
        {
            InitializeComponent();


            if (tipoUsuario.Equals("2"))
            {
                fornecedorToolStripMenuItem.Visible = false;
                usuárioToolStripMenuItem.Visible = false;
                fornecedorToolStripMenuItem.Visible = false;
                pesquisaClientesToolStripMenuItem.Visible = false;
                pesquisaFornecedoresToolStripMenuItem.Visible = false;
                pesquisaFuncionarioToolStripMenuItem.Visible = false;
                pesquisaUsuáriosToolStripMenuItem.Visible = false;
                pesquisaFornecedoresToolStripMenuItem.Visible = false;
            }



        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroCliente tela = new frmCadastroCliente(this);
            tela.MdiParent = this;
            tela.Show();
        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroProduto tela = new frmCadastroProduto();
            tela.MdiParent = this;
            tela.Show();
        }

        private void fornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroFornedor cadastroForn = new frmCadastroFornedor(this);
            cadastroForn.MdiParent = this;
            cadastroForn.Show();
        }

        private void funcionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroFuncionario cadastroFunc = new frmCadastroFuncionario(this);
            cadastroFunc.MdiParent = this;
            cadastroFunc.Show();
        }

        private void vendasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmVendas cadastroVenda = new frmVendas(this);
            cadastroVenda.MdiParent = this;
            cadastroVenda.Show();
        }

        private void forneedorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pesquisaClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPesquisarCliente pesquisarCliente = new frmPesquisarCliente();
            pesquisarCliente.MdiParent = this;
            pesquisarCliente.Show();

        }

        private void pesquisaProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPesquisarProduto pesquisarProduto = new frmPesquisarProduto();
            pesquisarProduto.MdiParent = this;
            pesquisarProduto.Show();
        }

        private void pesquisaServiçosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPesquisaServico pesquisaServico = new frmPesquisaServico();
            pesquisaServico.MdiParent = this;
            pesquisaServico.Show();
        }

        private void pesquisaFuncionarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPesquisaFuncionario pesquisaFuncionario = new frmPesquisaFuncionario();
            pesquisaFuncionario.MdiParent = this;
            pesquisaFuncionario.Show();
        }

        private void pesquisaFornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPesquisaFornecedor pesquisaFornecedor = new frmPesquisaFornecedor();
            pesquisaFornecedor.MdiParent = this;
            pesquisaFornecedor.Show();
        }

        private void pesquisaUsuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPesquisaUsuario pesquisaUsuario = new frmPesquisaUsuario();
            pesquisaUsuario.MdiParent = this;
            pesquisaUsuario.Show();
        }

        private void pesquisaVendasToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmPesquisaVenda pesquisaVenda = new frmPesquisaVenda();
            pesquisaVenda.MdiParent = this;
            pesquisaVenda.Show();
        }

        private void usuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroUsuarios cadastroUsuarios = new frmCadastroUsuarios(this);
            cadastroUsuarios.MdiParent = this;
            cadastroUsuarios.Show();
                
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            DependenteController dependente = new DependenteController();

            String Dia = DateTime.Now.Day.ToString();
            String Mes = DateTime.Now.Month.ToString();
            String Ano = DateTime.Now.Year.ToString();

            aniversario =  dependente.TrazerAniversariantes(Ano + "-" + Mes + "-" + Dia);

        }


        private void btnAniversario_Click_1(object sender, EventArgs e)
        {
            frmAniversariantes aniversariantes = new frmAniversariantes(aniversario);
            aniversariantes.MdiParent = this;
            aniversariantes.Show();
        }

        private void clienteToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmRelatorioCliente relatorioCliente = new frmRelatorioCliente();
            relatorioCliente.MdiParent = this;
            relatorioCliente.Show();
        }

        private void servçosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRelatorioServiço relatorioServiço = new frmRelatorioServiço();
            relatorioServiço.MdiParent = this;
            relatorioServiço.Show();
        }
    }
}
