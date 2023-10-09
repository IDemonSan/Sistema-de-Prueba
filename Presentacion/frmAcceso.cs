using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class frmAcceso : Form
    {
        public frmAcceso()
        {
            InitializeComponent();
        }
        Negocio_Usuario_Sistema Negocio_UserSistema = new Negocio_Usuario_Sistema();
        Entidad_Usuario_Sistema oUserSistema = new Entidad_Usuario_Sistema();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frmAcceso_Load(object sender, EventArgs e)
        {

        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            oUserSistema.nombre = txtUser.Text;
            oUserSistema.contraseña = txtPwd.Text;
            int men = Negocio_UserSistema.ValidarUsuario(oUserSistema);
            MessageBox.Show(men, "Mensaje");
            if (men == 1)
            {
                frmVista frmVistaCliente = new frmVista();
                frmVistaCliente.Show();
                this.Hide();
            }
            else
            {
                MessageBox("Error al acceder al sistema");
            }
        }
    }
}
