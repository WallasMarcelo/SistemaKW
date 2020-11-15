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
    public partial class frmVendas : frmBase
    {
        DataTable dataTable = new DataTable("itensVenda");
        int cont = 0;

        frmPrincipal principal;

        String CodigoVenda { get => txtCodigoVenda.Text; set => txtCodigoVenda.Text = value; }

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
        String NomeCliente { get => txtNomeCliente.Text; set => txtNomeCliente.Text = value; }
        String CodigoFuncionario { get => txtCodigoFuncionario.Text; set =>  txtCodigoFuncionario.Text = value; }

        String NomeFuncionario { get => txtNomeFuncionario.Text; set => txtNomeFuncionario.Text = value; }

        DateTime DataVenda { get => dtpDataVenda.Value ; set => dtpDataVenda.Value = value; }

        int TipoItemVenda 
        {
            get
            {
                if (rbProduto.Checked)
                    return 1;

                return 2;
            }

            set
            {
                if (value == 1)
                    rbProduto.Checked = true;
                else
                    rbServico.Checked = true;
            }
        }

        String CodigoItem { get => txtCodigoProduto.Text ; set => txtCodigoProduto.Text = value; }
        String NomeItem { get => txtNomeProduto.Text; set => txtNomeProduto.Text = value; }

        String Quantidade { get => txtQuantidade.Text ; set => txtQuantidade.Text = value; }

        String valorUnitario { get => mskValorunitario.Text ; set => mskValorunitario.Text = value; }

        String valorTotal { get => lblValorTotal.Text; set => lblValorTotal.Text = value; }



        public frmVendas(frmPrincipal principal)
        {
            InitializeComponent();
            Inativar();
            this.principal = principal;

            mskCPF.Enabled = true;
            txtNomeCliente.Enabled = true;
            txtCodigoVenda.Enabled = true;
            btnCancelar.Enabled = true;
        }

        private void frmVendas_Load(object sender, EventArgs e)
        {
            dataTable.Columns.Add("Código");
            dataTable.Columns.Add("Tipo");
            dataTable.Columns.Add("Descrição");
            dataTable.Columns.Add("Quantidade");
            dataTable.Columns.Add("Valor Unitário");
            dataTable.Columns.Add("Total");
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void mskCPF_KeyPress(object sender, KeyPressEventArgs e)
        {
          
         
        }

        private void bpbDadoProdutoServico_Enter(object sender, EventArgs e)
        {

        }

        private void mskDataVenda_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void mskCPF_Leave(object sender, EventArgs e)
        {
            buscarCliente();
        }

        private void mskCPF_Enter(object sender, EventArgs e)
        {
            buscarCliente();
        }


        public void buscarCliente()
        {
            VendaController vendaController = new VendaController();

            NomeCliente = vendaController.buscarClinte(cpf);
        }

        private void txtCodigoProduto_Leave(object sender, EventArgs e)
        {
            VendaController vendaController = new VendaController();
            

            if (rbProduto.Checked)
            {
               NomeItem = vendaController.buscarProduto(CodigoItem);
            }  
            else
            {
                DataTable dataTable = vendaController.buscarServico(CodigoItem);

                NomeItem = dataTable.Rows[0]["Nome"].ToString();
                valorUnitario = dataTable.Rows[0]["Valor"].ToString();
            }
              
        }

        private void bpbDadosClienteFunc_Enter(object sender, EventArgs e)
        {

        }

        private void txtCodigoFuncionario_Leave(object sender, EventArgs e)
        {
            VendaController vendaController = new VendaController();

            NomeFuncionario = vendaController.buscarFuncionario(CodigoFuncionario);
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            int quantidade = dataTable.Rows.Count;

            if (quantidade == 0)
                cont = 0;
            else if (quantidade == 1)
                cont = 1;
            else if (quantidade > 1)
                cont = quantidade;
       

            dataTable.Rows.Add();

            dataTable.Rows[cont]["Código"] = CodigoItem;
            dataTable.Rows[cont]["Tipo"] = TipoItemVenda == 1 ? "Produto" : "Serviço";
            dataTable.Rows[cont]["Descrição"] = NomeItem;
            dataTable.Rows[cont]["Quantidade"] = Quantidade;
            dataTable.Rows[cont]["Valor Unitário"] = valorUnitario;
            dataTable.Rows[cont]["Total"] = Convert.ToDecimal(valorUnitario) * Convert.ToDecimal(Quantidade) ;

            dgvItensVenda.DataSource = dataTable;
            //CalcularTotal();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
           
            Decimal valor = Convert.ToDecimal(dataTable.Rows[dgvItensVenda.CurrentRow.Index]["Total"]);
            valorTotal = (Convert.ToDecimal(valorTotal) - valor).ToString();

            dgvItensVenda.Rows.Remove(dgvItensVenda.CurrentRow);

            this.dataTable = (DataTable)dgvItensVenda.DataSource;
            dgvItensVenda.DataSource = this.dataTable;

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if(!cpf.Equals("") && !NomeCliente.Equals("") && !CodigoFuncionario.Equals("") 
                && !NomeFuncionario.Equals("") && dgvItensVenda.Rows.Count != 0)
            {
                VendaController vendaController = new VendaController();
                vendaController.Salvar(cpf, CodigoFuncionario, DataVenda, (DataTable)dgvItensVenda.DataSource,CodigoVenda);
                MessageBox.Show("Venda Realizada com sucesso!");
                Inativar();
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            VendaController vendaController = new VendaController();

            if (!CodigoVenda.Equals(""))
            {
                PassarValores(vendaController.pesquiarPorCodigo(Convert.ToInt32(CodigoVenda)));
                return;
            }

            if (!cpf.Equals(""))
            {
                vendaController.pesquiarPorCPF(cpf, this, this.principal);
                return;
            }

            vendaController.pesquiarPorNome(NomeCliente, this, this.principal);
        }


        public void PassarValores(Vendas vendas)
        {
            CodigoVenda = vendas.Cod_venda.ToString();
            cpf = vendas.CPF;
            NomeCliente = vendas.Nome_Cliente;
            CodigoFuncionario = Convert.ToString(vendas.Cod_funcionario);
            NomeFuncionario = vendas.Nome_Funcionario;
            DataVenda = vendas.Data_venda;

            PassarValoresItemVenda(new VendaController().pesquisarItemVenda(Convert.ToInt32(CodigoVenda)));
           // CalcularTotal();
        }

        public void PassarValoresItemVenda(DataTable dataTable)
        {
            this.dataTable = dataTable; 
            dgvItensVenda.DataSource = this.dataTable;
        }

        public void CalcularTotal()
        {
            Decimal total = 0;

            for(int i=0; i < dataTable.Rows.Count; i++)
                total = total + Convert.ToDecimal(dataTable.Rows[i]["Total"]);

            valorTotal = total.ToString();
        }

        private void lblValorTotal_Click(object sender, EventArgs e)
        {

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            Ativar();
            txtCodigoVenda.Enabled = false;
        }

        protected void Inativar()
        {
            txtCodigoVenda.Enabled = false;
            mskCPF.Enabled = false;
            txtNomeCliente.Enabled = false;
            txtNomeFuncionario.Enabled = false;
            txtNomeFuncionario.Enabled = false;
            dgvItensVenda.Enabled = false;
            txtCodigoProduto.Enabled = false;
            txtNomeProduto.Enabled = false;
            txtQuantidade.Enabled = false;
            mskValorunitario.Enabled = false;
            rbProduto.Enabled = false;
            rbServico.Enabled = false;



            btnAdicionar.Enabled = false;
            btnRemover.Enabled = false;
            btnAlterar.Enabled = false;
            btnCancelar.Enabled = false;
            btnDelete.Enabled = false;
        }

        protected void Ativar()
        {
            txtCodigoVenda.Enabled = true;
            mskCPF.Enabled = true;
            txtNomeCliente.Enabled = true;
            txtNomeFuncionario.Enabled = true;
            txtNomeFuncionario.Enabled = true;
            dgvItensVenda.Enabled = true;
            txtCodigoProduto.Enabled = true;
            txtNomeProduto.Enabled = true;
            txtQuantidade.Enabled = true;
            mskValorunitario.Enabled = true;
            rbProduto.Enabled = true;
            rbServico.Enabled = true;

            btnAdicionar.Enabled = true;
            btnRemover.Enabled = true;
            btnAlterar.Enabled = true;
            btnCancelar.Enabled = true;
            btnDelete.Enabled = true;
            btnSalvar.Enabled = true;

        }

        protected void Limpar()
        {
            txtCodigoVenda.Text = "";
            mskCPF.Text = "";
            txtNomeCliente.Text = "";
            txtNomeFuncionario.Text = "";
            txtNomeFuncionario.Text = "";
            txtCodigoProduto.Text = "";
            txtNomeProduto.Text = "";
            txtQuantidade.Text = "";
            mskValorunitario.Text = "";
            rbProduto.Checked = false;
            rbServico.Checked = false;

            dgvItensVenda.DataSource = null;
            dgvItensVenda.Rows.Clear();
            dgvItensVenda.Refresh();


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpar();
            Inativar();

            mskCPF.Enabled = true;
            txtNomeCliente.Enabled = true;
            txtCodigoVenda.Enabled = true;
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Ativar();
        }
    }
}
