using SistemaOdontologico.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaOdontologico
{
    public partial class Tratamientos : Form
    {
        public Tratamientos()
        {
            InitializeComponent();
        }

        public void CargarDatos(TratamientoBL tratamientosBL)
        { 
            
            listadeTratamientosBindingSource.DataSource = tratamientosBL.ListadeTratamientos;
     
}

        private void idLabel_Click(object sender, EventArgs e)
        {

        }

        private void precioLabel_Click(object sender, EventArgs e)
        {

        }

        private void descripcionLabel_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = " ";
            openFileDialog1.ShowDialog();

            var archivo = openFileDialog1.FileName;

            if (archivo  !="")
            {
                var fileInfo = new FileInfo(archivo);
                var fileStream = fileInfo.OpenRead();

                pictureBox1.Image = Image.FromStream(fileStream);

            }
        
         }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
        }
    }
    }
