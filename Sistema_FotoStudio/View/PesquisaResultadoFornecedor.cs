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
    public partial class PesquisaResultadoFornecedor : Form
    {
        frmCadastroFornedor cadastroFornecedor = null;
        public PesquisaResultadoFornecedor(DataTable tabela, frmCadastroFornedor cadastroFornecedor)
        {
            InitializeComponent();
            this.cadastroFornecedor = cadastroFornecedor;

            preencherTabela(tabela);
        }

        public void preencherTabela(DataTable table)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = table;

            DataGrid.DataSource = bs;//Colocar dados no DataGrid

        }

        private void DataGrid_DoubleClick(object sender, EventArgs e)
        {
            int linha = DataGrid.CurrentRow.Index;//Pegar indice da linha do clik da tabela
            string CPF = DataGrid.Rows[linha].Cells["CPF"].Value.ToString();//pegar a coluna CPF

            FornecedorController controller = new FornecedorController();

            controller.PassarCPF(CPF, this.cadastroFornecedor);//Chamar método PassarCPF do controller
            Dispose();//Fechar tela de pesquisa
        }
    }
}
