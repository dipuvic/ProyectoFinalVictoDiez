using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation
{
    public partial class FormPanelPrincipal : Form
    {
        public FormPanelPrincipal()
        {
            InitializeComponent();
        }


        private void FormPanelPrincipal_Load(object sender, EventArgs e)
        {
            TmrDate.Enabled = true;
            //Genera número aleatorio para mostrar frase culta
            Random rnd = new Random();
            int value = rnd.Next(1, 3);
            if (value == 0)
            {
                LblFrase.Text = "Locura es hacer lo mismo una y otra vez esperando obtener resultados diferentes";
            }
            else if (value == 1)
            {
                LblFrase.Text = "Hay dos cosas infinitas: el universo y la estupidez humana. Y del universo no estoy seguro.";
            }
            else if (value == 2)
            {
                LblFrase.Text = "En medio de la dificultad yace la oportunidad";
            }
            else if (value == 3)
            {
                LblFrase.Text = "Si no lo puedes explicar de forma simple, no lo entiendes suficientemente bien.";
            }
            else if (value == 4)
            {
                LblFrase.Text = "Intenta no volverte un hombre de éxito, sino volverte un hombre de valor.";
            }
            else if (value == 5)
            {
                LblFrase.Text = "Quien nunca ha cometido un error nunca ha intentado nada nuevo.";
            }
            else if (value == 6)
            {
                LblFrase.Text = "No tengo talentos especiales, pero sí soy profundamente curioso.";
            }
            else if (value == 7)
            {
                LblFrase.Text = "Si quieres vivir una vida feliz, átala a una meta, no a una persona o a un objeto.";
            }
            else if (value == 8)
            {
                LblFrase.Text = "Dios no juega a los dados con el universo.";
            }
            else if (value == 9)
            {
                LblFrase.Text = "La coincidencia es la forma en que Dios permanece anónimo.";
            }


        }

        private void TmrDate_Tick(object sender, EventArgs e)
        {
            LblFecha.Text = DateTime.Now.ToLongDateString();
            LblFecha.Text = DateTime.Now.ToLongDateString();
        }


    }
}
