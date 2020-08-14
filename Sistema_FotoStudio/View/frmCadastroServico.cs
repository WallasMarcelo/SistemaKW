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
    public partial class frmCadastroServico : frmBase
    {
        public frmCadastroServico()
        {
            InitializeComponent();
        }


        public int codServoco
        {
            get
            {
                int.TryParse(txtCodServico.Text, out int n);
                return n;
            }

            set
            {
                txtCodServico.Text = value.ToString();
            }
        }

        public string tipoServico { get => txtTipoServico.Text; set => txtTipoServico.Text = value; }
        public string valor { get => txtValor.Text; set => txtValor.Text = value; }
        public string descricaoServico { get => txtDescricaoServico.Text; set => txtDescricaoServico.Text = value; }
    }
}
