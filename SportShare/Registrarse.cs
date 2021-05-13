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
    public partial class Registrarse : Form
    {
        public Registrarse()
        {
            InitializeComponent();
        }

        ConexionBD bd = new ConexionBD();

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            bd.AbrirConexion();
            Usuario usu = new Usuario(txtIdUsu.Text, txtContraseñaRegist.Text, txtNombreRegist.Text, txtApellidosRegist.Text,Convert.ToDateTime(dtpFechNac.Value), Convert.ToDouble(txtPesoRegist.Text), Convert.ToDouble(txtAlturaRegist.Text), Convert.ToInt32(txtTlfRegist.Text), txtPoblaciónRegist.Text, txtProvinciaRegist.Text, cbxDeporteCrear.Text, txtEnfermedadesRegist.Text);
            usu.RegistrarUsuario(bd.Conexion, usu);
            bd.CerrarConexion();
        }
    }
}
