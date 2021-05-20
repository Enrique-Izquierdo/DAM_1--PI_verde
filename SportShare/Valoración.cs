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
        ConexionBD bd = new ConexionBD();
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

        private void btnEnviarValoración_Click(object sender, EventArgs e)
        {

            if (Datos.val.Contenido_Valoracion == "")
            {
                errores.SetError(btnEnviarValoración, "No has marcado ninguna valoración");
            }
            else
            {
                Valoracion val = new Valoracion(Datos.val.Contenido_Valoracion, Datos.usu.Alias, Datos.act.Alias_creador, DateTime.Now);
                Valoracion.EnviarValoracion(bd.Conexion, val);
                MessageBox.Show("Tu valoracion se ha enviado con éxito");
                this.Close();
            }
                
           
        }

        private void Valoración_Load(object sender, EventArgs e)
        {
            txtIdUsu.Text = Datos.act.Alias_creador;
        }
    }
}
