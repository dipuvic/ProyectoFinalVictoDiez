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

        public FormProducto()
        {
            InitializeComponent();
        }
        private void MostrarProductos()
        {
            D_Productos objetoD = new D_Productos();
            DgvProducto.DataSource = objetoD.MostrarProductos();
        }

        private void FormProducto_Load(object sender, EventArgs e)
        {
            MostrarProductos();
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                D_Productos objetoinsertar = new D_Productos();

                objetoD.InsertarProducto(TxtDescripcion.Text, TxtPrecio.Text);
                MostrarProductos();
            }
            catch(Exception ex)
            {
                MessageBox.Show("No se ha podido ingresar el producto por: " + ex);
            }
        }
    }
}
