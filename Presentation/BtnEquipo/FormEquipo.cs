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

namespace Presentation
{
    public partial class FormEquipo : Form
    {
        public FormEquipo()
        {
            InitializeComponent();
        }

        private void FormEquipo_Load(object sender, EventArgs e)
        {
            LblNombreApellido.Text = UserLoginCache.Nombre + " " + UserLoginCache.Apellido;
            LblCargo.Text = UserLoginCache.Cargo;
            LblCargo.Text = UserLoginCache.Email;
        }
    }
}
