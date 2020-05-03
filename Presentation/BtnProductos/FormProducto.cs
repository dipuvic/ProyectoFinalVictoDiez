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

        private void FormProducto_Load(object sender, EventArgs e)
        {
            MostrarProductos();
            ListarCategorias();
        }

        private void ListarCategorias()
        {
            D_Productos objD = new D_Productos();
            CmbCategoria.DataSource = objD.ListarCategorias();
            CmbCategoria.DisplayMember = "catpadre";
            CmbCategoria.ValueMember = "idcat";

        }

        private void MostrarProductos()
        {
            D_Productos objetoDMostrar = new D_Productos();
            DgvProducto.DataSource = objetoDMostrar.MostrarProductos();
        }
        private void BuscarProducto(string referencia)
        {
            D_Productos objetoDBuscar = new D_Productos();
            DgvProducto.DataSource = objetoDBuscar.BuscarProducto(referencia);
        }

        private void LimpiarFormulario()
        {
            TxtReferencia.Clear();
            TxtDescripcion.Clear();
            TxtPrecio.Clear();
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(CmbCategoria.SelectedIndex.ToString());
            //INGRESAR NUEVO PRODUCTO en la tabla producto de nuestra Base de Datos.
            
            if (editar==false)
            {
                try
                {
                    D_Productos objetoinsertar = new D_Productos();
                    
                    objetoD.InsertarProducto(CmbCategoria.SelectedIndex.ToString(), TxtDescripcion.Text, TxtPrecio.Text);
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
                idreferencia = DgvProducto.CurrentRow.Cells["Referencia"].Value.ToString();
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
                TxtReferencia.Text = DgvProducto.CurrentRow.Cells["Referencia"].Value.ToString();
                TxtDescripcion.Text = DgvProducto.CurrentRow.Cells["Descripción"].Value.ToString();
                TxtPrecio.Text = DgvProducto.CurrentRow.Cells["Precio"].Value.ToString();
                CmbCategoria.Text = DgvProducto.CurrentRow.Cells["Categoria"].Value.ToString();
                idreferencia = DgvProducto.CurrentRow.Cells["Referencia"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Seleccione una fila de la tabla");
            }
        }

        private void iBtnBuscar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(TxtBReferencia.Text);
            if (TxtBReferencia.Text == String.Empty)
            {
                MostrarProductos();
                MessageBox.Show("No se ha introducido ninguna referencia");
            }
            else
            {
                MessageBox.Show("Buscar:", TxtBReferencia.Text);
                BuscarProducto(TxtBReferencia.Text);
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MostrarProductos();
        }
    }
}
