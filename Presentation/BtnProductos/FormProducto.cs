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
        private string reference;

        public FormProducto()
        {
            InitializeComponent();
        }

        private void FormProducto_Load(object sender, EventArgs e)
        {
            MostrarProductos();
            ListarCategorias();
            CmbCategoria.Text = String.Empty;
            CmbBCategoria.Text = String.Empty;
        }

        private void ListarCategorias()
        {
            D_Productos objD = new D_Productos();
            CmbCategoria.DataSource = objD.ListarCategorias();
            CmbCategoria.DisplayMember = "catpadre";
            CmbCategoria.ValueMember = "idcat";

            CmbBCategoria.DataSource = objD.ListarCategorias();
            CmbBCategoria.DisplayMember = "catpadre";
            CmbBCategoria.ValueMember = "idcat";

        }

        private void MostrarProductos()
        {
            D_Productos objetoDMostrar = new D_Productos();
            DgvProducto.DataSource = objetoDMostrar.MostrarProductos();
        }
        private void BuscarProducto(string descripcion, string categoria, string referencia)
        {
            D_Productos objetoDBuscar = new D_Productos();

            if (TxtBReferencia.Text == "")
            {
                DgvProducto.DataSource = objetoDBuscar.BuscarProducto(descripcion, categoria, reference);
            }
            else if (TxtBReferencia.Text == " ")
            {
                TxtBReferencia.Text = String.Empty;
                DgvProducto.DataSource = objetoDBuscar.BuscarProducto(descripcion, categoria, reference);
            }
            else if (TxtBReferencia.Text != String.Empty)
            {
                DgvProducto.DataSource = objetoDBuscar.BuscarProducto(descripcion, categoria, referencia);
            }
        }


        private void LimpiarFormulario()
        {
            TxtReferencia.Clear();
            LblReferencia.Visible = false;
            TxtReferencia.Visible = false;
            BtnCancelar.Visible = false;
            TxtDescripcion.Clear(); 
            TxtPrecio.Clear();
            CmbCategoria.Text = String.Empty;
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

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            editar = false;
            LimpiarFormulario();
            BtnIngresar.Text = "Añadir";
            LblEdicionProducto.Text = "Añadir nuevo producto";
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (DgvProducto.SelectedRows.Count > 0)
            {
                editar = true;
                LblReferencia.Visible = true;
                TxtReferencia.Visible = true;
                BtnCancelar.Visible = true;
                BtnIngresar.Text = "Guardar";
                LblEdicionProducto.Text = "EDITAR PRODUCTO";
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

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (DgvProducto.SelectedRows.Count > 0)
            {
                idreferencia = DgvProducto.CurrentRow.Cells["Referencia"].Value.ToString();
                objetoD.EliminarProducto(idreferencia);
                MostrarProductos();
            }
            else
            {
                MessageBox.Show("Seleccione una fila de la tabla");
            }
        }


        private void TxtBReferencia_TextChanged(object sender, EventArgs e)
        {

            BuscarProducto(TxtBDescripcion.Text, CmbBCategoria.Text, TxtBReferencia.Text);
        }

        private void TxtBDescripcion_TextChanged(object sender, EventArgs e)
        {
            BuscarProducto(TxtBDescripcion.Text, CmbBCategoria.Text, TxtBReferencia.Text);
        }

        private void CmbBCategoria_TextChanged(object sender, EventArgs e)
        {
            BuscarProducto(TxtBDescripcion.Text, CmbBCategoria.Text, TxtBReferencia.Text);
        }

        //MOSTRAR TODOS LOS PRODUTOS
        private void iBtnBuscar_Click(object sender, EventArgs e)
        {
            MostrarProductos();
            TxtBReferencia.Text = String.Empty;
            TxtBDescripcion.Text = String.Empty;
            CmbBCategoria.Text = String.Empty;
        }


    }
}
