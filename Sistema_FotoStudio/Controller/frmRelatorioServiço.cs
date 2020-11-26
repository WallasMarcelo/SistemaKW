using Microsoft.Reporting.WinForms;
using Sistema_FotoStudio.Model;
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
    public partial class frmRelatorioServiço : Form
    {
        public frmRelatorioServiço()
        {
            InitializeComponent();
        }

        private void frmRelatorioServiço_Load(object sender, EventArgs e)
        {
            Servico servico = new Servico();
            DataTable dataTable = servico.PesquisarTodos();
            reportViewer1.LocalReport.DataSources.Clear();

            ReportDataSource rds = new ReportDataSource("DataSetServico", dataTable);
            reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.RefreshReport();

            this.reportViewer1.RefreshReport();
        }
    }
}
