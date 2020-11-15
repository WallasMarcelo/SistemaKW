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
    public partial class frmPesquisaUsuario : Form
    {
        public frmPesquisaUsuario()
        {
            InitializeComponent();
        }

        private String Codigo { get => txtCodigo.Text; set => txtCodigo.Text = value; } 
        private String Nome { get => txtFuncionario.Text; set => txtFuncionario.Text = value;}

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            pesquisaUsuarioController pesquisaUsuario = new pesquisaUsuarioController();

            if (!Codigo.Equals(""))
                ListarDados(pesquisaUsuario.pesquisaPorCodigo(Codigo));
            else
                ListarDados(pesquisaUsuario.pesquisaPorNome(Nome));
        }

        public void ListarDados(DataTable tabela)
        {


            dataGridUsuario.DataSource = tabela;

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtCodigo.Text = "";
            txtFuncionario.Text = "";

            dataGridUsuario.DataSource = null;
            dataGridUsuario.Rows.Clear();
            dataGridUsuario.Refresh();
        }
    }
}

