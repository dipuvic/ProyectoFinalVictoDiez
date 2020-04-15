using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain;
using Common.Cache;

namespace Presentation
{
    public partial class FormInicioSesion : Form
    {

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);


        UserModel usermodel = new UserModel();


        public FormInicioSesion()
        {
            InitializeComponent();
        }

        private void FormInicioSesion_Load(object sender, EventArgs e)
        {
            iPbxAlert.Visible = false;
            LblAlert.Visible = false;
        }


        private void iBtnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormInicioSesion_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void TxtUsuario_Leave(object sender, EventArgs e)
        {
            if (TxtUsuario.Text == "")
            {
                TxtUsuario.Text = "Usuario";
                TxtUsuario.ForeColor = Color.DimGray;
            }

        }

        private void TxtPassword_Leave(object sender, EventArgs e)
        {
            if (TxtPassword.Text == "")
            {
                TxtPassword.Text = "Contraseña";
                TxtPassword.ForeColor = Color.DimGray;
                TxtPassword.UseSystemPasswordChar = true;
            }
        }

        private void TxtUsuario_MouseClick(object sender, MouseEventArgs e)
        {
            if (TxtUsuario.Text == "Usuario")
            {
                TxtUsuario.Text = "";
                TxtUsuario.ForeColor = Color.LightGray;
            }
        }

        private void TxtPassword_MouseClick(object sender, MouseEventArgs e)
        {
            if (TxtPassword.Text == "Contraseña")
            {
                TxtPassword.Text = "";
                TxtPassword.ForeColor = Color.LightGray;
                TxtPassword.UseSystemPasswordChar = true;
            }
        }


        private void BtnAcceso_Click(object sender, EventArgs e)
        {
            if (TxtUsuario.Text != "Usuario" && TxtUsuario.TextLength > 2)
            {
                if (TxtPassword.Text != "Password")
                {
                    UserModel user = new UserModel();
                    var validLogin = user.LoginUser(TxtUsuario.Text, TxtPassword.Text);
                    if (validLogin == true)
                    {
                        FormMenuPrincipal mainMenu = new FormMenuPrincipal();
                        MessageBox.Show("Bienvenido " + UserLoginCache.Nombre + ", " + UserLoginCache.Apellido);
                        mainMenu.Show();
                        mainMenu.FormClosed += Logout;
                        this.Hide();
                    }
                    else
                    {
                        msgError("Incorrect username or password entered. \n   Please try again.");
                        TxtPassword.Text = "Password";
                        TxtPassword.UseSystemPasswordChar = false;
                        TxtUsuario.Focus();
                    }
                }
                else msgError("Please enter password.");
            }
            else msgError("Please enter username.");
        }
        private void msgError(string msg)
        {
            LblAlert.Text = "    " + msg;
            LblAlert.Visible = true;
        }
        private void Logout(object sender, FormClosedEventArgs e)
        {
            TxtPassword.Text = "Contraseña";
            TxtPassword.UseSystemPasswordChar = false;
            TxtUsuario.Text = "Usuario";
            LblAlert.Visible = false;
            this.Show();
        }
    }
}
