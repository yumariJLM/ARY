using SistemaOdontologico.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaOdontologico
{
    public partial class FormReporteDeFacturas : Form
    {
        public FormReporteDeFacturas()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
        public void CargarDatos(FacturaBL facturaBL, ClienteBL clienteBL )
        {
            var bindingSource = new BindingSource();
            bindingSource.DataSource =
                from f in facturaBL.ListadeFacturas select new
                {
                    Id = f.Id,
                    Fecha = f.Fecha,
                    Cliente = clienteBL.
                    ListadeClientes
                    .FirstOrDefault( r => r.Id == f.ClienteId)
                    .Nombre,
                    Subtotal = f.Subtotal,
                    Impuesto = f.Impuesto,
                    Total= f.Total,
                    Activo= f.Activo
                };

            var reporte = new ReporteDeFacturas();
            reporte.SetDataSource(bindingSource);

            crystalReportViewer1.ReportSource = reporte;

            crystalReportViewer1.RefreshReport();

        }
    }
}
