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
    public partial class FormReportesTratamientos : Form
    {
        public FormReportesTratamientos()
        {
            InitializeComponent();
        }

        public void CargarDatos(TratamientoBL tratamientosBL)
        {
            var bindingSource = new BindingSource();
            bindingSource.DataSource = tratamientosBL.ListadeTratamientos;

            var reporte = new ReportedeTratamientos();
            reporte.SetDataSource(bindingSource);

            crystalReportViewer1.ReportSource = reporte;

            crystalReportViewer1.RefreshReport();
        }

        }
}
