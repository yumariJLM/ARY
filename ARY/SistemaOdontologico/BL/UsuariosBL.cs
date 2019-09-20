using SistemaOdontologico.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaOdontologico.BL
{
    public class UsuariosBL
    {
        public BindingList<Usuario> ListadeUsuarios { get; set; }

        public UsuariosBL()
        {
            ListadeUsuarios = new BindingList<Usuario>();
            cargarDatosdePrueba();

        }

        private void cargarDatosdePrueba()
        {
            var usuarioAdmin = new Usuario(1, "yumari", "123");
            usuarioAdmin.PuedeVerCliente = true;
            usuarioAdmin.PuedeVerFacturas = true;
            usuarioAdmin.PuedeVerTratamiento = true;
            usuarioAdmin.PuedeVerServicio = true;

            var usuarioCaja = new Usuario(2, "angela", "456");
            usuarioCaja.PuedeVerFacturas = true;

            var usuarioCaja2 = new Usuario(3, "robert", "789");
            usuarioCaja2.PuedeVerFacturas = true;

            ListadeUsuarios.Add(usuarioAdmin);
            ListadeUsuarios.Add(usuarioCaja);
            ListadeUsuarios.Add(usuarioCaja2);
        }
        public Usuario Autenticar (string nombre, string contrasena)
        {
            foreach (var usuario in ListadeUsuarios )
            {
                if (usuario.Nombre == nombre && usuario.Contrasena == contrasena)
            {
                return usuario;
            }
        }
        return null;

        }
    }
}
