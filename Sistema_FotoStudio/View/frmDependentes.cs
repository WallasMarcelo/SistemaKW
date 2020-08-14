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
    public partial class frmDependentes : frmBase
    {
        public frmDependentes()
        {
            InitializeComponent();
        }

        private string CPFCleinte
        {
            get
            {
                mskCPFCliente.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                string texto = mskCPFCliente.Text;
                mskCPFCliente.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
                return texto;
            }

            set
            {
                mskCPFCliente.Text = value;
            }
        }

        private string NomeCliente { get => txtNome.Text; set => txtNome.Text = value; }
        private string NomeDependente { get => txtNomeDependente.Text; set => txtNomeDependente.Text = value; }
        private DateTime DataNasc_Depentente { get => dptDependente.Value; set => dptDependente.Value = value; }

        private void frmDependentes_Load(object sender, EventArgs e)
        {

        }
    }
}
