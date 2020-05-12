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
using Domain;

namespace Presentation
{
    public partial class FormEquipo : Form
    {
        D_Equipo objetoD = new D_Equipo();
        private bool editar = false;
        private string iduser;
        private string cargo;
        private int selectedusuario = 1;
        

        public FormEquipo()
        {
            InitializeComponent();
        }

        private void FormEquipo_Load(object sender, EventArgs e)
        {
            FormatoFormularioIngresar();
            MostrarEquipo();
            ListarCargos();
            CmbCargo.Text = String.Empty;
            CmbBCargo.Text = String.Empty;

        }

        private void FormatoFormularioIngresar()
        {
            var margin = BtnIngresar.Margin;
            margin.Left = 115;
            BtnIngresar.Margin = margin;
            BtnCancelar.Visible = false;
            BtnIngresar.Text = "Ingresar";
            LblTituloEquipo.Text = "ALTA USUARIO";
            LblIDUser.Visible = false;
            TxtIDUser.Visible = false;
            LblLogin.Visible = true;
            TxtLogin.Visible = true;
            LblPassword.Visible = true;
            TxtPassword.Visible = true;
            LimpiarFormulario();
        }

        private void LimpiarFormulario()
        {
            CmbCargo.Text = String.Empty;
            TxtIDUser.Text = String.Empty;
            TxtLogin.Text = String.Empty;
            TxtPassword.Text = String.Empty;
            TxtNombre.Text = String.Empty;
            TxtApellido.Text = String.Empty;
            TxtTelf.Text = String.Empty;
            TxtEmail.Text = String.Empty;
        }

        private void ListarCargos()
        {
            D_Equipo objD = new D_Equipo();
            CmbCargo.DataSource = objD.ListarCargos();
            CmbCargo.DisplayMember = "cargo";
            CmbCargo.ValueMember = "idcargo";

            CmbBCargo.DataSource = objD.ListarCargos();
            CmbBCargo.DisplayMember = "cargo";
            CmbBCargo.ValueMember = "idcargo";

        }

        private void MostrarEquipo()
        {
            D_Equipo objetoD = new D_Equipo();
            DgvEquipo.DataSource = objetoD.MostrarEquipo();
        }

