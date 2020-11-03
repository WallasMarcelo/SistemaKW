using Sistema_FotoStudio.Controller;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_FotoStudio.View
{
    public partial class pesquisaResultadoFuncionario : Form
    {
        private DataGridView DataGrid;
        frmCadastroFuncionario cadastroFuncionario = null;
        public pesquisaResultadoFuncionario(DataTable tabela, frmCadastroFuncionario cadastroCliente)
        {
            InitializeComponent();
            this.cadastroFuncionario = cadastroCliente;

            preencherTabela(tabela);
        }
          


        public void preencherTabela(DataTable table)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = table;

            DataGrid.DataSource = bs;//Colocar dados no DataGrid

        }

        private void InitializeComponent()
        {
            this.DataGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGrid
            // 
            this.DataGrid.AllowUserToAddRows = false;
            this.DataGrid.AllowUserToDeleteRows = false;
            this.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGrid.Location = new System.Drawing.Point(0, 0);
            this.DataGrid.Name = "DataGrid";
            this.DataGrid.ReadOnly = true;
            this.DataGrid.Size = new System.Drawing.Size(474, 249);
            this.DataGrid.TabIndex = 7;
            this.DataGrid.DoubleClick += new System.EventHandler(this.DataGrid_DoubleClick);
            // 
            // pesquisaResultadoFuncionario
            // 
            this.ClientSize = new System.Drawing.Size(474, 249);
            this.Controls.Add(this.DataGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "pesquisaResultadoFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.pesquisaResultadoFuncionario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        private void pesquisaResultadoFuncionario_Load(object sender, EventArgs e)
        {

        }

        private void DataGrid_DoubleClick(object sender, EventArgs e)
        {
            int linha = DataGrid.CurrentRow.Index;//Pegar indice da linha do clik da tabela
            string CPF = DataGrid.Rows[linha].Cells["CPF"].Value.ToString();//pegar a coluna CPF

            FuncionarioController controller = new FuncionarioController();

            controller.PassarCPF(CPF, this.cadastroFuncionario);//Chamar método PassarCPF do controller
            Dispose();//Fechar tela de pesquisa
        }
    }


}
