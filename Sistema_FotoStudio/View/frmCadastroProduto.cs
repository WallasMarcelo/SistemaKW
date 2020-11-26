using System;
using Sistema_FotoStudio.Model;
using Sistema_FotoStudio.Controller;
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

        List<String> lista_cod_Forn = new List<String>();

        public int idx_cod_forn;
        //Produto
        public String codigoProduto{ get => txtCodProduto.Text; set => txtCodProduto.Text = value; }
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

        private void frmCadastroProduto_Load(object sender, EventArgs e)
        {
            desativaComponentes();
            limpaCampos();
            btnNovo.Enabled = true;
            btnPesquisar.Enabled = true;
            txtCodProduto.Enabled = true;

            ProdutoController produtoController = new ProdutoController();
            DataTable cmbForn = produtoController.buscaFornecedorCmb();

            for (int i = 0; i < cmbForn.Rows.Count; i++)
            {
                cmbFornecedor.Items.Add(cmbForn.Rows[i]["NomeFantasia"].ToString());
                lista_cod_Forn.Add(cmbForn.Rows[i]["cod_fornecedor"].ToString());
            }

            

        }

                      

        private void btnNovo_Click(object sender, EventArgs e)
        {
            ativaComponentes();
            txtCodProduto.Enabled = false;
            btnPesquisar.Enabled = false;
            btnAlterar.Enabled = false;
            btnDelete.Enabled = false;
                
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            cancelar();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            btnAlterar.Enabled = true;

            ProdutoController produtoController = new ProdutoController();


            if (!codigoProduto.Equals(""))
            {
                Produto produto = produtoController.PesquisarPorCodigo(Convert.ToInt32(codigoProduto));

                PassarValoresCampo(produto);
                return;

            }

        }

      
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (NomeFornecedor == "" || marca == "" || lote == "" || descricaoProduto == "")
            {
                MessageBox.Show("Preencha os campos obrigatórios","Atenção",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
                ProdutoController prodController = new ProdutoController();
                //alterar pra pegar o codigo do fornecedore pelo nome pra joogar aqui como parametro
                if (prodController.cadastroProduto(codigoProduto.ToString(),Convert.ToInt32(lista_cod_Forn[idx_cod_forn]),marca,lote,quantidadeProduto,descricaoProduto) == 0)
                {
                    MessageBox.Show("Salvo com sucesso!","Sucesso!",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                    desativaComponentes();
                    limpaCampos();
                    btnNovo.Enabled = true;
                    btnPesquisar.Enabled = true;
                    txtCodProduto.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Erro","Erro:",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
            }
        }

        private void cmbFornecedor_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string nome_cmb_fornecedor = NomeFornecedor;

            idx_cod_forn = cmbFornecedor.FindString(NomeFornecedor);

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            ativaComponentes();
        }

        private void ativaComponentes()
        {
            btnNovo.Enabled = true;
            btnAlterar.Enabled = true;
            btnDelete.Enabled = true;
            btnCancelar.Enabled = true;
            btnPesquisar.Enabled = true;
            btnSalvar.Enabled = true;

            txtCodProduto.Enabled = true;
            txtDescricaoProduto.Enabled = true;
            txtLote.Enabled = true;
            txtMarca.Enabled = true;
            txtQuantidade.Enabled = true;
            cmbFornecedor.Enabled = true;
        }
        private void desativaComponentes()
        {
            btnNovo.Enabled = false;
            btnAlterar.Enabled = false;
            btnDelete.Enabled = false;
            btnCancelar.Enabled = false;
            btnPesquisar.Enabled = false;
            btnSalvar.Enabled = false;

            txtCodProduto.Enabled = false;
            txtDescricaoProduto.Enabled = false;
            txtLote.Enabled = false;
            txtMarca.Enabled = false;
            txtQuantidade.Enabled = false;
            cmbFornecedor.Enabled = false;
        }

        private void limpaCampos()
        {
            txtCodProduto.Text = "";
            txtDescricaoProduto.Text = "";
            txtLote.Text = "";
            txtMarca.Text = "";
            txtQuantidade.Text = "";
            cmbFornecedor.SelectedIndex = -1;
        }
        private void cancelar()
        {
            limpaCampos();
            desativaComponentes();
            btnNovo.Enabled = true;
            btnPesquisar.Enabled = true;
            txtCodProduto.Enabled = true;
        }

        public void PassarValoresCampo(Produto produto)
        {
            txtDescricaoProduto.Text = produto.descricao;
            txtLote.Text = produto.lote;
            txtMarca.Text = produto.marca;
            txtQuantidade.Text = Convert.ToString(produto.quantidade);

            NomeFornecedor = Convert.ToString(produto.nome_fornecedor);

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            DialogResult confirm = MessageBox.Show("Deseja realmente inativar esse cadastro?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (confirm.ToString().ToUpper() == "YES")
            {
                ProdutoController produtoController = new ProdutoController();
                int reultado = produtoController.Inativar(Convert.ToInt32(codigoProduto));

                if (reultado == 0)
                    MessageBox.Show("Inativado com sucesso!", "Sucesso.", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
        }
    }
}
