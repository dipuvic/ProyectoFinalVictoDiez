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
            DgvClientes.DataSource = objetoD.MostrarClietes();
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                objetoD.InsertarCliente(TxtNombre.Text, TxtNIF.Text, TxtCalle.Text, TxtMunicipio.Text, TxtProvincia.Text, TxtCodPostal.Text, TxtTelf.Text, TxtEmail.Text);
                MessageBox.Show("Se ha guardado el Cliente");
                //Volvemos a cargar los clientes
                //MostrarClientes();
            }
            catch(Exception ex)
            {
                MessageBox.Show("No se ha podido guardar los datos por el siguiente motivo: " + ex);
            }

        }
    }
}
