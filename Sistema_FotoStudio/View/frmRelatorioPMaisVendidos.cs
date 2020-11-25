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
    public partial class frmRelatorioPMaisVendidos : Form
    {
        public frmRelatorioPMaisVendidos()
        {
            InitializeComponent();
        }

        private void frmRelatorioPMaisVendidos_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            VendaController VendaController = new VendaController();
            DataTable dataTable = VendaController.pesquisarProdutosMaisVendidos();

            ReportDataSource rds = new ReportDataSource("DataSetPMaisVendidos", dataTable);
            reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.RefreshReport();
        }
    }
}
