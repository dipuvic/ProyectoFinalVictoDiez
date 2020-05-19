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

namespace Presentation.BtnLlamadas
{
    public partial class FormRegistro : Form
    {
        private string reference;

        public FormRegistro()
        {
            InitializeComponent();
        }

        private void FormRegistro_Load(object sender, EventArgs e)
        {
            MostrarRegistros();
        }

        private void MostrarRegistros()
        {
            D_Llamadas objD = new D_Llamadas();
            DgvRegistro.DataSource = objD.MostrarRegistros();
        }

        private void BuscarRegistro(string user, string cliente, string referencia)
        {
            D_Llamadas objetoDBuscar = new D_Llamadas();

            if (TxtRef.Text == "")
            {
                DgvRegistro.DataSource = objetoDBuscar.BuscarRegistro(user, cliente, reference);
            }
            else if (TxtRef.Text == " ")
            {
                TxtRef.Text = String.Empty;
                DgvRegistro.DataSource = objetoDBuscar.BuscarRegistro(user, cliente, reference);
            }
            else if (TxtRef.Text != String.Empty)
            {
                DgvRegistro.DataSource = objetoDBuscar.BuscarRegistro(user, cliente, referencia);
            }
        }

        private void TxtUsuario_TextChanged(object sender, EventArgs e)
        {
            BuscarRegistro(TxtUsuario.Text, TxtCliente.Text, TxtRef.Text);
        }

        private void TxtCliente_TextChanged(object sender, EventArgs e)
        {
            BuscarRegistro(TxtUsuario.Text, TxtCliente.Text, TxtRef.Text);
        }

        private void TxtRef_TextChanged(object sender, EventArgs e)
        {
            BuscarRegistro(TxtUsuario.Text, TxtCliente.Text, TxtRef.Text);
        }
    }
}
