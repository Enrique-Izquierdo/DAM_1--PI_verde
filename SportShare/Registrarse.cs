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
        public bool ControlErrores()
        {
            bool ok = true;
            if (txtIdUsu.Text == "")
            {
                errores.SetError(txtIdUsu, "Introduzca un ID usuario");
                ok = false;
            }
            else
            {
                errores.Clear();
            }
            if (txtNombreRegist.Text == "")
            {
                errores.SetError(txtNombreRegist, "Introduzca su nombre");
                ok = false;
            }
            else
            {
                errores.Clear();
            }
            if (txtApellidosRegist.Text == "")
            {
                errores.SetError(txtApellidosRegist, "Introduzca sus apellidos");
                ok = false;
            }
            else
            {
                errores.Clear();
            }
            if (txtContraseñaRegist.Text == "")
            {
                errores.SetError(txtContraseñaRegist, "Introduzca una contraseña");
                ok = false;
            }
            else
            {
                errores.Clear();
            }
            if (txtPeso.Text == "")
            {
                errores.SetError(txtPeso, "Introduzca su peso");
                ok = false;
            }
            else
            {
                errores.Clear();
            }
            if (txtAlturaRegist.Text == "")
            {
                errores.SetError(txtAlturaRegist, "Introduzca su altura");
                ok = false;
            }
            else
            {
                errores.Clear();
            }
            if (txtTlfRegist.Text == "")
            {
                errores.SetError(txtPeso, "Introduzca su número teléfono");
                ok = false;
            }
            else
            {
                errores.Clear();
            }
            if (txtPoblaciónRegist.Text == "")
            {
                errores.SetError(txtPoblaciónRegist, "Introduzca su población");
                ok = false;
            }
            else
            {
                errores.Clear();
            }
            if (txtProvinciaRegist.Text == "")
            {
                errores.SetError(txtProvinciaRegist, "Introduzca su provincia");
                ok = false;
            }
            else
            {
                errores.Clear();
            }
            return ok;
        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            bd.AbrirConexion();
            if (ControlErrores())
            {
                if (Usuario.UsuarioExiste(bd.Conexion, txtIdUsu.Text))
                {
                    errores.SetError(txtIdUsu, "Ya hay alguien con este nombre de usuario");
                }
                else
                {
                    Usuario usu = new Usuario(txtIdUsu.Text, txtContraseñaRegist.Text, txtNombreRegist.Text, txtApellidosRegist.Text, dtpFechNac.Value, Convert.ToDouble(txtPeso.Text), Convert.ToDouble(txtAlturaRegist.Text), Convert.ToInt32(txtTlfRegist.Text), txtPoblaciónRegist.Text, txtProvinciaRegist.Text, cbxDeporte.Text, txtEnfermedadesRegist.Text);
                    usu.RegistrarUsuario(bd.Conexion, usu);

                    this.Close();
                }
            }
            
            
            bd.CerrarConexion();

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
