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
    public partial class Producto : Form
    {
        D_Productos objetoD = new D_Productos();

        public Producto()
        {
            InitializeComponent();
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            objetoD.InsertarProducto(TxtDescripcion.Text, TxtPrecio.Text);
        }
    }
}
