using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportShare
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        

        private void lblDestacadosBusc_Click(object sender, EventArgs e)
        {

        }

        private void btnfutbolbusc_Click(object sender, EventArgs e)
        {

        }

        private void btnBaloncestoBusc_Click(object sender, EventArgs e)
        {

        }

        private void btnTenisBusc_Click(object sender, EventArgs e)
        {

        }

        private void btnCiclismoBusc_Click(object sender, EventArgs e)
        {

        }

        private void btnAtletismoBusc_Click(object sender, EventArgs e)
        {

        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {

        }

        private void tkbPrecioCrear_Scroll(object sender, EventArgs e)
        {
            lblPrecioNumCrear.Text = tkbPrecioCrear.Value.ToString() + "$";
            lblPrecioNumCrear.Visible = true;
        }

        private void btnCerrarSesión_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
