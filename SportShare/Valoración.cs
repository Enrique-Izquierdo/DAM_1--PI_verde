using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SportShare.Clase;

namespace SportShare
{
    public partial class Valoración : Form
    {
        public Valoración()
        {
            InitializeComponent();
        }

        private void picboxSonriente_Click(object sender, EventArgs e)
        {
            Datos.val.Contenido_Valoracion="Contento";
        }

        private void picboxNeutral_Click(object sender, EventArgs e)
        {
            Datos.val.Contenido_Valoracion = "Neutral";
        }

        private void picboxTriste_Click(object sender, EventArgs e)
        {
            Datos.val.Contenido_Valoracion = "Triste";
            
        }
    }
}
