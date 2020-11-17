using Microsoft.Reporting.WinForms;
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
    public partial class frmRelatorioVenda : Form
    {
        public frmRelatorioVenda()
        {
            InitializeComponent();
        }

        private void frmRelatorioVenda_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            pesquisaControllerVenda vendaController = new pesquisaControllerVenda();
            DataTable dataTable = vendaController.pesquisaTodos();

            ReportDataSource rds = new ReportDataSource("DataSetVendas", dataTable);
            reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.RefreshReport();
        }
    }
}
