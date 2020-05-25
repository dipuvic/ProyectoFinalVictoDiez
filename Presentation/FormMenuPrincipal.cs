using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using Common.Cache;
using Presentation.BtnClientes;
using Presentation.BtnCalidad;
using Presentation.BtnLlamadas;
using Presentation.BtnProveedor;
using Presentation.BtnAlmacen;

namespace Presentation
{

    public partial class FormMenuPrincipal : Form
    {
        public FormMenuPrincipal()
        {
            InitializeComponent();
        }

        //FUNCIÓN PARA ABRIR FORMULARIOS
        public void AbrirFormulario<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            formulario = PanelFormularios.Controls.OfType<MiForm>().FirstOrDefault();//Busca en la coleccion el formulario
                                                                                     //si el formulario/instancia no existe
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                PanelFormularios.Controls.Add(formulario);
                PanelFormularios.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
            }
            //si el formulario/instancia existe
            else
            {
                formulario.BringToFront();
            }
        }

        //Cargar datos de usuario de la capa COMMON.UserLoginCache()
        private void LoadUserData()
        {
            LblNombre.Text = UserLoginCache.Nombre + " " + UserLoginCache.Apellido;
            LblCargo.Text = UserLoginCache.Cargo;
            PrivilegiosUsuario();
        }

        private void CleanMenu()
        {
            iBtnEquipo.BackColor = Color.Empty;
            iBtnClientes.BackColor = Color.Empty;
            iBtnProveedor.BackColor = Color.Empty;
            iBtnProductos.BackColor = Color.Empty;
            iBtnCalidad.BackColor = Color.Empty;
            iBtnAlmacen.BackColor = Color.Empty;
            iBtnLlamadas.BackColor = Color.Empty;
        }

        //Administrar privilegios
        private void PrivilegiosUsuario()
        {
            if (UserLoginCache.Cargo == Cargos.Administrador)
            {
                //Código - Configurar estadísticas principales
            }
            if (UserLoginCache.Cargo == Cargos.Gerente)
            {
                //Código - Configurar estadísticas principales
            }
            if (UserLoginCache.Cargo == Cargos.JefeDepartamento)
            {
                //Código - Configurar estadísticas principales
            }
            if (UserLoginCache.Cargo == Cargos.Tecnico)
            {
                iBtnProveedor.Visible = false;
            }
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            AbrirFormulario<FormPanelPrincipal>();
            LoadUserData();
        }

        private void iBtnMenu_Click(object sender, EventArgs e)
        {
            //Gestiono el ancho del PanelVertical (Menú
            if(PanelVertical.Width == 45)
            {
                PanelVertical.Width = 160;


                iBtnUser.IconSize = 45;
                LblNombre.Visible = true;
                LblCargo.Visible = true;
                LblMenu.Width = 155;
                SeparadorMenu1.Width = 155;

            }
            else
            {
                PanelVertical.Width = 45;

                iBtnUser.IconSize = 32;
                LblNombre.Visible = false;
                LblCargo.Visible = false;
                LblMenu.Width = 45;
                SeparadorMenu1.Width = 35;


            }
        }

        private void PbxLogo_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormPanelPrincipal>();
        }

        private void iBtnUser_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormUsuario>();
            CleanMenu();
        }

        private void iBtnLogout_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Está seguro que desea cerrar sesión?", "Warning",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                this.Close();
        }

        private void iBtnEquipo_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormEquipo>();
            CleanMenu();
            iBtnEquipo.BackColor = Color.DimGray;
        }
        private void iBtnClientes_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormClientes>();
            CleanMenu();
            iBtnClientes.BackColor = Color.DimGray;
        }

        private void iBtnProveedor_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormProveedor>();
            CleanMenu();
            iBtnProveedor.BackColor = Color.DimGray;
        }

        private void iBtnProductos_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormProducto>();
            CleanMenu();
            iBtnProductos.BackColor = Color.DimGray;
        }

        private void iBtnCalidad_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormCalidad>();
            CleanMenu();
            iBtnCalidad.BackColor = Color.DimGray;
        }

        private void iBtnAlmacen_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormAlmacen>();
            CleanMenu();
            iBtnAlmacen.BackColor = Color.DimGray;
        }

        private void iBtnLlamadas_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormLlamada>();
            CleanMenu();
            iBtnLlamadas.BackColor = Color.DimGray;
        }


    }
}
