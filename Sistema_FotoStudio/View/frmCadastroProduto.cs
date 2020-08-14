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
    public partial class frmCadastroProduto : frmBase
    {
        public frmCadastroProduto()
        {
            InitializeComponent();
        }

        //Produto
        public int codigoProduto
        {
            get
            {
                int.TryParse(txtCodProduto.Text, out int n);
                return n;
            }

            set
            {
                txtCodProduto.Text = value.ToString();
            }
        }
        public string NomeFornecedor 
        {
            get
            {
                return cmbFornecedor.Text;
            }

            set
            {
                cmbFornecedor.SelectedIndex = cmbFornecedor.FindString(value);
            }
        
        
        }
        public string marca { get => txtMarca.Text; set => txtMarca.Text = value; } 
        public string lote { get => txtLote.Text; set => txtLote.Text = value; }
        public int quantidadeProduto
        {
            get
            {
                int.TryParse(txtQuantidade.Text, out int n);
                return n;
            }

            set
            {
                txtQuantidade.Text = value.ToString();
            }

        }
        public string descricaoProduto { get => txtDescricaoProduto.Text; set => txtDescricaoProduto.Text = value; }

        private void txtCodProduto_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cmbFornecedor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtMarca_TextChanged(object sender, EventArgs e)
        {

        }

        //Serviço





    }
}
