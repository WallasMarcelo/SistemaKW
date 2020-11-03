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
    public partial class frmPesquisaFuncionario : Form
    {
        public frmPesquisaFuncionario()
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
            pesquisaFuncionarioController pesquisaCliente = new pesquisaFuncionarioController();

            if (!CPF.Equals(""))
                ListarDados(pesquisaCliente.pesquisaPorCPF(CPF));
            else
                ListarDados(pesquisaCliente.pesquisaPorNome(Nome));
        }

        public void ListarDados(DataTable tabela)
        {
            BindingSource bs = new BindingSource();
            DataTable table = new DataTable();

          /*  for (int i = 0; i < tabela.Rows.Count; i++)
            {
                if(i % 2 == 0)
                {
                    DataRow linha = tabela.Rows[i];
                    table.Rows.Add(linha);

                    bs.DataSource = table;
                }
            }*/
           
            DataGridFuncionario.DataSource = bs;//Colocar dados no DataGrid

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Nome = "";
            CPF = "";

            DataGridFuncionario.DataSource = null;
            DataGridFuncionario.Rows.Clear();
            DataGridFuncionario.Refresh();
        }
    }
}
