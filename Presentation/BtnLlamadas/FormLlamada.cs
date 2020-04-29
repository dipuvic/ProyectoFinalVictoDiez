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
        public FormLlamada()
        {
            InitializeComponent();
        }

        private void FormLlamada_Load(object sender, EventArgs e)
        {
            ListarUsuarios();
            MostrarRegistroLlamadas();
        }

        private void ListarUsuarios()
        {
            D_Llamadas objLlamadas = new D_Llamadas();
            CmbUsuario.DataSource = objLlamadas.ListarUsuarios();
            CmbUsuario.DisplayMember = "Persona";
            CmbUsuario.ValueMember = "id_user";
        }

        private void MostrarRegistroLlamadas()
        {
            D_Llamadas objD = new D_Llamadas();
            DgvRegistro.DataSource = objD.MostrarRegistroLlamadas();
        }
    }
}
