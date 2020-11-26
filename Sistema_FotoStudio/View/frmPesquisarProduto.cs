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
    public partial class frmPesquisarProduto : Form
    {
        public frmPesquisarProduto()
        {
            InitializeComponent();
        }

        public string CodProduto { get => txtCodigo.Text; set => txtCodigo.Text = value; }

        public string descricao { get => txtDescricao.Text; set=> txtDescricao.Text = value;}

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtCodigo.Text = "";
            txtDescricao.Text = "";
            gridPesquisaproduto.DataSource = null;
            gridPesquisaproduto.Rows.Clear();
            gridPesquisaproduto.Refresh();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            ProdutoController produtoController = new ProdutoController();

            if (!CodProduto.Equals(""))
            {
                ListarDados(produtoController.PesquisarPorCodigo(CodProduto));
                return;
            }
            if (!descricao.Equals(""))
            {
                ListarDados(produtoController.PesquisarPorDescricao(descricao));
                return;
            }

            ListarDados(produtoController.PesquisarTodos());
            
        }

        public void ListarDados(DataTable tabela)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = tabela;

            gridPesquisaproduto.DataSource = bs;//Colocar dados no DataGrid

        }

       
    }
}
