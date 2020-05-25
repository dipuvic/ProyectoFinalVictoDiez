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

namespace Presentation.BtnAlmacen
{
    public partial class FormAlmacen : Form
    {
        D_Almacen objetoD = new D_Almacen();
        private string reference;


        public FormAlmacen()
        {
            InitializeComponent();
        }

        private void FormAlmacen_Load(object sender, EventArgs e)
        {
            MostrarAlmacen();
        }

        private void LimpiarFormulario()
        {
            TxtRef.Text = String.Empty;
            TxtLugar.Text = String.Empty;
            TxtProblem.Text = String.Empty;
        }

        private void MostrarAlmacen()
        {
            D_Almacen objetoDMostrar = new D_Almacen();
            DgvAlmacen.DataSource = objetoDMostrar.MostrarAlmacen();
        }

        private void InsertarAlmacen(string referencia, string lugar, string nota)
        {
            D_Almacen objetoinsertar = new D_Almacen();
            objetoinsertar.InsertarAlmacen(referencia, lugar, nota);
        }

        private void BuscarAlmacen(string referencia, string lugar)
        {
            D_Almacen objetoDBuscar = new D_Almacen();

            if (TxtBRef.Text == "")
            {
                DgvAlmacen.DataSource = objetoDBuscar.BuscarAlmacen(reference, lugar);
            }
            else if (TxtBRef.Text == " ")
            {
                TxtBRef.Text = String.Empty;
                DgvAlmacen.DataSource = objetoDBuscar.BuscarAlmacen(reference, lugar);
            }
            else if (TxtBRef.Text != String.Empty)
            {
                DgvAlmacen.DataSource = objetoDBuscar.BuscarAlmacen(referencia, lugar);
            }
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                InsertarAlmacen(TxtRef.Text, TxtLugar.Text, TxtProblem.Text);
                MessageBox.Show("Se ha AÑADIDO un nuevo producto.");
                LimpiarFormulario();
                MostrarAlmacen();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se ha podido ingresar el producto por: " + ex);
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void TxtBRef_TextChanged(object sender, EventArgs e)
        {
            BuscarAlmacen(TxtBRef.Text, TxtBLugar.Text);
        }

        private void TxtBLugar_TextChanged(object sender, EventArgs e)
        {
            BuscarAlmacen(TxtBRef.Text, TxtBLugar.Text);
        }
    }
}
