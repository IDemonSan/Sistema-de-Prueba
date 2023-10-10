using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Negocio;
using Entidad;
using Datos;

namespace Presentacion
{
    public partial class LoginForm : Form
    {

        Entidad.Entidad_Usuario_Sistema obje = new Entidad.Entidad_Usuario_Sistema();
        Negocio.Negocio_Usuario_Sistema objn = new Negocio.Negocio_Usuario_Sistema();

        public LoginForm()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void FrmAcceso_Load(object sender, EventArgs e)
        {

        }

        private void BtnAcceder_Click(object sender, EventArgs e)
        {
            string nombreUsuario = txtNombreUsuario.Text;
            string contraseña = txtContraseña.Text;

            // Configura los valores del objeto de entidad con los datos del usuario
            obje.NOMBRE_USUARIO = nombreUsuario;
            obje.PASS = contraseña;

            // Llamar a la Capa de Negocio para validar las credenciales
            string mensajeError;
            bool usuarioValido = objn.N_Login(obje, out mensajeError);

            if (usuarioValido)
            {
                // Iniciar sesión exitosamente
                MessageBox.Show("Inicio de sesión exitoso.");
                // Aquí puedes redirigir a la página principal u otra acción
            }
            else
            {
                // Mostrar el mensaje de error obtenido de la Capa de Negocio
                MessageBox.Show("Credenciales incorrectas. Mensaje de error: " + mensajeError);
            }
        }

        private void TxtNombreUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
