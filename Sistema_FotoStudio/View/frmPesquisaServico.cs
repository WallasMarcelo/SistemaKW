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
    public partial class frmPesquisaServico : Form
    {
        public frmPesquisaServico()
        {
            InitializeComponent();
        }

        public int codigoServico
        {
            get
            {
                int.TryParse(txtCodigo.Text, out int n);
                return n;
            }

            set
            {
                txtCodigo.Text = value.ToString();
            }
        }

        public string tipoServico { get => txtTipoServico.Text; set => txtTipoServico.Text = value; }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
