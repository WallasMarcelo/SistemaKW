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
    public partial class frmPesquisarCliente : Form
    {
        public frmPesquisarCliente()
        {
            InitializeComponent();
        }


        public string CPF
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

        public string Nome { get => txtNome.Text; set => txtNome.Text = value; }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Nome = "";
            CPF = "";

            DataGridCliente.DataSource = null;
            DataGridCliente.Rows.Clear();
            DataGridCliente.Refresh();
        }

        private void btnPesquisarCliente_Click(object sender, EventArgs e)
        {
            pesquisaClienteController pesquisaCliente = new pesquisaClienteController();

            if (!CPF.Equals(""))
                ListarDados(pesquisaCliente.pesquisaPorCPF(CPF));
           else
                ListarDados(pesquisaCliente.pesquisaPorNome(Nome));
        }


        public void ListarDados(DataTable tabela)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = tabela;

            DataGridCliente.DataSource = bs;//Colocar dados no DataGrid

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
