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
    public partial class frmPesquisarDependentes : Form
    {
        public frmPesquisarDependentes()
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

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            DependenteController dependenteController = new DependenteController();


            if (!CPF.Equals("")) 
            {
                ListarDados(dependenteController.PesquisarPorCPF(CPF));
                return;
            }
            if (!Nome.Equals(""))
            {
                ListarDados(dependenteController.PesquisarPorNome(Nome));
                return;
            }

            ListarDados(dependenteController.PesquisaTodosDependente());

            
        }

        public void ListarDados(DataTable tabela)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = tabela;

            gridCliente.DataSource = bs;//Colocar dados no DataGrid

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Text = "";
            mskCPF.Text = "";
            gridCliente.DataSource = null;
            gridCliente.Rows.Clear();
            gridCliente.Refresh();
        }
    }
}
