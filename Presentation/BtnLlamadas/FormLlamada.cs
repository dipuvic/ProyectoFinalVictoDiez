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

namespace Presentation.BtnLlamadas
{
    public partial class FormLlamada : Form
    {
        private string reference;

        public FormLlamada()
        {
            InitializeComponent();
        }

        private void FormLlamada_Load(object sender, EventArgs e)
        {
            ListarUsuarios();
            ListarClientes();
            ListarReferencias();
           // LimpiarFormulario();
            MostrarProductos();
        }

        private void LimpiarFormulario()
        {
            CmbCompi.Text = String.Empty;
            CmbCliente.Text = String.Empty;
            CmbRef.Text = String.Empty;
            TxtProblem.Text = String.Empty;
            TxtObserva.Text = String.Empty;
        }
        private void ListarUsuarios()
        {
            D_Llamadas objLlamadas = new D_Llamadas();
            CmbCompi.DataSource = objLlamadas.ListarUsuarios();
            CmbCompi.DisplayMember = "Persona";
            CmbCompi.ValueMember = "id_user";
        }

        private void ListarClientes()
        {
            D_Llamadas objLlamadas = new D_Llamadas();
            CmbCliente.DataSource = objLlamadas.ListarClientes();
            CmbCliente.DisplayMember = "Cliente";
            CmbCliente.ValueMember = "id_cliente";
        }
        private void ListarReferencias()
        {
            D_Llamadas objLlamadas = new D_Llamadas();
            CmbRef.DataSource = objLlamadas.ListarReferencias();
            CmbRef.DisplayMember = "referencia";
        }

        private void MostrarProductos()
        {
            D_Llamadas objD = new D_Llamadas();
            DgvProducto.DataSource = objD.MostrarProductos();
        }

        private void BuscarRef(string referencia)
        {
            D_Llamadas objetoDBuscar = new D_Llamadas();
            if (CmbRef.Text == "")
            {
                DgvProducto.DataSource = objetoDBuscar.BuscarRef(reference);
            }
            else if (CmbRef.Text == " ")
            {
                CmbRef.Text = String.Empty;
                DgvProducto.DataSource = objetoDBuscar.BuscarRef(reference);
            }
            else if (CmbRef.Text != String.Empty)
            {
                DgvProducto.DataSource = objetoDBuscar.BuscarRef(referencia);
            }
        }

        private void CmbRef_TextChanged(object sender, EventArgs e)
        {
            BuscarRef(CmbRef.Text);
        }
    }
}
