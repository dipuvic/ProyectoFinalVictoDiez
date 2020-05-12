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


        // >>> LOAD Del Formulario Proveedores
        private void FormClientes_Load(object sender, EventArgs e)
        {
            MostrarClientes();
            FormatoFormularioIngresar();
        }


        // >>> Formato mensaje emergente "Rellenar para BUSCAR"

           
            // <<<<< Pendiente de hacer >>>>>
            


        // >>> Formato formulario Clientes
        private void FormatoFormularioIngresar()
        {
            var margin = BtnIngresar.Margin;
            margin.Left = 115;
            BtnIngresar.Margin = margin;
            BtnCancelar.Visible = false;
            BtnIngresar.Text = "Ingresar";
            LblTituloClientes.Text = "ALTA USUARIO";
            LimpiarFormulario();
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


        // >>> Funciones del formulario Clientes
        private void MostrarClientes()
        {
            D_Clientes objetoD = new D_Clientes();
            DgvClientes.DataSource = objetoD.MostrarClietes();
        }

        private void BuscarCliente(string nombre, string municipio, string provincia, string codpostal)
        {
            D_Clientes objetoDBuscar = new D_Clientes();
            DgvClientes.DataSource = objetoDBuscar.BuscarCliente(nombre, municipio, provincia, codpostal);
        }

        // >>> Eventos del Formulario Clientes
        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            //INGRESAR NUEVO PRODUCTO en la tabla producto de nuestra Base de Datos.

            if (editar == false)
            {
                try
                {

                    objetoD.InsertarCliente(TxtNombre.Text, TxtNIF.Text, TxtCalle.Text, CbxMunicipio.Text, CbxProvincia.Text, TxtCodPostal.Text, TxtTelf.Text, TxtEmail.Text);
                    MessageBox.Show("Se ha AÑADIDO un nuevo cliente." + TxtNombre.Text);
                    LimpiarFormulario();
                    MostrarClientes();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se ha podido ingresar el cliente por: " + ex);
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

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
            FormatoFormularioIngresar();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (DgvClientes.SelectedRows.Count > 0)
            {
                editar = true;
                var margin = BtnIngresar.Margin;
                margin.Left = 40;
                BtnIngresar.Margin = margin;
                BtnCancelar.Visible = true;
                BtnIngresar.Text = "Guardar";
                LblTituloClientes.Text = "EDITAR CLIENTE";
                selectedclient = DgvClientes.CurrentRow.Cells["Código"].Value.ToString();
                TxtNombre.Text = DgvClientes.CurrentRow.Cells["Nombre"].Value.ToString();
                TxtNIF.Text = DgvClientes.CurrentRow.Cells["NIF"].Value.ToString();
                TxtCalle.Text = DgvClientes.CurrentRow.Cells["Calle"].Value.ToString();
                CbxMunicipio.Text = DgvClientes.CurrentRow.Cells["Municipio"].Value.ToString();
                CbxProvincia.Text = DgvClientes.CurrentRow.Cells["Provincia"].Value.ToString();
                TxtCodPostal.Text = DgvClientes.CurrentRow.Cells["CP"].Value.ToString();
                TxtTelf.Text = DgvClientes.CurrentRow.Cells["Teléfono"].Value.ToString();
                TxtEmail.Text = DgvClientes.CurrentRow.Cells["Email"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Seleccione una fila de la tabla");
            }
        }

        private void TxtBNombre_TextChanged(object sender, EventArgs e)
        {
            BuscarCliente(TxtBNombre.Text, CmbBMunicipio.Text, CmbBProvincia.Text, TxtBCodPostal.Text);
        }

        private void CmbBMunicipio_TextChanged(object sender, EventArgs e)
        {
            BuscarCliente(TxtBNombre.Text, CmbBMunicipio.Text, CmbBProvincia.Text, TxtBCodPostal.Text);
        }

        private void CmbBProvincia_TextChanged(object sender, EventArgs e)
        {
            BuscarCliente(TxtBNombre.Text, CmbBMunicipio.Text, CmbBProvincia.Text, TxtBCodPostal.Text);
        }

        private void TxtBCodPostal_TextChanged(object sender, EventArgs e)
        {
            BuscarCliente(TxtBNombre.Text, CmbBMunicipio.Text, CmbBProvincia.Text, TxtBCodPostal.Text);
        }


    }
}
