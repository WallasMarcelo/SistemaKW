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
    public partial class frmPesquisaVenda : Form
    {
        String Codigo { get => txtCodigoVenda.Text; set => txtCodigoVenda.Text = value; }
        String CPF
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

        String NomeCliente { get => txtNome.Text; set => txtNome.Text = value; }
        

        public frmPesquisaVenda()
        {
            InitializeComponent();
        }

        private void frmPesquisaVenda_Load(object sender, EventArgs e)
        {

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            pesquisaControllerVenda controllerVenda = new pesquisaControllerVenda();

            if (!Codigo.Equals(""))
            {
                ListarDados(controllerVenda.pesquisaPorCodigo(Codigo));
                return;
            }
               
            if (!CPF.Equals(""))
            {
                ListarDados(controllerVenda.pesquisaPorCPF(CPF));
                return;
            }
               
            if (!NomeCliente.Equals(""))
            {
                ListarDados(controllerVenda.pesquisaPorNome(NomeCliente));
                return;
            }

            ListarDados(controllerVenda.pesquisaTodos());


        }

        public void ListarDados(DataTable tabela)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = tabela;

            dataGridVenda.DataSource = bs;//Colocar dados no DataGrid

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Codigo = "";
            CPF = "";
            NomeCliente = "";

            dataGridVenda.DataSource = null;
            dataGridVenda.Rows.Clear();
            dataGridVenda.Refresh();
        }


    }
}
