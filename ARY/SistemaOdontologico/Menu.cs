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
    public partial class Menu : Form

    {
        ClienteBL _clientesBL;
        ServiciosBL _serviciosBL;
        TratamientoBL _tratamientosBL;
        FacturaBL _facturasBL;
        UsuariosBL _usuariosBL;

        public Menu()
        {
            InitializeComponent();
            _clientesBL = new ClienteBL();
            _serviciosBL = new ServiciosBL();
            _tratamientosBL = new TratamientoBL();
            _facturasBL = new FacturaBL();
            _usuariosBL = new BL.UsuariosBL();

        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formclientes = new Clientes();
            formclientes.MdiParent = this;
            formclientes.CargarDatos(_clientesBL, _serviciosBL);
            formclientes.Show();
        }

        private void serviciosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formtratamiento = new Tratamientos ();
            formtratamiento.MdiParent = this;
            formtratamiento.CargarDatos(_tratamientosBL);
            formtratamiento.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
                Application.Exit();
           
        }

        private void facturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formFactura = new Factura();
            formFactura.MdiParent = this;

            formFactura.CargarDatos(_facturasBL, _clientesBL, _tratamientosBL);

            formFactura.Show();

        }

        private void Menu_Load(object sender, EventArgs e)
        {
            var login = new login();
            login.CargarDatos(_usuariosBL);
            login.ShowDialog();

            facturasToolStripMenuItem.Visible = login.UsuarioAutenticado.PuedeVerFacturas;
            serviciosToolStripMenuItem.Visible = login.UsuarioAutenticado.PuedeVerServicio;
            clientesToolStripMenuItem.Visible = login.UsuarioAutenticado.PuedeVerCliente;
        }

        private void tratamientosAplicadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formReportesTratamientos = new FormReportesTratamientos();
           formReportesTratamientos.MdiParent = this;
            formReportesTratamientos.CargarDatos(_tratamientosBL);

            formReportesTratamientos.Show();
        }

        private void facturasToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            var formReportesFacturas = new FormReporteDeFacturas();
            formReportesFacturas.MdiParent = this;
            formReportesFacturas.CargarDatos(_facturasBL, _clientesBL);

            formReportesFacturas.Show();

        }

        private void reportesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
