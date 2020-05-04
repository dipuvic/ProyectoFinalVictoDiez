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

namespace Presentation.BtnClientes
{
    
    public partial class FormClientes : Form
    {
        D_Clientes objetoD = new D_Clientes();
        private bool editar = false;
        private string selectedclient;

        public FormClientes()
        {
            InitializeComponent();
        }

        private void FormClientes_Load(object sender, EventArgs e)
        {
            MostrarClientes();
        }

        private void MostrarClientes()
        {
            D_Clientes objetoD = new D_Clientes();
            DgvClientes.DataSource = objetoD.MostrarClietes();
        }
        private void LimpiarFormulario()
        {
            TxtNombre.Clear();
            TxtNIF.Clear();
            TxtCalle.Clear();
            CbxMunicipio.Text = "";
            CbxProvincia.Text = "";
            TxtCodPostal.Clear();
            TxtTelf.Clear();
            TxtEmail.Clear();
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            //INGRESAR NUEVO PRODUCTO en la tabla producto de nuestra Base de Datos.

            if (editar == false)
            {
                try
                {
                    D_Productos objetoinsertar = new D_Productos();

                    objetoD.InsertarCliente(TxtNombre.Text, TxtNIF.Text, TxtCalle.Text, CbxMunicipio.Text, CbxProvincia.Text, TxtCodPostal.Text, TxtTelf.Text, TxtEmail.Text);
                    MessageBox.Show("Se ha AÑADIDO un nuevo cliente." + TxtNombre.Text);
                    LimpiarFormulario();
                    MostrarClientes();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se ha podido ingresar el producto por: " + ex);
                }
            }

            //EDITAR PRODUCTO SELECCIONADO EN DataGridView DgvProductos.
            if (editar == true)
            {
                try
                {
                    objetoD.EditarCliente(selectedclient, TxtNombre.Text, TxtNIF.Text, TxtCalle.Text, CbxMunicipio.Text, CbxProvincia.Text, TxtCodPostal.Text, TxtTelf.Text, TxtEmail.Text);
                    MostrarClientes();
                    MessageBox.Show("Se ha EDITADO el producto seleccionado.");
                    LimpiarFormulario();
                    editar = false;
                    BtnIngresar.Text = "Añadir";
                    LblTituloClientes.Text = "Añadir nuevo producto";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se ha podido editar los datos por: " + ex);
                }
            }
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (DgvClientes.SelectedRows.Count > 0)
            {
                editar = true;
                BtnIngresar.Text = "Guardar";
                LblTituloClientes.Text = "Editar cliente seleccionado";
                selectedclient = DgvClientes.CurrentRow.Cells["id_cliente"].Value.ToString();
                TxtNombre.Text = DgvClientes.CurrentRow.Cells["Nombre"].Value.ToString();
                TxtNIF.Text = DgvClientes.CurrentRow.Cells["NIF"].Value.ToString();
                TxtCalle.Text = DgvClientes.CurrentRow.Cells["Calle"].Value.ToString();
                CbxMunicipio.Text = DgvClientes.CurrentRow.Cells["Municipio"].Value.ToString();
                CbxProvincia.Text = DgvClientes.CurrentRow.Cells["Provincia"].Value.ToString();
                TxtCodPostal.Text = DgvClientes.CurrentRow.Cells["CodPostal"].Value.ToString();
                TxtTelf.Text = DgvClientes.CurrentRow.Cells["telf"].Value.ToString();
                TxtEmail.Text = DgvClientes.CurrentRow.Cells["Email"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Seleccione una fila de la tabla");
            }
        }
    }
}
