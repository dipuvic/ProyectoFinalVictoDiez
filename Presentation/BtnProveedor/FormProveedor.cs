using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain;
using Common.Cache;

namespace Presentation.BtnProveedor
{
    public partial class FormProveedor : Form
    {
        D_Proveedor objetoD = new D_Proveedor();
        private bool editar = false;
        private string selectedproveedor;

        public FormProveedor()
        {
            InitializeComponent();
        }

        // >>> LOAD Del Formulario Proveedores
        private void FormProveedor_Load(object sender, EventArgs e)
        {
            LimpiarFormulario();
            MostrarProveedores();
            FormatoFormularioIngresar();
        }

        // >>> Formato mensaje emergente "Rellenar para BUSCAR"
        private void flowLayoutPanel7_MouseHover(object sender, EventArgs e)
        {
            if (TxtBNombre.Text == String.Empty || TxtBNIF.Text == String.Empty || TxtBEmail.Text == String.Empty || CmbBMunicipio.Text == String.Empty || CmbBProvincia.Text == String.Empty || TxtCP.Text == String.Empty)
            {
                this.Ttmensaje.SetToolTip(flowLayoutPanel7, "Rellene los campos para búsqueda automática");
            }

        }

        // >>> Funciones del formulario Proveedores
        private void LimpiarFormulario()
        {
            TxtNombre.Text = String.Empty;
            TxtNIF.Text = String.Empty;
            CmbMunicipio.Text = String.Empty;
            CmbProvincia.Text = String.Empty;
            CmbPais.Text = String.Empty;
            TxtCalle.Text = String.Empty;
            TxtCP.Text = String.Empty;
            TxtEmail.Text = String.Empty;
            TxtTelf.Text = String.Empty;
        }

        private void MostrarProveedores()
        {
            D_Proveedor objetoD = new D_Proveedor();
            DgvProveedor.DataSource = objetoD.MostrarProveedores();
        }

        private void FormatoFormularioIngresar()
        {
            var margin = BtnIngresar.Margin;
            margin.Left = 300;
            BtnIngresar.Margin = margin;
            BtnCancelar.Visible = false;
            BtnIngresar.Text = "Ingresar";
            LblTituloProveedor.Text = "ALTA Proveedor";
            LimpiarFormulario();
        }

        private void BuscarProveedor(string nombre, string nif, string email, string municipio, string provincia, string cp)
        {
            D_Proveedor objetoDBuscar = new D_Proveedor();
            DgvProveedor.DataSource = objetoDBuscar.BuscarProveedor(nombre, nif, email, municipio, provincia, cp);
        }


        // >>>  Eventos del Formulario Proveedores

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            if (editar == false)
            {
                try
                {
                    objetoD.InsertarProveedor(TxtNombre.Text, TxtNIF.Text, CmbMunicipio.Text, CmbBProvincia.Text, CmbPais.Text, TxtCalle.Text, TxtCP.Text, TxtEmail.Text, TxtTelf.Text);
                    MessageBox.Show("Se ha AÑADIDO un nuevo Proveedor: " + " " + TxtNombre.Text);
                    LimpiarFormulario();
                    MostrarProveedores();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se ha podido ingresar el proveedor por: " + ex);
                }
            }

            //EDITAR proveedor seleccionado EN DataGridView DgvProductos.
            if (editar == true)
            {
                try
                {
                    objetoD.EditarProveedor(selectedproveedor, TxtNombre.Text, TxtNIF.Text, CmbMunicipio.Text, CmbProvincia.Text, CmbPais.Text, TxtCalle.Text, TxtCP.Text, TxtEmail.Text, TxtTelf.Text);
                    MostrarProveedores();
                    MessageBox.Show("Se ha EDITADO el proveedor seleccionado.");
                    LimpiarFormulario();
                    FormatoFormularioIngresar();
                    editar = false;
                    BtnIngresar.Text = "Ingresar";
                    LblTituloProveedor.Text = "ALTA PROVEEDOR";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se ha podido editar los datos por: " + ex);
                }
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
            FormatoFormularioIngresar();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (DgvProveedor.SelectedRows.Count > 0)
            {
                editar = true;
                var margin = BtnIngresar.Margin;
                margin.Left = 235;
                BtnIngresar.Margin = margin;
                BtnCancelar.Visible = true;
                BtnIngresar.Text = "Guardar";
                LblTituloProveedor.Text = "EDITAR CLIENTE";
                selectedproveedor = DgvProveedor.CurrentRow.Cells["Código"].Value.ToString();
                TxtNombre.Text = DgvProveedor.CurrentRow.Cells["Nombre"].Value.ToString();
                TxtNIF.Text = DgvProveedor.CurrentRow.Cells["NIF"].Value.ToString();
                CmbMunicipio.Text = DgvProveedor.CurrentRow.Cells["Municipio"].Value.ToString();
                CmbProvincia.Text = DgvProveedor.CurrentRow.Cells["Provincia"].Value.ToString();
                CmbPais.Text = DgvProveedor.CurrentRow.Cells["País"].Value.ToString();
                TxtCalle.Text = DgvProveedor.CurrentRow.Cells["Calle"].Value.ToString();
                TxtCP.Text = DgvProveedor.CurrentRow.Cells["CP"].Value.ToString();
                TxtEmail.Text = DgvProveedor.CurrentRow.Cells["Email"].Value.ToString();
                TxtTelf.Text = DgvProveedor.CurrentRow.Cells["Teléfono"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Seleccione una fila de la tabla");
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (DgvProveedor.SelectedRows.Count > 0)
            {
                selectedproveedor = DgvProveedor.CurrentRow.Cells["Código"].Value.ToString();
                MessageBox.Show(selectedproveedor);
                objetoD.EliminarProveedor(selectedproveedor);
                MostrarProveedores();
            }
            else
            {
                MessageBox.Show("Seleccione una fila de la tabla");
            }
        }

        private void TxtBNombre_TextChanged(object sender, EventArgs e)
        {
            BuscarProveedor(TxtBNombre.Text, TxtBNIF.Text, TxtBEmail.Text, CmbBMunicipio.Text, CmbBProvincia.Text, TxtBCP.Text);
        }

        private void TxtBNIF_TextChanged(object sender, EventArgs e)
        {
            BuscarProveedor(TxtBNombre.Text, TxtBNIF.Text, TxtBEmail.Text, CmbBMunicipio.Text, CmbBProvincia.Text, TxtBCP.Text);
        }

        private void TxtBEmail_TextChanged(object sender, EventArgs e)
        {
            BuscarProveedor(TxtBNombre.Text, TxtBNIF.Text, TxtBEmail.Text, CmbBMunicipio.Text, CmbBProvincia.Text, TxtBCP.Text);
        }

        private void CmbBMunicipio_TextChanged(object sender, EventArgs e)
        {
            BuscarProveedor(TxtBNombre.Text, TxtBNIF.Text, TxtBEmail.Text, CmbBMunicipio.Text, CmbBProvincia.Text, TxtBCP.Text);
        }

        private void CmbBProvincia_TextChanged(object sender, EventArgs e)
        {
            BuscarProveedor(TxtBNombre.Text, TxtBNIF.Text, TxtBEmail.Text, CmbBMunicipio.Text, CmbBProvincia.Text, TxtBCP.Text);
        }

        private void TxtBCP_TextChanged(object sender, EventArgs e)
        {
            BuscarProveedor(TxtBNombre.Text, TxtBNIF.Text, TxtBEmail.Text, CmbBMunicipio.Text, CmbBProvincia.Text, TxtBCP.Text);
        }
    }
}
