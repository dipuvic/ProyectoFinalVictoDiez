using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common.Cache;

namespace Presentation
{
    public partial class FormUsuario : Form
    {
        public FormUsuario()
        {
            InitializeComponent();
        }

        private void FormUsuario_Load(object sender, EventArgs e)
        {
            MostrarDatosUser();
        }

        private void MostrarDatosUser()
        {
            LblNombreApellido.Text = UserLoginCache.Nombre + " " + UserLoginCache.Apellido;
            LblCargo.Text = UserLoginCache.Cargo;
            LblTelefono.Text = UserLoginCache.Telefono;
            LblEmail.Text = UserLoginCache.Email;
        }

        private void iBtnLogout_Click(object sender, EventArgs e)
        {
            //Mejorar cerrado de sesion de usuario
            if (MessageBox.Show("Está seguro que desea cerrar sesión?", "Warning",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                this.Close();
                
        }
    }
}
