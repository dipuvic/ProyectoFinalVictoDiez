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
    public partial class FormProducto : Form
    {
        D_Productos objetoD = new D_Productos();
        private string idreferencia = null;
        private bool editar = false;

        public FormProducto()
        {
            InitializeComponent();
        }
        private void MostrarProductos()
        {
            D_Productos objetoD = new D_Productos();
            DgvProducto.DataSource = objetoD.MostrarProductos();
        }
        private void LimpiarFormulario()
        {
            TxtReferencia.Clear();
            TxtDescripcion.Clear();
            TxtCategoria.Clear();
            TxtPrecio.Clear();
        }

        private void FormProducto_Load(object sender, EventArgs e)
        {
            MostrarProductos();
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            if (editar==false)
            {
                //INGRESAR NUEVO PRODUCTO en la tabla producto de nuestra Base de Datos.
                try
                {
                    D_Productos objetoinsertar = new D_Productos();

                    objetoD.InsertarProducto(TxtDescripcion.Text, TxtPrecio.Text);
                    MessageBox.Show("Se ha AÑADIDO un nuevo producto.");
                    LimpiarFormulario();
                    MostrarProductos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se ha podido ingresar el producto por: " + ex);
                }
            }

            //EDITAR PRODUCTO SELECCIONADO EN DataGridView DgvProductos.
            if (editar==true)
            {
                try
                {
                    objetoD.EditarProducto(TxtReferencia.Text, TxtDescripcion.Text, TxtPrecio.Text);
                    MostrarProductos();
                    MessageBox.Show("Se ha EDITADO el producto seleccionado.");
                    LimpiarFormulario();
                    editar = false;
                    BtnIngresar.Text = "Añadir";
                    LblEdicionProducto.Text = "Añadir nuevo producto";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se ha podido editar los datos por: " + ex);
                }
            }

        }

        private void BtnEliminar_Click_1(object sender, EventArgs e)
        {
            if (DgvProducto.SelectedRows.Count > 0)
            {
                idreferencia = DgvProducto.CurrentRow.Cells["referencia"].Value.ToString();
                objetoD.EliminarProducto(idreferencia);
                MostrarProductos();
            }
        }

        private void BtnEditar_Click_1(object sender, EventArgs e)
        {
            if (DgvProducto.SelectedRows.Count > 0)
            {
                editar = true;
                BtnIngresar.Text = "Guardar";
                LblEdicionProducto.Text = "Editar producto seleccionado";
                TxtReferencia.Text = DgvProducto.CurrentRow.Cells["referencia"].Value.ToString();
                TxtDescripcion.Text = DgvProducto.CurrentRow.Cells["descripcion"].Value.ToString();
                TxtPrecio.Text = DgvProducto.CurrentRow.Cells["precio"].Value.ToString();
                idreferencia = DgvProducto.CurrentRow.Cells["referencia"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Seleccione una fila de la tabla");
            }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                objetoD.BuscarProducto(TxtRefBuscar.Text, TxtDescripBuscar.Text);
                MostrarProductos();
                MessageBox.Show("Se ha realizado la búsqueda.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se ha podido buscar el producto por: " + ex);
            }
        }
    }
}
