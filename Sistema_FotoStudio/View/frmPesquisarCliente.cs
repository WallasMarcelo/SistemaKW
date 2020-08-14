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

        }
    }
}
