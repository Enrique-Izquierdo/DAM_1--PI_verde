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
    public partial class IniciarSesión : Form
    {
        public IniciarSesión()
        {
            InitializeComponent();
        }
<<<<<<< HEAD
        public bool ControlErrores()
        {
            bool ok = true;
            if (txtNomUsu.Text == "")
            {
                errores.SetError(txtNomUsu, "Introduzca un ID usuario");
                ok = false;
            }
            else
            {
                errores.Clear();
            }
            if (txtContraseña.Text == "")
            {
                errores.SetError(txtContraseña, "Introduzca su contraseña");
                ok = false;
            }
            else
            {
                errores.Clear();
            }
            return ok;
        }
            ConexionBD bd = new ConexionBD();
=======
        ConexionBD bd = new ConexionBD();
>>>>>>> origin/proyC#bueno
        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            bd.AbrirConexion();
            errores.Clear();
            if (ControlErrores())
            {
                if (Usuario.UsuarioExiste(bd.Conexion, txtNomUsu.Text))
                {
                    if (Usuario.VerificarContraseña(bd.Conexion, txtContraseña.Text, txtNomUsu.Text))
                    {
                        Datos.usu = Usuario.BuscarUsuario(bd.Conexion,txtNomUsu.Text);
                        Principal pr = new Principal();
                        
                        
                        pr.ShowDialog();

                    }
                    else
                    {
                        errores.SetError(txtContraseña, "Contraseña incorrecta");
                    }
                }
                else
                {
                    errores.SetError(txtNomUsu, "Nombre de usuario inexistente");
                }
            }
            
            bd.CerrarConexion();
            
        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            Registrarse reg = new Registrarse();
            reg.ShowDialog();
<<<<<<< HEAD
=======

        }
>>>>>>> origin/proyC#bueno

        private void IniciarSesión_Load(object sender, EventArgs e)
        {
            bd.AbrirConexion();
            bd.CerrarConexion();
        }

       
    }
}
