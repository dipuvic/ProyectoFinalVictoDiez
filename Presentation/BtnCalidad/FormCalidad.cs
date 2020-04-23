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

namespace Presentation.BtnCalidad
{
    public partial class FormCalidad : Form
    {
        public FormCalidad()
        {
            InitializeComponent();
        }

        private void FormCalidad_Load(object sender, EventArgs e)
        {
            TxtUsuario.Text = UserLoginCache.Nombre + " " + UserLoginCache.Apellido;
        }
    }
}
