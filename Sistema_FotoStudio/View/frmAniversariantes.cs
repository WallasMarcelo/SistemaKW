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
    public partial class frmAniversariantes : Form
    {
        public frmAniversariantes(DataTable table)
        {
            InitializeComponent();
            preencherTabela(table);
        }


        public void preencherTabela(DataTable table)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = table;

            dataGridAniversario.DataSource = bs;//Colocar dados no DataGrid

        }
    }
}
