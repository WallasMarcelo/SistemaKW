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
    public partial class frmPesquisaResultadoUsuario : Form
    {
        private frmCadastroUsuarios cadastroUsuarios = null;

        public frmPesquisaResultadoUsuario(DataTable tabela, frmCadastroUsuarios cadastroUsuarios)
        {
            InitializeComponent();
            this.cadastroUsuarios = cadastroUsuarios;

            preencherTabela(tabela);
        }

      
        public void preencherTabela(DataTable table)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = table;

            DataGridUsuario.DataSource = bs;//Colocar dados no DataGrid

        }


        private void DataGridUsuario_DoubleClick(object sender, EventArgs e)
        {
            int linha = DataGridUsuario.CurrentRow.Index;//Pegar indice da linha do clik da tabela
            string Codigo = DataGridUsuario.Rows[linha].Cells["Cod_funcionario"].Value.ToString();//pegar a coluna CPF

            UsuarioController controller = new UsuarioController();

            controller.PassarCodigo(Convert.ToInt32(Codigo), this.cadastroUsuarios);//Chamar método PassarCPF do controller
            Dispose();//Fechar tela de pesquisa

        }
    }
}
