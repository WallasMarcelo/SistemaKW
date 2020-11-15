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
    public partial class pesquisaResultadoVendas : Form
    {

        frmVendas vendas = null;

        public pesquisaResultadoVendas(DataTable table, frmVendas vendas)
        {
            InitializeComponent();
            this.vendas = vendas;

            preencherTabela(table);
         

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
            string Codigo = DataGrid.Rows[linha].Cells["Código"].Value.ToString();//pegar a coluna CPF

            VendaController controller = new VendaController();

            controller.PassarCodigo(Codigo, this.vendas);//Chamar método PassarCPF do controller
            Dispose();//Fechar tela de pesquisa
        }
    }
}
