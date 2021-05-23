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
    public partial class Pantalla_Evento : Form
    {
        public Pantalla_Evento()
        {
            InitializeComponent();
        }

        private void btnValorar_Click(object sender, EventArgs e)
        {
            Valoración valorac = new Valoración();
            valorac.Show();
        }
    }
}
