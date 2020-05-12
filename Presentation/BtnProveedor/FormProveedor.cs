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
        }

        // >>> Forrmato mensaje emergente "Rellenar para BUSCAR"
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
            TxtNombre.Text = String.Empty;
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

            //EDITAR PRODUCTO SELECCIONADO EN DataGridView DgvProductos.
            if (editar == true)
            {
                selectedproveedor = DgvProveedor.CurrentRow.Cells["Código"].Value.ToString();
                try
                {
                    objetoD.EditarProveedor(selectedproveedor, TxtNombre.Text, TxtNIF.Text, CmbMunicipio.Text, CmbProvincia.Text, CmbPais.Text, TxtCalle.Text, TxtCP.Text, TxtEmail.Text, TxtTelf.Text);
                    MostrarProveedores();
                    MessageBox.Show("Se ha EDITADO el proveedor seleccionado.");
                    LimpiarFormulario();
                    editar = false;
                    BtnIngresar.Text = "Añadir";
                    LblTituloProveedor.Text = "Añadir nuevo producto";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se ha podido editar los datos por: " + ex);
                }
            }
        }
    }
}
