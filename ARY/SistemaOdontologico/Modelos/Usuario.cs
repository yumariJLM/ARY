using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaOdontologico.Modelos
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Contrasena { get; set; }

        public bool PuedeVerCliente { get; set; }
        public bool PuedeVerFacturas { get; set; }
        public bool PuedeVerServicio { get; set; }

        public bool PuedeVerTratamiento { get; set; }


        public Usuario(int id, string nombre, string contrasena)
        {
            Id = id;
            Nombre = nombre;
            Contrasena = contrasena;
                
        }
    }
}