        private void BuscarUsuario(string nombre, string apellido, string cargo, string email)
        {
            D_Equipo objetoDBuscar = new D_Equipo();
            DgvEquipo.DataSource = objetoDBuscar.BuscarUsuario(nombre, apellido, cargo, email);
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            selectedusuario = CmbCargo.SelectedIndex + 1;

            if (editar == false)
            {
                try
                {
                    objetoD.InsertarUsuario(Convert.ToString(selectedusuario), TxtLogin.Text, TxtPassword.Text, TxtNombre.Text, TxtApellido.Text, TxtTelf.Text, TxtEmail.Text);
                    MessageBox.Show("Se ha AÑADIDO un nuevo usuario." + TxtNombre.Text +" "+ TxtApellido.Text);
                    LimpiarFormulario();
                    MostrarEquipo();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se ha podido ingresar el usuario por: " + ex);
                }
            }

            //EDITAR PRODUCTO SELECCIONADO EN DataGridView DgvProductos.
            if (editar == true)
            {
                try
                {
                    objetoD.EditarUsuario(TxtIDUser.Text, Convert.ToString(selectedusuario), TxtLogin.Text, TxtPassword.Text, TxtNombre.Text, TxtApellido.Text, TxtTelf.Text, TxtEmail.Text);
                    MostrarEquipo();
                    MessageBox.Show("Se ha EDITADO el usuario seleccionado.");
                    LimpiarFormulario();
                    editar = false;
                    BtnIngresar.Text = "Añadir";
                    LblTituloEquipo.Text = "Añadir nuevo producto";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se ha podido editar los datos del usuario por: " + ex);
                }
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            editar = false;
            LimpiarFormulario();
            FormatoFormularioIngresar();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (DgvEquipo.SelectedRows.Count > 0)
            {
                editar = true;
                var margin = BtnIngresar.Margin;
                margin.Left = 40;
                BtnIngresar.Margin = margin;
                BtnCancelar.Visible = true;
                BtnIngresar.Text = "Guardar";
                LblTituloEquipo.Text = "EDITAR PRODUCTO";
                cargo = DgvEquipo.CurrentRow.Cells["Cargo"].Value.ToString();

                if (cargo == "Administrador" || cargo == "Gerente" || cargo == "Jefe Departamento" || cargo == "Técnico")
                {
                    LblIDUser.Visible = true;
                    TxtIDUser.Visible = true;
                    LblLogin.Visible = true;
                    TxtLogin.Visible = true;
                    LblPassword.Visible = true;
                    TxtPassword.Visible = true;
                    CmbCargo.Text = DgvEquipo.CurrentRow.Cells["Cargo"].Value.ToString();
                    TxtIDUser.Text = DgvEquipo.CurrentRow.Cells["Código"].Value.ToString();
                    TxtLogin.Text = DgvEquipo.CurrentRow.Cells["Login"].Value.ToString();
                    TxtPassword.Text = DgvEquipo.CurrentRow.Cells["Password"].Value.ToString();
                    TxtNombre.Text = DgvEquipo.CurrentRow.Cells["Nombre"].Value.ToString();
                    TxtApellido.Text = DgvEquipo.CurrentRow.Cells["Apellido"].Value.ToString();
                    TxtTelf.Text = DgvEquipo.CurrentRow.Cells["Teléfono"].Value.ToString();
                    TxtEmail.Text = DgvEquipo.CurrentRow.Cells["Email"].Value.ToString();
                }
                else if (cargo == "Comercial" || cargo == "Recepción" || cargo == "Contabilidad" || cargo == "Importación")
                {
                    LblIDUser.Visible = true;
                    TxtIDUser.Visible = true;
                    LblLogin.Visible = false;
                    TxtLogin.Visible = false;
                    LblPassword.Visible = false;
                    TxtPassword.Visible = false;
                    CmbCargo.Text = DgvEquipo.CurrentRow.Cells["Cargo"].Value.ToString();
                    TxtIDUser.Text = DgvEquipo.CurrentRow.Cells["Código"].Value.ToString();
                    TxtNombre.Text = DgvEquipo.CurrentRow.Cells["Nombre"].Value.ToString();
                    TxtApellido.Text = DgvEquipo.CurrentRow.Cells["Apellido"].Value.ToString();
                    TxtTelf.Text = DgvEquipo.CurrentRow.Cells["Teléfono"].Value.ToString();
                    TxtEmail.Text = DgvEquipo.CurrentRow.Cells["Email"].Value.ToString();
                }

            }
            else
            {
                MessageBox.Show("Seleccione una fila de la tabla");
            }
        }


        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (DgvEquipo.SelectedRows.Count > 0)
            {
                iduser = DgvEquipo.CurrentRow.Cells["Código"].Value.ToString();
                objetoD.EliminarUsuario(iduser);
                MostrarEquipo();
            }
            else
            {
                MessageBox.Show("Seleccione una fila de la tabla");
            }
        }

        private void CmbCargo_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (CmbCargo.Text == "Administrador" || CmbCargo.Text == "Gerente" || CmbCargo.Text == "Jefe Departamento")
            {
                LblLogin.Visible = true;
                TxtLogin.Visible = true;
                LblPassword.Visible = true;
                TxtPassword.Visible = true;
            }
            else if (CmbCargo.Text == "Comercial" || CmbCargo.Text == "Recepción" || CmbCargo.Text == "Contabilidad" || CmbCargo.Text == "Importación")
            {
                LblLogin.Visible = false;
                TxtLogin.Visible = false;
                LblPassword.Visible = false;
                TxtPassword.Visible = false;
            }
        }

        private void TxtBNombre_TextChanged(object sender, EventArgs e)
        {
            BuscarUsuario(TxtBNombre.Text, TxtBApellido.Text, CmbBCargo.Text, TxtBEmail.Text);
        }

        private void TxtBApellido_TextChanged(object sender, EventArgs e)
        {
            BuscarUsuario(TxtBNombre.Text, TxtBApellido.Text, CmbBCargo.Text, TxtBEmail.Text);
        }

        private void CmbBCargo_TextChanged(object sender, EventArgs e)
        {
            BuscarUsuario(TxtBNombre.Text, TxtBApellido.Text, CmbBCargo.Text, TxtBEmail.Text);
        }

        private void TxtBEmail_TextChanged(object sender, EventArgs e)
        {
            BuscarUsuario(TxtBNombre.Text, TxtBApellido.Text, CmbBCargo.Text, TxtBEmail.Text);
        }
    }
}
