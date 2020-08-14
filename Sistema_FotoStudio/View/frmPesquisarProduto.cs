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
    public partial class frmPesquisarProduto : Form
    {
        public frmPesquisarProduto()
        {
            InitializeComponent();
        }

        public int CodProduto
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
